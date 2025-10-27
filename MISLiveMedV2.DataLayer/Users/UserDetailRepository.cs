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
	public class UserDetailRepository : IDisposable
	{
		public IList<UserDetailModel> SelectUserDetails()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var usersRecord =
						connection.Query<UserDetailModel>($"SELECT * FROM UsersDetails WHERE CompanyId = @CompanyId;", p);

					return usersRecord.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public UserDetailModel SelectUserDetailById(int userId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@UserId", userId);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var usersRecord =
						connection.QuerySingleOrDefault<UserDetailModel>($"SELECT top 1 * FROM UsersDetails WHERE UserId = @userId AND CompanyId = @CompanyId;", p);

					return usersRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewUserDetail(UserDetailModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@UserId", dataModel.UserId);
					p.Add("@Title", dataModel.Title);
					p.Add("@FirstName", dataModel.FirstName);
					p.Add("@LastName", dataModel.LastName);
					p.Add("@PhoneNumber", dataModel.PhoneNumber);
					p.Add("@IsSales", dataModel.IsSales);
					p.Add("@SalesContractId", dataModel.SalesContractId);
					p.Add("@Address", dataModel.Address);
					p.Add("@CountryId", dataModel.CountryId);
					p.Add("@CityId", dataModel.CityId);
					p.Add("@DistrictId", dataModel.DistrictId);
					p.Add("@ProvinceId", dataModel.ProvinceId);
					p.Add("@BirthDate", dataModel.BirthDate);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@IsDefault", dataModel.IsDefault);

					dataModel.Id = connection.ExecuteScalar<int>(
						"dbo.job_AddNewUserDetails @UserId, @Title, @FirstName, @LastName, @PhoneNumber, " +
						"@IsSales, @SalesContractId, @Address, @CountryId, @CityId, @DistrictId, " +
						"@ProvinceId, @BirthDate, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected, @IsDefault ",
						p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public void UpdateUserDetail(UserDetailModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@UserId", dataModel.UserId);
					p.Add("@Title", dataModel.Title);
					p.Add("@FirstName", dataModel.FirstName);
					p.Add("@LastName", dataModel.LastName);
					p.Add("@PhoneNumber", dataModel.PhoneNumber);
					p.Add("@IsSales", dataModel.IsSales);
					p.Add("@SalesContractId", dataModel.SalesContractId);
					p.Add("@Address", dataModel.Address);
					p.Add("@CountryId", dataModel.CountryId);
					p.Add("@CityId", dataModel.CityId);
					p.Add("@DistrictId", dataModel.DistrictId);
					p.Add("@ProvinceId", dataModel.ProvinceId);
					p.Add("@BirthDate", dataModel.BirthDate);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar("dbo.job_UpdateUserDetails @Id, @UserId, @Title, @FirstName, @LastName, @PhoneNumber, " +
					                             "@IsSales, @SalesContractId, @Address, @CountryId, @CityId, @DistrictId, " +
					                             "@ProvinceId, @BirthDate, @Notes, @LastModifiedBy, @IsProtected, @Active", p);

				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public void DeleteUserDetail(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("Delete from Users WHERE UserID = @Id", p);
				}
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
