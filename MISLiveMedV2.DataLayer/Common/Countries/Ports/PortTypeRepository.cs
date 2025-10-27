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
    public class PortTypeRepository : IDisposable
    {
        public IList<PortTypeModel> SelectPortsType()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@CompanyId", CurrentUser.CompanyId);

                    var portsTypeRecords =
                        connection.Query<PortTypeModel>("SELECT * FROM PortsType WHERE CompanyId = @CompanyId;", parameters);
                    return portsTypeRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PortTypeModel SelectPortTypeById(int portTypeId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", portTypeId);

                    var portTypeRecord =
                        connection.QuerySingleOrDefault<PortTypeModel>("SELECT * FROM PortsType WHERE Id = @Id;", parameters);
                    return portTypeRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewSeaport(PortTypeModel portTypeModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    parameters.Add("@PortType", portTypeModel.PortType);
                    parameters.Add("@CompanyId", CurrentUser.CompanyId);
                    parameters.Add("@Notes", portTypeModel.Notes);
                    parameters.Add("@CreatedBy", CurrentUser.UserId);

                    portTypeModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewPortType @PortType, @CompanyId, @Notes, @CreatedBy", parameters);

                    return portTypeModel.Id;
                }
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool UpdateSeaport(PortTypeModel portTypeModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", portTypeModel.Id);
                    parameters.Add("@PortType", portTypeModel.PortType);
                    parameters.Add("@Notes", portTypeModel.Notes);
                    parameters.Add("@LastModifiedBy", portTypeModel.LastModifiedBy);
                    parameters.Add("@LastModifiedDate", portTypeModel.LastModifiedDate);
                    parameters.Add("@Active", portTypeModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdatePortType @Id, @PortType, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", parameters);
                }

                return true;
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool DeletePortType(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM PortsType WHERE Id = @Id", parameters);
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
