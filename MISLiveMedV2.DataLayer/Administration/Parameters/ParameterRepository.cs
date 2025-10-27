using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Administration.Parameters;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Administration.Parameters
{
    public class ParameterRepository : IDisposable
    {

        public IList<ParameterModel> ParametersList()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var parametersRecords =
                        connection.Query<ParameterModel>("SELECT * FROM AppParameters WHERE CompanyId = @CompanyId;", p);
                    return parametersRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ParameterModel ParameterById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var parameterRecord =
                        connection.QuerySingleOrDefault<ParameterModel>("SELECT * FROM AppParameters WHERE Id = @Id;", p);
                    return parameterRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewParameter(ParameterModel parameterModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Code", parameterModel.Code);
                    p.Add("@Description", parameterModel.Description);
                    p.Add("@Value", parameterModel.Value);
                    p.Add("@TextValue", parameterModel.TextValue);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", parameterModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    parameterModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewParameter @Code, @Description, @Value, @TextValue, @CompanyId, @Notes, @CreatedBy", p);

                    return parameterModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateParameter(ParameterModel parameterModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", parameterModel.Id);
                    p.Add("@Description", parameterModel.Description);
                    p.Add("@Notes", parameterModel.Notes);
                    p.Add("@LastModifiedBy", parameterModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", parameterModel.LastModifiedDate);
                    p.Add("@Active", parameterModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateParameter @Id, @Code, @Description, @Value, @TextValue, @Notes, @LastModifiedBy, @LastModifiedDate, @Active",
                        p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteParameter(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM AppParameters WHERE Id = @Id", p);
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
