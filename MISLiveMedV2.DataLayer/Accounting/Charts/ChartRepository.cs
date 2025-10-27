using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Charts;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.Accounting.Charts
{
    public class ChartRepository : IDisposable
    {
        public IList<ChartModel> SelectCharts(bool byNumber, bool bySerial)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@ByNumber", byNumber);
                    p.Add("@BySerial", bySerial);

                    var records =
                        connection.Query<ChartModel>("SELECT * FROM Charts " +
                                                     "WHERE (@ByNumber = 0 OR Serial IS NULL) " +
                                                     "AND (@BySerial = 0 OR Serial IS NOT NULL) " +
                                                     "AND CompanyId = @CompanyId ORDER BY Number, Serial;", p);
                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ChartModel SelectChartsById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

					var record =
                        connection.QueryFirstOrDefault<ChartModel>("SELECT * FROM Charts WHERE Id = @Id AND CompanyId = @CompanyId;", p);
                    return record;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ChartModel SelectChartsByNumber(string number, ChartType type = ChartType.T)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var p = new DynamicParameters();
			        p.Add("@Number", number);
			        p.Add("@CompanyId", CurrentUser.CompanyId);
			        p.Add("@ChartTypeId", type);

			        var records =
				        connection.QuerySingleOrDefault<ChartModel>("SELECT * FROM Charts " +
				                                                    "WHERE Number = @Number AND ChartTypeId = @ChartTypeId " +
				                                                    "AND CompanyId = @CompanyId;", p);
			        return records;
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
        }

		public ChartModel SelectChartsBySerial(string number, string serial)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var p = new DynamicParameters();
			        p.Add("@Number", number);
			        p.Add("@Serial", serial);
			        p.Add("@CompanyId", CurrentUser.CompanyId);

			        var records =
				        connection.QuerySingleOrDefault<ChartModel>("SELECT * FROM Charts " +
																	"WHERE Number = @Number AND ISNULL(Serial, '') = @Serial " +
																	"AND CompanyId = @CompanyId;", p);
			        return records;
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
        }
        public string SelectChartsByNumber(string number)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var p = new DynamicParameters();
			        p.Add("@Number", number);
			        p.Add("@CompanyId", CurrentUser.CompanyId);
			        p.Add("@ChartType", ChartType.R.ToString());

			        var x = ChartType.R.ToString();


					var record =
				        connection.ExecuteScalar<string>("SELECT ISNULL(MAX(Serial), 0) + 1 As NewSerial FROM Charts " +
																	"WHERE Number = @Number AND ChartType = @ChartType " +
				                                                    "AND CompanyId = @CompanyId;", p);
			        return record;
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
        }

		public int AddNewChart(ChartModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Number", dataModel.Number);
                    p.Add("@Serial", dataModel.Serial);
                    p.Add("@AccountName", dataModel.AccountName);
                    p.Add("@ChartType", dataModel.ChartType);

					p.Add("@Notes", dataModel.Notes);
                    p.Add("@CompanyId", dataModel.CompanyId);
                    p.Add("@BranchId", dataModel.BranchId);
                    p.Add("@CreatedBy", dataModel.CreatedBy);
                    p.Add("@IsProtected", dataModel.IsProtected);
                    p.Add("@WorkingYear", dataModel.WorkingYear);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Charts (Number, Serial, AccountName, ChartType, " +
							"Notes, CompanyId, BranchId, CreatedBy, IsProtected, WorkingYear) " +
							"OUTPUT Inserted.Id " +
							"VALUES(@Number, @Serial, @AccountName, @ChartType, " +
							"@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected, @WorkingYear)", p);

                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool UpdateChart(ChartModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", dataModel.Id);
                    p.Add("@Number", dataModel.Number);
                    p.Add("@Serial", dataModel.Serial);
                    p.Add("@AccountName", dataModel.AccountName);
                    p.Add("@ChartType", dataModel.ChartType);

					p.Add("@Notes", dataModel.Notes);
                    p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
                    p.Add("@IsProtected", dataModel.IsProtected);
                    p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Charts SET Number = @Number, Serial = @Serial, AccountName = @AccountName, ChartType = @ChartType, " +
							"Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate = GETDATE(), " +
							"IsProtected = @IsProtected, Active = @Active " +
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

        public bool DeleteChart(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Charts WHERE Id = @Id", p);
                }

                return true;
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

		#region Validate Account

		public bool ValidateAccountNumber(string number, string serial)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Number", number);
					p.Add("@Serial", serial.PadLeft(5, '0'));
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var record =
						connection.QueryFirstOrDefault<ChartModel>("SELECT * FROM Charts " +
						                                           "WHERE Number = @Number AND Serial = @Serial " +
						                                           "AND CompanyId = @CompanyId;", p);

					return record != null;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public ChartModel ValidateAccountName(string accountName)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@AccountName", accountName);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var record =
						connection.QueryFirstOrDefault<ChartModel>("SELECT * FROM Charts " +
																   "WHERE AccountName = @AccountName " +
						                                           "AND CompanyId = @CompanyId;", p);

					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool ValidateAccountInJournal(int chartId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ChartId", chartId);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var record =
						connection.QueryFirstOrDefault<ChartModel>("SELECT TOP 1 * FROM JournalDetails jd " +
																   "WHERE ChartId = @ChartId " +
						                                           "AND CompanyId = @CompanyId;", p);

					return record != null;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		#endregion


		#region Old Section
		public IList<AccNameModel> SelectAccByCode(int workingYear)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();

					string accNameTable = "accname_" + workingYear + "$";

					var records =
						connection.Query<AccNameModel>($"SELECT * FROM {accNameTable} " +
						                               "ORDER BY number, serial;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public AccNameModel SelectAccByCode(string number, string serial, int workingYear)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();

					string accNameTable = "accname_" + workingYear + "$";

					var records =
						connection.QuerySingle<AccNameModel>($"SELECT * FROM {accNameTable} " +
						                               "ORDER BY number, serial;", p);
					return records;
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
