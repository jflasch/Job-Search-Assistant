using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Search_Assistant
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create text file connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
