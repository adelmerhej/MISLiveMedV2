using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Invoices;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Invoices
{
    public class InvoiceDetailRepository : IDisposable
    {
        public IList<InvoiceDetailModel> SelectInvoiceDetails(bool isAdmin)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Protected", 0);

                    var invoices =
                        connection.Query<InvoiceDetailModel>("SELECT ind.* FROM invoice_details ind INNER JOIN invoices i on ind.InvoiceId = i.Id" +
                                                             " WHERE (i.Protected = 0) AND i.CompanyId = @CompanyId;", p);
                    return invoices.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<InvoiceDetailModel> SelectInvoiceDetailByJobNo(int jobId, int departmentId, bool isAdmin)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@JobId", jobId);
                    p.Add("@DepartmentId", departmentId);
                    p.Add("@IsAdmin", isAdmin);

                    var invoices =
                        connection.Query<InvoiceDetailModel>("SELECT ind.* FROM invoice_details ind INNER JOIN invoices i on ind.InvoiceId = i.Id" +
                                                             " WHERE (@IsAdmin = 1 OR i.Protected = 0) AND i.JobId = @JobId " +
                                                             "AND i.DepartmentId = @DepartmentId AND c.CompanyId = @CompanyId;", p);
                    return invoices.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<InvoiceDetailModel> SelectInvoiceDetailByInvoiceId(int invoiceId, bool isAdmin)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@InvoiceId", invoiceId);
                    p.Add("@IsAdmin", isAdmin);

                    var invoices =
                        connection.Query<InvoiceDetailModel>("SELECT ind.* FROM invoice_details ind INNER JOIN invoices i on ind.InvoiceId = i.Id" +
                                                             " WHERE (@IsAdmin = 1 OR i.Protected = 0) AND ind.InvoiceId = @InvoiceId " +
                                                             "AND i.CompanyId = @CompanyId;", p);
                    return invoices.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public InvoiceDetailModel SelectInvoiceById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var invoiceRecord =
                        connection.QuerySingleOrDefault<InvoiceDetailModel>("SELECT * FROM invoice_details WHERE Id = @Id;", p);
                    return invoiceRecord;
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
