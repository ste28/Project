using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_DB
{
    public static class DataDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=Project UAS;Persist Security Info=True;User ID=sa;Password=***********";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
