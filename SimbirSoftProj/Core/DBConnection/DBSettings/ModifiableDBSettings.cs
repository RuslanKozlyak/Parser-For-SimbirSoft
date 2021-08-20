using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SimbirSoftProj.Core.DBConnection;

namespace SimbirSoftProj.Core
{
    public class ModifiableDBSettings : IDBSettings
    {
        string connectionString = "";

        public ModifiableDBSettings(string servername,string database)
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
