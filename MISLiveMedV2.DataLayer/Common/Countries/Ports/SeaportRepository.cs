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
    public class SeaportRepository : IDisposable
    {
        public IList<PortModel> SelectSeaports()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@CompanyId", CurrentUser.CompanyId);

                    var seaportsRecords =
                        connection.Query<PortModel>("SELECT * FROM Ports WHERE PortTypeId = 1 AND CompanyId = @CompanyId;", parameters);
                    return seaportsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PortModel SelectSeaportById(int seaportId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", seaportId);

                    var seaportRecord =
                        connection.QuerySingleOrDefault<PortModel>("SELECT * FROM Ports WHERE Id = @Id;", parameters);
                    return seaportRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

		public int AddNewSeaport(PortModel dataModel)
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
						"INSERT INTO Ports (Code, Name, PortTypeId, CityId, CountryId, Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@Code, @Name, @PortTypeId, @CityId, @CountryId, @Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)", parameters);


					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateSeaport(PortModel dataModel)
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

		public bool DeleteSeaport(int id)
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

        public void Dispose()
        {

        }

        #endregion
    }
}
