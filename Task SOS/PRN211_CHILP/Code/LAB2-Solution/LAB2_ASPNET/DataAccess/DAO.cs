﻿using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_ASPNET.DataAccess
{
    internal class DAO
    {
        public static SqlConnection getConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
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

    }
}