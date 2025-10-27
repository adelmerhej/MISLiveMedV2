using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Reports.Quotations;

namespace MISLiveMed.DataLayers.Reports.Quotations
{
    public class QuotationsJobsReportRepository
    {
        public IList<QuotationsJobsReportModel> QuotationsJobsReport(DateTime? dateFrom, DateTime? dateTo, int departmentId, 
            int customerId, int salesId, int userId, string statusFilter, bool matchedJobs, string orderBy, string sortingBy, int urgent,
            DateTime? followupDateFrom, DateTime? followupDateTo, int sectionFilter)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", dateFrom);
                p.Add("@DateTo", dateTo);
                p.Add("@DepartmentId", departmentId);
                p.Add("@CustomerId", customerId);
                p.Add("@SalesId", salesId);
                p.Add("@UserId", userId);
                p.Add("@StatusFilter", statusFilter);
                p.Add("@OrderBy", orderBy);
                p.Add("@SortingBy", sortingBy);
                p.Add("@Urgent", urgent);
                p.Add("@FollowupDateFrom", followupDateFrom);
                p.Add("@FollowupDateTo", followupDateTo);
                p.Add("@SectionFilter", sectionFilter);

                List<QuotationsJobsReportModel> quotationsJobsReports;

                if (matchedJobs)
                {
                    quotationsJobsReports =
                        (List<QuotationsJobsReportModel>)connection.Query<QuotationsJobsReportModel>(
                            "dbo._job_QuotationsJobsReport_V101 @DateFrom, @DateTo, @DepartmentId, " +
                                "@CustomerId, @SalesId, @UserId, @StatusFilter, @OrderBy, @SortingBy, " +
                                "@Urgent, @FollowupDateFrom, @FollowupDateTo, @SectionFilter", p);
                }
                else
                {
                    quotationsJobsReports =
                        (List<QuotationsJobsReportModel>)connection.Query<QuotationsJobsReportModel>(
                            "dbo._job_QuotationsJobsReport_V102 @DateFrom, @DateTo, @DepartmentId, " +
                                "@CustomerId, @SalesId, @UserId, @StatusFilter, @OrderBy, @SortingBy, " +
                                "@Urgent, @FollowupDateFrom, @FollowupDateTo, @SectionFilter", p);
                }

                return quotationsJobsReports.ToList();
            }
        }
    }
}
