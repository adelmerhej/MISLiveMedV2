using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Quotations;

namespace MISLiveMed.DataLayers.CRM.Quotations
{
    public class QuotationHeaderCostSellingRepository : IDisposable
    {
        public IList<QuotationHeaderCostSellingModel> QuotationHeaderList(int quotationId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", quotationId);

                    var quotationsRecords =
                        connection.Query<QuotationHeaderCostSellingModel>("SELECT * FROM QuotationHeaderCostSelling " +
                                        "WHERE QuotationId = @QuotationId ", p);

                    return quotationsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public QuotationHeaderCostSellingModel QuotationHeaderByVersionNo(int quotationId, int versionNo)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", quotationId);
                    p.Add("@VersionNo", versionNo);

                    var quotationsRecords =
                        connection.QuerySingleOrDefault<QuotationHeaderCostSellingModel>("SELECT * FROM QuotationHeaderCostSelling " +
                                            "WHERE QuotationId = @QuotationId AND VersionNo = @VersionNo", p);

                    return quotationsRecords;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public QuotationHeaderCostSellingModel QuotationHeaderById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var quotationsRecords =
                        connection.QuerySingleOrDefault<QuotationHeaderCostSellingModel>("SELECT * FROM QuotationHeaderCostSelling " +
                            "WHERE Id = @Id;", p);

                    return quotationsRecords;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int FindRelatedJobNo(int pRefNo, int pDepartmentId, string pDepartmentPrefix)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@RefNo", pRefNo);
                    p.Add("@DepartmentId", pDepartmentId);
                    p.Add("@DepartmentPrefix", pDepartmentPrefix);

                    var jobNo =
                        connection.ExecuteScalar<int>("dbo.XOGetJobNO @RefNo, @DepartmentId, @DepartmentPrefix", p);

                    return jobNo;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public int NewVersionNo(int departmentId = 0, int quotationId = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DepartmentId", departmentId);
                    p.Add("@QuotationId", quotationId);

                    var quotationLastVersion =
                        connection.ExecuteScalar<int>("SELECT isnull(max(VersionNo) , 0) + 1" +
                                                    "FROM dbo.QuotationHeaderCostSelling " +
                                                    "WHERE DepartmentId = @DepartmentId and QuotationId = @QuotationId", p);

                    return quotationLastVersion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public QuotationHeaderCostSellingModel QuotationLastVersion(int pId = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", pId);

                    var quotationLastVersion =
                        connection.QuerySingle<QuotationHeaderCostSellingModel>("dbo.job_QuotationLastVersion @Id", p);

                    return quotationLastVersion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }
        public void CancelQuotation(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", id);

                _ = connection.ExecuteScalar("UPDATE Quotations set Canceled = 1, CanceledDate = GETDATE() WHERE Id = @Id;", p);
            }
        }

        #region Implementation of IDisposable

        public void Dispose()
        {

        }

        #endregion
    }
}
