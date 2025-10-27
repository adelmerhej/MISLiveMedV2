using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Payments
{
    public class PaymentTypeRepository : IDisposable
    {
        public IList<PaymentTypeModel> SelectPaymentsType()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var paymentsType =
                        connection.Query<PaymentTypeModel>("SELECT * FROM PaymentsType WHERE Active = 1;");
                    return paymentsType.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PaymentTypeModel SelectPaymentTypeById(int paymentTypeId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", paymentTypeId);

                    var paymentTypeRecord =
                        connection.QuerySingleOrDefault<PaymentTypeModel>("SELECT * FROM PaymentsType WHERE Id = @Id;", p);
                    return paymentTypeRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewPaymentType(PaymentTypeModel paymentTypeModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@PaymentType", paymentTypeModel.PaymentType);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", paymentTypeModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    paymentTypeModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewPaymentType @PaymentType, @CompanyId, @Notes, @CreatedBy", p);

                    return paymentTypeModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdatePaymentType(PaymentTypeModel paymentTypeModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", paymentTypeModel.Id);
                    p.Add("@PaymentType", paymentTypeModel.PaymentType);
                    p.Add("@Notes", paymentTypeModel.Notes);
                    p.Add("@LastModifiedBy", paymentTypeModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", paymentTypeModel.LastModifiedDate);
                    p.Add("@Active", paymentTypeModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdatePaymentType @Id, @PaymentType, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);

                    return paymentTypeModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeletePaymentType(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM PaymentsType WHERE Id = @Id", p);
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
