using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace All_In_1_Planning.Data
{
    public class DbConn
    {
        static string connectionString = "Server=localhost;Database=All-In-1Planning;Username=root;SslMode=none;";

        public static MySqlConnection Connection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
