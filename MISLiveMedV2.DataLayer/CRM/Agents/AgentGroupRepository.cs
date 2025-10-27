using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.CRM.Agents
{
    public class AgentGroupRepository : IDisposable
    {
        public IList<AgentGroupModel> SelectAgentsGroup()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {

                    var agentsGroupRecord =
                        connection.Query<AgentGroupModel>("SELECT * FROM AgentGroup WHERE Active = 1;");
                    return agentsGroupRecord.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public AgentGroupModel SelectAgentGroupById(int continentId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", continentId);

                    var agentGroupRecord =
                        connection.QuerySingleOrDefault<AgentGroupModel>("SELECT * FROM AgentGroup WHERE Id = @Id;", p);
                    return agentGroupRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewAgentGroup(AgentGroupModel agentGroupModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Description", agentGroupModel.Description);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", agentGroupModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    agentGroupModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_InsertAgentGroup @Description, @CompanyId, @Notes, @CreatedBy", p);

                    return agentGroupModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateAgentGroup(AgentGroupModel agentGroupModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", agentGroupModel.Id);
                    p.Add("@Description", agentGroupModel.Description);
                    p.Add("@Notes", agentGroupModel.Notes);
                    p.Add("@LastModifiedBy", agentGroupModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", agentGroupModel.LastModifiedDate);
                    p.Add("@Active", agentGroupModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateAgentGroup @Id, @Description, @Notes, @LastModifiedBy, @LastModifiedDate, @Active",
                        p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteAgentGroup(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM AgentGroup WHERE Id = @Id", p);
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
