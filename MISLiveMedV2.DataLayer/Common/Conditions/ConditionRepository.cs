using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Conditions;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Conditions
{
    public class ConditionRepository : IDisposable
    {
        public IList<ConditionModel> ConditionsList()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var conditionsRecords =
                        connection.Query<ConditionModel>("SELECT * FROM Conditions WHERE CompanyId = @CompanyId;", p);
                    return conditionsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ConditionModel ConditionById(int conditionId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", conditionId);

                    var conditionRecord =
                        connection.QuerySingleOrDefault<ConditionModel>("SELECT * FROM Conditions WHERE Id = @Id;", p);
                    return conditionRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewCondition(ConditionModel conditionModel)
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
                        "dbo.job_AddNewCondition @Description, @CompanyId, @Notes, @CreatedBy", p);

                    return conditionModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateCondition(ConditionModel conditionModel)
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
                        "dbo.job_UpdateCondition @Id, @Description, @Notes, @LastModifiedBy, @LastModifiedDate, @Active",
                        p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteCondition(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Conditions WHERE Id = @Id", p);
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
