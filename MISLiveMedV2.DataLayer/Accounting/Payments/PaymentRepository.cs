using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Payments;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.Accounting.Payments
{
    public class PaymentRepository : IDisposable
    {
        public IList<PaymentModel> SelectPayments(EnumPaymentType paymentType)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@PaymentTypeId", paymentType);

                    var payments =
                        connection.Query<PaymentModel>("SELECT * FROM Payments WHERE PaymentTypeId = @PaymentTypeId AND CompanyId = @CompanyId;", p);
                    return payments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PaymentModel SelectPaymentById(int paymentId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", paymentId);

                    var paymentRecord =
                        connection.QuerySingleOrDefault<PaymentModel>("SELECT * FROM Payments WHERE Id = @Id;", p);
                    return paymentRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewPayment(PaymentModel paymentModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@PaymentTypeId", paymentModel.PaymentTypeId);
                    p.Add("@JobId", paymentModel.JobId);
                    p.Add("@DepartmentId", paymentModel.DepartmentId);
                    p.Add("@ReferenceId", paymentModel.ReferenceNo);
                    p.Add("@MemberTypeId", paymentModel.MemberTypeId);
                    p.Add("@MemberId", paymentModel.MemberId);
                    p.Add("@CurrencyId", paymentModel.CurrencyId);
                    p.Add("@Rate", paymentModel.Rate);
                    p.Add("@Amount", paymentModel.Amount);
                    p.Add("@LAmount", paymentModel.LAmount);
                    p.Add("@FAmount", paymentModel.FAmount);
                    p.Add("@Discount", paymentModel.Discount);
                    p.Add("@Posted", paymentModel.Posted);
                    p.Add("@Paid", paymentModel.Paid);
                    p.Add("@Protected", paymentModel.Protected);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", paymentModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    paymentModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewPayment @PaymentTypeId, @JobId, @DepartmentId, @ReferenceId, @MemberTypeId, @MemberId, " +
                                    "@CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @Discount, @Paid, @Posted, @Protected, " +
                                    "@CompanyId, @Notes, @CreatedBy", p);

                    return paymentModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdatePayment(PaymentModel paymentModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", paymentModel.Id);
                    p.Add("@PaymentDate", paymentModel.PaymentDate);
                    p.Add("@PaymentTypeId", paymentModel.PaymentTypeId);
                    p.Add("@JobId", paymentModel.JobId);
                    p.Add("@DepartmentId", paymentModel.DepartmentId);
                    p.Add("@ReferenceId", paymentModel.ReferenceNo);
                    p.Add("@MemberTypeId", paymentModel.MemberTypeId);
                    p.Add("@MemberId", paymentModel.MemberId);
                    p.Add("@CurrencyId", paymentModel.CurrencyId);
                    p.Add("@Rate", paymentModel.Rate);
                    p.Add("@Amount", paymentModel.Amount);
                    p.Add("@LAmount", paymentModel.LAmount);
                    p.Add("@FAmount", paymentModel.FAmount);
                    p.Add("@Discount", paymentModel.Discount);
                    p.Add("@Paid", paymentModel.Paid);
                    p.Add("@Posted", paymentModel.Posted);
                    p.Add("@Protected", paymentModel.Protected);
                    p.Add("@Notes", paymentModel.Notes);
                    p.Add("@LastModifiedBy", paymentModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", paymentModel.LastModifiedDate);
                    p.Add("@Active", paymentModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdatePayment @Id, @PaymentDate, @PaymentTypeId, @JobId, @DepartmentId, @ReferenceId, @MemberTypeId, @MemberId, " +
                                        "@CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @Discount, @Paid, @Posted, @Protected, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);

                    return paymentModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool UpdatePaymentById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("EXEC DBO.XO_UpdatePaidPayments @Id;", p);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public bool DeletePayment(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Payments WHERE Id = @Id", p);
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
