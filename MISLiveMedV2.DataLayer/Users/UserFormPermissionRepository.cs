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
	public class UserFormPermissionRepository : IDisposable
	{
		public IList<UserFormPermissionModel> SelectUserFormPermissions()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var dataRecords =
						connection.Query<UserFormPermissionModel>("SELECT * FROM UsersFormPermission u WHERE u.CompanyId = @CompanyId;", p);

					return dataRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public UserFormPermissionModel SelectUserFormPermissionById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					var userRecord =
						connection.QuerySingleOrDefault<UserFormPermissionModel>(
							"SELECT * FROM UsersFormPermission WHERE Id = @Id ;", p);

					return userRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public UserFormPermissionModel SelectUserFormPermissionById(int userId, int formId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@UserId", userId);
					p.Add("@FormId", formId);

					var userRecord =
						connection.QuerySingleOrDefault<UserFormPermissionModel>(
							"SELECT * FROM UsersFormPermission WHERE UserId = @UserId AND FormId = @FormId;", p);

					return userRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewUserFormPermission(UserFormPermissionModel dataModel)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
				p.Add("@FormId", dataModel.FormId);
				p.Add("@UserId", dataModel.UserId);

				p.Add("@Notes", dataModel.Notes);
				p.Add("@CompanyId", dataModel.CompanyId);
				p.Add("@BranchId", dataModel.BranchId);
				p.Add("@CreatedBy", dataModel.CreatedBy);
				p.Add("@IsProtected", dataModel.IsProtected);
				p.Add("@IsDefault", dataModel.IsDefault);

				dataModel.Id = connection.ExecuteScalar<int>(
					"INSERT INTO UsersFormPermission (FormId, UserId, Notes, CompanyId, BranchId, CreatedBy, CreatedDate, IsProtected, IsDefault)" +
					"VALUES (@FormId, @UserId, @Notes, @CompanyId, @BranchId, @CreatedBy, GETDATE(), @IsProtected, @IsDefault)",
					p);

				return dataModel.Id;

			}
		}

		public void UpdateUserFormPermission(UserFormPermissionModel dataModel)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@Id", dataModel.Id);
				p.Add("@FormId", dataModel.FormId);
				p.Add("@UserId", dataModel.UserId);

				p.Add("@Notes", dataModel.Notes);
				p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
				p.Add("@IsProtected", dataModel.IsProtected);
				p.Add("@Active", dataModel.Active);

				_ = connection.ExecuteScalar("UPDATE UsersFormPermission SET " +
											 "FormId = @FormId, UserId = @UserId, Notes = @Notes, " +
											 "LastModifiedBy = @LastModifiedBy, LastModifiedDate = GETDATE(), IsProtected = @IsProtected, Active = @Active " +
											 "WHERE Id = @Id ",
					p);

			}
		}

		public void DeleteUserFormPermission(int id)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@Id", id);

				_ = connection.ExecuteScalar("Delete from UsersFormPermission WHERE Id = @Id", p);
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
