using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Items;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Items
{
    public class ItemRepository : IDisposable
    {

        public IList<ItemModel> SelectItems()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var items =
                        connection.Query<ItemModel>("Select * from Items WHERE CompanyId = @CompanyId;", p);
                    return items.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ItemModel SelectItemById(int itemId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", itemId);

                    var itemRecord =
                        connection.QuerySingleOrDefault<ItemModel>("SELECT * FROM Items WHERE Id = @Id;", p);
                    return itemRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<ItemModel> SelectItemsByDepartment(int itemId = 0, int departmentId = 0, int isDefault = 1)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@ItemId", itemId);
                    p.Add("@DepartmentId", departmentId);
                    p.Add("@IsDefault", isDefault);

                    var itemsList =
                        connection.Query<ItemModel>("dbo.job_GetItemsByDepartment @ItemId, @DepartmentId, @IsDefault", p);

                    return itemsList.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
