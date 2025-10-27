using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Journals;
using MISLiveMed.Models.Models.Accounting.Journals.Reports;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Journals
{
	public class JournalRepository : IDisposable
	{
		public IList<JournalModel> SelectJournals(int workingYear)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@WorkingYear", workingYear);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<JournalModel>("SELECT * FROM Journals " +
													   "WHERE CompanyId = @CompanyId AND WorkingYear = @WorkingYear " +
													   "ORDER BY JvNo;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public IList<JournalVoucherReportModel> JournalVoucherReport(int journalId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", journalId);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					return connection.Query<JournalVoucherReportModel>(
						"dbo.rep_JournalVoucherReport_V001 @Id, @CompanyId;", p).ToList();

				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<JournalVoucherReportModel> DailyJournalVoucherReport(DateTime? dateFrom, DateTime? dateTo, string codeFrom, string codeTo, 
			string refNoFrom, string refNoTo, int journalTypes, int sortingByFilter, bool isProtected)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@DateFrom", dateFrom);
					p.Add("@DateTo", dateTo);
					p.Add("@CodeFrom", codeFrom);
					p.Add("@CodeTo", codeTo);
					p.Add("@RefNoFrom", refNoFrom);
					p.Add("@RefNoTo", refNoTo);
					p.Add("@JournalTypes", journalTypes);
					p.Add("@SortingByFilter", sortingByFilter);
					p.Add("@IsProtected", isProtected);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					return connection.Query<JournalVoucherReportModel>(
						"dbo.rep_DailyJournalVoucherReport_V001 @DateFrom, @DateTo, @CodeFrom, @CodeTo, @RefNoFrom, @RefNoTo, " +
						"@JournalTypes, @SortingByFilter, @IsProtected, @CompanyId;", p).ToList();

				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public JournalModel SelectJournalById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.QuerySingleOrDefault<JournalModel>("SELECT * FROM Journals " +
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

		public JournalModel SelectJournalByJvNo(int jvNo, int workingYear)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@JvNo", jvNo);
					p.Add("@WorkingYear", workingYear);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.QuerySingleOrDefault<JournalModel>("SELECT * FROM Journals " +
																	  "WHERE JvNo = @JvNo AND WorkingYear = @WorkingYear " +
																	  "AND CompanyId = @CompanyId;", p);
					return records;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int SelectNewJvNo(int workingYear)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@WorkingYear", workingYear);

					var records =
						connection.QuerySingleOrDefault<JournalModel>("SELECT MAX(JvNo) + 1 AS JvNo FROM Journals " +
																	  "WHERE CompanyId = @CompanyId AND WorkingYear = @WorkingYear;", p);

					return records.JvNo;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


		public int AddNewJournal(JournalModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@JvNo", dataModel.JvNo);
					p.Add("@JournalTypeId", dataModel.JournalTypeId);
					p.Add("@JournalDate", dataModel.JournalDate);
					p.Add("@Reference", dataModel.Reference);
					p.Add("@CurrencyId", dataModel.CurrencyId);
					p.Add("@Rate", dataModel.Rate);
					p.Add("@IsPosted", dataModel.IsPosted);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@LastModifiedDate", dataModel.LastModifiedDate);

					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@WorkingYear", dataModel.WorkingYear);
					p.Add("@Locked", dataModel.Locked);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Journals (JvNo, JournalTypeId, JournalDate, Reference, CurrencyId, Rate, IsPosted, " +
						"Notes, CompanyId, BranchId, CreatedBy, CreatedDate, LastModifiedBy, LastModifiedDate, IsProtected, WorkingYear, Locked) " +
						"OUTPUT Inserted.Id " +
						"VALUES(@JvNo, @JournalTypeId, @JournalDate, @Reference, @CurrencyId, @Rate, @IsPosted, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, GETDATE(), @LastModifiedBy, @LastModifiedDate, @IsProtected, @WorkingYear, @Locked)", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateJournal(JournalModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@JvNo", dataModel.JvNo);
					p.Add("@JournalTypeId", dataModel.JournalTypeId);
					p.Add("@JournalDate", dataModel.JournalDate);
					p.Add("@Reference", dataModel.Reference);
					p.Add("@CurrencyId", dataModel.CurrencyId);
					p.Add("@Rate", dataModel.Rate);
					p.Add("@IsPosted", dataModel.IsPosted);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);
					p.Add("@WorkingYear", dataModel.WorkingYear);
					p.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Journals SET JvNo = @JvNo, JournalTypeId = @JournalTypeId, JournalDate = @JournalDate, " +
								"Reference = @Reference, CurrencyId = @CurrencyId, Rate = @Rate, IsPosted = @IsPosted, " +
								"Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate = GETDATE(), " +
								"IsProtected = @IsProtected, Active = @Active, WorkingYear = @WorkingYear, Locked = @Locked " +
								"WHERE Id = @Id;",
						p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteJournal(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Journals WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		#region Old Section
		public IList<AJournalModel> SelectAJournals(int workingYear)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();

					string journalTable = "journal_" + workingYear + "$";

					var records =
						connection.Query<AJournalModel>($"SELECT * FROM {journalTable} " +
						                                               "ORDER BY code;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public AJournalModel SelectAJournalByCode(int workingYear, string code)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Code", code);

					string journalTable = "journal_" + workingYear + "$";

					var record =
						connection.QuerySingleOrDefault<AJournalModel>($"SELECT * FROM {journalTable} " +
						                                               "WHERE Code = @Code ", p);
					return record;
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
