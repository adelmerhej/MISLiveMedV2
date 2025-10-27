using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Reports.History;

namespace MISLiveMed.DataLayers.Reports.History
{
    public static class JobHistoryDal
    {
        public static IList<JobHistoryModel> JobHistoryDataList(DateTime? dateFrom, DateTime? dateTo,
            int UserId = 0, int OperatorId = 0)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", dateFrom);
                p.Add("@DateTo", dateTo);
                p.Add("@UserId", UserId);
                p.Add("@OperatorId", OperatorId);

                var quotationModels =
                    connection.Query<JobHistoryModel>(
                        "History.jobHistoryList @DateFrom, @DateTo, @UserId, @OperatorId;", p);

                return quotationModels.ToList();
            }
        }

        public static IList<JobsHistoryReportModel> JobHistoryReportDataList(DateTime? dateFrom, DateTime? dateTo,
            int departmentId = 0, int userId = 0, bool all = true, bool active = false, bool closed = false, bool canceled = false, int sortBy = 0)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", dateFrom);
                p.Add("@DateTo", dateTo);
                p.Add("@DepartmentId", departmentId);
                p.Add("@UserId", userId);
                p.Add("@All", all);
                p.Add("@Active", active);
                p.Add("@Closed", closed);
                p.Add("@Canceled", canceled);
                p.Add("@OrderBy", sortBy);

                var reportModels =
                    connection.Query<JobsHistoryReportModel>(
                        "dbo.__JobsHistoryReport @DateFrom, @DateTo, @DepartmentId, @UserId, @All, @Active, @Closed, @Canceled, @OrderBy", p);

                return reportModels.ToList();
            }
        }


    }
}
