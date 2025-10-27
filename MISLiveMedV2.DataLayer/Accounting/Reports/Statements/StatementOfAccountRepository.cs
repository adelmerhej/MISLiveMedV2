using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Reports.Statements;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Reports.Statements
{
	public class StatementOfAccountRepository
	{
		public void StatementOfAccountById(DateTime? dateFrom, DateTime? dateTo, int chartId = 0,
				int currencyId = 2, bool isProtected = false, int workingYear = 0)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@DateFrom", dateFrom);
					p.Add("@DateTo", dateTo);
					p.Add("@ChartId", chartId);
					p.Add("@WorkingYear", workingYear);
					p.Add("@CurrencyId", currencyId);

					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@UserId", CurrentUser.UserId);
					p.Add("@Protected", isProtected);

					_ = connection.ExecuteScalar<SpecialIncomeStatementModel>("dbo._GenerateIncomeStatement @DateFrom, @DateTo, @Real, @UserId, @CompanyId, @CurrencyId;", p);
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<StatementOfAccountReportModel> StatementOfAccountReport(DateTime? dateFrom, DateTime? dateTo, 
			int chartId = 0, int currencyId = 2)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@DateFrom", dateFrom);
					p.Add("@DateTo", dateTo);
					p.Add("@ChartId", chartId);
					p.Add("@CurrencyId", currencyId);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					return connection.Query<StatementOfAccountReportModel>(
						"dbo.rep_StatementOfAccountReport_V001 @DateFrom, @DateTo, @ChartId, @CurrencyId, @CompanyId;", p).ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<StatementOfAccountReportModel> StatementOfAccountReport(DateTime? dateFrom, DateTime? dateTo,
			int chartId = 0, int currencyId = 0, int workingYear = 0, bool isProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					// 

					var p = new DynamicParameters();
					p.Add("@DateFrom", dateFrom);
					p.Add("@DateTo", dateTo);
					p.Add("@ChartId", chartId);
					p.Add("@CurrencyId", currencyId);
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@WorkingYear", workingYear);
					p.Add("@IsProtected", isProtected);

					return connection.Query<StatementOfAccountReportModel>(
						"dbo.rep_StatementOfAccountReport_V001 @DateFrom, @DateTo, @ChartId, @CurrencyId, @CompanyId, " +
						"@WorkingYear, @IsProtected;", p).ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public IList<TrialBalanceModel> TrialBalanceReport(DateTime? dateFrom, DateTime? dateTo,
			string fromChartId = "", string toChartId = "", int currencyId = 0, int workingYear = 0, bool isProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					// 

					var p = new DynamicParameters();
					p.Add("@DateFrom", dateFrom);
					p.Add("@DateTo", dateTo);
					p.Add("@FromChartId", fromChartId);
					p.Add("@ToChartId", toChartId);
					p.Add("@CurrencyId", currencyId);
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@WorkingYear", workingYear);
					p.Add("@IsProtected", isProtected);

					return connection.Query<TrialBalanceModel>(
						"dbo.rep_TrialBalanceReport_V001 @DateFrom, @DateTo, @FromChartId, @ToChartId, @CurrencyId, @CompanyId, " +
						"@WorkingYear, @IsProtected;", p).ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


	}
}
