using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Reports;

namespace MISLiveMed.DataLayers.JobData.SeaImport.Reports
{
    public class EmptyContainerReportRepository : IDisposable

    {
        public IList<EmptyContainerReportModel> EmptyContainerList(DateTime? dateFrom = null, DateTime? dateTo = null, bool containerToCnee = false, 
                                                                    bool emptyContainer = false, int jobNo = 0, string departmentsSelected = "",
                                                                    bool showOnlyEmpty = false)
        {
            try
            {
	            using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
	            var p = new DynamicParameters();
	            p.Add("@DateFrom", dateFrom);
	            p.Add("@DateTo", dateTo);
	            p.Add("@ContainerToCnee", containerToCnee);
	            p.Add("@EmptyContainer", containerToCnee);
	            p.Add("@JobNo", jobNo);
	            p.Add("@DepartmentId", departmentsSelected);
	            p.Add("@DepartmentId", departmentsSelected);
	            p.Add("@ShowOnlyEmpty", showOnlyEmpty);

	            var jobsList =
		            connection.Query<EmptyContainerReportModel>("dbo.rep_EmptyContainerList @DateFrom, @DateTo, @ContainerToCnee, " +
		                                                        "@EmptyContainer, @JobNo, @DepartmentId, @ShowOnlyEmpty;", p);

	            return jobsList.ToList();
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
