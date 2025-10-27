using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.Common.Countries.Ports
{
    public class PortRepository : IDisposable
    {
        public IList<PortModel> SelectPorts(PortType portTypeId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@PortTypeId", (int)portTypeId);
                    parameters.Add("@CompanyId", CurrentUser.CompanyId);

					var seaportsRecords =
                        connection.Query<PortModel>("SELECT * FROM Ports " +
                                                    "WHERE (@PortTypeId = 0 OR PortTypeId = @PortTypeId) " +
                                                    "AND CompanyId = @CompanyId;", parameters);
                    return seaportsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public PortModel SelectPortById(PortType portTypeId, int id)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var parameters = new DynamicParameters();
			        parameters.Add("@PortTypeId", (int)portTypeId);
			        parameters.Add("@PortId", id);
			        parameters.Add("@CompanyId", CurrentUser.CompanyId);

			        var seaportsRecords =
				        connection.QuerySingleOrDefault<PortModel>("SELECT * FROM Ports " +
																   "WHERE PortTypeId = @PortTypeId AND Id = @PortId " +
				                                                   "AND CompanyId = @CompanyId;", parameters);
			        return seaportsRecords;
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
        }

		public PortModel SelectPortByName(PortType portTypeId, string portName = "Beirut")
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@PortTypeId", (int)portTypeId);
                    parameters.Add("@PortName", portName);
                    parameters.Add("@CompanyId", CurrentUser.CompanyId);

                    var seaportsRecords =
                        connection.QuerySingleOrDefault<PortModel>("SELECT * FROM Ports " +
                                                                   "WHERE PortTypeId = @PortTypeId AND Name = @PortName " +
                                                                   "AND CompanyId = @CompanyId;", parameters);
                    return seaportsRecords;
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
