using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Export.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.JobData.SeaExport
{
    public class JobSeaExportRepository : IDisposable
    {
        public IList<JobSeaExportModel> JobsSeaExportList(bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
	                var p = new DynamicParameters();
	                p.Add("@CompanyId", CurrentUser.CompanyId);
	                p.Add("@IsProtected", showProtected);

					var jobsList =
                        connection.Query<JobSeaExportModel>("SELECT * FROM JobSeaExport " +
                                                            "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
                                                            "AND CompanyId = @CompanyId;", p);

					return jobsList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
