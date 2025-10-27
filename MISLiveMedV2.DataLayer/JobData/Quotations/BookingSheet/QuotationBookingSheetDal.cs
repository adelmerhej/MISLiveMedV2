using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Reports.CostSelling;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.JobData.Quotations.BookingSheet
{
    public static class QuotationBookingSheetDal
    {

        #region INSERT EVENT

        public static QuotationHeaderCostSellingModel InsertQuotationHeaderCostSelling(QuotationHeaderCostSellingModel quotationHeader)
        {
            var p = new DynamicParameters();
            QuotationHeaderCostSellingModel newQuoteHeader = new QuotationHeaderCostSellingModel();

            //Header
            newQuoteHeader = InsertQuotationHeader(quotationHeader);

            // Details
            //real
            foreach (QuotationCostModel costModel in quotationHeader.QuotationRealCostDetails)
            {
                if (costModel.Deleted) continue;
                InsertCostQuotation(costModel, newQuoteHeader.Id);
            }

            //Selling
            foreach (QuotationSellingModel sellingModel in quotationHeader.QuotationSellingModels)
            {
                if (sellingModel.Deleted) continue;
                InsertSellingQuotationHeader(sellingModel, newQuoteHeader.Id);
            }

            return newQuoteHeader;
        }


        #endregion

        #region UPDATE EVENT

        public static void UpdateQuotationHeaderCostSelling(QuotationHeaderCostSellingModel quotationHeader)
        {
            UpdateQuotationHeader(quotationHeader);

            // Delete Real Cost Event if some items were removed
            foreach (QuotationCostModel realCostModel in quotationHeader.QuotationRealCostDetails)
            {
                if (realCostModel.Deleted)
                {
                    DeleteRealCostQuotation(realCostModel.Id);
                    continue;
                }

                int isNewRecord = CheckForCostQuotationId(realCostModel.Id);
                if (isNewRecord <= 0)
                {
                    InsertCostQuotation(realCostModel, quotationHeader.Id);
                    continue;
                }
                UpdateCostQuotation(realCostModel);
            }

            // Selling Event
            foreach (QuotationSellingModel sellingModel in quotationHeader.QuotationSellingModels)
            {
                if (sellingModel.Deleted)
                {
                    DeleteSellingQuotation(sellingModel.Id);
                    continue;
                }

                int isNewRecord = CheckForSellingQuotationId(sellingModel.Id);

                if (isNewRecord <= 0)
                {
                    InsertSellingQuotationHeader(sellingModel, quotationHeader.Id);
                    continue;
                }
                UpdateSellingQuotationHeader(sellingModel);
            }
        }

        #endregion

        #region Delete EVENT

        //DeleteQuotationCost
        public static void DeleteCostSellingQuotation(int quotationId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", quotationId);

                    _ = connection.ExecuteScalar("dbo.job_DeleteCostSellingQuotation @Id", p);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }

        #endregion

        #region QUOTATION HEADER EVENTS
        
        private static QuotationHeaderCostSellingModel InsertQuotationHeader(QuotationHeaderCostSellingModel quotationHeader)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                //check if version number is the last version
                int newVersionNo = QuotationDal.GetNewQuotationVersionNo(quotationHeader.DepartmentId, quotationHeader.Id);

                p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                p.Add("@QuoteDate", quotationHeader.QuoteDate);
                p.Add("@BookingDate", quotationHeader.BookingDate);
                p.Add("@DepartmentId", quotationHeader.DepartmentId);
                p.Add("@QuotationId", quotationHeader.QuotationId);
                p.Add("@VersionNo", newVersionNo);
                p.Add("@TransitTime", quotationHeader.TransitTime);
                p.Add("@Validity", quotationHeader.Validity);
                p.Add("@ValidityDate", quotationHeader.ValidityDate);
                p.Add("@UserId", quotationHeader.UserId);
                p.Add("@DisplayProvisionColumns", quotationHeader.DisplayProvisionColumns);
                p.Add("@CompanyId", CurrentUser.CompanyId);
                p.Add("@Notes", quotationHeader.Notes);
                p.Add("@CreatedBy", CurrentUser.UserId);

                return connection.QueryFirstOrDefault<QuotationHeaderCostSellingModel>(
                    "dbo.job_AddNewQHeaderCostSelling_V001 @QuoteDate, @BookingDate, @DepartmentId, @QuotationId," +
                    "@VersionNo, @TransitTime, @Validity, @ValidityDate, @UserId, @DisplayProvisionColumns, " +
                    "@CompanyId, @Notes, @CreatedBy",
                    p);
            }
        }

        private static void UpdateQuotationHeader(QuotationHeaderCostSellingModel quotationHeader)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", quotationHeader.Id);
                p.Add("@QuoteDate", quotationHeader.QuoteDate);
                p.Add("@BookingDate", quotationHeader.BookingDate);
                p.Add("@DepartmentId", quotationHeader.DepartmentId);
                p.Add("@QuotationId", quotationHeader.QuotationId);
                p.Add("@SeaCarrierId", quotationHeader.SeaCarrierId);
                p.Add("@VersionNo", quotationHeader.VersionNo);
                p.Add("@TransitTime", quotationHeader.TransitTime);
                p.Add("@Validity", quotationHeader.Validity);
                p.Add("@ValidityDate", quotationHeader.ValidityDate);
                p.Add("@UserId", quotationHeader.UserId);
                p.Add("@DisplayProvisionColumns", quotationHeader.DisplayProvisionColumns);
                p.Add("@Notes", quotationHeader.Notes);
                p.Add("@LastModifiedBy", quotationHeader.LastModifiedBy);
                p.Add("@LastModifiedDate", quotationHeader.LastModifiedDate);
                p.Add("@Active", quotationHeader.Active);

                _ = connection.ExecuteScalar(
                    "dbo.job_UpdateQHeaderCostSelling_V001 @Id, @QuoteDate, @BookingDate, @DepartmentId, @QuotationId, " +
                    "@SeaCarrierId, @VersionNo, @TransitTime, @Validity, @ValidityDate, @UserId, @DisplayProvisionColumns, " +
                    "@Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);
            }
        }
        
        #endregion
        
        #region COST QUOTATION EVENTS

        private static void InsertCostQuotation(QuotationCostModel quotationCost, int newQuoteHeaderId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                p.Add("@QHeaderId", newQuoteHeaderId);
                p.Add("@AgentId", quotationCost.AgentId);
                p.Add("@PaymentId", quotationCost.PaymentId);
                p.Add("@ItemId", quotationCost.ItemId);
                p.Add("@Description", quotationCost.Description);
                p.Add("@CurrencyId", quotationCost.CurrencyId);
                p.Add("@Rate", quotationCost.Rate);
                p.Add("@Amount", quotationCost.Amount);
                p.Add("@LocalAmount", quotationCost.LocalAmount);
                p.Add("@ForeignAmount", quotationCost.ForeignAmount);
                p.Add("@ProvisionAmount", quotationCost.ProvisionAmount);
                p.Add("@ProvisionAmountLL", quotationCost.ProvisionAmountLL);
                p.Add("@ProvisionAmountUSD", quotationCost.ProvisionAmountUSD);
                p.Add("@Vat", quotationCost.Vat);
                p.Add("@VatRate", quotationCost.VatRate);
                p.Add("@VatAmount", quotationCost.VatAmount);
                p.Add("@LocalVatAmount", quotationCost.LocalVatAmount);
                p.Add("@ForeignVatAmount", quotationCost.ForeignVatAmount);
                p.Add("@ProvisionVATAmount", quotationCost.ProvisionVATAmount);
                p.Add("@ProvisionVATAmountLL", quotationCost.ProvisionVATAmountLL);
                p.Add("@ProvisionVATAmountUSD", quotationCost.ProvisionVATAmountUSD);
                p.Add("@CompanyId", CurrentUser.CompanyId);
                p.Add("@Notes", quotationCost.Notes);
                p.Add("@CreatedBy", CurrentUser.UserId);

                _ = connection.ExecuteScalar<QuotationHeaderCostSellingModel>(
                    "dbo.job_AddNewCostQuotation_V001 @QHeaderId, @AgentId, @PaymentId, @ItemId, @Description, @CurrencyId, " +
                    "@Rate, @Amount, @LocalAmount, @ForeignAmount, @ProvisionAmount, @ProvisionAmountLL, @ProvisionAmountUSD, " +
                    "@Vat, @VatRate, @VatAmount, @LocalVatAmount, @ForeignVatAmount, " +
                    "@ProvisionVATAmount, @ProvisionVATAmountLL, @ProvisionVATAmountUSD, @CompanyId, @Notes, @CreatedBy",
                    p);
            }
        }

        private static void UpdateCostQuotation(QuotationCostModel quotationRealCost)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", quotationRealCost.Id);
                p.Add("@QHeaderId", quotationRealCost.QHeaderId);
                p.Add("@AgentId", quotationRealCost.AgentId);
                p.Add("@PaymentId", quotationRealCost.PaymentId);
                p.Add("@ItemId", quotationRealCost.ItemId);
                p.Add("@Description", quotationRealCost.Description);
                p.Add("@CurrencyId", quotationRealCost.CurrencyId);
                p.Add("@Rate", quotationRealCost.Rate);
                p.Add("@Amount", quotationRealCost.Amount);
                p.Add("@LocalAmount", quotationRealCost.LocalAmount);
                p.Add("@ForeignAmount", quotationRealCost.ForeignAmount);
                p.Add("@ProvisionAmount", quotationRealCost.ProvisionAmount);
                p.Add("@ProvisionAmountLL", quotationRealCost.ProvisionAmountLL);
                p.Add("@ProvisionAmountUSD", quotationRealCost.ProvisionAmountUSD);
                p.Add("@Vat", quotationRealCost.Vat);
                p.Add("@VatRate", quotationRealCost.VatRate);
                p.Add("@VatAmount", quotationRealCost.VatAmount);
                p.Add("@LocalVatAmount", quotationRealCost.LocalVatAmount);
                p.Add("@ForeignVatAmount", quotationRealCost.ForeignVatAmount);
                p.Add("@ProvisionVATAmount", quotationRealCost.ProvisionVATAmount);
                p.Add("@ProvisionVATAmountLL", quotationRealCost.ProvisionVATAmountLL);
                p.Add("@ProvisionVATAmountUSD", quotationRealCost.ProvisionVATAmountUSD);
                p.Add("@Notes", quotationRealCost.Notes);
                p.Add("@LastModifiedBy", quotationRealCost.LastModifiedBy);
                p.Add("@LastModifiedDate", quotationRealCost.LastModifiedDate);
                p.Add("@Active", quotationRealCost.Active);

                _ = connection.ExecuteScalar<QuotationCostModel>(
                    "dbo.job_UpdateQuotationCost_V001 @Id, @QHeaderId, @AgentId, @PaymentId, @ItemId, @Description, @CurrencyId, " +
                    "@Rate, @Amount, @LocalAmount, @ForeignAmount, @ProvisionAmount, @ProvisionAmountLL, @ProvisionAmountUSD, " +
                    "@Vat, @VatRate, @VatAmount, @LocalVatAmount, @ForeignVatAmount, " +
                    "@ProvisionVATAmount, @ProvisionVATAmountLL, @ProvisionVATAmountUSD, " +
                    "@Notes, @LastModifiedBy, @LastModifiedDate, @Active",
                    p);
            }
        }

        public static void DeleteRealCostQuotation(int quotationId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", quotationId);

                    _ = connection.ExecuteScalar("DELETE QuotationRealCost WHERE Id = @Id;", p);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }

        private static int CheckForCostQuotationId(int costQuotationId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", costQuotationId);

                    var existingId = connection.ExecuteScalar(
                        "SELECT Id FROM QuotationRealCost WHERE Id = @Id;",
                        p) ?? 0;

                    return (int)existingId;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }


        #endregion
        
        #region SELLING QUOTATION EVENTS

        private static void InsertSellingQuotationHeader(QuotationSellingModel quotationSelling, int newQuoteHeaderId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                p.Add("@QHeaderId", newQuoteHeaderId);
                p.Add("@MemberId", quotationSelling.MemberId);
                p.Add("@PaymentId", quotationSelling.PaymentId);
                p.Add("@ItemId", quotationSelling.ItemId);
                p.Add("@Description", quotationSelling.Description);
                p.Add("@CurrencyId", quotationSelling.CurrencyId);
                p.Add("@Rate", quotationSelling.Rate);
                p.Add("@Amount", quotationSelling.Amount);
                p.Add("@LocalAmount", quotationSelling.LocalAmount);
                p.Add("@ForeignAmount", quotationSelling.ForeignAmount);
                p.Add("@Vat", quotationSelling.Vat);
                p.Add("@VatRate", quotationSelling.VatRate);
                p.Add("@VatAmount", quotationSelling.VatAmount);
                p.Add("@LocalVatAmount", quotationSelling.LocalVatAmount);
                p.Add("@ForeignVatAmount", quotationSelling.ForeignVatAmount);
                p.Add("@CompanyId", CurrentUser.CompanyId);
                p.Add("@Notes", quotationSelling.Notes);
                p.Add("@CreatedBy", CurrentUser.UserId);

                _ = connection.ExecuteScalar<QuotationHeaderCostSellingModel>(
                    "dbo.job_AddNewQuotationSelling_V001 @QHeaderId, @MemberId, @PaymentId, @ItemId, @Description, @CurrencyId, " +
                    "@Rate, @Amount, @LocalAmount, @ForeignAmount, @Vat, @VatRate, @VatAmount, @LocalVatAmount, " +
                    "@ForeignVatAmount, @CompanyId, @Notes, @CreatedBy",
                    p);
            }
        }


        private static void UpdateSellingQuotationHeader(QuotationSellingModel quotationSelling)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", quotationSelling.Id);
                p.Add("@QHeaderId", quotationSelling.QHeaderId);
                p.Add("@MemberId", quotationSelling.MemberId);
                p.Add("@PaymentId", quotationSelling.PaymentId);
                p.Add("@ItemId", quotationSelling.ItemId);
                p.Add("@Description", quotationSelling.Description);
                p.Add("@CurrencyId", quotationSelling.CurrencyId);
                p.Add("@Rate", quotationSelling.Rate);
                p.Add("@Amount", quotationSelling.Amount);
                p.Add("@LocalAmount", quotationSelling.LocalAmount);
                p.Add("@ForeignAmount", quotationSelling.ForeignAmount);
                p.Add("@Vat", quotationSelling.Vat);
                p.Add("@VatRate", quotationSelling.VatRate);
                p.Add("@VatAmount", quotationSelling.VatAmount);
                p.Add("@LocalVatAmount", quotationSelling.LocalVatAmount);
                p.Add("@ForeignVatAmount", quotationSelling.ForeignVatAmount);
                p.Add("@Notes", quotationSelling.Notes);
                p.Add("@LastModifiedBy", quotationSelling.LastModifiedBy);
                p.Add("@LastModifiedDate", quotationSelling.LastModifiedDate);
                p.Add("@Active", quotationSelling.Active);

                _ = connection.ExecuteScalar<QuotationSellingModel>(
                    "dbo.job_UpdateQuotationSelling_V001 @Id, @QHeaderId, @MemberId, @PaymentId, @ItemId, @Description, @CurrencyId, " +
                    "@Rate, @Amount, @LocalAmount, @ForeignAmount, @Vat, @VatRate, @VatAmount, @LocalVatAmount, " +
                    "@ForeignVatAmount, @Notes, @LastModifiedBy, @LastModifiedDate, @Active",
                    p);
            }
        }

        public static void DeleteSellingQuotation(int quotationId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", quotationId);

                    _ = connection.ExecuteScalar("dbo.job_DeleteSellingQuotation @Id", p);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }

        private static int CheckForSellingQuotationId(int costQuotationId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", costQuotationId);

                    var existingId = connection.ExecuteScalar(
                        "dbo.job_GetSellingQuotationsbyId @Id",
                        p) ?? 0;
                        
                    return (int)existingId;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }

        #endregion

        public static IList<BookingSheetReportModel> GetBookingSheetReportById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {

                    var p = new DynamicParameters();
                    p.Add("@QuotationId", id);

                    var quotationsList =
                        connection.Query<BookingSheetReportModel>("dbo.job_GetBookingSheetReportById @QuotationId", p);

                    return quotationsList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }
    }
}
