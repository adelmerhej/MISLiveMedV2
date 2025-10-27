using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Payments;

namespace MISLiveMed.DataLayers.Common.Payments
{
    public class PaymentMethodRepository
    {
        public IList<PaymentMethodModel> SelectPaymentsMethod(bool isActive = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Active", isActive);

                    var paymentsList =
                        connection.Query<PaymentMethodModel>("SELECT * FROM MethodOfPayment " +
                                                             "WHERE (@Active = 0 or Active = @Active)", p);

                    return paymentsList.ToList();
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
