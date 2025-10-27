using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Countries
{
	public class DistrictRepository : IDisposable
	{
		public IList<DistrictModel> SelectDistricts()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", CurrentUser.CompanyId);

					var districtsRecords =
						connection.Query<DistrictModel>("SELECT * FROM Districts WHERE CompanyId = @CompanyId;", parameters);
					return districtsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<DistrictModel> SelectDistrictsByCompanyId(int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", companyId);

					var districtsRecords =
						connection.Query<DistrictModel>("SELECT * FROM Districts WHERE CompanyId = @CompanyId;", parameters);
					return districtsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public DistrictModel SelectDistrictById(int districtId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", districtId);

					var districtRecord =
						connection.QuerySingleOrDefault<DistrictModel>("SELECT * FROM Districts WHERE Id = @Id;", parameters);
					return districtRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewDistrict(DistrictModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					parameters.Add("@Name", dataModel.Name);
					parameters.Add("@ProvinceId", dataModel.ProvinceId);
					parameters.Add("@CountryId", dataModel.CountryId);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@CompanyId", dataModel.CompanyId);
					parameters.Add("@BranchId", dataModel.BranchId);
					parameters.Add("@CreatedBy", dataModel.CreatedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Locked", dataModel.Locked);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Districts (Name, ProvinceId, CountryId, Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@Name, @ProvinceId, @CountryId, @Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)"
										, parameters);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateDistrict(DistrictModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", dataModel.Id);
					parameters.Add("@Name", dataModel.Name);
					parameters.Add("@ProvinceId", dataModel.ProvinceId);
					parameters.Add("@CountryId", dataModel.CountryId);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Active", dataModel.Active);
					parameters.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Districts SET " +
								"Name = @Name, ProvinceId = @ProvinceId, CountryId = @CountryId, " +
								"Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate= GETDATE(), " +
								"WorkingYear = @WorkingYear, IsProtected = @IsProtected, IsDefault = @IsDefault, " +
								"Active = @Active, Locked = @Locked " +
								"WHERE Id = @Id", parameters);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteDistrict(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Districts WHERE Id = @Id", parameters);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public void Dispose()
		{

		}
	}
}
