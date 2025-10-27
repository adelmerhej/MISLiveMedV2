using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Charts;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Charts
{
	public class ChartDetailRepository : IDisposable
	{
		public IList<ChartDetailModel> SelectChartDetails()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<ChartDetailModel>("SELECT * FROM ChartsDetails WHERE CompanyId = @CompanyId ORDER BY ParentId;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<ChartDetailModel> SelectChartDetails(int chartId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ChartId", chartId);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<ChartDetailModel>("SELECT * FROM ChartsDetails " +
						                                   "WHERE ChartId = @ChartId AND CompanyId = @CompanyId " +
														   "ORDER BY ChartId, CurrencyId;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<ChartDetailModel> SelectChartDetails(string number, string serial, string currency)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<ChartDetailModel>("SELECT * FROM ChartsDetails WHERE CompanyId = @CompanyId ORDER BY ParentId;", p);
					return records.ToList();
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
