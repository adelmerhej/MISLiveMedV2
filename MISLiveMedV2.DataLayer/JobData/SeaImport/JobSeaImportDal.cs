using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.JobData.SeaImport
{
    public static class JobSeaImportDal
    {
        #region get Users List

        public static IList<UserModel> GetSalesList()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var salesList =
                        connection.Query<UserModel>("dbo.rp_GetUsersList @isAdmin", new
                        {
                            isAdmin = false
                        });

                    return salesList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }


        #endregion

        #region get Quotations List

        public static IList<QuotationModel> GetQuotationsList(int pDepartmentFilter = 0,
            bool pBooked = false, bool pCancelled = false, bool pLost = false, bool pAll = false, int pSalesFilter = 0,
            EnumStatusType pStatusFilter = EnumStatusType.NotSelected, int pOrderBy = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DepartmentFilter", pDepartmentFilter);
                    p.Add("@Booked", pBooked);
                    p.Add("@Cancelled", pCancelled);
                    p.Add("@Lost", pLost);
                    p.Add("@All", pAll);
                    p.Add("@SalesFilter", pSalesFilter);
                    p.Add("@StatusFilter", pStatusFilter);
                    p.Add("@OrderBy", pOrderBy);

                    var quotationsList =
                        connection.Query<QuotationModel>(
                            "dbo.job_GetQuotationsList @DepartmentFilter, @Booked, @Cancelled, @Lost, @All, @SalesFilter, " +
                            "@StatusFilter, @OrderBy", p);

                    return quotationsList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }

        }

        public static IList<QuotationModel> GetPendingQuotationsList(int pDepartmentFilter = 0,
            bool pBooked = false, bool pCancelled = false, bool pLost = false, bool pAll = false, int pSalesFilter = 0,
            int pStatusFilter = 0, int pOrderBy = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DepartmentFilter", pDepartmentFilter);
                    p.Add("@Booked", pBooked);
                    p.Add("@Cancelled", pCancelled);
                    p.Add("@Lost", pLost);
                    p.Add("@All", pAll);
                    p.Add("@SalesFilter", pSalesFilter);
                    p.Add("@StatusFilter", pStatusFilter);
                    p.Add("@OrderBy", pOrderBy);

                    var quotationsList =
                        connection.Query<QuotationModel>("dbo.job_GetPendingQuotationsList @DepartmentFilter, @Booked, @Cancelled, @Lost, " +
                                                              "@All, @SalesFilter, @StatusFilter, @OrderBy", p);

                    return quotationsList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }

        }

        public static IList<QuotationModel> GetQuotationsListById(int pMemberId = 0, int pUserId = 0, int pOrderBy = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@MemberId", pMemberId);
                    p.Add("@UserId", pUserId);
                    p.Add("@OrderBy", pOrderBy);

                    var quotationsListById =
                        connection.Query<QuotationModel>("dbo.job_GetQuotationsListById @MemberId, @UserId, @OrderBy", p);

                    return quotationsListById.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }

        }
        #endregion


        #region Job Sea Import DAL

        public static IList<JobSeaImportModel> GetSeaImportJobsList(int memberId = 0, int userid = 0, bool pendingJobs = false,
                                        bool closedJobs = false, bool cancelled = false, bool allJobs = true, int orderBy = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@MemberId", memberId);
                    p.Add("@UserId", userid);
                    p.Add("@Pending", pendingJobs);
                    p.Add("@ClosedJobs", closedJobs);
                    p.Add("@Cancelled", cancelled);
                    p.Add("@All", allJobs);
                    p.Add("@OrderBy", orderBy);

                    var jobsList =
                        connection.Query<JobSeaImportModel>("dbo.job_GetSeaImportJobsList @MemberId, @UserId, @Pending, @ClosedJobs, @Cancelled, @All, @OrderBy", p);

                    return jobsList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static IList<JobSeaImportModel> GetJobsSeaImportDetails(int memberId = 0, int userid = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@MemberId", memberId);
                    p.Add("@UserId", userid);

                    var jobsList =
                        connection.Query<JobSeaImportModel>("dbo.job_GetJobsSeaImportDetails @MemberId, @UserId", p);

                    return jobsList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static IList<JobSeaImportModel> GetJobsSeaImportTejrim(DateTime? dateFrom, DateTime? dateTo, string startingRefNo, int memberId = 0, int userid = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DateFrom", dateFrom);
                    p.Add("@DateTo", dateTo);
                    p.Add("@StartingRefNo", startingRefNo);
                    p.Add("@MemberId", memberId);
                    p.Add("@UserId", userid);
                    
                    var jobsList =
                        connection.Query<JobSeaImportModel>("dbo.job_GetJobsSeaImportTejrim @DateFrom, @DateTo, @StartingRefNo, @MemberId, @UserId", p);

                    return jobsList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public static void UpdateInvoicedTejrim(int jobNo, bool invoiced)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@JobNo", jobNo);
                p.Add("@Invoiced", invoiced);

                _ = connection.ExecuteScalar("dbo.job_UpdateInvoicedTejrim @JobNo, @Invoiced", p);
            }
        }

        #endregion
    }
}
