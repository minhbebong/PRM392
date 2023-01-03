using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Model
{
    public class ModelBase
    {
        public static SqlConnection Connection;
        
        public static void CloseConnection()
        {
            if (Connection?.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public static void ConnectDatabase()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = "localhost";
            stringBuilder.UserID = "sa";
            stringBuilder.Password = "123456";
            stringBuilder.InitialCatalog = "Cars";
            stringBuilder.TrustServerCertificate = true;
            stringBuilder.IntegratedSecurity = true;

            Connection = new SqlConnection(stringBuilder.ConnectionString);
            Connection.Open();
        }
    }
}
