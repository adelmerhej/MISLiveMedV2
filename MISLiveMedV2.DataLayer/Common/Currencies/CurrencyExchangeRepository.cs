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
    public class CurrencyExchangeRepository : IDisposable
	{ 
		public IList<CurrencyExchangeModel> SelectCurrenciesExchange()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<CurrencyExchangeModel>("SELECT * FROM CurrenciesExchange " +
																"WHERE CompanyId = @CompanyId " +
						                                        "ORDER BY ExchangeDate DESC;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<CurrencyExchangeModel> SelectCurrencyById(int currencyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CurrencyId", currencyId);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<CurrencyExchangeModel>("SELECT * FROM CurrenciesExchange " +
						                                        "WHERE CompanyId = @CompanyId AND CurrencyId = @CurrencyId " +
						                                        "ORDER BY ExchangeDate DESC;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<CurrencyExchangeModel> SelectCurrencyByDate(DateTime date)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ExchangeDate", date);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<CurrencyExchangeModel>("SELECT Id, CurrencyId, ExchangeValue, ExchangeDate, HighValue, Notes, DATEPART(wk, ExchangeDate) As WeekNumber " +
						                                        "FROM CurrenciesExchange " +
																"WHERE CompanyId = @CompanyId AND CAST(ExchangeDate AS DATE) = CAST(@ExchangeDate AS DATE) " +
																"ORDER BY CurrencyId;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public CurrencyExchangeModel SelectExchangeCurrency(int currencyId, DateTime? exchangeDate)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CurrencyId", currencyId);
					p.Add("@ExchangeDate", exchangeDate);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var record =
						connection.QuerySingleOrDefault<CurrencyExchangeModel>("SELECT top 1 * FROM CurrenciesExchange " +
													"WHERE CompanyId = @CompanyId AND ExchangeDate IS NOT NULL " +
													"AND CAST(ExchangeDate AS DATE) <= CAST(@ExchangeDate AS DATE) AND CurrencyId = @CurrencyId AND ExchangeValue > 0" +
						                            "ORDER BY ExchangeDate DESC;", p);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public CurrencyExchangeModel CheckForExchangeCurrency(int currencyId, DateTime? currencyDate)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CurrencyId", currencyId);
					p.Add("@CurrencyDate", currencyDate);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var record =
						connection.QuerySingleOrDefault<CurrencyExchangeModel>("SELECT top 1 * FROM CurrenciesExchange " +
	                                                       "WHERE CompanyId = @CompanyId AND ExchangeDate IS NOT NULL " +
														   "AND CAST(ExchangeDate AS DATE) = CAST(@CurrencyDate AS DATE) AND CurrencyId = @CurrencyId " +
	                                                       "ORDER BY ExchangeDate DESC;", p);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewCurrencyExchange(CurrencyExchangeModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@CurrencyId", dataModel.CurrencyId);
					p.Add("@ExchangeValue", dataModel.ExchangeValue);
					p.Add("@ExchangeDate", dataModel.ExchangeDate);
					p.Add("@HighValue", dataModel.HighValue);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO CurrenciesExchange (CurrencyId, ExchangeValue, ExchangeDate, HighValue, Notes, CompanyId, BranchId, CreatedBy) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@CurrencyId, @ExchangeValue, @ExchangeDate, @HighValue, @Notes, @CompanyId, @BranchId, @CreatedBy) ", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateCurrencyExchange(CurrencyExchangeModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@CurrencyId", dataModel.CurrencyId);
					p.Add("@ExchangeValue", dataModel.ExchangeValue);
					p.Add("@ExchangeDate", dataModel.ExchangeDate);
					p.Add("@HighValue", dataModel.HighValue);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
						"UPDATE CurrenciesExchange SET " +
						"CurrencyId = @CurrencyId, ExchangeValue = @ExchangeValue, ExchangeDate = @ExchangeDate, HighValue = @HighValue, " +
						"Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate= GETDATE(), IsProtected = @IsProtected, Active = @Active " +
						"WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteCurrencyExchange(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM CurrenciesExchange WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		#region Implementation of IDisposable

		/// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
		public void Dispose()
		{
		}

		#endregion
	}
}
