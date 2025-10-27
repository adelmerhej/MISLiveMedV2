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
    public class CityRepository : IDisposable
    {
        public IList<CityModel> SelectCities()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@CompanyId", CurrentUser.CompanyId);

                    var citiesRecords =
                        connection.Query<CityModel>("SELECT * FROM Cities WHERE CompanyId = @CompanyId;", parameters);
                    return citiesRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<CityModel> SelectCitiesByCompanyId(int companyId)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var parameters = new DynamicParameters();
			        parameters.Add("@CompanyId", companyId);

			        var citiesRecords =
				        connection.Query<CityModel>("SELECT * FROM Cities WHERE CompanyId = @CompanyId;", parameters);
			        return citiesRecords.ToList();
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
        }

		public IList<CityModel> SelectCitiesByCountryId(int countryId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@CountryId", countryId);

                    var citiesRecords =
                        connection.Query<CityModel>("SELECT * FROM Cities WHERE CountryId = @CountryId;", parameters);
                    return citiesRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CityModel SelectCityById(int cityId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", cityId);

                    var cityRecord =
                        connection.QuerySingleOrDefault<CityModel>("SELECT * FROM Cities WHERE Id = @Id;", parameters);
                    return cityRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewCity(CityModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    parameters.Add("@CountryId", dataModel.CountryId);
                    parameters.Add("@CityCode", dataModel.CityCode);
                    parameters.Add("@CityName", dataModel.CityName);
                    parameters.Add("@DistrictId", dataModel.DistrictId);
                    parameters.Add("@Population", dataModel.Population);
                    parameters.Add("@IsCapital", dataModel.IsCapital);

                    parameters.Add("@CompanyId", dataModel.CompanyId);
                    parameters.Add("@BranchId", dataModel.BranchId);
                    parameters.Add("@CreatedBy", dataModel.CreatedBy);
                    parameters.Add("@WorkingYear", dataModel.WorkingYear);
                    parameters.Add("@IsProtected", dataModel.IsProtected);
                    parameters.Add("@IsDefault", dataModel.IsDefault);
                    parameters.Add("@Locked", dataModel.Locked);

					dataModel.Id = connection.ExecuteScalar<int>(
					"INSERT INTO Cities (CountryId, CityCode, CityName, DistrictId, Population, IsCapital, " +
										"Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
										"OUTPUT Inserted.Id " +
										"VALUES (@CountryId, @CityCode, @CityName, @DistrictId, @Population, @IsCapital, " +
										"@Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)", parameters)
	                    ;
                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public void UpdateCity(CityModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", dataModel.Id);
                    parameters.Add("@CountryId", dataModel.CountryId);
                    parameters.Add("@CityCode", dataModel.CityCode);
                    parameters.Add("@CityName", dataModel.CityName);
                    parameters.Add("@DistrictId", dataModel.DistrictId);
                    parameters.Add("@Population", dataModel.Population);
                    parameters.Add("@IsCapital", dataModel.IsCapital);

                    parameters.Add("@Notes", dataModel.Notes);
                    parameters.Add("@LastModifiedBy", dataModel.LastModifiedBy);
                    parameters.Add("@WorkingYear", dataModel.WorkingYear);
                    parameters.Add("@IsProtected", dataModel.IsProtected);
                    parameters.Add("@IsDefault", dataModel.IsDefault);
                    parameters.Add("@Active", dataModel.Active);
                    parameters.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Cities SET " +
									"CountryId = @CountryId, CityCode = @CityCode, CityName = @CityName, DistrictId = @DistrictId, " +
									"Population = @Population, IsCapital = @IsCapital, " +
									"Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate= GETDATE(), " +
									"WorkingYear = @WorkingYear, IsProtected = @IsProtected, IsDefault = @IsDefault, " +
									"Active = @Active, Locked = @Locked " +
									"WHERE Id = @Id", parameters);
                }
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool DeleteCity(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Cities WHERE Id = @Id", parameters);
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
