using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Reports.Settings;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Reports.Settings
{
    public class BalanceSheetSettingRepository : IDisposable
	{
		public IList<BalanceSheetSettingModel> SelectBalanceSheetSettings()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<BalanceSheetSettingModel>("SELECT * FROM BalanceSheetSettings WHERE CompanyId = @CompanyId;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public BalanceSheetSettingModel SelectBalanceSheetSettingById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					var record =
						connection.QuerySingleOrDefault<BalanceSheetSettingModel>("SELECT * FROM BalanceSheetSettings WHERE Id = @Id;", p);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewBalanceSheetSetting(BalanceSheetSettingModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);

					p.Add("@BalanceHeaderId", dataModel.BalanceHeaderId);
					p.Add("@ParentId", dataModel.ParentId);
					p.Add("@AccountNumber", dataModel.AccountNumber);
					p.Add("@Description", dataModel.Description);
					p.Add("@DbCr", dataModel.DbCr);
					p.Add("@ColumnFirst", dataModel.ColumnFirst);
					p.Add("@ColumnSecond", dataModel.ColumnSecond);
					p.Add("@OrderInList", dataModel.OrderInList);
					p.Add("@IsTotal", dataModel.IsTotal);
					p.Add("@IsGrandTotal", dataModel.IsGrandTotal);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
					"INSERT INTO BalanceSheetSettings (BalanceHeaderId, ParentId, AccountNumber, Description, DbCr, ColumnFirst, ColumnSecond, " +
							"OrderInList, IsTotal, IsGrandTotal, Notes, CompanyId, BranchId, CreatedBy, IsProtected) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@BalanceHeaderId, @ParentId, @AccountNumber, @Description, @DbCr, @ColumnFirst, @ColumnSecond, " +
							"@OrderInList, @IsTotal, @IsGrandTotal, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p)
						;
					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateBalanceSheetSetting(BalanceSheetSettingModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@BalanceHeaderId", dataModel.BalanceHeaderId);
					p.Add("@ParentId", dataModel.ParentId);
					p.Add("@AccountNumber", dataModel.AccountNumber);
					p.Add("@Description", dataModel.Description);
					p.Add("@DbCr", dataModel.DbCr);
					p.Add("@ColumnFirst", dataModel.ColumnFirst);
					p.Add("@ColumnSecond", dataModel.ColumnSecond);
					p.Add("@OrderInList", dataModel.OrderInList);
					p.Add("@IsTotal", dataModel.IsTotal);
					p.Add("@IsGrandTotal", dataModel.IsGrandTotal);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
						"UPDATE BalanceSheetSettings SET " +
							"BalanceHeaderId = @BalanceHeaderId, ParentId = @ParentId, AccountNumber = @AccountNumber, Description = @Description, " +
							"DbCr = @DbCr, ColumnFirst = @ColumnFirst, ColumnSecond = @ColumnSecond, OrderInList = @OrderInList, " +
							"IsTotal = @IsTotal, IsGrandTotal = @IsGrandTotal, Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
							"LastModifiedDate= GETDATE(), IsProtected = @IsProtected, Active = @Active " +
							"WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteBalanceSheetSetting(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM BalanceSheetSettings WHERE Id = @Id", p);
				}

				return true;
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
