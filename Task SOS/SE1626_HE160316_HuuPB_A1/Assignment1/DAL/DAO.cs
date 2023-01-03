using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.DAL
{
    internal class DAO
    {
        string strConnect;
        public static SqlConnection sqlConnection = null;
        public DAO()
        {
            var conf = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            strConnect = conf.GetConnectionString("DbConnection");
            sqlConnection = new SqlConnection(strConnect);
            sqlConnection.Open();
        }
        public DataTable GetDataTable(string sql)
        {
            try
            {
                

                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = sqlConnection;

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public bool Update(SqlCommand cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConnect);
                cmd.Connection = conn;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
