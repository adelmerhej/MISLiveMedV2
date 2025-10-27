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
	public class ContinentRepository : IDisposable
	{
		public IList<ContinentModel> SelectContinents()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<ContinentModel>("SELECT * FROM Continents WHERE CompanyId = @CompanyId;", parameters);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<ContinentModel> SelectContinentByCompanyId(int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", companyId);

					var records =
						connection.Query<ContinentModel>("SELECT * FROM Continents WHERE CompanyId = @CompanyId;", parameters);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<ContinentModel> SelectContinentsByCountryId(int countryId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CountryId", countryId);

					var records =
						connection.Query<ContinentModel>("SELECT * FROM Continents WHERE ContinentId = @ContinentId;", parameters);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public ContinentModel SelectContinentByCityId(int cityId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", cityId);

					var record =
						connection.QuerySingleOrDefault<ContinentModel>("SELECT * FROM Continents WHERE Id = @Id;", parameters);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewContinent(ContinentModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					parameters.Add("@Name", dataModel.Name);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@CompanyId", dataModel.CompanyId);
					parameters.Add("@BranchId", dataModel.BranchId);
					parameters.Add("@CreatedBy", dataModel.CreatedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Locked", dataModel.Locked);

					dataModel.Id = connection.ExecuteScalar<int>(
							"INSERT INTO Continents (Name, Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@Name, @Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)", parameters)
						;
					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateContinent(ContinentModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", dataModel.Id);
					parameters.Add("@Name", dataModel.Name);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Active", dataModel.Active);
					parameters.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>("UPDATE Continents SET " +
									"Name = @Name, Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate= GETDATE(), " +
									"WorkingYear = @WorkingYear, IsProtected = @IsProtected, IsDefault = @IsDefault, " +
									"Active = @Active, Locked = @Locked WHERE Id = @Id", parameters); ;
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteContinent(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Continents WHERE Id = @Id", parameters);
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
