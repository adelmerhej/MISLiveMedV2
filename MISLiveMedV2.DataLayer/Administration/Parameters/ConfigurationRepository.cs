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
    public class ConfigurationRepository : IDisposable
    {
        public IList<ConfigurationModel> ConfigurationsList()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var configurationsRecords =
                        connection.Query<ConfigurationModel>("SELECT * FROM Configurations WHERE CompanyId = @CompanyId;", p);
                    return configurationsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ConfigurationModel ConfigurationById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var configurationRecord =
                        connection.QuerySingleOrDefault<ConfigurationModel>("SELECT * FROM Configurations WHERE Id = @Id;", p);
                    return configurationRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewConfiguration(ConfigurationModel configurationModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Code", configurationModel.Code);
                    p.Add("@Description", configurationModel.Description);
                    p.Add("@Value", configurationModel.Value);
                    p.Add("@TextValue", configurationModel.TextValue);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", configurationModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    configurationModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewConfiguration @Code, @Description, @Value, @TextValue, @CompanyId, @Notes, @CreatedBy", p);

                    return configurationModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateConfiguration(ConfigurationModel configurationModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", configurationModel.Id);
                    p.Add("@Description", configurationModel.Description);
                    p.Add("@Notes", configurationModel.Notes);
                    p.Add("@LastModifiedBy", configurationModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", configurationModel.LastModifiedDate);
                    p.Add("@Active", configurationModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateConfiguration @Id, @Code, @Description, @Value, @TextValue, @Notes, @LastModifiedBy, @LastModifiedDate, @Active",
                        p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteConfiguration(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Configurations WHERE Id = @Id", p);
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
