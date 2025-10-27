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
    public class BalanceSheetRepository
    {
		public IList<ExtendedBalanceSheetSettingModel> SelectBalanceSheet()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var p = new DynamicParameters();
				p.Add("@UserId", CurrentUser.UserId);
				p.Add("@CompanyId", CurrentUser.CompanyId);
				p.Add("@HeaderId", 0);

				string sqlString = "SELECT bs.BalanceHeaderId, bs.ParentId, bs.AccountNumber, bs.Description, bs.Chiff, " +
				                   "bs.Amounta, bs.Amountb, bs.Amountn, bs.ColumnFirst, bs.ColumnSecond, bs.OrderInList, " +
				                   "bs.IsTotal, bs.IsGrandTotal, bs.UserId " +
				                   "FROM _BalanceStatements bs WHERE (@HeaderId = 0 OR bs.BalanceHeaderId = @HeaderId) " +
				                   "ORDER BY BalanceHeaderId, ParentId, OrderInList";

				var records =
					connection.Query<ExtendedBalanceSheetSettingModel>(sqlString, p);
				return records.ToList();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool GenerateBalanceSheetData(DateTime? dateFrom, DateTime? dateTo, int balanceHeaderId, string currency, int workingYear)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var parameters = new DynamicParameters();
				parameters.Add("@UserId", CurrentUser.UserId);
				parameters.Add("@CompanyId", CurrentUser.CompanyId);
				parameters.Add("@WorkingYear", workingYear);
				parameters.Add("@BalanceHeaderId", balanceHeaderId);

				connection.ExecuteScalar("DELETE FROM _BalanceStatements WHERE UserId = @UserId", parameters);

				GenerateAssets(dateFrom, dateTo, workingYear);
				GenerateLiabilities(dateFrom, dateTo, workingYear);
				
				CleanBalanceStatementTable();
				CalculateTotals(dateFrom, dateTo, workingYear);

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		
		public bool GenerateAssets(DateTime? dateFrom, DateTime? dateTo, int workingYear)
		{
			try
			{
				IList<ExtendedBalanceSheetSettingModel> records;

				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@UserId", CurrentUser.UserId);
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@BranchId", CurrentUser.BranchId);
					p.Add("@HeaderId", 1);

					string insertSqlString = "INSERT INTO _BalanceStatements (BalanceHeaderId, ParentId, AccountNumber, Description, " +
											 "Chiff, DbCr, Amounta, Amountb, Amountn, ColumnFirst, ColumnSecond, OrderInList, IsTotal, " +
											 "IsGrandTotal, UserId, CompanyId, BranchId, CreatedBy) " +
											 "SELECT bs.BalanceHeaderId, bs.ParentId, bs.AccountNumber, bs.Description, '' AS Chiff, " +
											 "DbCr, 0 AS Amounta, 0 AS Amountb, 0 AS Amountn, bs.ColumnFirst, bs.ColumnSecond, bs.OrderInList, " +
											 "bs.IsTotal, bs.IsGrandTotal, @UserId, @CompanyId, @BranchId, @UserId " +
											 "FROM BalanceSheetSettings bs WHERE (@HeaderId = 0 OR bs.BalanceHeaderId = @HeaderId) " +
											 "ORDER BY BalanceHeaderId, ParentId, OrderInList;";
					_ =
						connection.ExecuteScalar<ExtendedBalanceSheetSettingModel>(insertSqlString, p);

					string sqlString = "SELECT Id, BalanceHeaderId, ParentId, AccountNumber, Description, Chiff, DbCr, Amounta, Amountb, Amountn, " +
					                   "ColumnFirst, ColumnSecond, OrderInList, IsTotal, IsGrandTotal, UserId " +
									   "FROM _BalanceStatements bs WHERE (@HeaderId = 0 OR bs.BalanceHeaderId = @HeaderId) " +
					                   "ORDER BY BalanceHeaderId, ParentId, OrderInList";

					records =
						connection.Query<ExtendedBalanceSheetSettingModel>(sqlString, p).ToList();
				}

				foreach (var asset in records)
				{
					AddSet(dateFrom, dateTo, asset.Id, asset.BalanceHeaderId, asset.ParentId, asset.AccountNumber,
						asset.Description, asset.ColumnFirst, asset.ColumnSecond,
						asset.OrderInList, asset.IsTotal, asset.IsGrandTotal, workingYear);
				}

				// Additional asset sets could be added here if needed.
				CleanUpDepreciation();
				UpdateBalanceStatementTotals();
				UpdateBalanceStatementAssetsTotals();
				UpdateBalanceRegularizationAssetsTotals();
				UpdateBalanceStatementAssetsGrandTotals();

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public bool GenerateLiabilities(DateTime? dateFrom, DateTime? dateTo, int workingYear)
		{
			try
			{
				IList<ExtendedBalanceSheetSettingModel> records;

				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@UserId", CurrentUser.UserId);
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@BranchId", CurrentUser.BranchId);
					p.Add("@HeaderId", 2);

					string insertSqlString = "INSERT INTO _BalanceStatements (BalanceHeaderId, ParentId, AccountNumber, Description, " +
					                         "Chiff, DbCr, Amounta, Amountb, Amountn, ColumnFirst, ColumnSecond, OrderInList, IsTotal, " +
					                         "IsGrandTotal, UserId, CompanyId, BranchId, CreatedBy) " +
					                         "SELECT bs.BalanceHeaderId, bs.ParentId, bs.AccountNumber, bs.Description, '' AS Chiff, " +
					                         "DbCr, 0 AS Amounta, 0 AS Amountb, 0 AS Amountn, bs.ColumnFirst, bs.ColumnSecond, bs.OrderInList, " +
					                         "bs.IsTotal, bs.IsGrandTotal, @UserId, @CompanyId, @BranchId, @UserId " +
					                         "FROM BalanceSheetSettings bs WHERE (@HeaderId = 0 OR bs.BalanceHeaderId = @HeaderId) " +
					                         "ORDER BY BalanceHeaderId, ParentId, OrderInList;";
					_ =
						connection.ExecuteScalar<ExtendedBalanceSheetSettingModel>(insertSqlString, p);

					string sqlString = "SELECT Id, BalanceHeaderId, ParentId, AccountNumber, Description, Chiff, DbCr, Amounta, Amountb, Amountn, " +
					                   "ColumnFirst, ColumnSecond, OrderInList, IsTotal, IsGrandTotal, UserId " +
					                   "FROM _BalanceStatements bs WHERE (@HeaderId = 0 OR bs.BalanceHeaderId = @HeaderId) " +
					                   "ORDER BY BalanceHeaderId, ParentId, OrderInList";

					records =
						connection.Query<ExtendedBalanceSheetSettingModel>(sqlString, p).ToList();
				}

				foreach (var asset in records)
				{
					AddSet(dateFrom, dateTo, asset.Id, asset.BalanceHeaderId, asset.ParentId, asset.AccountNumber,
						asset.Description, asset.ColumnFirst, asset.ColumnSecond,
						asset.OrderInList, asset.IsTotal, asset.IsGrandTotal, workingYear);
				}

				CalculateLiabilitiesTotals();
				CalculateLiabilitiesProfitOrLoss(dateFrom, dateTo, workingYear);
				CalculateLiabilitiesGrandTotals();

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		//private string GetChartAccountName(string number)
		//{
		//	try
		//	{
		//		using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
		//		var parameters = new DynamicParameters();
		//		parameters.Add("@Number", number);
		//		var model = connection.QuerySingleOrDefault<ChartModel>(
		//			"SELECT AccountName FROM Charts WHERE Number = @Number AND Serial IS NULL;", parameters);
		//		return model?.AccountName ?? string.Empty;
		//	}
		//	catch (Exception ex)
		//	{
		//		throw new Exception(ex.Message);
		//	}
		//}

		private void AddSet(DateTime? dateFrom, DateTime? dateTo, int id, int balanceHeaderId, int parentId,
			string accountNumber, string description, bool columnFirst, bool columnSecond, int orderInList,
			bool isTotal, bool isGrandTotal, int workingYear)
		{
			try
			{
				decimal totalFirstColumn = 0;
				decimal totalSecondColumn = 0;
				string numberFirstOccurrence = "";

				if (accountNumber != null)
				{
					foreach (string line in accountNumber.Trim().Split([Environment.NewLine], StringSplitOptions.None))
					{
						if (numberFirstOccurrence == "") numberFirstOccurrence = line;
						totalFirstColumn += columnFirst ? SumAccount(dateFrom, dateTo, line, workingYear) : 0;
						totalSecondColumn += columnSecond ? SumAccount(dateFrom, dateTo, line, workingYear) : 0;
					}
				}

				if (totalFirstColumn != 0 || totalSecondColumn != 0)
				{

					decimal combinedTotal = columnFirst
						? totalFirstColumn + totalSecondColumn
						: totalFirstColumn - totalSecondColumn;

					if (balanceHeaderId == 2)
					{
						totalFirstColumn = -totalFirstColumn;
						combinedTotal = -combinedTotal;
					}

					//if (numberFirstOccurrence == "475")
					//{
					//	totalFirstColumn = -totalFirstColumn;
					//	totalFirstColumn = -totalFirstColumn;
					//}

					UpdateAsset(id, balanceHeaderId, parentId, numberFirstOccurrence, description, string.Empty,
						columnFirst ? totalFirstColumn : 0,
						columnSecond ? -totalSecondColumn : 0,
						combinedTotal, columnFirst, columnSecond, orderInList, isTotal, isGrandTotal, workingYear);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public bool UpdateAsset(int id, int balanceHeaderId, int parentId, string accountNumber, string description, string chiff, 
			decimal amounta, decimal amountb, decimal amountn, bool columnFirst, bool columnSecond, int orderInList,
			bool isTotal, bool isGrandTotal, int workingYear)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var parameters = new DynamicParameters();
				parameters.Add("@Id", id);
				parameters.Add("@BalanceHeaderId", balanceHeaderId);
				parameters.Add("@ParentId", parentId);
				parameters.Add("@AccountNumber", accountNumber);
				parameters.Add("@Description", description);
				parameters.Add("@Chiff", chiff);
				parameters.Add("@Amounta", amounta);
				parameters.Add("@Amountb", amountb);
				parameters.Add("@Amountn", amountn);
				parameters.Add("@ColumnFirst", columnFirst);
				parameters.Add("@ColumnSecond", columnSecond);
				parameters.Add("@OrderInList", orderInList);
				parameters.Add("@IsTotal", isTotal);
				parameters.Add("@IsGrandTotal", isGrandTotal);
				parameters.Add("@UserId", CurrentUser.UserId);

				parameters.Add("@CompanyId", CurrentUser.CompanyId);
				parameters.Add("@BranchId", CurrentUser.BranchId);
				parameters.Add("@CreatedBy", CurrentUser.UserId);
				parameters.Add("@WorkingYear", workingYear);

				connection.ExecuteScalar<int>(
					"Update _BalanceStatements SET Chiff = @Chiff, AccountNumber = @AccountNumber, Description = @Description, " +
					"Amounta = @Amounta, Amountb = @Amountb, Amountn = @Amountn, UserId = @UserId, " +
					"CompanyId = @CompanyId, BranchId = @BranchId, CreatedBy = @CreatedBy, WorkingYear = @WorkingYear " +
					"WHERE Id = @Id ", 
					parameters);
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private decimal SumAccount(DateTime? dateFrom, DateTime? dateTo, string number, int workingYear)
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var parameters = new DynamicParameters();
				parameters.Add("@DateFrom", dateFrom);
				parameters.Add("@DateTo", dateTo);
				parameters.Add("@Number", number);
				parameters.Add("@UserId", CurrentUser.UserId);
				parameters.Add("@CompanyId", CurrentUser.CompanyId);
				parameters.Add("@WorkingYear", workingYear);

				var totalRecord =
					connection.QuerySingleOrDefault<BalanceSheetInitialModel>(
						$"exec dbo.rep_GenerateSumOfBalanceSheet_V001 @DateFrom, @DateTo, {number}, @CompanyId, @WorkingYear;", parameters);

				if (totalRecord == null) return 0;

				return totalRecord.OPUSD + totalRecord.DBUSD - totalRecord.CRUSD;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		private void CleanUpDepreciation()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				var totalRecords =
					connection.Query<ExtendedBalanceSheetSettingModel>(
						"SELECT * FROM _BalanceStatements WHERE ColumnSecond = 1 and IsTotal = 0 and IsGrandTotal = 0 " +
						"ORDER BY BalanceHeaderId, ParentId, OrderInList;");

				foreach (var record in totalRecords)
				{
					connection.ExecuteScalar<int>($"UPDATE _BalanceStatements SET Amountb = -(Amountb + {record.Amountb}), " +
					                              $"Amountn = Amounta - {record.Amountb} " +
					                              $"WHERE BalanceHeaderId = {record.BalanceHeaderId} AND ParentId = {record.ParentId} " +
					                              $"AND OrderInList ={record.OrderInList} AND ColumnSecond = 0 ");
				}

				connection.ExecuteScalar("DELETE FROM _BalanceStatements WHERE ColumnFirst = 0 AND ColumnSecond = 1 ");
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		private void UpdateBalanceStatementTotals()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				connection.ExecuteScalar("EXEC dbo.rep_UpdateBalanceStatementTotals");
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		private void UpdateBalanceStatementAssetsTotals()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				connection.ExecuteScalar("EXEC dbo.rep_UpdateBalanceStatementAssetsTotals");
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		private void UpdateBalanceRegularizationAssetsTotals()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				connection.ExecuteScalar("EXEC dbo.rep_UpdateBalanceRegularizationAssetsTotals");
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		private void UpdateBalanceStatementAssetsGrandTotals()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				connection.ExecuteScalar("EXEC dbo.rep_UpdateBalanceStatementAssetsGrandTotals");
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		private void CleanBalanceStatementTable()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				connection.ExecuteScalar("DELETE FROM _BalanceStatements WHERE Amounta = 0 AND Amountb = 0 AND Amountn = 0 AND IsTotal = 0 AND IsGrandTotal = 0");
				connection.ExecuteScalar("DELETE FROM _BalanceStatements WHERE BalanceHeaderId = 1 AND DbCr = 'D' AND amounta <0;");
				connection.ExecuteScalar("DELETE FROM _BalanceStatements WHERE BalanceHeaderId = 2 AND DbCr = 'C' AND amounta <0;");
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		//Liabilities
		private void CalculateLiabilitiesTotals()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				connection.ExecuteScalar("EXEC dbo.rep_CalculateLiabilitiesTotals");
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		private void CalculateLiabilitiesProfitOrLoss(DateTime? dateFrom, DateTime? dateTo, int workingYear)
		{
			try
			{
				var parameters = new DynamicParameters();
				parameters.Add("@DateFrom", dateFrom);
				parameters.Add("@DateTo", dateTo);
				parameters.Add("@UserId", CurrentUser.UserId);
				parameters.Add("@CompanyId", CurrentUser.CompanyId);
				parameters.Add("@WorkingYear", workingYear);

				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				connection.ExecuteScalar("EXEC dbo.rep_CalculateLiabilitiesProfitOrLoss @DateFrom, @DateTo, @CompanyId, @WorkingYear;", parameters);
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		private void CalculateLiabilitiesGrandTotals()
		{
			try
			{
				using IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString());
				connection.ExecuteScalar("EXEC dbo.rep_CalculateLiabilitiesGrandTotals");
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		private void CalculateTotals(DateTime? dateFrom, DateTime? dateTo, int workingYear)
		{
			CleanUpDepreciation();
			UpdateBalanceStatementTotals();
			UpdateBalanceStatementAssetsTotals();
			UpdateBalanceRegularizationAssetsTotals();
			UpdateBalanceStatementAssetsGrandTotals();

			CalculateLiabilitiesTotals();
			CalculateLiabilitiesProfitOrLoss(dateFrom, dateTo, workingYear);
			CalculateLiabilitiesGrandTotals();
		}
	}
}
