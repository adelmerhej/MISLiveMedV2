using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Reports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MISLiveMed.DataLayers.JobData.SeaImport
{
	public class JobSeaImportRepository : IDisposable
	{
		public IList<JobSeaImportModel> JobSeaImportList(bool showProtected = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@CompanyId", CurrentUser.CompanyId);
				p.Add("@IsProtected", showProtected);

				var jobsList =
					connection.Query<JobSeaImportModel>("SELECT * FROM JobSImport " +
														"WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
														"AND CompanyId = @CompanyId;", p);

				return jobsList.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


		public JobSeaImportModel JobSeaImportByJobId(int id, bool showProtected = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", id);
				p.Add("@CompanyId", CurrentUser.CompanyId);
				p.Add("@IsProtected", showProtected);

				var jobRecord =
					connection.QuerySingleOrDefault("SELECT * FROM JobSImport WHERE CompanyId = @CompanyId AND Id = @Id " +
													"AND (@IsProtected = 0 OR IsProtected = @IsProtected);", p);

				return jobRecord;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public JobSeaImportModel JobSeaImportByJobNo(int jobNo, bool showProtected = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@JobNo", jobNo);
				p.Add("@CompanyId", CurrentUser.CompanyId);
				p.Add("@IsProtected", showProtected);

				var jobRecord =
					connection.QuerySingleOrDefault("SELECT * FROM JobSImport WHERE CompanyId = @CompanyId AND JobNo = @JobNo" +
													"AND (@IsProtected = 0 OR IsProtected = @IsProtected);", p);

				return jobRecord;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw new Exception(e.Message);
			}
		}

		public IList<DataReportModel> GetClosedBookingList()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@CompanyId", CurrentUser.CompanyId);

				var quotationModels =
					connection.Query<DataReportModel>("dbo.rep_ClosedBookingList_V001 @CompanyId", p);

				return quotationModels.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public IList<DataReportModel> GetClosedBookingList(DateTime? dateFrom, DateTime? dateTo,
							int memberId = 0, int userid = 0, int salesId = 0, bool invoiced = false)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@DateFrom", dateFrom);
				p.Add("@DateTo", dateTo);
				p.Add("@MemberId", memberId);
				p.Add("@UserId", userid);
				p.Add("@SalesId", salesId);
				p.Add("@Invoiced", invoiced);
				p.Add("@CompanyId", CurrentUser.CompanyId);

				var quotationModels =
					connection.Query<DataReportModel>("dbo.rep_ClosedBookingList_V002 @DateFrom, @DateTo, @MemberId, @UserId, @SalesId, @Invoiced, @CompanyId", p);

				return quotationModels.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewJobSeaImport(JobSeaImportModel model)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
				p.Add("@ReferenceNo", model.ReferenceNo);
				p.Add("@DepartmentId", model.DepartmentId);
				p.Add("@JobTypeId", model.JobTypeId);
				p.Add("@JobNo", model.JobNo);
				p.Add("@JobDate", model.JobDate);
				p.Add("@Mbl", model.Mbl);
				p.Add("@CustomerId", model.CustomerId);
				p.Add("@ConsigneeId", model.ConsigneeId);
				p.Add("@SeaportDeparture", model.SeaportDeparture);
				p.Add("@CountryDeparture", model.CountryDeparture);
				p.Add("@SeaportDestination", model.SeaportDestination);
				p.Add("@CountryDestination", model.CountryDestination);
				p.Add("@AgentId", model.AgentId);
				p.Add("@FreeOfDemurrage", model.FreeOfDemurrage);
				p.Add("@BookingNo", model.BookingNo);
				p.Add("@NatureOfGoods", model.NatureOfGoods);
				p.Add("@ValueOfGoods", model.ValueOfGoods);
				p.Add("@Quantities", model.Quantities);
				p.Add("@Volume", model.Volume);
				p.Add("@Pieces", model.Pieces);
				p.Add("@Weight", model.Weight);
				p.Add("@VesselId", model.VesselId);
				p.Add("@FeederVesselId", model.FeederVesselId);
				p.Add("@PreferredCurrencyId", model.PreferredCurrencyId);
				p.Add("@TotalInvoicesLl", model.TotalInvoicesLl);
				p.Add("@TotalInvoicesUsd", model.TotalInvoicesUsd);
				p.Add("@TotalCostsLl", model.TotalCostsLl);
				p.Add("@TotalCostsUsd", model.TotalCostsUsd);
				p.Add("@OperatingUserId", model.OperatingUserId);
				p.Add("@SalesId", model.SalesId);
				p.Add("@UserId", model.UserId);
				p.Add("@Project", model.Project);
				p.Add("@Transit", model.Transit);
				p.Add("@FullPaid", model.FullPaid);
				p.Add("@FullPaidDate", model.FullPaidDate);
				p.Add("@ClearingAgentId", model.ClearingAgentId);
				p.Add("@Etd", model.Etd);
				p.Add("@Eta", model.Eta);
				p.Add("@Atd", model.Atd);
				p.Add("@Ata", model.Ata);
				p.Add("@CutOffDate", model.CutOffDate);
				p.Add("@LoadingDate", model.LoadingDate);
				p.Add("@Ppcc", model.Ppcc);
				p.Add("@Status", model.Status);
				p.Add("@BlStatus", model.BlStatus);
				p.Add("@RTejrim", model.RTejrim);
				p.Add("@RTejrimDate", model.RTejrimDate);
				p.Add("@Tejrim", model.Tejrim);
				p.Add("@TejrimDate", model.TejrimDate);
				p.Add("@RClearance", model.RClearance);
				p.Add("@RClearanceDate", model.RClearanceDate);
				p.Add("@IncoTerms", model.IncoTerms);
				p.Add("@AllInOrderToBeLoaded", model.AllInOrderToBeLoaded);
				p.Add("@AllInOrderOnWater", model.AllInOrderOnWater);
				p.Add("@PendingForDelivery", model.PendingForDelivery);
				p.Add("@PendingDeliveryDate", model.PendingDeliveryDate);
				p.Add("@Delivered", model.Delivered);
				p.Add("@DeliveredTo", model.DeliveredTo);
				p.Add("@DeliveredDate", model.DeliveredDate);
				p.Add("@ContainerToCnee", model.ContainerToCnee);
				p.Add("@ContainerToCneeDate", model.ContainerToCneeDate);
				p.Add("@EmptyContainer", model.EmptyContainer);
				p.Add("@EmptyContainerDate", model.EmptyContainerDate);
				p.Add("@ConfirmEmptyContainer", model.ConfirmEmptyContainer);
				p.Add("@ConfirmEmptyContainerDate", model.ConfirmEmptyContainerDate);
				p.Add("@JobScId", model.JobScId);
				p.Add("@JobStatus", model.JobStatus);
				p.Add("@Closed", model.Closed);
				p.Add("@ClosedDate", model.ClosedDate);
				p.Add("@CancelledJob", model.CancelledJob);
				p.Add("@CancelledJobDate", model.CancelledJobDate);
				p.Add("@CancelledJobByUserId", model.CancelledJobByUserId);
				p.Add("@LastJobReopenedBy", model.LastJobReopenedBy);
				p.Add("@LastJobReopenedDate", model.LastJobReopenedDate);
				p.Add("@CostReady", model.CostReady);
				p.Add("@CostReadyDate", model.CostReadyDate);
				p.Add("@PaidDO", model.PaidDO);
				p.Add("@PaidDODate", model.PaidDODate);
				p.Add("@MissingDocuments", model.MissingDocuments);
				p.Add("@MissingDocumentsDate", model.MissingDocumentsDate);

				p.Add("@Notes", model.Notes);
				p.Add("@CompanyId", model.CompanyId);
				p.Add("@CreatedBy", model.CreatedBy);
				p.Add("@IsProtected", model.IsProtected);

				model.Id = connection.ExecuteScalar<int>(
					"dbo.job_AddNewJobSeaImport @ReferenceNo, @DepartmentId, @JobTypeId, @JobNo, @JobDate, @Mbl, @CustomerId, @ConsigneeId, " +
					"@SeaportDeparture, @CountryDeparture, @SeaportDestination, @CountryDestination, @AgentId, @FreeOfDemurrage, @BookingNo, " +
					"@NatureOfGoods, @ValueOfGoods, @Quantities, @Volume, @Pieces, @Weight, @VesselId, @FeederVesselId, " +
					"@PreferredCurrencyId, @TotalInvoicesLl, @TotalInvoicesUsd, @TotalCostsLl, @TotalCostsUsd, @OperatingUserId, @SalesId, @UserId, " +
					"@Project, @Transit, @FullPaid, @FullPaidDate, @ClearingAgentId, @Etd, @Eta, @Atd, @Ata, @CutOffDate, @LoadingDate, " +
					"@Ppcc, @Status, @BlStatus, @RTejrim, @RTejrimDate, @Tejrim, @TejrimDate, @RClearance, @RClearanceDate, @IncoTerms, " +
					"@AllInOrderToBeLoaded, @AllInOrderOnWater, @PendingDelivery, @PendingDeliveryDate, @Delivered, @DeliveredTo, " +
					"@DeliveredDate, @ContainerToCnee, @ContainerToCneeDate, " +
					"@EmptyContainer, @EmptyContainerDate, @ConfirmEmptyContainer, @ConfirmEmptyContainerDate, @JobScId, @JobStatus, @Closed, " +
					"@ClosedDate, @CancelledJob, @CancelledJobDate, @CancelledJobByUserId, @LastJobReopenedBy, @LastJobReopenedDate, " +
					"@CostReady, @CostReadyDate, @PaidDO, @PaidDODate, @MissingDocuments, @MissingDocumentsDate, @Notes, @CompanyId, @CreatedBy, @IsProtected;",
					p);
				return model.Id;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


		public void UpdateJobSeaImport(JobSeaImportModel model)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", model.Id);
				p.Add("@ReferenceNo", model.ReferenceNo);
				p.Add("@DepartmentId", model.DepartmentId);
				p.Add("@JobTypeId", model.JobTypeId);
				p.Add("@JobNo", model.JobNo);
				p.Add("@JobDate", model.JobDate);
				p.Add("@Mbl", model.Mbl);
				p.Add("@CustomerId", model.CustomerId);
				p.Add("@ConsigneeId", model.ConsigneeId);
				p.Add("@SeaportDeparture", model.SeaportDeparture);
				p.Add("@CountryDeparture", model.CountryDeparture);
				p.Add("@SeaportDestination", model.SeaportDestination);
				p.Add("@CountryDestination", model.CountryDestination);
				p.Add("@AgentId", model.AgentId);
				p.Add("@FreeOfDemurrage", model.FreeOfDemurrage);
				p.Add("@BookingNo", model.BookingNo);
				p.Add("@NatureOfGoods", model.NatureOfGoods);
				p.Add("@ValueOfGoods", model.ValueOfGoods);
				p.Add("@Quantities", model.Quantities);
				p.Add("@Volume", model.Volume);
				p.Add("@Pieces", model.Pieces);
				p.Add("@Weight", model.Weight);
				p.Add("@VesselId", model.VesselId);
				p.Add("@FeederVesselId", model.FeederVesselId);
				p.Add("@PreferredCurrencyId", model.PreferredCurrencyId);
				p.Add("@TotalInvoicesLl", model.TotalInvoicesLl);
				p.Add("@TotalInvoicesUsd", model.TotalInvoicesUsd);
				p.Add("@TotalCostsLl", model.TotalCostsLl);
				p.Add("@TotalCostsUsd", model.TotalCostsUsd);
				p.Add("@OperatingUserId", model.OperatingUserId);
				p.Add("@SalesId", model.SalesId);
				p.Add("@UserId", model.UserId);
				p.Add("@Project", model.Project);
				p.Add("@Transit", model.Transit);
				p.Add("@FullPaid", model.FullPaid);
				p.Add("@FullPaidDate", model.FullPaidDate);
				p.Add("@ClearingAgentId", model.ClearingAgentId);
				p.Add("@Etd", model.Etd);
				p.Add("@Eta", model.Eta);
				p.Add("@Atd", model.Atd);
				p.Add("@Ata", model.Ata);
				p.Add("@CutOffDate", model.CutOffDate);
				p.Add("@LoadingDate", model.LoadingDate);
				p.Add("@Ppcc", model.Ppcc);
				p.Add("@Status", model.Status);
				p.Add("@BlStatus", model.BlStatus);
				p.Add("@RTejrim", model.RTejrim);
				p.Add("@RTejrimDate", model.RTejrimDate);
				p.Add("@Tejrim", model.Tejrim);
				p.Add("@TejrimDate", model.TejrimDate);
				p.Add("@RClearance", model.RClearance);
				p.Add("@RClearanceDate", model.RClearanceDate);
				p.Add("@IncoTerms", model.IncoTerms);
				p.Add("@AllInOrderToBeLoaded", model.AllInOrderToBeLoaded);
				p.Add("@AllInOrderOnWater", model.AllInOrderOnWater);
				p.Add("@PendingForDelivery", model.PendingForDelivery);
				p.Add("@PendingDeliveryDate", model.PendingDeliveryDate);
				p.Add("@Delivered", model.Delivered);
				p.Add("@DeliveredTo", model.DeliveredTo);
				p.Add("@DeliveredDate", model.DeliveredDate);
				p.Add("@ContainerToCnee", model.ContainerToCnee);
				p.Add("@ContainerToCneeDate", model.ContainerToCneeDate);
				p.Add("@EmptyContainer", model.EmptyContainer);
				p.Add("@EmptyContainerDate", model.EmptyContainerDate);
				p.Add("@ConfirmEmptyContainer", model.ConfirmEmptyContainer);
				p.Add("@ConfirmEmptyContainerDate", model.ConfirmEmptyContainerDate);
				p.Add("@JobScId", model.JobScId);
				p.Add("@JobStatus", model.JobStatus);
				p.Add("@Closed", model.Closed);
				p.Add("@ClosedDate", model.ClosedDate);
				p.Add("@CancelledJob", model.CancelledJob);
				p.Add("@CancelledJobDate", model.CancelledJobDate);
				p.Add("@CancelledJobByUserId", model.CancelledJobByUserId);
				p.Add("@LastJobReopenedBy", model.LastJobReopenedBy);
				p.Add("@LastJobReopenedDate", model.LastJobReopenedDate);
				p.Add("@CostReady", model.CostReady);
				p.Add("@CostReadyDate", model.CostReadyDate);
				p.Add("@PaidDO", model.PaidDO);
				p.Add("@PaidDODate", model.PaidDODate);
				p.Add("@MissingDocuments", model.MissingDocuments);
				p.Add("@MissingDocumentsDate", model.MissingDocumentsDate);
				// Preserved from EntityObject
				p.Add("@Notes", model.Notes);
				p.Add("@LastModifiedBy", model.LastModifiedBy);
				p.Add("@Active", model.Active);
				p.Add("@IsProtected", model.IsProtected);

				_ = connection.Execute(
					@"dbo.job_UpdateJobSeaImport
				        @Id, @ReferenceNo, @DepartmentId, @JobTypeId, @JobNo, @JobDate, @Mbl, @CustomerId, @ConsigneeId,
				        @SeaportDeparture, @CountryDeparture, @SeaportDestination, @CountryDestination, @AgentId, @FreeOfDemurrage,
				        @BookingNo, @NatureOfGoods, @ValueOfGoods, @Quantities, @Volume, @Pieces, @Weight, @VesselId,
				        @FeederVesselId, @PreferredCurrencyId, @TotalInvoicesLl, @TotalInvoicesUsd, @TotalCostsLl, @TotalCostsUsd,
				        @OperatingUserId, @SalesId, @UserId, @Project, @Transit, @FullPaid, @FullPaidDate, @ClearingAgentId, @Etd, @Eta,
				        @Atd, @Ata, @CutOffDate, @LoadingDate, @Ppcc, @Status, @BlStatus, @RTejrim, @RTejrimDate, @Tejrim, @TejrimDate,
				        @RClearance, @RClearanceDate, @IncoTerms, @AllInOrderToBeLoaded, @AllInOrderOnWater, 
						@PendingDelivery, @PendingDeliveryDate, @Delivered, @DeliveredTo,
				        @DeliveredDate, @ContainerToCnee, @ContainerToCneeDate, @EmptyContainer, @EmptyContainerDate,
				        @ConfirmEmptyContainer, @ConfirmEmptyContainerDate, @JobScId, @JobStatus, @Closed, @ClosedDate,
				        @CancelledJob, @CancelledJobDate, @CancelledJobByUserId, @LastJobReopenedBy, @LastJobReopenedDate,
				        @CostReady, @CostReadyDate, @PaidDO, @PaidDODate, @MissingDocuments, @MissingDocumentsDate,
				        @Notes, @LastModifiedBy, @Active, @IsProtected;",
					p);
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}

		}

		public bool DeleteJobSeaImport(int id)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@Id", id);

				_ = connection.ExecuteScalar("DELETE FROM JobSImport WHERE Id = @Id;", p);

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


		#region To be moved to the corrected module

		public void UpdateInvoicedTejrim(int jobNo, bool invoiced)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@JobNo", jobNo);
				p.Add("@Invoiced", invoiced);

				_ = connection.ExecuteScalar("dbo.job_UpdateInvoicedTejrim @JobNo, @Invoiced", p);
			}
		}

		public IList<QuotationModel> GetQuotationsList(int pDepartmentFilter = 0,
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

		#endregion

		#region Implementation of IDisposable

		public void Dispose()
		{

		}

		#endregion
	}
}
