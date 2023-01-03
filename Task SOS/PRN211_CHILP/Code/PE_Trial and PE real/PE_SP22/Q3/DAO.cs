
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Q3
{
    public class DAO
    {
        public static SqlConnection getConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            String ConStr = config.GetConnectionString("StudentConStr");
            return new SqlConnection(ConStr);
        }
        public static DataTable getDataBySql(string sql, SqlParameter[] parameters = null)
        {
            SqlCommand command = new SqlCommand(sql, getConnection());
            if (parameters != null) command.Parameters.AddRange(parameters);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        public static int ExecuteSql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, getConnection());
            if (parameters != null) command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
        public static void CRUD(string sql)
        {
            SqlCommand command = new SqlCommand(sql, getConnection());
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
        }
        public static List<ServiceEm> getAllService()
        {
            List<ServiceEm> list = new List<ServiceEm>();
            string sql = @"select se.RoomTitle, se.FeeType, se.Month, se.Year, 
                            se.Amount, em.Name from Services se 
                            left join Employees em on se.Employee = em.Id";
            DataTable dt = DAO.getDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ServiceEm(dr[0].ToString(),
                                       dr[1].ToString(),
                                       Convert.ToInt32(dr[2]),
                                       Convert.ToInt32(dr[3]),
                                       Convert.ToDouble(dr[4]),
                                       dr[5].ToString()));
            }
            return list;
        }
        public static List<ServiceEm> search(string s)
        {
            List<ServiceEm> list = new List<ServiceEm>();
            string sql = @"select se.RoomTitle, se.FeeType, se.Month, se.Year, 
                            se.Amount, em.Name from Services se 
                            left join Employees em on se.Employee = em.Id " + s;
            DataTable dt = DAO.getDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ServiceEm(dr[0].ToString(),
                                       dr[1].ToString(),
                                       Convert.ToInt32(dr[2]),
                                       Convert.ToInt32(dr[3]),
                                       Convert.ToDouble(dr[4]),
                                       dr[5].ToString()));
            }
            return list;
        }
    }
}
