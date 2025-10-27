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
    public class CommissionRepository : IDisposable
    {
        public IList<CommissionModel> SelectCommissions()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var payments =
                        connection.Query<CommissionModel>("SELECT * FROM Commissions WHERE CompanyId = @CompanyId;", p);
                    return payments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<CommissionModel> SelectCommissions(bool onlyPaid = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Paid", onlyPaid);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var payments =
                        connection.Query<CommissionModel>("SELECT * FROM Commissions WHERE paid = @Paid AND CompanyId = @CompanyId;", p);
                    return payments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CommissionModel SelectCommissionById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var payment =
                        connection.QuerySingleOrDefault("SELECT * FROM Commissions WHERE CompanyId = @CompanyId;", p);
                    return payment;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewCommission(CommissionModel commissionModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@JobId", commissionModel.JobId);
                    p.Add("@DepartmentId", commissionModel.DepartmentId);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", commissionModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    commissionModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewCommission @JobId, @DepartmentId, @CompanyId, @Notes, @CreatedBy", p);

                    return commissionModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdateCommission(CommissionModel commissionModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", commissionModel.Id);
                    p.Add("@JobId", commissionModel.JobId);
                    p.Add("@DepartmentId", commissionModel.DepartmentId);
                    p.Add("@Notes", commissionModel.Notes);
                    p.Add("@LastModifiedBy", commissionModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", commissionModel.LastModifiedDate);
                    p.Add("@Active", commissionModel.Active);

                    int updatedCommission = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateCommission @Id, @JobId, @DepartmentId, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);

                    return updatedCommission;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteCommission(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Commissions WHERE Id = @Id", p);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ReCalculateCommissions()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {

                    _ = connection.ExecuteScalar("UPDATE Commissions SET TotalInvoices = dbo.__TotalInvoices_V101(c.JobId, c.DepartmentId) FROM Commissions c WHERE Paid = 0;");
                    _ = connection.ExecuteScalar("UPDATE Commissions SET TotalInvoices = dbo.__TotalInvoices_V101(c.JobId, c.DepartmentId) FROM Commissions c WHERE Paid = 0;");
                    _ = connection.ExecuteScalar("UPDATE Commissions SET TotalInvoices = dbo.__TotalInvoices_V101(c.JobId, c.DepartmentId) FROM Commissions c WHERE Paid = 0;");
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
