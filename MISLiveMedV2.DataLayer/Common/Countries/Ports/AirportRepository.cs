using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Countries.Ports
{
    public class AirportRepository : IDisposable
    {
        public IList<PortModel> SelectAirports()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@CompanyId", CurrentUser.CompanyId);

                    var airportsRecords =
                        connection.Query<PortModel>("SELECT * FROM Ports WHERE PortTypeId = 2 AND CompanyId = @CompanyId;", parameters);
                    return airportsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public SeaportModel SelectAirportById(int airportId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", airportId);

                    var airportRecord =
                        connection.QuerySingleOrDefault<SeaportModel>("SELECT * FROM Ports WHERE Id = @Id;", parameters);
                    return airportRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewAirport(PortModel dataModel)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var parameters = new DynamicParameters();
			        parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
			        parameters.Add("@Code", dataModel.Code);
			        parameters.Add("@Name", dataModel.Name);
			        parameters.Add("@PortTypeId", dataModel.PortTypeId);
			        parameters.Add("@CityId", dataModel.CityId);
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
				        "INSERT INTO Ports (Code, Name, PortTypeId, CityId, CountryId, " +
						"Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
				        "OUTPUT Inserted.Id " +
				        "VALUES (@Code, @Name, @PortTypeId, @CityId, @CountryId, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)", parameters);


			        return dataModel.Id;
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
		}

        public bool UpdateAirport(PortModel dataModel)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var parameters = new DynamicParameters();
			        parameters.Add("@Id", dataModel.Id);
			        parameters.Add("@Code", dataModel.Code);
			        parameters.Add("@Name", dataModel.Name);
			        parameters.Add("@PortTypeId", dataModel.PortTypeId);
			        parameters.Add("@CityId", dataModel.CityId);
			        parameters.Add("@CountryId", dataModel.CountryId);

			        parameters.Add("@Notes", dataModel.Notes);
			        parameters.Add("@LastModifiedBy", dataModel.LastModifiedBy);
			        parameters.Add("@WorkingYear", dataModel.WorkingYear);
			        parameters.Add("@IsProtected", dataModel.IsProtected);
			        parameters.Add("@IsDefault", dataModel.IsDefault);
			        parameters.Add("@Active", dataModel.Active);
			        parameters.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>("UPDATE Ports SET " +
			                                          "Code = @Code, Name = @Name, PortTypeId = @PortTypeId, CityId= @CityId, CountryId = @CountryId, " +
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

        public bool DeleteAirport(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Ports WHERE Id = @Id", parameters);
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
