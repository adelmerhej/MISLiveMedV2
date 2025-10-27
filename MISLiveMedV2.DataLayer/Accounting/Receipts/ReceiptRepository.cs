using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Receipts;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.Accounting.Receipts
{
    public class ReceiptRepository : IDisposable
    {
        public IList<ReceiptModel> SelectReceipts(EnumPaymentType receiptType)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@ReceiptTypeId", receiptType);

                    var receipts =
                        connection.Query<ReceiptModel>("SELECT * FROM Receipts WHERE ReceiptTypeId = @ReceiptTypeId AND CompanyId = @CompanyId;", p);
                    return receipts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ReceiptModel SelectReceiptById(int receiptId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", receiptId);

                    var receiptRecord =
                        connection.QuerySingleOrDefault<ReceiptModel>("SELECT * FROM Receipts WHERE Id = @Id;", p);
                    return receiptRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewReceipt(ReceiptModel receiptModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@ReceiptDate", receiptModel.ReceiptDate);
                    p.Add("@PostingDate", receiptModel.PostingDate);
                    p.Add("@ValueDate", receiptModel.ValueDate);
                    p.Add("@ValueDate", receiptModel.ValueDate);
                    p.Add("@ReceiptTypeId", receiptModel.ReceiptTypeId);
                    p.Add("@JobId", receiptModel.JobId);
                    p.Add("@DepartmentId", receiptModel.DepartmentId);
                    p.Add("@ReferenceNo", receiptModel.ReferenceNo);
                    p.Add("@ReferenceId", receiptModel.ReferenceId);
                    p.Add("@MemberTypeId", receiptModel.MemberTypeId);
                    p.Add("@MemberId", receiptModel.MemberId);
                    p.Add("@CustomerId", receiptModel.CustomerId);
                    p.Add("@CurrencyId", receiptModel.CurrencyId);
                    p.Add("@Rate", receiptModel.Rate);
                    p.Add("@Amount", receiptModel.Amount);
                    p.Add("@LAmount", receiptModel.LAmount);
                    p.Add("@FAmount", receiptModel.FAmount);

                    p.Add("@Discount", receiptModel.Discount);
                    p.Add("@Posted", receiptModel.Posted);
                    p.Add("@Paid", receiptModel.Paid);
                    p.Add("@Protected", receiptModel.Protected);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", receiptModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    receiptModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewReceipt @ReceiptTypeId, @JobId, @DepartmentId, @ReferenceId, @MemberTypeId, @MemberId, " +
                                    "@CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @Discount, @Paid, @Posted, @Protected, " +
                                    "@CompanyId, @Notes, @CreatedBy", p);

                    return receiptModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        #region Implementation of IDisposable

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {

        }

        #endregion
    }
}
