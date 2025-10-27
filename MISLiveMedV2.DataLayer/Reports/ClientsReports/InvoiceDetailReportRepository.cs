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
    public class InvoiceDetailReportRepository
    {
        public IList<InvoiceDetailReportModel> SelectInvoiceDetailReport(DateTime? dateFrom, DateTime? dateTo,
            int userId = 0, int customerId = 0, int salesId = 0, string statusFilter = "", string departmentsFilter = "",
            string orderBy = "", string sortingBy = "", int fullPaid = 2, bool withDraft = true, bool withAllMembers = false,
            bool showAgents = false, int agentId = 0)
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
                    p.Add("@WithDraft", withDraft);
                    p.Add("@WithAllMembers", withAllMembers);
                    p.Add("@ShowAgents", showAgents);
                    p.Add("@AgentId", agentId);

                    var reportModels =
                        connection.Query<InvoiceDetailReportModel>(
                            "dbo.rep_InvoiceDetailedReport_V003 @DateFrom, @DateTo, @UserId, @CustomerId, @SalesId, " +
                            "@StatusFilterGroup, @DepartmentsFilter, @OrderBy, @SortingBy, @FullPaid, @WithDraft, @WithAllMembers, " +
                            "@ShowAgents, @AgentId;", p);
                            
                    return reportModels.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<InvoiceDetailReportModel> SelectClientsInvoiceReport(DateTime? dateFrom, DateTime? dateTo,
                        int userId = 0, int customerId = 0, int salesId = 0, string statusFilter = "", string departmentsFilter = "",
                        string orderBy = "", string sortingBy = "", int fullPaid = 2, bool withDraft = true, bool filterByCustomDate = false, 
                        bool withCustomDate = false, bool showProtected = false)
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
                    p.Add("@WithDraft", withDraft);
                    p.Add("@WithAllMembers", filterByCustomDate);
                    p.Add("@FilterByCustomDate", withCustomDate);
                    p.Add("@ShowProtected", showProtected);

                    var reportModels =
                        connection.Query<InvoiceDetailReportModel>(
                            "dbo.rep_ClientsInvoiceReport_V001 @DateFrom, @DateTo, @UserId, @CustomerId, @SalesId, " +
                            "@StatusFilterGroup, @DepartmentsFilter, @OrderBy, @SortingBy, @FullPaid, @WithDraft, " +
							"@WithAllMembers, @FilterByCustomDate, @ShowProtected;", p);

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
