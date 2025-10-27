using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Reports.DOPBalances;

namespace MISLiveMed.DataLayers.Reports.DOPBalances
{
    public class DopBalanceRepository
    {

        public IEnumerable<DopMemberModel> DopBalanceProfit(DateTime? dateFrom = null, DateTime? dateTo = null, bool provision = true)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DateFrom", dateFrom);
                    p.Add("@DateTo", dateTo);
                    p.Add("@Provision", provision);

                    var salesList =
                        connection.Query<DopMemberModel>("dbo._DopBalanceProfit @DateFrom, @DateTo, @Provision", p);

                    return salesList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<DopMemberModel> DopSuppliersByName(DateTime? dateFrom = null, DateTime? dateTo = null, bool provision = true)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DateFrom", dateFrom);
                    p.Add("@DateTo", dateTo);
                    p.Add("@Provision", provision);

                    var salesList =
                        connection.Query<DopMemberModel>("dbo._dop_SuppliersByName @DateFrom, @DateTo, @Provision", p);

                    return salesList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }

        }

        public IEnumerable<DopMemberModel> DopCustomersByName(DateTime? dateFrom = null, DateTime? dateTo = null, bool provision = true)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@DateFrom", dateFrom);
                    p.Add("@DateTo", dateTo);
                    p.Add("@Provision", provision);

                    var salesList =
                        connection.Query<DopMemberModel>("dbo._dop_CustomersByName @DateFrom, @DateTo, @Provision", p);

                    return salesList;
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
