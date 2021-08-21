using SimbirSoftProj.Core.DBConnection;

namespace SimbirSoftProj.Core
{
    public class ModifiableDBSettings : IDBSettings
    {
        string connectionString = "";

        public ModifiableDBSettings(string servername, string database)
        {
            connectionString = @$"Data Source={servername};Initial Catalog={database};Integrated Security=True";
        }
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }
    }
}
