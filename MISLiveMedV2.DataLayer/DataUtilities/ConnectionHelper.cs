using System;
using System.Data.Common;
using System.Data.SqlClient;
using MISLiveMed.DataLayers.DataAccess;
using MISLiveMed.Models.Models.Administration.Connections;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.DataLayers.DataUtilities
{
	internal static class ConnectionHelper
	{
		private static ConnectionModel _connectionModel = new ConnectionModel();

		public static string BuildConnectionString(bool includeDatabaseName = true)
		{
			_connectionModel = DatabaseFactory.ConnectionParamsGet();

			string connectionString = string.Concat("Server=", _connectionModel.DatabaseHost, ";" +
				"User Id=", _connectionModel.DatabaseUser, ";Password=", _connectionModel.DatabasePassword);

			if (includeDatabaseName)
			{
				connectionString = connectionString + ";Database=" + _connectionModel.DatabaseName;
			}
			return connectionString;
		}

		public static DbConnection DataConnection()
		{
			switch ((DatabaseTypes)Enum.Parse(typeof(DatabaseTypes), _connectionModel.DatabaseType))
			{
				case DatabaseTypes.SqlServer:
					return new SqlConnection(BuildConnectionString());

				case DatabaseTypes.MySql:
					return null;

				case DatabaseTypes.SqLite:
					return null;

				default:
					return null;
			}
		}
	}
}
