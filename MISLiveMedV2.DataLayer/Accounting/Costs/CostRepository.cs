using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.CostSheets;
using MISLiveMed.Models.Models.Accounting.Invoices;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Costs
{
    public class CostRepository : IDisposable
    {
        public IList<CostModel> SelectCosts(bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@ShowProtected", showProtected);

                    var costsheetList =
                        connection.Query<CostModel>("SELECT * FROM costsheet WHERE (@ShowProtected = 1 OR IsProtected = 0) " +
                                                         "AND DepartmentId = @DepartmentId " +
                                                         "AND CompanyId = @CompanyId;", p);
                    return costsheetList.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<CostModel> SelectCostByJobNo(int jobId, int departmentId, bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@JobId", jobId);
                    p.Add("@DepartmentId", departmentId);
                    p.Add("@ShowProtected", showProtected);

                    var costsheetList =
                        connection.Query<CostModel>("SELECT * FROM costsheet WHERE (@ShowProtected = 1 OR IsProtected = 0) " +
                                                         "AND JobId = @jobId AND DepartmentId = @DepartmentId " +
                                                         "AND CompanyId = @CompanyId;", p);
                    return costsheetList.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CostModel SelectCostById(int id, int departmentId, bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);
                    p.Add("@DepartmentId", departmentId);
                    p.Add("@ShowProtected", showProtected);
                    var costsheetRecord =
                        connection.QuerySingleOrDefault<CostModel>("SELECT * FROM costsheet WHERE (@ShowProtected = 1 OR IsProtected = 0) " +
                                                                   "AND DepartmentId = @DepartmentId AND Id = @Id;", p);
                    return costsheetRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewCost(CostModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);




                    dataModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewCost @PaymentDate, @ActionType, @PaymentTypeId, @JobId, @DepartmentId, @ReferenceId, @MemberTypeId, @MemberId, " +
                        "@CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @Discount, @Paid, @Posted, @IsProtected, @CompanyId, @Notes, @CreatedBy", p);


                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdateCost(InvoiceModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", dataModel.Id);




                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateCost @Id, @PaymentDate, @ActionType, @PaymentTypeId, @JobId, @DepartmentId, @ReferenceId, @MemberTypeId, @MemberId, " +
                        "@CurrencyId, @Rate, @Amount, @LAmount, @FAmount, @Discount, @Paid, @Posted, @IsProtected, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);

                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteCost(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM costsheet WHERE Id = @Id", p);
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
