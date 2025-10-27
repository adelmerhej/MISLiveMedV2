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
    public class CommissionManagerRepository : IDisposable
    {
        public IList<CommissionManagerModel> SelectCommissionsManagement()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var payments =
                        connection.Query<CommissionManagerModel>("SELECT * FROM CommissionsManager WHERE CompanyId = @CompanyId;", p);
                    return payments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CommissionManagerModel SelectCommissionManagementById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var payments =
                        connection.QuerySingleOrDefault<CommissionManagerModel>("SELECT * FROM CommissionsManager WHERE Id = @id;", p);
                    return payments;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CommissionManagerModel SelectCommissionManagementByUserId(int userId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@UserId", userId);

                    var payments =
                        connection.QuerySingleOrDefault<CommissionManagerModel>("SELECT * FROM CommissionsManager WHERE UserId = @UserId;", p);
                    return payments;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public int AddNewCommissionManager(CommissionManagerModel dataModel)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var p = new DynamicParameters();
			        p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
			        p.Add("@SalesId", dataModel.SalesId);
			        p.Add("@ContractStartDate", dataModel.ContractStartDate);
			        p.Add("@ContractEndDate", dataModel.ContractEndDate);
			        p.Add("@SalesProfitShare", dataModel.SalesProfitShare);
			        p.Add("@RecurringSalesProfitShare", dataModel.RecurringSalesProfitShare);
			        p.Add("@FixCommission", dataModel.FixCommission);
			        p.Add("@DefaultOfficeFees", dataModel.DefaultOfficeFees);
			        p.Add("@DefaultTransferFees", dataModel.DefaultTransferFees);
			        p.Add("@IsSales", dataModel.IsSales);

					p.Add("@Notes", dataModel.Notes);
			        p.Add("@CompanyId", dataModel.CompanyId);
			        p.Add("@BranchId", dataModel.BranchId);
			        p.Add("@CreatedBy", dataModel.CreatedBy);
			        p.Add("@IsProtected", dataModel.IsProtected);

			        dataModel.Id = connection.ExecuteScalar<int>(
				        "dbo.job_AddNewCommissionsManager @SalesId, @ContractStartDate, @ContractEndDate, @SalesProfitShare, " +
						"@RecurringSalesProfitShare, @FixCommission, @DefaultOfficeFees, @DefaultTransferFees, @IsSales, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected", p);

			        return dataModel.Id;
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
		}

        public int UpdateCommissionManager(CommissionManagerModel dataModel)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var p = new DynamicParameters();
			        p.Add("@Id", dataModel.Id);
			        p.Add("@SalesId", dataModel.SalesId);
			        p.Add("@ContractStartDate", dataModel.ContractStartDate);
			        p.Add("@ContractEndDate", dataModel.ContractEndDate);
			        p.Add("@SalesProfitShare", dataModel.SalesProfitShare);
			        p.Add("@RecurringSalesProfitShare", dataModel.RecurringSalesProfitShare);
			        p.Add("@FixCommission", dataModel.FixCommission);
			        p.Add("@DefaultOfficeFees", dataModel.DefaultOfficeFees);
			        p.Add("@DefaultTransferFees", dataModel.DefaultTransferFees);
			        p.Add("@IsSales", dataModel.IsSales);

					p.Add("@Notes", dataModel.Notes);
			        p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
			        p.Add("@IsProtected", dataModel.IsProtected);
			        p.Add("@Active", dataModel.Active);

			        int updatedCommission = connection.ExecuteScalar<int>(
				        "dbo.job_UpdateCommissionsManager @Id, @SalesId, @ContractStartDate, @ContractEndDate, @SalesProfitShare, " +
						"@RecurringSalesProfitShare, @FixCommission, @DefaultOfficeFees, @DefaultTransferFees, @IsSales, " +
						"@Notes, @LastModifiedBy, @IsProtected, @Active", p);

			        return updatedCommission;
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
		}

        public bool DeleteCommissionManager(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM CommissionsManager WHERE Id = @Id", p);
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
