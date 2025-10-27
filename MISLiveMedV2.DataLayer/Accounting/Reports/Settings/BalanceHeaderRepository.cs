using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Reports.Settings;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Reports.Settings
{
    public class BalanceHeaderRepository : IDisposable
    {
		public IList<BalanceHeaderModel> SelectBalanceHeaders()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					

					var records =
						connection.Query<BalanceHeaderModel>("SELECT * FROM BalanceHeaders WHERE CompanyId = @CompanyId;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public IList<BalanceHeaderModel> SelectBalanceHeaderByBalanceGroupId(int balanceGroupId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@BalanceGroupId", balanceGroupId);

					var records =
						connection.Query<BalanceHeaderModel>("SELECT * FROM BalanceHeaders " +
											"WHERE BalanceGroupId = @BalanceGroupId AND CompanyId = @CompanyId;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public BalanceHeaderModel SelectBalanceHeaderById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					var record =
						connection.QuerySingleOrDefault<BalanceHeaderModel>("SELECT * FROM BalanceHeaders WHERE Id = @Id;", p);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewBalanceHeader(BalanceHeaderModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@Description", dataModel.Description);
					p.Add("@BalanceGroupId", dataModel.BalanceGroupId);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
					"INSERT INTO BalanceHeaders (Description, BalanceGroupId, Notes, CompanyId, BranchId, CreatedBy, IsProtected) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@Description, @BalanceGroupId, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p)
						;
					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateBalanceHeader(BalanceHeaderModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@Description", dataModel.Description);
					p.Add("@BalanceGroupId", dataModel.BalanceGroupId);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
						"UPDATE BalanceHeaders SET " +
							"Description = @Description, BalanceGroupId = @BalanceGroupId, " +
							"Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
							"LastModifiedDate= GETDATE(), IsProtected = @IsProtected, Active = @Active " +
							"WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteBalanceHeader(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM BalanceHeaders WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
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
