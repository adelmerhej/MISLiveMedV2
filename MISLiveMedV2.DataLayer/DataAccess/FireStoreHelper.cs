using System;
using System.IO;
using Google.Cloud.Firestore;

namespace MISLiveMed.DataLayers.DataAccess
{
	public static class FireStoreHelper
	{
		private static string _filePath = "";
		public static FirestoreDb Database { get; set; }

		public static void SetEnvironmentVariable()
		{
			try
			{
				var connectionModel = DatabaseFactory.ConnectionParamsGet();

				if (connectionModel.FirebaseConfigString == "")
				{
					throw new Exception("EmptyString");
				}
				_filePath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
				File.WriteAllText(_filePath, connectionModel.FirebaseConfigString);

				File.SetAttributes(_filePath, FileAttributes.Hidden);
				Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", _filePath);

				Database = FirestoreDb.Create(connectionModel.FirebaseProjectId);
				File.Delete(_filePath);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public static void CheckDatabaseConnection()
		{
			var connectionModel = DatabaseFactory.ConnectionParamsGet();



		}
	}
}
