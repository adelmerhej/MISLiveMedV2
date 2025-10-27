using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Airlines;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Carriers
{
	public class AirlineRepository : IDisposable
	{
		public IList<AirlineModel> SelectAirlines()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var dataRecords =
						connection.Query<AirlineModel>("SELECT * FROM Airlines WHERE CompanyId = @CompanyId;", p);
					return dataRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public AirlineModel SelectAirlinesById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					var dataRecord =
						connection.QuerySingleOrDefault<AirlineModel>("SELECT * FROM Airlines WHERE Id = @Id;", p);
					return dataRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewAirline(AirlineModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@AirlineName", dataModel.AirlineName);
					p.Add("@IntegerCode", dataModel.IntegerCode);
					p.Add("@AbbreviationCode", dataModel.AbbreviationCode);
					p.Add("@FlightCode", dataModel.FlightCode);
					p.Add("@AirlineNameAWB", dataModel.AirlineNameAWB);
					p.Add("@Nationality", dataModel.Nationality);
					p.Add("@GSAAgent", dataModel.GSAAgent);
					p.Add("@GSAAgentId", dataModel.GSAAgentId);
					p.Add("@ReportId", dataModel.ReportId);
					p.Add("@AirlineDate", dataModel.AirlineDate);
					p.Add("@ActivationDate", dataModel.ActivationDate);
					p.Add("@IataCode", dataModel.IataCode);
					p.Add("@AwbPrefix", dataModel.AwbPrefix);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
						"dbo.job_AddNewAirline @AirlineName, @IntegerCode, @AbbreviationCode, @FlightCode, @AirlineNameAWB, " +
						"@Nationality, @GSAAgent, @GSAAgentId, @ReportId, @AirlineDate, @ActivationDate, @IataCode, @AwbPrefix, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public void UpdateAirline(AirlineModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@AirlineName", dataModel.AirlineName);
					p.Add("@IntegerCode", dataModel.IntegerCode);
					p.Add("@AbbreviationCode", dataModel.AbbreviationCode);
					p.Add("@FlightCode", dataModel.FlightCode);
					p.Add("@AirlineNameAWB", dataModel.AirlineNameAWB);
					p.Add("@Nationality", dataModel.Nationality);
					p.Add("@GSAAgent", dataModel.GSAAgent);
					p.Add("@GSAAgentId", dataModel.GSAAgentId);
					p.Add("@ReportId", dataModel.ReportId);
					p.Add("@AirlineDate", dataModel.AirlineDate);
					p.Add("@ActivationDate", dataModel.ActivationDate);
					p.Add("@IataCode", dataModel.IataCode);
					p.Add("@AwbPrefix", dataModel.AwbPrefix);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
						"dbo.job_UpdateAirline @Id, @AirlineName, @IntegerCode, @AbbreviationCode, @FlightCode, @AirlineNameAWB, " +
						"@Nationality, @GSAAgent, @GSAAgentId, @ReportId, @AirlineDate, @ActivationDate, @IataCode, @AwbPrefix, " +
						"@Notes, @LastModifiedBy, @IsProtected, @Active",
						p);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteAirline(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Airlines WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public void Dispose()
		{

		}
	}
}
