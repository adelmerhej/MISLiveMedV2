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
    public class AgentCategoryRepository
    {
        public IList<AgentCategoryModel> SelectAgentCategories(bool showOnlyActive = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@Active", showOnlyActive);

					var agentCategoryRecords =
                        connection.Query<AgentCategoryModel>("SELECT * FROM AgentCategories " +
                                                             "WHERE (@Active = 0 OR Active = @Active) " +
                                                             "AND CompanyId = @CompanyId;", p);
                    return agentCategoryRecords.ToList();
                }
            }
            catch (Exception e)
            {
				throw new Exception(e.Message);
			}
        }

        public AgentCategoryModel SelectAgentCategoryById(int agentCategoryId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", agentCategoryId);

                    var agentCategoryRecord =
                        connection.QuerySingleOrDefault<AgentCategoryModel>("SELECT * FROM AgentCategories WHERE Id = @Id;", p);
                    return agentCategoryRecord;
                }
            }
            catch (Exception e)
            {
				throw new Exception(e.Message);
			}
        }

        public int AddNewAgentCategory(AgentCategoryModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Name", dataModel.Name);

                    p.Add("@Notes", dataModel.Notes);
                    p.Add("@CompanyId", dataModel.CompanyId);
                    p.Add("@BranchId", dataModel.BranchId);
                    p.Add("@CreatedBy", dataModel.CreatedBy);
                    p.Add("@IsProtected", dataModel.IsProtected);

                    dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO AgentCategories (Name, Notes, CompanyId, BranchId, CreatedBy, IsProtected) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@Name, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p);


					return dataModel.Id;
                }
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool UpdateAgentCategory(AgentCategoryModel dataModel)
        {
            try
            {
	            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
	            {
		            var p = new DynamicParameters();
		            p.Add("@Id", dataModel.Id);
		            p.Add("@Name", dataModel.Name);

		            p.Add("@Notes", dataModel.Notes);
		            p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
		            p.Add("@IsProtected", dataModel.IsProtected);
		            p.Add("@Active", dataModel.Active);

		            _ = connection.ExecuteScalar<int>(
						"UPDATE AgentCategories SET " +
			            "Name = @Name, Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
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

        public bool DeleteAgentCategory(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM AgentCategories WHERE Id = @Id", p);
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
