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
	public class ProvinceRepository : IDisposable
	{
		public IList<ProvinceModel> SelectProvinces()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", CurrentUser.CompanyId);

					var provincesRecords =
						connection.Query<ProvinceModel>("SELECT * FROM Provinces WHERE CompanyId = @CompanyId;", parameters);
					return provincesRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public IList<ProvinceModel> SelectProvincesByCompanyId(int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", companyId);

					var provincesRecords =
						connection.Query<ProvinceModel>("SELECT * FROM Provinces WHERE CompanyId = @CompanyId;", parameters);
					return provincesRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<ProvinceModel> SelectProvincesByCountryId(int countryId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CountryId", countryId);

					var provincesRecords =
						connection.Query<ProvinceModel>("SELECT * FROM Provinces WHERE CountryId = @CountryId;", parameters);
					return provincesRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public ProvinceModel SelectProvinceById(int provinceId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", provinceId);

					var provinceRecord =
						connection.QuerySingleOrDefault<ProvinceModel>("SELECT * FROM Provinces WHERE Id = @Id;", parameters);
					return provinceRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewProvince(ProvinceModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					parameters.Add("@Name", dataModel.Name);
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
							"INSERT INTO Provinces (Name, CountryId, Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@Name, @CountryId, @Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)", parameters)
						;
					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateProvince(ProvinceModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", dataModel.Id);
					parameters.Add("@ProvinceName", dataModel.Name);
					parameters.Add("@CountryId", dataModel.CountryId);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Active", dataModel.Active);
					parameters.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Provinces SET " +
									"Name = @ProvinceName, CountryId = @CountryId, " +
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

		public bool DeleteProvince(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Provinces WHERE Id = @Id", parameters);
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
