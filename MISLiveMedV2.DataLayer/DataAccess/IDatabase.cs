using System.Configuration;
using System.Data;

namespace MISLiveMed.DataLayers.DataAccess
{
    public interface IDatabase
    {
        bool AllowCreateDataBase();
        ConnectionState CheckConnection();
        bool CheckDatabaseExists(string databaseName);
        void CreateDatabase(string databaseName);
        Configuration DatabaseConfiguration();
    }
}
