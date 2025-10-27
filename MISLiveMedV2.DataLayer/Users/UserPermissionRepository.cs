using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.Administration.Application;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Users
{
	public class UserPermissionRepository : IDisposable
	{
		private const string _schema = "_application";

		public IList<UserPermissionModel> SelectUserPermissions()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@CompanyId", CurrentUser.CompanyId);

				var dataRecords =
					connection.Query<UserPermissionModel>("SELECT * FROM UsersPermission u WHERE u.CompanyId = @CompanyId;", p);

				return dataRecords.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<UserPermissionModel> SelectUserPermissionById(int permissionId)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@PermissionId", permissionId);

				var userRecords =
					connection.Query<UserPermissionModel>("SELECT * FROM UsersPermission WHERE UserPermissionId = @PermissionId;", p);
				return userRecords.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public void SeedUserPermissionsData(int userId, bool isAdmin)
		{
			try
			{
				int permissionFormId = 0;

				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@UserId", userId);
				p.Add("@CompanyId", CurrentUser.CompanyId);
				p.Add("@BranchId", CurrentUser.BranchId);
				p.Add("@CreatedBy", CurrentUser.UserId);
				p.Add("@IsDefault", isAdmin);
				p.Add("@DefaultValue", isAdmin);

				var defaultPermissionControls =
					connection.Query<UserPermissionControlModel>("SELECT * FROM UsersPermissionControls " +
					                                             "WHERE CompanyId = @CompanyId AND IsDefault = 1;",
						p).ToList();

				var forms =
					connection.Query<ApplicationModel>(
						$@"SELECT * FROM {_schema}.Forms WHERE CompanyId = @CompanyId;", p);

				foreach (var form in forms)
				{
					var userForm =
						connection.QuerySingleOrDefault<UserFormPermissionModel>(
							$"SELECT * FROM UsersFormPermission " +
							$"WHERE CompanyId = @CompanyId AND FormId = {form.Id} AND UserId = @UserId", p);

					if (userForm == null)
					{
						permissionFormId = connection.ExecuteScalar<int>(
							"INSERT INTO UsersFormPermission (FormId, UserId, CompanyId, BranchId, CreatedBy, IsDefault) OUTPUT Inserted.Id " +
							$"VALUES ({form.Id}, @UserId, @CompanyId, @BranchId, @CreatedBy, @IsDefault)", p);
					}
					else
					{
						var permissionFormModel =
							connection.QuerySingleOrDefault<UserFormPermissionModel>(
								$"SELECT * FROM UsersFormPermission " +
								$"WHERE CompanyId = @CompanyId AND FormId = {form.Id} AND UserId = @UserId;",
								p);

						if (permissionFormModel != null)
						{
							permissionFormId = permissionFormModel.Id;
						}
					}

					foreach (var defaultPermissionControl in defaultPermissionControls)
					{
						UserPermissionModel userPermissionModel =
							connection.QuerySingleOrDefault<UserPermissionModel>(
								$"SELECT * FROM UsersPermission " +
								$"WHERE CompanyId = @CompanyId AND UserPermissionId = {permissionFormId} " +
								$"AND ControlName = '{defaultPermissionControl.ControlName}';", p);

						if (userPermissionModel == null)
						{
							_ = connection.ExecuteScalar<int>(
								"INSERT INTO UsersPermission (UserPermissionId, ControlName, Value, CompanyId, BranchId, CreatedBy, IsDefault) " +
								"OUTPUT Inserted.Id " +
								$"VALUES ({permissionFormId}, '{defaultPermissionControl.ControlName}', @DefaultValue, @CompanyId, " +
								$"@BranchId, @UserId, @DefaultValue)", p);
						}
					}
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool HasPermission()
		{


			return true;
		}

		public IList<UserPermissionModel> SelectUserPermissionById(int userId, int formId)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@UserId", userId);
				p.Add("@FormId", formId);
				p.Add("@CompanyId", CurrentUser.CompanyId);

				var userRecords =
					connection.Query<UserPermissionModel>("SELECT up.* FROM UsersPermission up " +
					                                      "INNER JOIN UsersFormPermission ufp ON up.UserPermissionId = ufp.Id " +
					                                      "WHERE up.CompanyId = @CompanyId AND ufp.UserId = @UserId AND ufp.FormId = @FormId;", p);
				return userRecords.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewUserPermission(UserPermissionModel dataModel)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
				p.Add("@UserPermissionId", dataModel.UserPermissionId);
				p.Add("@ControlName", dataModel.ControlName);
				p.Add("@Value", dataModel.Value);

				p.Add("@Notes", dataModel.Notes);
				p.Add("@CompanyId", dataModel.CompanyId);
				p.Add("@BranchId", dataModel.BranchId);
				p.Add("@CreatedBy", dataModel.CreatedBy);
				p.Add("@IsProtected", dataModel.IsProtected);
				p.Add("@IsDefault", dataModel.IsDefault);

				dataModel.Id = connection.ExecuteScalar<int>(
					"INSERT INTO UsersPermission (UserPermissionId, ControlName, Value, Notes, " +
					"CompanyId, BranchId, CreatedBy, IsProtected, IsDefault)" +
					"VALUES (@UserPermissionId, @ControlName, @Value, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected, @IsDefault)",
					p);

				return dataModel.Id;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool UpdateUserPermission(UserPermissionModel dataModel)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", dataModel.Id);
				p.Add("@UserPermissionId", dataModel.UserPermissionId);
				p.Add("@ControlName", dataModel.ControlName);
				p.Add("@Value", dataModel.Value);

				p.Add("@Notes", dataModel.Notes);
				p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
				p.Add("@IsProtected", dataModel.IsProtected);
				p.Add("@Active", dataModel.Active);

				_ = connection.ExecuteScalar("UPDATE UsersPermission SET " +
				                             "UserPermissionId = @UserPermissionId, ControlName = @ControlName, Value = @Value, " +
				                             "Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate = GETDATE(), IsProtected = @IsProtected, Active = @Active " +
				                             "WHERE Id = @Id ",
					p);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteUserPermission(int id)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", id);

				_ = connection.ExecuteScalar("Delete from UsersPermission WHERE Id = @Id", p);

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
