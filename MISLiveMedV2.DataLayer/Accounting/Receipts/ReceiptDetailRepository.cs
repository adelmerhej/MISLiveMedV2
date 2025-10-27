using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Receipts;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Receipts
{
    public class ReceiptDetailRepository : IDisposable
    {

        public IList<ReceiptDetailModel> SelectReceiptsDetails()
        {
            try
            {
                var p = new DynamicParameters();
                p.Add("@Id", CurrentUser.CompanyId);

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var receiptsDetails =
                        connection.Query<ReceiptDetailModel>("SELECT * FROM ReceiptsDetails WHERE CompanyId = 1;", p);
                    return receiptsDetails.ToList();
                }
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

        }

        #endregion
    }
}
