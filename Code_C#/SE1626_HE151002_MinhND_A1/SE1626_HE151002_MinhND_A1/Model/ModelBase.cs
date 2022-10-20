using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1626_HE151002_MinhND_A1.Model
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
