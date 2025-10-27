using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Payments;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Payments
{
    public class PaymentDetailRepository : IDisposable
    {
        public IList<PaymentDetailModel> SelectPaymentsDetails()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", CurrentUser.CompanyId);

                    var paymentsDetails =
                        connection.Query<PaymentDetailModel>("SELECT * FROM PaymentsDetails WHERE CompanyId = 1;", p);
                    return paymentsDetails.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PaymentDetailModel SelectPaymentDetailById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var paymentDetailRecord =
                        connection.QuerySingleOrDefault<PaymentDetailModel>("SELECT * FROM PaymentsDetails WHERE Id = @Id;", p);
                    return paymentDetailRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<PaymentDetailModel> SelectPaymentDetailByPaymentId(int paymentId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@PaymentId", paymentId);

                    var paymentDetailRecord =
                        connection.Query<PaymentDetailModel>("SELECT * FROM PaymentsDetails WHERE PaymentId = @PaymentId;", p);
                    return paymentDetailRecord.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewPaymentDetail(PaymentDetailModel paymentDetailModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@PaymentId", paymentDetailModel.PaymentId);
                    p.Add("@PaymentDetailDate", paymentDetailModel.PaymentDetailDate);
                    p.Add("@TypeId", paymentDetailModel.TypeId);
                    p.Add("@CurrencyId", paymentDetailModel.CurrencyId);
                    p.Add("@Rate", paymentDetailModel.Rate);
                    p.Add("@Amount", paymentDetailModel.Amount);
                    p.Add("@LAmount", paymentDetailModel.LAmount);
                    p.Add("@FAmount", paymentDetailModel.FAmount);
                    p.Add("@Discount", paymentDetailModel.Discount);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", paymentDetailModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    paymentDetailModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewPaymentDetail @PaymentId, @PaymentDetailDate, @TypeId, @ReferenceId, @CurrencyId, " +
                                    "@Rate, @Amount, @LAmount, @FAmount, @Discount, @CompanyId, @Notes, @CreatedBy", p);

                    return paymentDetailModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdatePaymentDetail(PaymentDetailModel paymentDetailModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", paymentDetailModel.Id);
                    p.Add("@PaymentId", paymentDetailModel.PaymentId);
                    p.Add("@PaymentDetailDate", paymentDetailModel.PaymentDetailDate);
                    p.Add("@TypeId", paymentDetailModel.TypeId);
                    p.Add("@CurrencyId", paymentDetailModel.CurrencyId);
                    p.Add("@Rate", paymentDetailModel.Rate);
                    p.Add("@Amount", paymentDetailModel.Amount);
                    p.Add("@LAmount", paymentDetailModel.LAmount);
                    p.Add("@FAmount", paymentDetailModel.FAmount);
                    p.Add("@Discount", paymentDetailModel.Discount);
                    p.Add("@Notes", paymentDetailModel.Notes);
                    p.Add("@LastModifiedBy", paymentDetailModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", paymentDetailModel.LastModifiedDate);
                    p.Add("@Active", paymentDetailModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdatePaymentDetail @Id, @PaymentId, @PaymentDetailDate, @TypeId, @ReferenceId, @CurrencyId, " +
                        "@Rate, @Amount, @LAmount, @FAmount, @Discount, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);

                    return paymentDetailModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteAllPaymentDetails(int paymentId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@PaymentId", paymentId);

                    _ = connection.ExecuteScalar("DELETE FROM PaymentsDetails WHERE PaymentId = @PaymentId", p);
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

                    _ = connection.ExecuteScalar("DELETE FROM PaymentsDetails WHERE Id = @Id", p);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeletePaymentDetail(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM PaymentsDetails WHERE Id = @Id", p);
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
