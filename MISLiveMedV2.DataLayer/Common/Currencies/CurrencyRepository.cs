using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Currencies
{
    public class CurrencyRepository : IDisposable
    {
        public IList<CurrencyModel> SelectCurrencies()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var currenciesRecords =
                        connection.Query<CurrencyModel>("SELECT * FROM Currencies WHERE CompanyId = @CompanyId;", p);
                    return currenciesRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<CurrencyModel> SelectCurrenciesByCompanyId(int companyId)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var p = new DynamicParameters();
			        p.Add("@CompanyId", companyId);

			        var currenciesRecords =
				        connection.Query<CurrencyModel>("SELECT * FROM Currencies WHERE CompanyId = @CompanyId;", p);
			        return currenciesRecords.ToList();
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
        }
		public CurrencyModel SelectCurrencyById(int currencyId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", currencyId);

                    var currencyRecord =
                        connection.QuerySingleOrDefault<CurrencyModel>("SELECT * FROM Currencies WHERE Id = @Id;", p);
                    return currencyRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int SelectCurrencyByCode(string currencyCode)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        int currencyId = 0;

			        switch (currencyCode)
			        {
                        case "LL":
	                        currencyId = 1;
							break;

                        case "USD":
	                        currencyId = 2;
	                        break;

                        case "EU":
	                        currencyId = 3;
	                        break;

                        case "GBP   ":
	                        currencyId = 4;
	                        break;

                        case "SF":
	                        currencyId = 5;
	                        break;
							
						default:
					        break;
			        }

					return currencyId;
					;
				}
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
        }


		public int AddNewCurrency(CurrencyModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@CurrencyCode", dataModel.CurrencyCode);
                    p.Add("@CurrencySymbol", dataModel.CurrencySymbol);
                    p.Add("@CurrencyName", dataModel.CurrencyName);
                    p.Add("@DivByLocalRate", dataModel.DivByLocalRate);
                    p.Add("@DivideByForeignRate", dataModel.DivideByForeignRate);
                    p.Add("@Decimals", dataModel.Decimals);
                    p.Add("@Rounding", dataModel.Rounding);

                    p.Add("@Notes", dataModel.Notes);
                    p.Add("@CompanyId", dataModel.CompanyId);
                    p.Add("@BranchId", dataModel.BranchId);
                    p.Add("@CreatedBy", dataModel.CreatedBy);
                    p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
	                    "INSERT INTO Currencies (CurrencyCode, CurrencySymbol, CurrencyName, DivByLocalRate, DivideByForeignRate, Decimals, Rounding," +
	                    "Notes, CompanyId, BranchId, CreatedBy, IsProtected) " +
	                    "OUTPUT Inserted.Id " +
	                    "VALUES (@CurrencyCode, @CurrencySymbol, @CurrencyName, @DivByLocalRate, @DivideByForeignRate, @Decimals, @Rounding, " +
	                    "@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p);

                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool UpdateCurrency(CurrencyModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", dataModel.Id);
                    p.Add("@CurrencyCode", dataModel.CurrencyCode);
                    p.Add("@CurrencySymbol", dataModel.CurrencySymbol);
                    p.Add("@CurrencyName", dataModel.CurrencyName);
                    p.Add("@DivByLocalRate", dataModel.DivByLocalRate);
                    p.Add("@DivideByForeignRate", dataModel.DivideByForeignRate);
                    p.Add("@Decimals", dataModel.Decimals);
                    p.Add("@Rounding", dataModel.Rounding);

                    p.Add("@Notes", dataModel.Notes);
                    p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
                    p.Add("@IsProtected", dataModel.IsProtected);
                    p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Currencies SET " +
						"CurrencyCode = @CurrencyCode, CurrencySymbol = @CurrencySymbol, CurrencyName = @CurrencyName, DivByLocalRate = @DivByLocalRate, " +
						"DivideByForeignRate = @DivideByForeignRate, Decimals = @Decimals, Rounding = @Rounding, Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
						"LastModifiedDate= GETDATE(), IsProtected = @IsProtected, Active = @Active " +
						"WHERE Id = @Id", p); ;
                }

                return true;
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool DeleteCurrency(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Currencies WHERE Id = @Id", p);
                }

                return true;
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        #region Implementation of IDisposable

        public void Dispose()
        {

        }

        #endregion

    }
}
