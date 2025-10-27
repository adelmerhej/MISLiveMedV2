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
	public class CountryRepository : IDisposable
	{
		public IList<CountryModel> SelectCountries()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", CurrentUser.CompanyId);

					var countriesRecords =
						connection.Query<CountryModel>("SELECT * FROM Countries WHERE CompanyId = @CompanyId;", parameters);
					return countriesRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<CountryModel> SelectCountriesByCompanyId(int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", companyId);

					var countriesRecords =
						connection.Query<CountryModel>("SELECT * FROM Countries WHERE CompanyId = @CompanyId;", parameters);
					return countriesRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public CountryModel SelectCountryById(int countryId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", countryId);

					var countryRecord =
						connection.QuerySingleOrDefault<CountryModel>("SELECT * FROM Countries WHERE Id = @Id;", parameters);
					return countryRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewCountry(CountryModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					parameters.Add("@ContinentId", dataModel.ContinentId);
					parameters.Add("@RegionId", dataModel.RegionId);
					parameters.Add("@Code2", dataModel.Code2);
					parameters.Add("@CountryCode", dataModel.CountryCode);
					parameters.Add("@CountryName", dataModel.CountryName);
					parameters.Add("@Nationality", dataModel.Nationality);
					parameters.Add("@SurfaceArea", dataModel.SurfaceArea);
					parameters.Add("@IndependentYear", dataModel.IndependentYear);
					parameters.Add("@Population", dataModel.Population);
					parameters.Add("@LifeExpectancy", dataModel.LifeExpectancy);
					parameters.Add("@GNP", dataModel.GNP);
					parameters.Add("@GNPOld", dataModel.GNPOld);
					parameters.Add("@GovernmentForm", dataModel.GovernmentForm);
					parameters.Add("@LocalName", dataModel.LocalName);
					parameters.Add("@HeadOfState", dataModel.HeadOfState);
					parameters.Add("@Capital", dataModel.Capital);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@CompanyId", dataModel.CompanyId);
					parameters.Add("@BranchId", dataModel.BranchId);
					parameters.Add("@CreatedBy", dataModel.CreatedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Locked", dataModel.Locked);


					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Countries (ContinentId, RegionId, Code2, CountryCode, CountryName, Nationality, " +
									"SurfaceArea, IndependentYear, Population, LifeExpectancy, GNP, GNPOld, GovernmentForm, " +
									"LocalName, HeadOfState, Capital, " +
									"Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@ContinentId, @RegionId, @Code2, @CountryCode, @CountryName, @Nationality, @SurfaceArea, " +
									"@IndependentYear, @Population, @LifeExpectancy, @GNP, @GNPOld, @GovernmentForm, " +
									"@LocalName, @HeadOfState, @Capital, " +
									"@Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)", parameters);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateCountry(CountryModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", dataModel.Id);
					parameters.Add("@ContinentId", dataModel.ContinentId);
					parameters.Add("@RegionId", dataModel.RegionId);
					parameters.Add("@Code2", dataModel.Code2);
					parameters.Add("@CountryCode", dataModel.CountryCode);
					parameters.Add("@CountryName", dataModel.CountryName);
					parameters.Add("@Nationality", dataModel.Nationality);
					parameters.Add("@SurfaceArea", dataModel.SurfaceArea);
					parameters.Add("@IndependentYear", dataModel.IndependentYear);
					parameters.Add("@Population", dataModel.Population);
					parameters.Add("@LifeExpectancy", dataModel.LifeExpectancy);
					parameters.Add("@GNP", dataModel.GNP);
					parameters.Add("@GNPOld", dataModel.GNPOld);
					parameters.Add("@LocalName", dataModel.LocalName);
					parameters.Add("@GovernmentForm", dataModel.GovernmentForm);
					parameters.Add("@HeadOfState", dataModel.HeadOfState);
					parameters.Add("@Capital", dataModel.Capital);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Active", dataModel.Active);
					parameters.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Countries SET " +
								"ContinentId = @ContinentId, RegionId = @RegionId, Code2 = @Code2, CountryCode = @CountryCode, CountryName = @CountryName, " +
								"Nationality = @Nationality, SurfaceArea = @SurfaceArea, IndependentYear = @IndependentYear, Population = @Population, " +
								"LifeExpectancy = @LifeExpectancy, GNP = @GNP, GNPOld = @GNPOld, GovernmentForm = @GovernmentForm, HeadOfState = @HeadOfState, " +
								"Capital = @Capital, " +
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

		public bool DeleteCountry(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Countries WHERE Id = @Id", parameters);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		#region Implementation of IDisposable

		public void Dispose()
		{

		}

		#endregion
	}
}
