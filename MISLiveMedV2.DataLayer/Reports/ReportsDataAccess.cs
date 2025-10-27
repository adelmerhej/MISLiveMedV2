using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Reports;
using MISLiveMed.Models.Models.Reports.JobsStatus;
using MISLiveMed.Models.Models.Reports.Profit;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Reports
{
    public static class ReportsDataAccess
    { 
        public static IList<QuotationModel> GetQuotations()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@CompanyId", CurrentUser.CompanyId);

                var quotationModels =
                    connection.Query<QuotationModel>("SELECT * FROM Quotations WHERE CompanyId = @CompanyId;", p);

                return quotationModels.ToList();
            }
        }

        #region NotLoadedReport
        public static IList<DataReportModel> GetToBeLoadedReport(int varDateInterval, int pUserId, 
                                                        int pShipmentTypeOptions, int pShipmentStatusOptions, int varMemberId, int pSalesId, 
                                                        int pAllInOrder, int pCritical, int pVeryCritical, int pExtremeCritical,
                                                        int departmentId, int pIntervalCritical)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();

                p.Add("@DateInterval", varDateInterval);
                p.Add("@UserId", pUserId);
                p.Add("@ShipmentType", pShipmentTypeOptions);
                p.Add("@ShipmentStatus", pShipmentStatusOptions);
                p.Add("@MemberId", varMemberId);
                p.Add("@SalesId", pSalesId);
                p.Add("@AllInOrder", pAllInOrder);
                p.Add("@isCritical", pCritical);
                p.Add("@isVeryCritical", pVeryCritical);
                p.Add("@isExtremeCritical", pExtremeCritical);
                p.Add("@IntervalCritical", pIntervalCritical);

                IList<DataReportModel> quotationModels = new List<DataReportModel>();

                switch (departmentId)
                {
                    case 16:
                        quotationModels =
                            connection.Query<DataReportModel>("dbo.rep_ToBeLoadedReport_SI_V200 @DateInterval, @UserId, " +
                                                              "@ShipmentType, @ShipmentStatus, @MemberId, @SalesId, " +
                                                              "@AllInOrder, @isCritical, @isVeryCritical, @isExtremeCritical, @IntervalCritical", p).ToList(); 
                        break;

                    case 18:
                        quotationModels =
                            connection.Query<DataReportModel>("dbo.rep_ToBeLoadedReport_SE_V200 @DateInterval, @UserId, " +
                                                              "@ShipmentType, @ShipmentStatus, @MemberId, @SalesId, " +
                                                              "@AllInOrder, @isCritical, @isVeryCritical, @isExtremeCritical, @IntervalCritical", p).ToList();
                        break;
                }


                return quotationModels.ToList();
            }
        }

        #endregion


        #region BookingDepartureReport
        public static IList<DataReportModel> GetOnWaterReport(int pDateInterval,
            int pUserId, int pShipmentStatus, int pMemberId, int pSalesId, int pAllInOrder, 
            int pCritical, int pVeryCritical, int departmentId, int pendingFullPaid)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();

                p.Add("@varDateInterval", pDateInterval);
                p.Add("@UserId", pUserId);
                p.Add("@ShipmentStatus", pShipmentStatus);
                p.Add("@MemberId", pMemberId);
                p.Add("@SalesId", pSalesId);
                p.Add("@AllInOrder", pAllInOrder);
                p.Add("@isCritical", pCritical);
                p.Add("@IntervalCritical", pVeryCritical);
                p.Add("@PendingFullPaid", pendingFullPaid);

                IList<DataReportModel> quotationModels = new List<DataReportModel>();

                switch (departmentId)
                {
                    case 16:
                        quotationModels =
                            connection.Query<DataReportModel>("dbo.rep_OnWaterReport_SI_V200 @varDateInterval, @UserId, @ShipmentStatus, @MemberId, " +
                                                              "@SalesId, @AllInOrder, @isCritical, @IntervalCritical, @PendingFullPaid", p).ToList();
                        break;

                    case 18:
                        quotationModels =
                            connection.Query<DataReportModel>("dbo.rep_OnWaterReport_SE_V200 @varDateInterval, @UserId, @ShipmentStatus, @MemberId, " +
                                                              "@SalesId, @AllInOrder, @isCritical, @IntervalCritical, @PendingFullPaid", p).ToList();
                        break;
                }


                return quotationModels;
            }
        }


        #endregion


        #region BookingReadyForTejrim
        public static IList<DataReportModel> GetBookingReadyForTejrimReport(string pRefNo,
            int pDateInterval, int pUserId, int pShipmentStatus, int pMemberId, int pSalesId, int pAllInOrder, int pCritical, int pIntervalCritical)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@varStartingRefNo", pRefNo);
                p.Add("@varDateInterval", pDateInterval);
                p.Add("@UserId", pUserId);
                p.Add("@ShipmentStatus", pShipmentStatus);
                p.Add("@MemberId", pMemberId);
                p.Add("@SalesId", pSalesId);
                p.Add("@AllInOrder", pAllInOrder);
                p.Add("@isCritical", pCritical);
                p.Add("@IntervalCritical", pIntervalCritical);

                var quotationModels =
                    connection.Query<DataReportModel>("dbo.rp_BookingReadyForTejrim @varStartingRefNo, @varDateInterval, @UserId, @ShipmentStatus, @MemberId, " +
                                                      "@SalesId, @AllInOrder, @isCritical, @IntervalCritical",p);

                return quotationModels.ToList();
            }
        }

        //public static IList<DataReportModel> GetClosedBookingList(DateTime? dateFrom, DateTime? dateTo, string startingRefNo, 
        //                                        int memberId = 0, int userid = 0, int invoiced = 2)
        //{
        //    using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@DateFrom", dateFrom);
        //        p.Add("@DateTo", dateTo);
        //        p.Add("@StartingRefNo", startingRefNo);
        //        p.Add("@MemberId", memberId);
        //        p.Add("@UserId", userid);
        //        p.Add("@Invoiced", invoiced);

        //        var quotationModels =
        //            connection.Query<DataReportModel>("dbo.job_GetClosedBookingList @DateFrom, @DateTo, @StartingRefNo, @MemberId, @UserId, @Invoiced", p);

        //        return quotationModels.ToList();
        //    }
        //}
        #endregion


        #region BookingNotReadyForTejrim
        public static IList<DataReportModel> GetBookingNotReadyForTejrimReport(string pRefNo,
            int pDateInterval, int pUserName, int pShipmentStatus, int pMemberId, int pSalesId, int pAllInOrder, int pCritical, int pIntervalCritical)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@varStartingRefNo", pRefNo);
                p.Add("@varDateInterval", pDateInterval);
                p.Add("@UserId", pUserName);
                p.Add("@ShipmentStatus", pShipmentStatus);
                p.Add("@MemberId", pMemberId);
                p.Add("@SalesId", pSalesId);
                p.Add("@AllInOrder", pAllInOrder);
                p.Add("@isCritical", pCritical);
                p.Add("@IntervalCritical", pIntervalCritical);

                var quotationModels =
                    connection.Query<DataReportModel>(
                        "dbo.rp_BookingNOTReadyForTejrim @varStartingRefNo, @varDateInterval, @UserId, @ShipmentStatus, @MemberId, @SalesId, " +
                        "@AllInOrder, @isCritical, @IntervalCritical",p);

                return quotationModels.ToList();
            }
        }

        #endregion


        #region GetTobeCleared Report

        public static IList<DataReportModel> GetToBeClearedReportList(DateTime? jobDateFrom, DateTime? jobDateTo, int memberId,
	        int userid, int salesId, string orderBy, string sortingBy)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
	            var p = new DynamicParameters();
	            p.Add("@DateFrom", jobDateFrom);
	            p.Add("@DateTo", jobDateTo);
	            p.Add("@MemberId", memberId);
	            p.Add("@UserId", userid);
	            p.Add("@salesId", salesId);
	            p.Add("@OrderBy", orderBy);
	            p.Add("@SortingBy", sortingBy);

				var quotationModels =
                    connection.Query<DataReportModel>("dbo.rp_GetToBeClearedReportList_V001 @DateFrom, @DateTo, @MemberId, " +
                                                      "@UserId, @salesId, @OrderBy, @SortingBy", p);

				return quotationModels.ToList();
            }
        }

        public static IList<TotalProfitReportModel> GetTotalProfitReportList(DateTime? dateEtaFrom, DateTime? dateEtaTo,  
                                        int memberId, int userid, int salesId, int departmentId, int pendingFullPaid, bool detailedJobs,
                                        string filterBy, string orderBy, string sortingBy, bool printDifferenceOnly)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateEtaFrom", dateEtaFrom);
                p.Add("@DateEtaTo", dateEtaTo);
                p.Add("@MemberId", memberId);
                p.Add("@SalesId", salesId);
                p.Add("@UserId", userid);
                p.Add("@DepartmentId", departmentId);
                p.Add("@PendingFullPaid", pendingFullPaid);
                p.Add("@FilterBy", filterBy);
                p.Add("@OrderBy", orderBy);
                p.Add("@SortingBy", sortingBy);
                p.Add("@PrintDifferenceOnly", printDifferenceOnly);

				var quotationModels =
                    connection.Query<TotalProfitReportModel>(
                        detailedJobs ? "dbo.rp_DetailedTotalProfitReportList_V002 @DateEtaFrom, @DateEtaTo, @MemberId, @UserId, " +
									   "@SalesId, @DepartmentId, @PendingFullPaid, @FilterBy, @OrderBy, @SortingBy, @PrintDifferenceOnly"
							: "dbo.rp_GetTotalProfitReportList_V1 @DateEtaFrom, @DateEtaTo, @MemberId, @UserId, @SalesId, @DepartmentId, @PendingFullPaid", p);

                return quotationModels.ToList();
            }
        }

        public static IList<OptimizedTotalProfitReportModel> AllTotalProfitReportList(DateTime? dateEtaFrom, DateTime? dateEtaTo, DateTime? dateJobFrom, DateTime? dateJobTo,
			int memberId, int userid, int salesId, int departmentId, int pendingFullPaid, bool detailedJobs,
	        string filterBy, string orderBy, string sortingBy, bool printDifferenceOnly)
        {
	        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
	        {
		        var p = new DynamicParameters();
		        p.Add("@DateEtaFrom", dateEtaFrom);
		        p.Add("@DateEtaTo", dateEtaTo);
		        p.Add("@DateJobFrom", dateJobFrom);
		        p.Add("@DateJobTo", dateJobTo);
				p.Add("@MemberId", memberId);
		        p.Add("@SalesId", salesId);
		        p.Add("@UserId", userid);
		        p.Add("@DepartmentId", departmentId);
		        p.Add("@PendingFullPaid", pendingFullPaid);
		        p.Add("@FilterBy", filterBy);
		        p.Add("@OrderBy", orderBy);
		        p.Add("@SortingBy", sortingBy);
		        p.Add("@PrintDifferenceOnly", printDifferenceOnly);

		        var quotationModels =
			        connection.Query<OptimizedTotalProfitReportModel>(
				        detailedJobs ? "dbo.rp_DetailedTotalProfitReportList_V003 @DateEtaFrom, @DateEtaTo, @DateJobFrom, @DateJobTo, @MemberId, @UserId, " +
									   "@SalesId, @DepartmentId, @PendingFullPaid, @FilterBy, @OrderBy, @SortingBy, @PrintDifferenceOnly"
							: "dbo.rp_GetTotalProfitReportList_V1 @DateEtaFrom, @DateEtaTo, @MemberId, @UserId, @SalesId, @DepartmentId, @PendingFullPaid", p);

		        return quotationModels.ToList();
	        }
        }

		public static IList<TotalProfitReportModel> GetTotalNegativeReportList(DateTime? jobDateFrom, DateTime? jobDateTo,
                                                                                                int memberId, int userid, int departmentId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", jobDateFrom);
                p.Add("@DateTo", jobDateTo);
                p.Add("@MemberId", memberId);
                p.Add("@UserId", userid);
                p.Add("@DepartmentId", departmentId);

                var quotationModels =
                    connection.Query<TotalProfitReportModel>("dbo.rp_GetNegativeJobsReportList @DateFrom, @DateTo, @MemberId, @UserId, @DepartmentId", p);

                return quotationModels.ToList();
            }
        }


        public static IList<JobStatusReportModel> GetJobsReportStatus(DateTime? dateFrom, DateTime? dateTo,
            DateTime? dateEtdFrom, DateTime? dateEtdTo,
            int jobId, int memberId, int userid, int salesId, int departmentId, bool detailedJobs, 
            int fullPaid, int jobClosedStatus, bool includeMembers, string memberOf, string orderBy, string sortingBy)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
	            Dapper.SqlMapper.Settings.CommandTimeout = 100;
					
				var p = new DynamicParameters();
                p.Add("@DateFrom", dateFrom);
                p.Add("@DateTo", dateTo);
                p.Add("@DateEtdFrom", dateEtdFrom);
                p.Add("@DateEtdTo", dateEtdTo);
                p.Add("@JobId", jobId);
                p.Add("@MemberId", memberId);
                p.Add("@UserId", userid);
                p.Add("@SalesId", salesId);
                p.Add("@DepartmentId", departmentId);
                p.Add("@DetailedJobs", detailedJobs);
                p.Add("@FullPaid", fullPaid);
                p.Add("@JobClosedStatus", jobClosedStatus); 
                p.Add("@IncludeMembers", includeMembers);
                p.Add("@MemberOf", memberOf);
                p.Add("@OrderBy", orderBy);
                p.Add("@SortingBy", sortingBy);

				var records = connection.Query<JobStatusReportModel>(
                    detailedJobs
                        ? "dbo.rep_GetJobsReportStatusDetailed_V31 @DateFrom, @DateTo, @DateEtdFrom, @DateEtdTo, @JobId, @MemberId, @UserId, @SalesId, " +
                          "@DepartmentId, @DetailedJobs, @FullPaid, @JobClosedStatus, @IncludeMembers, @MemberOf, @OrderBy, @SortingBy"
                        : "dbo.rep_GetJobsReportStatus_V31 @DateFrom, @DateTo, @DateEtdFrom, @DateEtdTo, @MemberId, @UserId, @SalesId, @DepartmentId, " +
                          "@DetailedJobs, @FullPaid, @IncludeMembers, @MemberOf, @OrderBy, @SortingBy",
                    p).ToList();
                    
                return records;
            }
        }

        public static IList<TotalProfitReportModel> GetActiveClientsListReport(DateTime? jobDateFrom, DateTime? jobDateTo,
            int memberId, int userid, int departmentId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", jobDateFrom);
                p.Add("@DateTo", jobDateTo);
                p.Add("@MemberId", memberId);
                p.Add("@UserId", userid);
                p.Add("@DepartmentId", departmentId);

                var quotationModels =
                    connection.Query<TotalProfitReportModel>("dbo.rp_GetNegativeJobsReportList @DateFrom, @DateTo, @MemberId, @UserId, @DepartmentId", p);

                return quotationModels.ToList();
            }
        }

        #endregion

        #region Detailed Profit

        public static IList<DetailedProfitReportModel> DetailedProfitReport(DateTime? dateFrom, DateTime? dateTo,
                                        int memberId, int userid, int salesId, int departmentId, int pendingFullPaid)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", dateFrom);
                p.Add("@DateTo", dateTo);
                p.Add("@MemberId", memberId);
                p.Add("@UserId", userid);
                p.Add("@SalesId", salesId);
                p.Add("@DepartmentId", departmentId);
                p.Add("@PendingFullPaid", pendingFullPaid);

                p.Add("@CurrentUserId", CurrentUser.UserId);

                _ = connection.ExecuteScalar("EXEC DBO._AddPendingJobs @CurrentUserId", p);

                
                var quotationModels = connection.Query<DetailedProfitReportModel>(
                     "dbo.rp_DetailedProfitReport_V2 @DateFrom, @DateTo, @MemberId, @UserId, @SalesId, @DepartmentId, @PendingFullPaid",
                     p, commandTimeout: 180).ToList();

                return quotationModels;
            }
        }

        public static InitSummaryModel SummarySalesCommissions(DateTime? dateFrom, DateTime? dateTo,
                                int salesId, int tejrim, int isPaid)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", dateFrom);
                p.Add("@DateTo", dateTo);
                p.Add("@SalesId", salesId);
                p.Add("@Tejrim", tejrim);
                p.Add("@IsPaid", isPaid);

                var quotationModels = connection.QuerySingleOrDefault<InitSummaryModel>(
                     "dbo." +
                     "XO_Summary_SalesCommissions" +
                     " @DateFrom, @DateTo, @SalesId, @Tejrim, @IsPaid;",
                     p);

                return quotationModels;
            }
        }
        #endregion

        public static IList<AirDataReportModel> GetAirFreightImportReportList(DateTime? jobDateFrom, DateTime? jobDateTo, 
            int customerId = 0, int userid = 0, int salesId = 0)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", jobDateFrom);
                p.Add("@DateTo", jobDateTo);
                p.Add("@CustomerId", customerId);
                p.Add("@UserId", userid);
                p.Add("@SalesId", salesId);

                var quotationModels =
                    connection.Query<AirDataReportModel>("dbo.rp_GetAirFreightImportReportList " +
                                        "@DateFrom, @DateTo, @CustomerId, @UserId, @SalesId", p);

                return quotationModels.ToList();
            }
        }
        public static IList<AirDataReportModel> GetAirFreightExportReportList(DateTime? jobDateFrom, DateTime? jobDateTo,
            int customerId = 0, int userid = 0, int salesId = 0)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateFrom", jobDateFrom);
                p.Add("@DateTo", jobDateTo);
                p.Add("@CustomerId", customerId);
                p.Add("@UserId", userid);
                p.Add("@SalesId", salesId);

                var quotationModels =
                    connection.Query<AirDataReportModel>("dbo.rp_GetAirFreightExportReportList " +
                                                         "@DateFrom, @DateTo, @CustomerId, @UserId, @SalesId", p);

                return quotationModels.ToList();
            }
        }

        
        #region Fix Real Currenct (Should ve temporary)

        public static void FixRealCurrency()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                _ = connection.ExecuteReader("dbo._DopFixRealCurrency");
            }
        }

        #endregion

    }
}
