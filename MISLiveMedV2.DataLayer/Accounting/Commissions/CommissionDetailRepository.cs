using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Commissions;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Commissions
{
    public class CommissionDetailRepository : IDisposable
    {
        public IList<CommissionDetailModel> SelectCommissionsDetail()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var payments =
                        connection.Query<CommissionDetailModel>("SELECT * FROM CommissionsDetails WHERE CompanyId = @CompanyId;", p);
                    return payments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CommissionDetailModel SelectCommissionDetailById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var payment =
                        connection.QuerySingleOrDefault<CommissionDetailModel>("SELECT * FROM CommissionsDetails WHERE Id = @id;", p);
                    return payment;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IList<CommissionDetailModel> SelectCommissionDetailByCommissionId(int commissionId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CommissionId", commissionId);

                    var payments =
                        connection.Query<CommissionDetailModel>("SELECT * FROM CommissionsDetails WHERE CommissionId = @CommissionId;", p);
                    return payments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewCommissionDetail(CommissionDetailModel commissionDetail)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@CommissionManagerId", commissionDetail.CommissionManagerId);
                    p.Add("@CommissionId", commissionDetail.CommissionId);
                    p.Add("@SalesId", commissionDetail.SalesId);
                    p.Add("@CurrencyId", commissionDetail.CurrencyId);
                    p.Add("@Rate", commissionDetail.Rate);
                    p.Add("@Amount", commissionDetail.Amount);
                    p.Add("@LAmount", commissionDetail.LAmount);
                    p.Add("@FAmount", commissionDetail.FAmount);
                    p.Add("@SalesProfitShare", commissionDetail.SalesProfitShare);
                    p.Add("@FixCommission", commissionDetail.FixCommission);
                    p.Add("@Paid", commissionDetail.Paid);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", commissionDetail.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    commissionDetail.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewCommissionDetail @CommissionManagerId, @CommissionId, @SalesId, @CurrencyId, @Rate, " +
                        "@Amount, @LAmount, @FAmount, @SalesProfitShare, @FixCommission, @Paid, @CompanyId, @Notes, @CreatedBy", p);

                    return commissionDetail.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdateCommissionDetail(CommissionDetailModel commissionDetail)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", commissionDetail.Id);
                    p.Add("@CommissionManagerId", commissionDetail.CommissionManagerId);
                    p.Add("@CommissionId", commissionDetail.CommissionId);
                    p.Add("@SalesId", commissionDetail.SalesId);
                    p.Add("@CurrencyId", commissionDetail.CurrencyId);
                    p.Add("@Rate", commissionDetail.Rate);
                    p.Add("@Amount", commissionDetail.Amount);
                    p.Add("@LAmount", commissionDetail.LAmount);
                    p.Add("@FAmount", commissionDetail.FAmount);
                    p.Add("@SalesProfitShare", commissionDetail.SalesProfitShare);
                    p.Add("@FixCommission", commissionDetail.FixCommission);
                    p.Add("@Paid", commissionDetail.Paid);
                    p.Add("@Notes", commissionDetail.Notes);
                    p.Add("@LastModifiedBy", commissionDetail.LastModifiedBy);
                    p.Add("@LastModifiedDate", commissionDetail.LastModifiedDate);
                    p.Add("@Active", commissionDetail.Active);

                    int updatedCommissionDetail = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateCommissionDetail @Id, @CommissionManagerId, @CommissionId, @SalesId, @CurrencyId, @Rate, " +
                        "@Amount, @LAmount, @FAmount, @SalesProfitShare, @FixCommission, @Paid, " +
                        "@Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);

                    return updatedCommissionDetail;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteCommissionDetailById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM CommissionsDetails WHERE Id = @Id", p);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteCommissionDetail(int commissionId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CommissionId", commissionId);

                    _ = connection.ExecuteScalar("DELETE FROM CommissionsDetails WHERE CommissionId = @CommissionId", p);
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

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
        }

        #endregion
    }
}
