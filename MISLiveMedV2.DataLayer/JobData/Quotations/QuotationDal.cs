using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Reports.Accounting;
using MISLiveMed.Models.Models.Reports.CostSelling;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.JobData.Quotations
{
    public static class QuotationDal
    {
        #region Insert/Update/Delete Quotation

        public static IEnumerable<QuotationReportModel> GetQuotationsReport(int? pDepartmentFilter = 0,
            int? pSalesFilter = 0, EnumStatusType pStatusFilter = EnumStatusType.NotSelected)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DepartmentFilter", pDepartmentFilter);
                    p.Add("@SalesFilter", pSalesFilter);
                    p.Add("@StatusFilter", pStatusFilter);

                    var quotationsList =
                        connection.Query<QuotationReportModel>("dbo.job_GetCostSellingQuotationsReport @DepartmentFilter, @SalesFilter, @StatusFilter", p);

                    return quotationsList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static QuotationModel InsertQuotation(QuotationModel quotationModel)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@RefNo", 0, DbType.Int32, ParameterDirection.Output);
                p.Add("@DepartmentPrefix", quotationModel.DepartmentPrefix);
                p.Add("@DepartmentId", quotationModel.DepartmentId);
                p.Add("@QuotationDate", quotationModel.QuotationDate);
                p.Add("@MemberId", quotationModel.MemberId);
                p.Add("@ConsigneeId", quotationModel.ConsigneeId);
                p.Add("@UserId", quotationModel.UserId);
                p.Add("@SalesId", quotationModel.SalesId);
                p.Add("@Vol", quotationModel.Vol);
                p.Add("@Pol", quotationModel.Pol);
                p.Add("@Pod", quotationModel.Pod);
                p.Add("@Status", quotationModel.Status);
                p.Add("@AgentId", quotationModel.AgentId);
                p.Add("@CarrierId", quotationModel.CarrierId);
                p.Add("@Attention", quotationModel.Attention);
                p.Add("@FollowupDate", quotationModel.FollowupDate);
                p.Add("@Booked", quotationModel.Booked);
                p.Add("@BookedDate", quotationModel.BookedDate);
                p.Add("@Lost", quotationModel.Lost);
                p.Add("@LostDate", quotationModel.LostDate);
                p.Add("@Deleted", quotationModel.Deleted);
                p.Add("@DeletedDate", quotationModel.DeletedDate);
                p.Add("@ETD", quotationModel.ETD);
                p.Add("@ETA", quotationModel.ETA);
                p.Add("@ATD", quotationModel.ATD);
                p.Add("@ATA", quotationModel.ATA);
                p.Add("@ShipperName", quotationModel.ShipperName);
                p.Add("@TermsId", quotationModel.TermsId);
                p.Add("@Urgent", quotationModel.Urgent);
                p.Add("@Notes", quotationModel.Notes);
                p.Add("@CompanyId", CurrentUser.CompanyId);
                p.Add("@CreatedBy", CurrentUser.UserId);
                p.Add("@IsProtected", false);

                quotationModel = connection.QueryFirst<QuotationModel>(
                    "dbo.job_AddNewQuotations_V3 @DepartmentPrefix, @DepartmentId, @QuotationDate, @MemberId, @ConsigneeId, @UserId, " +
                            "@SalesId, @Vol, @Pol, @Pod, @Status, @AgentId, @CarrierId, @Attention, @FollowupDate, @Booked, @BookedDate, " +
                            "@Lost, @LostDate, @Deleted, @DeletedDate, @ShipperName, @ETD, @ETA, @ATD, @ATA, @TermsId, @Urgent, @Notes, @CompanyId, @CreatedBy, @IsProtected;",
                    p);

                return quotationModel;
            }
        }

        public static void UpdateQuotation(QuotationModel quotationModel)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", quotationModel.Id);
                p.Add("@DepartmentPrefix", quotationModel.DepartmentPrefix);
                p.Add("@DepartmentId", quotationModel.DepartmentId);
                p.Add("@QuotationDate", quotationModel.QuotationDate);
                p.Add("@MemberId", quotationModel.MemberId);
                p.Add("@ConsigneeId", quotationModel.ConsigneeId);
                p.Add("@UserId", quotationModel.UserId);
                p.Add("@SalesId", quotationModel.SalesId);
                p.Add("@Vol", quotationModel.Vol);
                p.Add("@Pol", quotationModel.Pol);
                p.Add("@Pod", quotationModel.Pod);
                p.Add("@Status", quotationModel.Status);
                p.Add("@AgentId", quotationModel.AgentId);
                p.Add("@CarrierId", quotationModel.CarrierId);
                p.Add("@Attention", quotationModel.Attention);
                p.Add("@FollowupDate", quotationModel.FollowupDate);
                p.Add("@QuotedDate", quotationModel.QuotedDate);
                p.Add("@Booked", quotationModel.Booked);
                p.Add("@BookedDate",  quotationModel.BookedDate);
                p.Add("@Lost", quotationModel.Lost);
                p.Add("@LostDate", quotationModel.LostDate);
                p.Add("@Reason", quotationModel.Reason);
                p.Add("@Deleted", quotationModel.Deleted);
                p.Add("@DeletedDate", quotationModel.DeletedDate);
                p.Add("@ShipperName", quotationModel.ShipperName);
                p.Add("@JobNo", quotationModel.JobNo);
                p.Add("@ETD", quotationModel.ETD);
                p.Add("@ETA", quotationModel.ETA);
                p.Add("@ATD", quotationModel.ATD);
                p.Add("@ATA", quotationModel.ATA);
                p.Add("@TermsId", quotationModel.TermsId);
                p.Add("@Urgent", quotationModel.Urgent);
                p.Add("@UrgentDate", quotationModel.UrgentDate);
                p.Add("@Notes", quotationModel.Notes);
                p.Add("@LastModifiedBy", CurrentUser.UserId);
                p.Add("@IsProtected", quotationModel.IsProtected);

                _ = connection.ExecuteScalar("dbo.job_UpdateQuotations_V4 @Id, @DepartmentPrefix, @DepartmentId, @QuotationDate, " +
                            "@MemberId, @ConsigneeId, @UserId, @SalesId, @Vol, @Pol, @Pod, @Status, @AgentId, @CarrierId, @Attention, " +
                            "@FollowupDate, @QuotedDate, @Booked, @BookedDate, @Lost, @LostDate, @Reason, @Deleted, @DeletedDate, @ShipperName, " +
                            "@JobNo, @ETD, @ETA, @ATD, @ATA, @TermsId, @Urgent, @UrgentDate, @Notes, @LastModifiedBy, @IsProtected", p);
            }
        }

        public static void CancelQuotation(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", id);

                _ = connection.ExecuteScalar("UPDATE Quotations set Canceled = 1, CanceledDate = GETDATE() WHERE Id = @Id;", p);
            }
        }

        public static void DeleteQuotation(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", id);

                _ = connection.ExecuteScalar("Delete Quotations WHERE Id = @Id;", p);
            }
        }


        #endregion


        #region Insert/Update Quotation Price --> Cost/Selling section

        public static QuotationHeaderCostSellingModel InsertQuoteHeaderPricing(QuotationHeaderCostSellingModel quotationModel)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                p.Add("@DepartmentId", quotationModel.DepartmentId);
                p.Add("@QuotationId", quotationModel.QuotationId);
                p.Add("@VersionNo", quotationModel.VersionNo);
                p.Add("@TransitTime", quotationModel.TransitTime);
                p.Add("@Validity", quotationModel.Validity);
                p.Add("@ValidityDate", quotationModel.ValidityDate);
                p.Add("@UserId", quotationModel.UserId);
                p.Add("@Notes", quotationModel.Notes);


                quotationModel = connection.QueryFirst<QuotationHeaderCostSellingModel>(
                    "dbo.job_InsertQuoteHeaderPricing @DepartmentId, @QuotationId, @VersionNo, @TransitTime, @Validity, @ValidityDate, " +
                    "@UserId, @Notes",
                    p);

                return quotationModel;
            }
        }

        public static void UpdateQuoteHeaderPricing(QuotationHeaderCostSellingModel quotationModel)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                p.Add("@DepartmentId", quotationModel.DepartmentId);
                p.Add("@QuotationId", quotationModel.QuotationId);
                p.Add("@VersionNo", quotationModel.VersionNo);
                p.Add("@TransitTime", quotationModel.TransitTime);
                p.Add("@Validity", quotationModel.Validity);
                p.Add("@ValidityDate", quotationModel.ValidityDate);
                p.Add("@UserId", quotationModel.UserId);
                p.Add("@Notes", quotationModel.Notes);


                _ = connection.ExecuteScalar<QuotationHeaderCostSellingModel>(
                    "dbo.job_UpdateQuoteHeaderPricing @DepartmentId, @QuotationId, @VersionNo, @TransitTime, @Validity, @ValidityDate, " +
                    "@UserId, @Notes",
                    p);
            }
        }

        #endregion


        #region get Cost/Selling report
        public static IEnumerable<CostSellingReportModel> GetCostSellingQuotationsReportById(int pId, int pVersion)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", pId);
                    p.Add("@Version", pVersion);

                    var quotationsList =
                        connection.Query<CostSellingReportModel>("dbo.job_GetCostSellingQuotationsReportById @Id, @Version", p);

                    return quotationsList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<QuotationCostModel> GetCostQuotations(int pQuotationId = 0, int pVersionNo = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", pQuotationId);
                    p.Add("@VersionNo", pVersionNo);

                    var quotationsCostList =
                        connection.Query<QuotationCostModel>("dbo.job_GetRealCostQuotationsList_V1 @QuotationId, @VersionNo", p);

                    return quotationsCostList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<QuotationSellingModel> GetSellingQuotations(int pQuotationId = 0, int pVersionNo = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", pQuotationId);
                    p.Add("@VersionNo", pVersionNo);

                    var quotationsCostList =
                        connection.Query<QuotationSellingModel>("dbo.job_SelectSellingByQuotationId @QuotationId, @VersionNo", p);

                    return quotationsCostList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }


        public static int GetNewQuotationVersionNo(int pQuotationId = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", pQuotationId);

                    var quotationVersion =
                        connection.ExecuteScalar<int>("dbo.job_GetQuotationHeaderLastVersion @QuotationId", p);

                    return quotationVersion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static IList<PaymentReportModel> PaymentReportList(DateTime? dateFrom, DateTime? dateTo,
            string filterBy = "showAll", int department = 0, int sortBy = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DateFrom", dateFrom);
                    p.Add("@DateTo", dateTo);
                    p.Add("@FilterBy", filterBy);
                    p.Add("@DepartmentId", department);
                    p.Add("@SortBy", sortBy);

                    var paymentReportList =
                        connection.Query<PaymentReportModel>("dbo.job_PaymentReportList @DateFrom, @DateTo, " +
                                                             "@FilterBy, @DepartmentId, @SortBy", p);

                    return paymentReportList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<QuotationHeaderCostSellingModel> GetQuotationsCostSellingById(int pQuotationId = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", pQuotationId);

                    var costSellingHeader =
                        connection.Query<QuotationHeaderCostSellingModel>("dbo.job_GetQuotationsCostSelling @QuotationId", p);

                    return costSellingHeader;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static int GetJobNoByRefNo(int pRefNo, int pDepartmentId, string pDepartmentPrefix)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@RefNo", pRefNo);
                    p.Add("@DepartmentId", pDepartmentId);
                    p.Add("@DepartmentPrefix", pDepartmentPrefix);

                    var jobNo =
                        connection.ExecuteScalar<int>("dbo.XOGetJobNO @RefNo, @DepartmentId, @DepartmentPrefix", p);

                    return jobNo;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        #endregion


          public static QuotationHeaderCostSellingModel SelectQuotationHeaderById(int pId = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", pId);

                    var quotationLastVersion =
                        connection.QuerySingle<QuotationHeaderCostSellingModel>("dbo.job_SelectQuotationHeaders @Id", p);

                    return quotationLastVersion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static QuotationHeaderCostSellingModel GetLastQuotationHeaderById(int pId = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", pId);

                    var quotationLastVersion =  
                        connection.QuerySingle<QuotationHeaderCostSellingModel>("dbo.job_GetQuotationHeaderLastVersion @Id", p);

                    return quotationLastVersion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static int GetNewQuotationVersionNo(int departmentId = 0, int quotationId = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DepartmentId", departmentId);
                    p.Add("@QuotationId", quotationId);

                    var quotationLastVersion =
                        connection.ExecuteScalar<int>("SELECT dbo.xo_GetNewVersionNo(@DepartmentId, @QuotationId)", p);

                    return quotationLastVersion;
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
