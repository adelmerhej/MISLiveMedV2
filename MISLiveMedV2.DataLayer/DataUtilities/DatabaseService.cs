using Dapper;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MISLiveMed.DataLayers.DataUtilities
{
	public class DatabaseService : IDatabaseService
	{
		private readonly string _connectionString;
		//private readonly ILogger<DatabaseService> _logger;

		//public DatabaseService(IConfiguration configuration, ILogger<DatabaseService> logger = null)
		//{
		//	_connectionString = configuration.GetConnectionString("DefaultConnection");
		//	_logger = logger;
		//}

		#region Implementation of IDatabaseService

		/// <summary>
		/// Returns formatted server datetime string
		/// </summary>
		public string GetServerDateTime()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var serverDateTime = connection.ExecuteScalar<DateTime>("SELECT GETDATE()");
					return FormatDateTime(serverDateTime);
				}
			}
			catch (Exception ex)
			{
				//_logger?.LogError(ex, "Error getting server datetime");

				// Fallback to local datetime if SQL Server is unavailable
				return FormatDateTime(DateTime.Now);
			}
		}

		/// <summary>
		/// Returns raw DateTime object from server
		/// </summary>
		public DateTime GetServerDateTimeRaw()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					return connection.ExecuteScalar<DateTime>("SELECT GETDATE()");
				}
			}
			catch (Exception)
			{
				// Return local DateTime directly, not formatted string
				return DateTime.Now;
			}
		}

		#endregion

		/// <summary>
		/// Format DateTime to match original VB6 format
		/// </summary>
		private static string FormatDateTime(DateTime dateTime)
		{
			// "M/d/yyyy h:mm:ss tt" matches "M/d/yyyy h:mm:ss AMPM"
			return dateTime.ToString("M/d/yyyy h:mm:ss tt");
		}
	}
}
