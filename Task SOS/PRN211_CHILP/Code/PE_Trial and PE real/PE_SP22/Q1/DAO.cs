using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string ConStr = config.GetConnectionString("StudentConStr");
            return new SqlConnection(ConStr);
        }

        public static DataTable GetDataBySql(string sql, SqlParameter[] parameters = null)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null) command.Parameters.AddRange(parameters);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }

        public static int executeSQL(string sql)
        {
            int n = 0;
            SqlCommand command = new SqlCommand(sql, GetConnection());
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return n;
        }
        public static int addRoom(Room ro)
        {
            string sql = @"insert into Rooms(Title, Square, Floor, Description, Comment)
                            values('" + ro.Title + "', " + ro.Square + ", "+ro.Floor+"," +
                            "'"+ro.Description+"', '"+ro.Comment+"')";
            return executeSQL(sql);
        }
    }
}
