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
    public class QuotationCostRepository
    {
        public IList<QuotationCostModel> SelectQuotationsRealCost()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var quotationsRecords =
                        connection.Query<QuotationCostModel>("SELECT * FROM QuotationRealCost WHERE CompanyId = @CompanyId AND Active = 1;", p);
                    return quotationsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<QuotationCostModel> SelectRealCostByQuotationId(int pQuotationId = 0, int pVersionNo = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", pQuotationId);
                    p.Add("@VersionNo", pVersionNo);

                    var quotationsCostList =
                        connection.Query<QuotationCostModel>("dbo.job_SelectRealCostByQuotationId @QuotationId, @VersionNo", p);

                    return quotationsCostList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public IList<QuotationCostPriceModel> TotalQuotationCostPrice(int pQuotationId = 0, int pVersionNo = 0)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@QuotationId", pQuotationId);
                    p.Add("@VersionNo", pVersionNo);

                    var recordsCostPriceModels =
                        connection.Query<QuotationCostPriceModel>("dbo.job_SelectRealCostQuotations_V001 @QuotationId, @VersionNo", p);

                    return recordsCostPriceModels.ToList();
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
