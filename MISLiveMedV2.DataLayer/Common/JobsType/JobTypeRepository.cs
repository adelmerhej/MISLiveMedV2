using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.JobsType;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.JobsType
{
    public class JobTypeRepository : IDisposable
    {
        public IList<JobTypeModel> SelectJobsType(bool showOnlyActive = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Active", showOnlyActive);

					var jobsType =
                        connection.Query<JobTypeModel>("SELECT * FROM JobsType " +
                                                       "WHERE (@Active = 0 OR Active = @Active) " +
                                                       "AND CompanyId = @CompanyId;", p);
					return jobsType.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public JobTypeModel SelectJobTypeById(int jobTypeId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", jobTypeId);

                    var jobType =
                        connection.QuerySingleOrDefault<JobTypeModel>("SELECT * FROM JobsType WHERE Id = @Id;", p);
                    return jobType;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewJobType(JobTypeModel dataModel)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var p = new DynamicParameters();
			        p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
			        p.Add("@Description", dataModel.Description);

			        p.Add("@Notes", dataModel.Notes);
			        p.Add("@CompanyId", dataModel.CompanyId);
			        p.Add("@BranchId", dataModel.BranchId);
			        p.Add("@CreatedBy", dataModel.CreatedBy);
			        p.Add("@IsProtected", dataModel.IsProtected);

			        dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO JobsType (Description, Notes, CompanyId, BranchId, CreatedBy, IsProtected) " +
				        "OUTPUT Inserted.Id " +
						"VALUES (@Description, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p);


			        return dataModel.Id;
		        }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
	        }
		}

        public bool UpdateJobType(JobTypeModel dataModel)
        {
	        try
	        {
		        using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
		        {
			        var p = new DynamicParameters();
			        p.Add("@Id", dataModel.Id);
			        p.Add("@Name", dataModel.Description);

			        p.Add("@Notes", dataModel.Notes);
			        p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
			        p.Add("@IsProtected", dataModel.IsProtected);
			        p.Add("@Active", dataModel.Active);

			        _ = connection.ExecuteScalar<int>(
						"UPDATE JobsType SET " +
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

        public bool DeleteJobType(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM JobsType WHERE Id = @Id", p);
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
            throw new NotImplementedException();
        }

        #endregion
    }
}
