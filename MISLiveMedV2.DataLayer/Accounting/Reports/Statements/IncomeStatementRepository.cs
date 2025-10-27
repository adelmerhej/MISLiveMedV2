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
    public class IncomeStatementRepository
    {
        public IList<SpecialIncomeStatementModel> SelectIncomeStatements()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@UserId", CurrentUser.UserId);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var records =
                        connection.Query<SpecialIncomeStatementModel>("exec dbo._SelectIncomeStatements @UserId, @CompanyId;", p);
                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<IncomeAccountModel> SelectIncomeAccounts()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var records =
                        connection.Query<IncomeAccountModel>("SELECT AccountGroup, AccountNumber, Description, BalanceGroupId, Section, ColumnList, OrderInList, " +
                                                             "IsTotal FROM _AccBalances WHERE CompanyId = @CompanyId ORDER BY OrderInList;", p);
                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
		public decimal ExecuteIncomeAccountCalculation(DateTime? dateFrom, DateTime? dateTo, bool isTotal, int currencyId, string accountNumber)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var parameters = new DynamicParameters();
			        parameters.Add("@DateFrom", dateFrom);
			        parameters.Add("@DateTo", dateTo);
			        parameters.Add("@Real", isTotal);
			        parameters.Add("@UserId", CurrentUser.UserId);
			        parameters.Add("@CompanyId", CurrentUser.CompanyId);
			        parameters.Add("@CurrencyId", currencyId);
			        parameters.Add("@AccountNumber", accountNumber);

			        return connection.ExecuteScalar<decimal>(
				        "EXEC dbo._CalculateIncomeAccount @DateFrom, @DateTo, @Real, @UserId, @CompanyId, @CurrencyId, @AccountNumber;",
				        parameters);
		        }
	        }
	        catch (Exception ex)
	        {
		        throw new Exception(ex.Message);
	        }
        }

		public void AddIncomeStatementEntry(DateTime? dateFrom, DateTime? dateTo, bool real, bool isTotal,
            int accountGroup, string accountNumber, string description, int orderInList, int columnList, 
            int section, int currencyId, decimal totalAmount)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var parameters = new DynamicParameters();
			        parameters.Add("@DateFrom", dateFrom);
			        parameters.Add("@DateTo", dateTo);
			        parameters.Add("@Real", real);
			        parameters.Add("@IsTotal", isTotal);
			        parameters.Add("@AccountGroup", accountGroup);
			        parameters.Add("@AccountNumber", accountNumber);
			        parameters.Add("@Description", description);
			        parameters.Add("@OrderInList", orderInList);
			        parameters.Add("@ColumnList", columnList);
			        parameters.Add("@Section", section);
			        parameters.Add("@CurrencyId", currencyId);
			        parameters.Add("@totalAmount", totalAmount);
			        parameters.Add("@UserId", CurrentUser.UserId);
			        parameters.Add("@CompanyId", CurrentUser.CompanyId);

			        connection.ExecuteScalar<SpecialIncomeStatementModel>(
				        "EXEC dbo._AddNewIncomeAccount_V001 @DateFrom, @DateTo, @Real, @IsTotal, @AccountGroup, @AccountNumber, " +
				        "@Description, @OrderInList, @ColumnList, @Section, @CurrencyId, @totalAmount, @UserId, @CompanyId;",
				        parameters);
		        }
	        }
	        catch (Exception ex)
	        {
		        throw new Exception(ex.Message);
	        }
		}

        public decimal CalculateTotalIncome(int accountGroup, int columnPosition)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@AccountGroup", accountGroup);
                    parameters.Add("@UserId", CurrentUser.UserId);
                    parameters.Add("@CompanyId", CurrentUser.CompanyId);

                    string query = columnPosition switch
                    {
                        1 => "SELECT SUM(Amount1) FROM _IncomeStatements WHERE AccountGroup = @AccountGroup " +
                             "AND CreatedBy = @UserId AND CompanyId = @CompanyId GROUP BY AccountGroup;",
                        2 => "SELECT SUM(Amount2) FROM _IncomeStatements WHERE AccountGroup = @AccountGroup " +
                             "AND CreatedBy = @UserId AND CompanyId = @CompanyId GROUP BY AccountGroup;",
                        3 => "SELECT SUM(Amount3) FROM _IncomeStatements WHERE AccountGroup = @AccountGroup " +
                             "AND CreatedBy = @UserId AND CompanyId = @CompanyId GROUP BY AccountGroup;",
                        4 => "SELECT SUM(Amount4) FROM _IncomeStatements WHERE AccountGroup = @AccountGroup " +
                             "AND CreatedBy = @UserId AND CompanyId = @CompanyId GROUP BY AccountGroup;",
                        _ => throw new ArgumentOutOfRangeException(nameof(columnPosition), @"Invalid column position")
                    };

                    return connection.ExecuteScalar<decimal>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal CalculateIncomeProvisions(DateTime dateFrom, DateTime dateTo, int typeId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();

                    DateTime now = dateTo;
                    var startDate = new DateTime(now.Year, now.Month, 1); 
                    var endDate = startDate.AddMonths(1).AddDays(-1);

                    p.Add("@DateFrom", startDate);
                    p.Add("@DateTo", endDate);
                    p.Add("@TypeId", typeId);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    decimal totals = connection.QuerySingleOrDefault<decimal>("exec dbo.rep_GenerateIncomeProvisions_V001 @DateFrom, @DateTo, @TypeId, @CompanyId;", p);

                    return totals;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<DetailedIncomeStatementModel> GenerateDetailedIncome(DateTime? dateFrom, DateTime? dateTo, string orderBy, 
	        string sortingBy, bool removeDuplicates)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DateFrom", dateFrom);
                    p.Add("@DateTo", dateTo);
                    p.Add("@UserId", CurrentUser.UserId);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@OrderBy", orderBy);
					p.Add("@SortingBy", sortingBy);
					p.Add("@RemoveDuplicates", removeDuplicates);

					var continentsRecords =
                        connection.Query<DetailedIncomeStatementModel>(
							"exec dbo.rep_GenerateIncomeList_V001 @DateFrom, @DateTo, @UserId, @CompanyId, @OrderBy, @SortingBy, @RemoveDuplicates;", p);

                    return continentsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

 

        public void DeleteIncomeStatementTmpTable()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@UserId", CurrentUser.UserId);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    _ = connection.ExecuteScalar("DELETE FROM _IncomeStatements WHERE CreatedBy = @UserId AND CompanyId = @CompanyId;", p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
