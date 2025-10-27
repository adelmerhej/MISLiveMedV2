using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Invoices;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Invoices
{
    public class InvoiceRepository : IDisposable
    {
        public IList<InvoiceModel> SelectInvoices(bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@ShowProtected", showProtected);

                    var invoices =
                        connection.Query<InvoiceModel>("SELECT * FROM MainInvoice WHERE (@ShowProtected = 1 OR IsProtected = 0) " +
                                                       "AND CompanyId = @CompanyId ORDER BY JobId DESC, InvoiceNo;", p);
                    return invoices.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<InvoiceModel> SelectInvoicesByJobNo(int jobId, int departmentId, bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@JobId", jobId);
                    p.Add("@DepartmentId", departmentId);
                    p.Add("@showProtected", showProtected);

                    var invoices =
                        connection.Query<InvoiceModel>("SELECT * FROM MainInvoice WHERE (@showProtected = 1 OR IsProtected = 0) " +
                                                       "AND JobId = @jobId AND departmentId = @DepartmentId " +
                                                       "AND CompanyId = @CompanyId;", p);
                    return invoices.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public InvoiceModel SelectInvoiceById(int invoiceId, int departmentId, bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", invoiceId);

                    var invoiceRecord =
                        connection.QuerySingleOrDefault<InvoiceModel>("SELECT * FROM MainInvoice WHERE (@showProtected = 1 OR IsProtected = 0) " +
                                                                      "AND DepartmentId = @DepartmentId AND Id = @Id;", p);
                    return invoiceRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewInvoice(InvoiceModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@InvoiceNo", dataModel.InvoiceNo);
                    p.Add("@InvoiceRef", dataModel.InvoiceRef);
                    p.Add("@JobId", dataModel.JobId);
                    p.Add("@DepartmentId", dataModel.DepartmentId);
                    p.Add("@InvoiceDate", dataModel.InvoiceDate);
                    p.Add("@MemberId", dataModel.MemberId);
                    p.Add("@ToNotified", dataModel.ToNotified);
                    p.Add("@Notify", dataModel.Notify);
                    p.Add("@Attn", dataModel.Attn);
                    p.Add("@Subject", dataModel.Subject);
                    p.Add("@Subject1", dataModel.Subject1);
                    p.Add("@Subject2", dataModel.Subject2);
                    p.Add("@Subject3", dataModel.Subject3);
                    p.Add("@CurrencyId", dataModel.CurrencyId);
                    p.Add("@CurrencyRate", dataModel.CurrencyRate);
                    p.Add("@Amount", dataModel.Amount);
                    p.Add("@LAmount", dataModel.LAmount);
                    p.Add("@FAmount", dataModel.FAmount);
                    p.Add("@TotalItemVAT", dataModel.TotalItemVAT);
                    p.Add("@TotalItemNonVAT", dataModel.TotalItemNonVAT);
                    p.Add("@TotalVAT", dataModel.TotalVAT);
                    p.Add("@LTotalVAT", dataModel.LTotalVAT);
                    p.Add("@FTotalVAT", dataModel.FTotalVAT);
                    p.Add("@IsAgent", dataModel.IsAgent);
                    p.Add("@SalesId", dataModel.SalesId);
                    p.Add("@UserId", dataModel.UserId);
                    p.Add("@OperationDate", dataModel.OperationDate);
                    p.Add("@ModifyDate", dataModel.ModifyDate);
                    p.Add("@Posted", dataModel.Posted);
                    p.Add("@Original", dataModel.Original);
                    p.Add("@Closed", dataModel.Closed);
                    p.Add("@ClosedDate", dataModel.ClosedDate);
                    p.Add("@Canceled", dataModel.Canceled);
                    p.Add("@CanceledDate", dataModel.CanceledDate);
                    p.Add("@Reason", dataModel.Reason);
                    p.Add("@CurSLRate", dataModel.CurSLRate);
                    p.Add("@TotalReceived", dataModel.TotalReceived);
                    p.Add("@DiffOfExchange", dataModel.DiffOfExchange);
                    p.Add("@TotalCreditNote", dataModel.TotalCreditNote);
                    p.Add("@TotalDebitNote", dataModel.TotalDebitNote);
                    p.Add("@TotalDue", dataModel.TotalDue);
                    p.Add("@Locked", dataModel.Locked);
                    p.Add("@PrintOriginalDate", dataModel.PrintOriginalDate);
                    p.Add("@PrintOriginalByUser", dataModel.PrintOriginalByUser);
                    p.Add("@LastPrintOrigDate", dataModel.LastPrintOrigDate);
                    p.Add("@LastPrintOrigByUser", dataModel.LastPrintOrigByUser);
                    p.Add("@JVNO", dataModel.JVNO);
                    p.Add("@DebitNote", dataModel.DebitNote);
                    p.Add("@CreditNote", dataModel.CreditNote);
                    p.Add("@DueDate", dataModel.DueDate);
                    p.Add("@RefNo", dataModel.RefNo);
                    p.Add("@SettledAmount", dataModel.SettledAmount);
                    p.Add("@Paid", dataModel.Paid);
                    p.Add("@IsProtected", dataModel.IsProtected);
                    p.Add("@CompanyId", dataModel.CompanyId);
                    p.Add("@Notes", dataModel.Notes);
                    p.Add("@CreatedBy", dataModel.CreatedBy);

                    dataModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewInvoice @PaymentDate, @ActionType, @PaymentTypeId, @JobId, @DepartmentId, @ReferenceId, @MemberTypeId, @MemberId, " +
                                    "@CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @Discount, @Paid, @Posted, @IsProtected, @CompanyId, @Notes, @CreatedBy", p);

                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdateInvoice(InvoiceModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", dataModel.Id);
                    p.Add("@InvoiceNo", dataModel.InvoiceNo);
                    p.Add("@InvoiceRef", dataModel.InvoiceRef);
                    p.Add("@JobId", dataModel.JobId);
                    p.Add("@DepartmentId", dataModel.DepartmentId);
                    p.Add("@InvoiceDate", dataModel.InvoiceDate);
                    p.Add("@MemberId", dataModel.MemberId);
                    p.Add("@ToNotified", dataModel.ToNotified);
                    p.Add("@Notify", dataModel.Notify);
                    p.Add("@Attn", dataModel.Attn);
                    p.Add("@Subject", dataModel.Subject);
                    p.Add("@Subject1", dataModel.Subject1);
                    p.Add("@Subject2", dataModel.Subject2);
                    p.Add("@Subject3", dataModel.Subject3);
                    p.Add("@CurrencyId", dataModel.CurrencyId);
                    p.Add("@CurrencyRate", dataModel.CurrencyRate);
                    p.Add("@Amount", dataModel.Amount);
                    p.Add("@LAmount", dataModel.LAmount);
                    p.Add("@FAmount", dataModel.FAmount);
                    p.Add("@TotalItemVAT", dataModel.TotalItemVAT);
                    p.Add("@TotalItemNonVAT", dataModel.TotalItemNonVAT);
                    p.Add("@TotalVAT", dataModel.TotalVAT);
                    p.Add("@LTotalVAT", dataModel.LTotalVAT);
                    p.Add("@FTotalVAT", dataModel.FTotalVAT);
                    p.Add("@IsAgent", dataModel.IsAgent);
                    p.Add("@SalesId", dataModel.SalesId);
                    p.Add("@UserId", dataModel.UserId);
                    p.Add("@OperationDate", dataModel.OperationDate);
                    p.Add("@ModifyDate", dataModel.ModifyDate);
                    p.Add("@Posted", dataModel.Posted);
                    p.Add("@Original", dataModel.Original);
                    p.Add("@Closed", dataModel.Closed);
                    p.Add("@ClosedDate", dataModel.ClosedDate);
                    p.Add("@Canceled", dataModel.Canceled);
                    p.Add("@CanceledDate", dataModel.CanceledDate);
                    p.Add("@Reason", dataModel.Reason);
                    p.Add("@CurSLRate", dataModel.CurSLRate);
                    p.Add("@TotalReceived", dataModel.TotalReceived);
                    p.Add("@DiffOfExchange", dataModel.DiffOfExchange);
                    p.Add("@TotalCreditNote", dataModel.TotalCreditNote);
                    p.Add("@TotalDebitNote", dataModel.TotalDebitNote);
                    p.Add("@TotalDue", dataModel.TotalDue);
                    p.Add("@Locked", dataModel.Locked);
                    p.Add("@PrintOriginalDate", dataModel.PrintOriginalDate);
                    p.Add("@PrintOriginalByUser", dataModel.PrintOriginalByUser);
                    p.Add("@LastPrintOrigDate", dataModel.LastPrintOrigDate);
                    p.Add("@LastPrintOrigByUser", dataModel.LastPrintOrigByUser);
                    p.Add("@JVNO", dataModel.JVNO);
                    p.Add("@DebitNote", dataModel.DebitNote);
                    p.Add("@CreditNote", dataModel.CreditNote);
                    p.Add("@DueDate", dataModel.DueDate);
                    p.Add("@RefNo", dataModel.RefNo);
                    p.Add("@SettledAmount", dataModel.SettledAmount);
                    p.Add("@Paid", dataModel.Paid);
                    p.Add("@IsProtected", dataModel.IsProtected);
                    p.Add("@Notes", dataModel.Notes);
                    p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", dataModel.LastModifiedDate);
                    p.Add("@Active", dataModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateInvoice @Id, @PaymentDate, @ActionType, @PaymentTypeId, @JobId, @DepartmentId, @ReferenceId, @MemberTypeId, @MemberId, " +
                                        "@CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @Discount, @Paid, @Posted, @IsProtected, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);

                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteInvoice(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM invoices WHERE Id = @Id", p);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        #region Implementation of IDisposable

        public void Dispose()
        {

        }

        #endregion
    }
}
