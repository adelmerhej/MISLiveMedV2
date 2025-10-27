using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Journals;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Journals
{
	public class JournalDetailRepository : IDisposable
	{
		public IList<JournalDetailModel> SelectJournalDetails(int workingYear)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@WorkingYear", workingYear);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<JournalDetailModel>("SELECT * FROM JournalDetails " +
															 "WHERE CompanyId = @CompanyId AND WorkingYear = @WorkingYear " +
															 "ORDER BY JournalId, Line;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public JournalDetailModel SelectJournalDetailById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.QuerySingleOrDefault<JournalDetailModel>("SELECT * FROM JournalDetails " +
																			"WHERE Id = @Id " +
																			"AND CompanyId = @CompanyId;", p);
					return records;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public IList<JournalDetailModel> SelectJournalDetailsByJvNo(int workingYear, int jvNo)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@WorkingYear", workingYear);
					p.Add("@JournalId", jvNo);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<JournalDetailModel>("SELECT * FROM JournalDetails " +
												 "WHERE CompanyId = @CompanyId AND WorkingYear = @WorkingYear AND JournalId = @JournalId " +
												 "ORDER BY JournalId, Line;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public IList<JournalDetailModel> SelectJournalDetailsByChartId(int workingYear, int chartId, int jvNo)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@WorkingYear", workingYear);
					p.Add("@ChartId", chartId);
					p.Add("@JournalId", jvNo);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<JournalDetailModel>("SELECT * FROM JournalDetails " +
															 "WHERE CompanyId = @CompanyId AND WorkingYear = @WorkingYear AND ChartId = @ChartId " +
															 "AND JournalId = @JournalId ORDER BY JournalId, Line;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewJournalDetail(JournalDetailModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@JournalId", dataModel.JournalId);
					p.Add("@Line", dataModel.Line);
					p.Add("@ChartId", dataModel.ChartId);
					p.Add("@CostCenterId", dataModel.CostCenterId);
					p.Add("@FlowTypeId", dataModel.FlowTypeId);
					p.Add("@ValueDate", dataModel.ValueDate);
					p.Add("@CurrencyId", dataModel.CurrencyId);
					p.Add("@Rate", dataModel.Rate);
					p.Add("@Description", dataModel.Description);
					p.Add("@DbCr", dataModel.DbCr);
					p.Add("@Amount", dataModel.Amount);
					p.Add("@LAmount", dataModel.LAmount);
					p.Add("@FAmount", dataModel.FAmount);
					p.Add("@Posted", dataModel.Posted);
					p.Add("@DocumentRef", dataModel.DocumentRef);
					p.Add("@JobNo", dataModel.JobNo);
					p.Add("@DepartmentId", dataModel.DepartmentId);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@WorkingYear", dataModel.WorkingYear);
					p.Add("@Locked", dataModel.Locked);

					dataModel.Id = connection.ExecuteScalar<int>(
						"dbo.job_AddNewJournalDetail @JournalId, @Line, @ChartId, @CostCenterId, @FlowTypeId, " +
						"@ValueDate, @CurrencyId, @Rate, @Description, @DbCr, @Amount, @LAmount, @FAmount, " +
						"@Posted, @DocumentRef, @JobNo, @DepartmentId, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected, @WorkingYear, @Locked", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateJournalDetail(JournalDetailModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@JournalId", dataModel.JournalId);
					p.Add("@Line", dataModel.Line);
					p.Add("@ChartId", dataModel.ChartId);
					p.Add("@CostCenterId", dataModel.CostCenterId);
					p.Add("@FlowTypeId", dataModel.FlowTypeId);
					p.Add("@ValueDate", dataModel.ValueDate);
					p.Add("@CurrencyId", dataModel.CurrencyId);
					p.Add("@Rate", dataModel.Rate);
					p.Add("@Description", dataModel.Description);
					p.Add("@DbCr", dataModel.DbCr);
					p.Add("@Amount", dataModel.Amount);
					p.Add("@LAmount", dataModel.LAmount);
					p.Add("@FAmount", dataModel.FAmount);
					p.Add("@Posted", dataModel.Posted);
					p.Add("@DocumentRef", dataModel.DocumentRef);
					p.Add("@JobNo", dataModel.JobNo);
					p.Add("@DepartmentId", dataModel.DepartmentId);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);
					p.Add("@WorkingYear", dataModel.WorkingYear);
					p.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>(
						"dbo.job_UpdateJournalDetail @Id, @JournalId, @Line, @ChartId, @CostCenterId, @FlowTypeId, " +
						"@ValueDate, @CurrencyId, @Rate, @Description, @DbCr, @Amount, @LAmount, @FAmount, " +
						"@Posted, @DocumentRef, @JobNo, @DepartmentId, " +
						"@Notes, @LastModifiedBy, @IsProtected, @Active, @WorkingYear, @Locked", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteJournalDetail(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM JournalDetails WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


		#region Old Tables
		public int SelectTotalJournalDetails(int workingYear)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					string journalDetailTable = "adetail_" + workingYear + "$";

					var records =
						connection.Query<AdetailModel>($"SELECT * FROM {journalDetailTable} " +
						                               "ORDER BY Code, Line;");
					return records.Count();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<AdetailModel> SelectJournalDetailsByCode(int workingYear, string code)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Code", code);

					string journalDetailTable = "adetail_" + workingYear + "$";

					var records =
						connection.Query<AdetailModel>($"SELECT * FROM {journalDetailTable} " +
						                               "WHERE Code = @Code " +
						                               "ORDER BY Line;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		#endregion

		#region Implementation of IDisposable

		/// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
		public void Dispose()
		{
		}

		#endregion
	}
}
