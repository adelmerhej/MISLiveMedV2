using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.AspNet.Identity;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Common;

namespace MISLiveMed.DataLayers.Users
{
	public class UserRepository : IDisposable
	{
		private const string _collectionName = "users";

		public IList<UserModel> SelectUsers(bool showProtected = false, bool showOnlyActive = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@CompanyId", CurrentUser.CompanyId);
				p.Add("@IsProtected", showProtected);
				p.Add("@Active", showOnlyActive);

				var usersRecord =
					connection.Query<UserModel>("SELECT * FROM Users u " +
					                            "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
					                            "AND (@Active = 0 OR Active = @Active) " +
					                            "AND CompanyId = @CompanyId;", p);

				return usersRecord.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public UserModel SelectUserById(int userId, bool showProtected = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@UserId", userId);
				p.Add("@IsProtected", showProtected);
				p.Add("@CompanyId", CurrentUser.CompanyId);

				var userRecord =
					connection.QuerySingleOrDefault<UserModel>("SELECT * FROM Users " +
					                                           "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
					                                           "AND Id = @UserId " +
					                                           "AND CompanyId = @CompanyId;", p);

				return userRecord;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public UserModel GetUsersByName(string userName, bool showProtected = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@UserName", userName);
				p.Add("@IsProtected", showProtected);
				p.Add("@CompanyId", CurrentUser.CompanyId);

				var userRecord =
					connection.QuerySingleOrDefault<UserModel>("SELECT * FROM Users u " +
					                                           "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
					                                           "AND UserName = @UserName " +
					                                           "AND CompanyId = @CompanyId;", p);
				return userRecord;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public UserModel SelectSalesByCustomerId(int customerId, bool showProtected = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@CustomerId", customerId);
				p.Add("@IsProtected", showProtected); 
				p.Add("@CompanyId", CurrentUser.CompanyId);

				var userRecord =
					connection.QuerySingleOrDefault<UserModel>("SELECT u.* FROM Users u INNER JOIN Customers c ON u.Id = c.SalesId " +
					                                           "WHERE (@IsProtected = 1 OR u.IsProtected = @IsProtected) " +
					                                           "AND c.Id = @CustomerId " +
					                                           "AND u.CompanyId = @CompanyId;",
						p);

				return userRecord;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<UserModel> SelectUsersAsSales(bool showProtected = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@CompanyId", CurrentUser.CompanyId);
				p.Add("@IsProtected", showProtected);

				var salesRecord =
					connection.Query<UserModel>("SELECT * FROM Users u inner join UsersDetails ud on u.Id = ud.UserId " +
					                            "WHERE (@IsProtected = 1 OR u.IsProtected = @IsProtected) " +
					                            "AND ud.IsSales = 1 " +
					                            "AND u.CompanyId = @CompanyId", p);
				return salesRecord.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<OperatingUserHistoryModel> SelectUserHistoryById(int responsibleId, bool showProtected = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@ResponsibleId", responsibleId);
				p.Add("@CompanyId", CurrentUser.CompanyId);
				p.Add("@IsProtected", showProtected);

				var userRecord =
					connection.Query<OperatingUserHistoryModel>("dbo.job_ResponsibleHistory @ResponsibleId, @CompanyId, @IsProtected;", p);
				return userRecord.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public UserModel SelectDefaultUserByCompanyId(int companyId)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@CompanyId", companyId);

				var userRecord =
					connection.QuerySingleOrDefault<UserModel>("SELECT * FROM Users " +
					                                           "WHERE CompanyId = @CompanyId AND UserName ='admin';", p);

				return userRecord;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewUser(UserModel dataModel)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
				p.Add("@UserName", dataModel.UserName);
				p.Add("@Password", dataModel.Password);
				p.Add("@PasswordHash", dataModel.PasswordHash);
				p.Add("@SecurityStamp", dataModel.SecurityStamp);
				p.Add("@Email", dataModel.Email);
				p.Add("@EmailConfirmed", dataModel.EmailConfirmed);
				p.Add("@MobileNumber", dataModel.MobileNumber);
				p.Add("@MobileNumberConfirmed", dataModel.MobileNumberConfirmed);
				p.Add("@TwoFactorEnabled", dataModel.TwoFactorEnabled);
				p.Add("@LockoutEndDate", dataModel.LockoutEndDate);
				p.Add("@LockoutEnabled", dataModel.LockoutEnabled);
				p.Add("@AccessFailedCount", dataModel.AccessFailedCount);
				p.Add("@ChangePasswordNextLogon", dataModel.ChangePasswordNextLogon);
				p.Add("@SecurityLevel", dataModel.SecurityLevel);
				p.Add("@FirstTimeAccess", dataModel.FirstTimeAccess);
				p.Add("@PermissionChanged", dataModel.PermissionChanged);

				p.Add("@Notes", dataModel.Notes);
				p.Add("@CompanyId", dataModel.CompanyId);
				p.Add("@BranchId", dataModel.BranchId);
				p.Add("@CreatedBy", dataModel.CreatedBy);
				p.Add("@IsProtected", dataModel.IsProtected);
				p.Add("@IsDefault", dataModel.IsDefault);

				dataModel.Id = connection.ExecuteScalar<int>(
					"dbo.job_AddNewUser @UserName, @Password, @PasswordHash, @SecurityStamp, @Email, @EmailConfirmed, " +
					"@MobileNumber, @MobileNumberConfirmed, @TwoFactorEnabled, @LockoutEndDate, @LockoutEnabled, @AccessFailedCount, " +
					"@ChangePasswordNextLogon, @SecurityLevel, @FirstTimeAccess, @PermissionChanged, " +
					"@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected, @IsDefault ",
					p);

				return dataModel.Id;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateUser(UserModel dataModel)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", dataModel.Id);
				p.Add("@UserName", dataModel.UserName);
				p.Add("@Password", dataModel.Password);
				p.Add("@PasswordHash", dataModel.PasswordHash);
				p.Add("@SecurityStamp", dataModel.SecurityStamp);
				p.Add("@Email", dataModel.Email);
				p.Add("@EmailConfirmed", dataModel.EmailConfirmed);
				p.Add("@MobileNumber", dataModel.MobileNumber);
				p.Add("@MobileNumberConfirmed", dataModel.MobileNumberConfirmed);
				p.Add("@TwoFactorEnabled", dataModel.TwoFactorEnabled);
				p.Add("@LockoutEndDate", dataModel.LockoutEndDate);
				p.Add("@LockoutEnabled", dataModel.LockoutEnabled);
				p.Add("@AccessFailedCount", dataModel.AccessFailedCount);
				p.Add("@ChangePasswordNextLogon", dataModel.ChangePasswordNextLogon);
				p.Add("@SecurityLevel", dataModel.SecurityLevel);
				p.Add("@FirstTimeAccess", dataModel.FirstTimeAccess);
				p.Add("@PermissionChanged", dataModel.PermissionChanged);

				p.Add("@Notes", dataModel.Notes);
				p.Add("@CompanyId", dataModel.CompanyId);
				p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
				p.Add("@IsProtected", dataModel.IsProtected);
				p.Add("@Active", dataModel.Active);

				_ = connection.ExecuteScalar("dbo.job_UpdateUser @Id, @UserName, @Password, @PasswordHash, @SecurityStamp, @Email, @EmailConfirmed, " +
				                             "@MobileNumber, @MobileNumberConfirmed, @TwoFactorEnabled, @LockoutEndDate, @LockoutEnabled, @AccessFailedCount, " +
				                             "@ChangePasswordNextLogon, @SecurityLevel, @FirstTimeAccess, @PermissionChanged, " +
				                             "@Notes, @CompanyId, @LastModifiedBy, @IsProtected, @Active", p);

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteUser(int id)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", id);

				_ = connection.ExecuteScalar("Delete from Users WHERE Id = @Id", p);

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		#region Fix Missing UserId / AuthId / PasswordHash

		/// <summary>
		/// Fixes legacy rows:
		/// - Sets UserId = Id where missing (legacy internal FK usage).
		/// - Generates AuthId (GUID) where AuthId IS NULL.
		/// - Hashes plain Password into PasswordHash where PasswordHash IS NULL AND Password not null/empty.
		/// NOTE: Assumes the Users table has columns: UserId, AuthId, Password, PasswordHash.
		/// Adjust column names if your schema differs.
		/// </summary>
		public bool FixTableUsers()
		{
			try
			{
				using (var connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					connection.Open();
					using (var transaction = connection.BeginTransaction())
					{
						// 1. Ensure UserId backfill (kept from original logic)
						connection.Execute("UPDATE Users SET UserId = Id WHERE UserId IS NULL", transaction: transaction);

						// 2. Assign GUID AuthId for missing
						// NEWID() is evaluated per row in SQL Server.
						connection.Execute("UPDATE Users SET AuthId = NEWID() WHERE AuthId IS NULL", transaction: transaction);

						// 3. Retrieve rows needing password hashing
						// We pull only the needed columns; if Password column name differs, rename here.
						var rowsNeedingHash = connection.Query<dynamic>(
							"SELECT Id, Password, PasswordHash FROM Users WHERE (PasswordHash IS NULL OR PasswordHash = '') AND (Password IS NOT NULL AND Password <> '')",
							transaction: transaction).ToList();

						if (rowsNeedingHash.Any())
						{
							SystemUtilities.PasswordHasher = new PasswordHasher();

							foreach (var r in rowsNeedingHash)
							{
								string plain = (string)r.Password;
								if (string.IsNullOrWhiteSpace(plain))
									continue;

								var hashed = SystemUtilities.PasswordHasher.HashPassword(plain);

								var p = new DynamicParameters();
								p.Add("@Id", (int)r.Id);
								p.Add("@PasswordHash", hashed);

								connection.Execute("UPDATE Users SET PasswordHash = @PasswordHash WHERE Id = @Id", p, transaction);
							}
						}

						transaction.Commit();
					}
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		#endregion

		#region Implementation of IDisposable

		public void Dispose()
		{

		}

		#endregion
	}
}
