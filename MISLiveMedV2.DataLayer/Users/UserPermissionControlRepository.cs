using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Users
{
	public class UserPermissionControlRepository : IDisposable
	{
		public IList<UserPermissionControlModel> SelectDefaultUserPermissionControls()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", 1);

					var dataRecords =
						connection.Query<UserPermissionControlModel>("SELECT * FROM UsersPermissionControls u WHERE u.CompanyId = @CompanyId;", p);

					return dataRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<UserPermissionControlModel> SelectUserPermissionControls()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var dataRecords =
						connection.Query<UserPermissionControlModel>("SELECT * FROM UsersPermissionControls u WHERE u.CompanyId = @CompanyId;", p);

					return dataRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int SelectUserPermissionControlByControlName(string controlName, int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ControlName", controlName);
					p.Add("@CompanyId", companyId);

					var userRecords =
						connection.QuerySingleOrDefault<UserPermissionControlModel>("SELECT * FROM UsersPermissionControls " +
							"WHERE ControlName = @ControlName AND CompanyId = @CompanyId;", p);

					var returnFormId = userRecords?.Id ?? 0;
					return returnFormId;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<UserPermissionControlModel> SelectUserPermissionControlById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					var userRecords =
						connection.Query<UserPermissionControlModel>("SELECT * FROM UsersPermissionControls WHERE Id = @Id;", p);
					return userRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewUserPermissionControl(UserPermissionControlModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@ControlName", dataModel.ControlName);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
							"INSERT INTO UsersPermissionControls (ControlName, Notes, CompanyId, BranchId, CreatedBy, IsProtected) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@ControlName, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p)
						;
					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateUserPermissionControl(UserPermissionControlModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@ControlName", dataModel.ControlName);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>("UPDATE UsersPermissionControls SET " +
													  "ControlName = @ControlName, Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
													  "LastModifiedDate= GETDATE(), IsProtected = @IsProtected, Active = @Active WHERE Id = @Id", p); ;
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteCUserPermissionControl(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM UsersPermissionControls WHERE Id = @Id", p);
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
