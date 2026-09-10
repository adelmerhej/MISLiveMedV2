using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Export.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MISLiveMed.DataLayers.JobData.SeaExport
{
	public class JobSeaExportDetailRepository : IDisposable
	{
		public IList<JobSeaExportDetailModel> JobsSeaExportDetail(bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@IsProtected", showProtected);

					var jobsList =
						connection.Query<JobSeaExportDetailModel>("SELECT * FROM JobSExportDetail " +
																   "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
																   "AND CompanyId = @CompanyId;", p);

					return jobsList.ToList();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw new Exception(e.Message);
			}
		}


		public IList<JobSeaExportDetailModel> JobsSeaExportDetailByJobNo(int jobNo)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@jobNo", jobNo);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var jobsList =
						connection.Query<JobSeaExportDetailModel>("SELECT * FROM JobSExportDetail " +
																  "WHERE CompanyId = @CompanyId AND JobId = @jobNo;", p);

					return jobsList.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


		#region Implementation of IDisposable

		public void Dispose()
		{

		}

		#endregion
	}
}
