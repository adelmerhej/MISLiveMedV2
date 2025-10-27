using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.CostSheets;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Costs
{
    public class CostDetailRepository : IDisposable
    {
        public IList<CostDetailModel> SelectCostDetails(bool isAdmin)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@IsAdmin", isAdmin);

                    var costsheetList =
                        connection.Query<CostDetailModel>("SELECT cd.* FROM costsheet_details cd INNER JOIN costsheet c on cd.SheetId = c.Id" +
                                                               " WHERE (@IsAdmin = 1 OR c.Protected = 0) AND c.CompanyId = @CompanyId;", p);
                    return costsheetList.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<CostDetailModel> SelectCostDetailsByJobNo(int jobId, int departmentId, bool isAdmin)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@JobId", jobId);
                    p.Add("@DepartmentId", departmentId);
                    p.Add("@IsAdmin", isAdmin);

                    var costsheetList =
                        connection.Query<CostDetailModel>("SELECT cd.* FROM costsheet_details cd INNER JOIN costsheet c on cd.SheetId = c.Id" +
                                                               " WHERE (@IsAdmin = 1 OR c.Protected = 0) AND c.JobId = @JobId " +
                                                               "AND c.DepartmentId = @DepartmentId AND c.CompanyId = @CompanyId;", p);
                    return costsheetList.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<CostDetailModel> SelectCostDetailsBySheetId(int sheetId, bool isAdmin)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@SheetId", sheetId);
                    p.Add("@IsAdmin", isAdmin);

                    var costsheetList =
                        connection.Query<CostDetailModel>("SELECT cd.* FROM costsheet_details cd INNER JOIN costsheet c on cd.SheetId = c.Id" +
                                                               " WHERE (@IsAdmin = 1 OR c.Protected = 0) AND cd.SheetId = @SheetId " +
                                                               "AND c.CompanyId = @CompanyId;", p);
                    return costsheetList.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CostDetailModel SelectCostDetailsById(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    var costsheetRecord =
                        connection.QuerySingleOrDefault<CostDetailModel>("SELECT * FROM costsheet_details WHERE Id = @Id;", p);
                    return costsheetRecord;
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
