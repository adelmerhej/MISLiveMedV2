using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.ClientsReports;

namespace MISLiveMed.DataLayers.Reports.ClientsReports
{
    public class ClientDetailReportRepository
    {
        public IList<ClientDetailReportModel> SelectClientDetailReport(DateTime? dateFrom, DateTime? dateTo,
            int userId = 0, int customerId = 0, int salesId = 0, string statusFilter = "", string departmentsFilter = "", 
            string orderBy = "", string sortingBy = "", int fullPaid = 2)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DateFrom", dateFrom);
                    p.Add("@DateTo", dateTo);
                    p.Add("@UserId", userId);
                    p.Add("@CustomerId", customerId);
                    p.Add("@SalesId", salesId);
                    p.Add("@StatusFilterGroup", statusFilter);
                    p.Add("@DepartmentsFilter", departmentsFilter);
                    p.Add("@OrderBy", orderBy);
                    p.Add("@SortingBy", sortingBy);
                    p.Add("@FullPaid", fullPaid);

                    var reportModels =
                        connection.Query<ClientDetailReportModel>(
                            "dbo.rep_ClientDetailedReport_V001 @DateFrom, @DateTo, @UserId, @CustomerId, @SalesId, " +
                                "@StatusFilterGroup, @DepartmentsFilter, @OrderBy, @SortingBy, @FullPaid;", p);

                    return reportModels.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
