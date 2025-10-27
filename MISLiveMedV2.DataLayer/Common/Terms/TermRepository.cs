using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Terms;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Terms
{
    public class TermRepository : IDisposable
    {
        public IList<TermsModel> SelectTerms()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var seaportsRecords =
                        connection.Query<TermsModel>("SELECT * FROM Terms WHERE CompanyId = @CompanyId;", p);
                    return seaportsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TermsModel SelectTermById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var termRecord =
                        connection.QuerySingleOrDefault<TermsModel>("SELECT * FROM Terms WHERE Id = @Id;", p);
                    return termRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewTerm(TermsModel termsModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@TermCode", termsModel.TermCode);
                    p.Add("@Description", termsModel.Description);
                    p.Add("@CompanyId", termsModel.CompanyId);
                    p.Add("@Notes", termsModel.Notes);
                    p.Add("@CreatedBy", termsModel.CreatedBy);

                    termsModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewTerm @TermCode, @Description, @CompanyId, @Notes, @CreatedBy", p);

                    return termsModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateTerm(TermsModel termsModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", termsModel.Id);
                    p.Add("@TermCode", termsModel.TermCode);
                    p.Add("@Description", termsModel.Description);
                    p.Add("@Notes", termsModel.Notes);
                    p.Add("@LastModifiedBy", termsModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", termsModel.LastModifiedDate);
                    p.Add("@Active", termsModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateTerm @Id, @TermCode, @Description, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteTerm(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Terms WHERE Id = @Id", p);
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
