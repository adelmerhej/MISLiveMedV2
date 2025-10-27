using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.CRM.Quotations
{
    public class QuotationSellingRepository
    {
        public IList<QuotationSellingModel> SelectQuotationSelling()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var quotationsRecords =
                        connection.Query<QuotationSellingModel>("SELECT * FROM QuotationSelling WHERE CompanyId = @CompanyId AND Active = 1;", p);
                    return quotationsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<QuotationSellingModel> SelectSellingByQuotationId(int pQuotationId = 0, int pVersionNo = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", pQuotationId);
                    p.Add("@VersionNo", pVersionNo);

                    var quotationsCostList =
                        connection.Query<QuotationSellingModel>("dbo.job_SelectSellingByQuotationId @QuotationId, @VersionNo", p);

                    return quotationsCostList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public IList<QuotationSellingPriceModel> TotalQuotationsSellingCost(int pQuotationId = 0, int pVersionNo = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", pQuotationId);
                    p.Add("@VersionNo", pVersionNo);

                    var quotationsSellingList =
                        connection.Query<QuotationSellingPriceModel>("dbo.job_GetTotalSellingQuotations @QuotationId, @VersionNo", p);

                    return quotationsSellingList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

    }
}
