using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Management.DLA.Getway
{
    class DBConnection
    {
        public SqlConnection connection;
        private string connectionString;
        public DBConnection()
        {
            connectionString = ConfigurationSettings.AppSettings["connectionString"];
            connection = new SqlConnection(connectionString);
        }
    }
}
