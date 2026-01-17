using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Conditions;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.Common.Conditions
{
	public class ConditionDetailRepository : IDisposable
	{
		public IList<ConditionDetailModel> SelectConditionDetails(int conditionId, int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ConditionId", conditionId);
					p.Add("@CompanyId", companyId);

					var conditionDetailsRecords =
						connection.Query<ConditionDetailModel>("SELECT * FROM ConditionDetails " +
						"WHERE ConditionId = @ConditionId AND CompanyId = @CompanyId;", p);
					return conditionDetailsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<ConditionDetailModel> SelectConditionDetails(int conditionId, int companyId, bool active)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ConditionId", conditionId);
					p.Add("@CompanyId", companyId);
					p.Add("@Active", active);  // Currently not used in query

					var conditionDetailsRecords =
						connection.Query<ConditionDetailModel>("SELECT * FROM ConditionDetails " +
						"WHERE CompanyId = @CompanyId " +
						"AND RequiredEffectiveDate <= GETDATE() AND (RequiredEndDate IS NULL OR RequiredEndDate >= GETDATE());", p);
					return conditionDetailsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<ConditionDetailModel> SelectConditionDetailsByConditionId(ConditionSelection conditionId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ConditionId", (int)conditionId);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var conditionDetailsRecords =
						connection.Query<ConditionDetailModel>("SELECT * FROM ConditionDetails WHERE ConditionId = @ConditionId AND CompanyId = @CompanyId;", p);
					return conditionDetailsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<ConditionDetailModel> SelectConditionDetailsByJobNo(ConditionSelection conditionId, int jobNo)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ConditionId", conditionId);
					p.Add("@JobNo", jobNo);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var conditionDetailsRecords =
						connection.Query<ConditionDetailModel>("SELECT cd.Id, r.JobNo, cd.Description, r.IsRequired, r.IsFulFilled " +
															   "FROM JobSImportRequiredDocuments r INNER JOIN ConditionDetails cd " +
															   "on cd.Id = r.RequiredListId " +
															   "WHERE cd.ConditionId = @ConditionId AND JobNo = @JobNo;", p);
					return conditionDetailsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public ConditionDetailModel SelectConditionDetailById(int conditionId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", conditionId);

					var conditionDetailRecord =
						connection.QuerySingleOrDefault<ConditionDetailModel>("SELECT * FROM ConditionDetails WHERE Id = @Id;", p);
					return conditionDetailRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewConditionDetail(ConditionDetailModel conditionModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@Description", conditionModel.Description);
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@Notes", conditionModel.Notes);
					p.Add("@CreatedBy", CurrentUser.UserId);

					conditionModel.Id = connection.ExecuteScalar<int>(
						"dbo.job_AddNewConditionDetail @Description, @CompanyId, @Notes, @CreatedBy", p);

					return conditionModel.Id;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public void UpdateConditionDetail(ConditionDetailModel conditionModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", conditionModel.Id);
					p.Add("@Description", conditionModel.Description);
					p.Add("@Notes", conditionModel.Notes);
					p.Add("@LastModifiedBy", conditionModel.LastModifiedBy);
					p.Add("@LastModifiedDate", conditionModel.LastModifiedDate);
					p.Add("@Active", conditionModel.Active);

					_ = connection.ExecuteScalar<int>(
						"dbo.job_UpdateConditionDetail @Id, @Description, @Notes, @LastModifiedBy, @LastModifiedDate, @Active",
						p);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteConditionDetail(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM ConditionDetails WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
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
