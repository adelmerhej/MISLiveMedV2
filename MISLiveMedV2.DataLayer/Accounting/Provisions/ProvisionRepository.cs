using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Provisions;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.Accounting.Provisions
{
    public class ProvisionRepository : IDisposable
    {
        public IList<ProvisionModel> SelectProvisions()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var records =
                        connection.Query<ProvisionModel>("SELECT * FROM _Provisions WHERE CompanyId = @CompanyId;", p);
                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<ProvisionModel> SelectProvisionsByTypeId(ProvisionsType provisionTypeId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@provisionTypeId", provisionTypeId);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var records =
                        connection.Query<ProvisionModel>("SELECT * FROM _Provisions WHERE ProvisionTypeId = @ProvisionTypeId " +
                                                         "AND CompanyId = @CompanyId;", p);
                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ProvisionModel SelectProvisionById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var record =
                        connection.QueryFirstOrDefault<ProvisionModel>("SELECT * FROM _Provisions WHERE Id = @Id;", p);
                    return record;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewProvision(ProvisionModel provisionModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@ProvisionTypeId", provisionModel.ProvisionTypeId);
                    p.Add("@ProvisionDate", provisionModel.ProvisionDate);
                    p.Add("@CurrencyId", provisionModel.CurrencyId);
                    p.Add("@Rate", provisionModel.Rate);
                    p.Add("@Amount", provisionModel.Amount);
                    p.Add("@LAmount", provisionModel.LAmount);
                    p.Add("@FAmount", provisionModel.FAmount);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", provisionModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    provisionModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewProvision @ProvisionTypeId, @ProvisionDate, @CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @CompanyId, @Notes, @CreatedBy;", p);

                    return provisionModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateProvision(ProvisionModel provisionModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", provisionModel.Id);
                    p.Add("@ProvisionTypeId", provisionModel.ProvisionTypeId);
                    p.Add("@ProvisionDate", provisionModel.ProvisionDate);
                    p.Add("@CurrencyId", provisionModel.CurrencyId);
                    p.Add("@Rate", provisionModel.Rate);
                    p.Add("@Amount", provisionModel.Amount);
                    p.Add("@LAmount", provisionModel.LAmount);
                    p.Add("@FAmount", provisionModel.FAmount);
                    p.Add("@Notes", provisionModel.Notes);
                    p.Add("@LastModifiedBy", provisionModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", provisionModel.LastModifiedDate);
                    p.Add("@Active", provisionModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateProvision @Id, @ProvisionTypeId, @ProvisionDate, @CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @Notes, " +
                        "@LastModifiedBy, @LastModifiedDate, @Active",
                        p);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public bool DeleteProvision(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM _Provisions WHERE Id = @Id", p);
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