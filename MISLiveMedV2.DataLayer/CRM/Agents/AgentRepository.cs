using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.CRM.Agents
{
    public class AgentRepository : IDisposable
    {
	    public IList<InitDataObjectModel> SelectMembers(bool showOnlyActive = false, bool showProtected = false)
	    {
		    try
		    {
			    using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			    {
				    var p = new DynamicParameters();
				    p.Add("@CompanyId", CurrentUser.CompanyId);
				    p.Add("@Active", showOnlyActive);
				    p.Add("@ShowProtected", showProtected);

				    var agentsRecord =
					    connection.Query<InitDataObjectModel>("SELECT Id as Value, AgentName as Name FROM Agents " +
					                                          "WHERE (@ShowProtected = 1 OR IsProtected = 0) " +
					                                          "AND (@Active = 0 OR Active = @Active) " +
					                                          "AND CompanyId = @CompanyId;", p);
				    return agentsRecord.ToList();
			    }
		    }
		    catch (Exception e)
		    {
			    throw new Exception(e.Message);
		    }
	    }

	    public IList<AgentModel> SelectAgents(bool showOnlyActive = false, bool showProtected = false)
	    {
		    try
		    {
			    using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			    {
				    var p = new DynamicParameters();
				    p.Add("@CompanyId", CurrentUser.CompanyId);
				    p.Add("@Active", showOnlyActive);
				    p.Add("@ShowProtected", showProtected);

				    var agentsRecord =
					    connection.Query<AgentModel>("SELECT * FROM Agents " +
					                                 "WHERE (@ShowProtected = 1 OR IsProtected = 0) " +
					                                 "AND (@Active = 0 OR Active = @Active) " +
					                                 "AND CompanyId = @CompanyId;", p);
				    return agentsRecord.ToList();
			    }
		    }
		    catch (Exception e)
		    {
			    throw new Exception(e.Message);
		    }
	    }

		public AgentModel SelectAgentById(int agentId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", agentId);

                    var agentRecord =
                        connection.QuerySingleOrDefault<AgentModel>("SELECT * FROM Agents WHERE Id = @Id;", p);
                    return agentRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IList<AgentModel> SelectAgentByCategoryId(int categoryId, bool showOnlyActive = false, bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@CategoryId", categoryId);
                    p.Add("@ShowOnlyActive", showProtected);
                    p.Add("@ShowProtected", showProtected);

                    var agentRecord =
                        connection.Query<AgentModel>("SELECT * FROM Agents " +
                                                     "WHERE (@ShowOnlyActive = 0 OR Active = 1) AND (@ShowProtected = 1 OR IsProtected = 0) " +
                                                     "AND CompanyId = @CompanyId;", p);
                    return agentRecord.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewAgent(AgentModel agentModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@AgentName", agentModel.AgentName);
                    p.Add("@MemberOfId", agentModel.MemberOfId);
                    p.Add("@ActiveDate", agentModel.ActiveDate);
                    p.Add("@FollowupDate", agentModel.FollowupDate);
                    p.Add("@CountryId", agentModel.CountryId);
                    p.Add("@CityId", agentModel.CityId);
                    p.Add("@AgentGroupId", agentModel.AgentGroupId);
                    p.Add("@AgentCategoryId", agentModel.AgentCategoryId);
                    p.Add("@Address", agentModel.Address);
                    p.Add("@PhoneNumber1", agentModel.PhoneNumber1);
                    p.Add("@PhoneNumber2", agentModel.PhoneNumber2);
                    p.Add("@PhoneNumber3", agentModel.PhoneNumber3);
                    p.Add("@FaxNumber", agentModel.FaxNumber);
                    p.Add("@Website", agentModel.Website);
                    p.Add("@MofNo", agentModel.MofNo);
                    p.Add("@Email", agentModel.Email);
                    p.Add("@Activity", agentModel.Activity);
                    p.Add("@IsSales", agentModel.IsSales);
                    p.Add("@ResponsibleId", agentModel.ResponsibleId);
                    p.Add("@SalesId", agentModel.SalesId);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", agentModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    agentModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_InsertAgent @AgentName, @MemberOfId, @ActiveDate, @FollowupDate, @CountryId, @CityId, " +
                        "@AgentGroupId, @AgentCategoryId, @Address, @PhoneNumber1, @PhoneNumber2, @PhoneNumber3, @FaxNumber, " +
                        "@Website, @MofNo, @Email, @Activity, @IsSales, @ResponsibleId, @SalesId, @CompanyId, @Notes, @CreatedBy", p);

                    return agentModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateAgent(AgentModel agentModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", agentModel.Id);
                    p.Add("@AgentName", agentModel.AgentName);
                    p.Add("@MemberOfId", agentModel.MemberOfId);
                    p.Add("@ActiveDate", agentModel.ActiveDate);
                    p.Add("@FollowupDate", agentModel.FollowupDate);
                    p.Add("@CountryId", agentModel.CountryId);
                    p.Add("@CityId", agentModel.CityId);
                    p.Add("@AgentGroupId", agentModel.AgentGroupId);
                    p.Add("@AgentCategoryId", agentModel.AgentCategoryId);
                    p.Add("@Address", agentModel.Address.Trim());
                    p.Add("@PhoneNumber1", agentModel.PhoneNumber1);
                    p.Add("@PhoneNumber2", agentModel.PhoneNumber2);
                    p.Add("@PhoneNumber3", agentModel.PhoneNumber3);
                    p.Add("@FaxNumber", agentModel.FaxNumber);
                    p.Add("@Website", agentModel.Website);
                    p.Add("@MofNo", agentModel.MofNo);
                    p.Add("@Email", agentModel.Email);
                    p.Add("@Activity", agentModel.Activity);
                    p.Add("@IsSales", agentModel.IsSales);
                    p.Add("@ResponsibleId", agentModel.ResponsibleId);
                    p.Add("@SalesId", agentModel.SalesId);
                    p.Add("@Notes", agentModel.Notes);
                    p.Add("@LastModifiedBy", agentModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", agentModel.LastModifiedDate);
                    p.Add("@Active", agentModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateAgent @Id, @AgentName, @MemberOfId, @ActiveDate, @FollowupDate, @CountryId, @CityId, " +
                        "@AgentGroupId, @AgentCategoryId, @Address, @PhoneNumber1, @PhoneNumber2, @PhoneNumber3, @FaxNumber, " +
                        "@Website, @MofNo, @Email, @Activity, @IsSales, @ResponsibleId, @SalesId, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteAgent(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Agents WHERE Id = @Id", p);
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

        public void Dispose()
        {

        }

        #endregion

    }
}
