using Q1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.DataAccess
{
    internal class EmployeeDAO
    {
        public static List<DEmployee> getAllEmployee()
        {
            List<DEmployee> lstEm = new List<DEmployee>();
            string sql = @"select e.Id, e.Name, e.Dob, e.Sex, e.Position, e.Department, d.Name dn from Employee e inner 
                            join Department d on e.Department = d.Id";
            DataTable dt = DAO.getDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                lstEm.Add(new DEmployee(Convert.ToInt32(dr["Id"]),
                                        dr["Name"].ToString(),
                                        Convert.ToDateTime(dr["Dob"]), 
                                        dr["Sex"].ToString(),
                                        dr["Position"].ToString(), 
                                        Convert.ToInt32(dr["Department"]), 
                                        dr["dn"].ToString()));
            }
            return lstEm;
        }
        public static List<string> getAllPosition()
        {
            List<string> lstPosition = new List<string>();
            string sql = "select distinct Position from Employee";
            DataTable dt = DAO.getDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                lstPosition.Add(dr["Position"].ToString());
            }
            return lstPosition;
        }
        public static List<DEmployee> searchByName(string name)
        {
            List<DEmployee> lstEm = new List<DEmployee>();
            string sql = @"select e.Id, e.Name, e.Dob, e.Sex, e.Position, e.Department, d.Name dn from Employee e inner 
                            join Department d on e.Department = d.Id where e.Name like '%" + name + "%'";
            DataTable dt = DAO.getDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                lstEm.Add(new DEmployee(Convert.ToInt32(dr["Id"]),
                                        dr["Name"].ToString(),
                                        Convert.ToDateTime(dr["Dob"]),
                                        dr["Sex"].ToString(),
                                        dr["Position"].ToString(),
                                        Convert.ToInt32(dr["Department"]),
                                        dr["dn"].ToString()));
            }
            return lstEm;
        }
        public static List<DEmployee> searchByPosition(string name)
        {
            List<DEmployee> lstEm = new List<DEmployee>();
            string sql = @"select e.Id, e.Name, e.Dob, e.Sex, e.Position, e.Department, d.Name dn from Employee e inner 
                            join Department d on e.Department = d.Id where e.Position = '" + name +"'";
            DataTable dt = DAO.getDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                lstEm.Add(new DEmployee(Convert.ToInt32(dr["Id"]),
                                        dr["Name"].ToString(),
                                        Convert.ToDateTime(dr["Dob"]),
                                        dr["Sex"].ToString(),
                                        dr["Position"].ToString(),
                                        Convert.ToInt32(dr["Department"]),
                                        dr["dn"].ToString()));
            }
            return lstEm;
        }
        public static List<DEmployee> searchBySex(string name)
        {
            List<DEmployee> lstEm = new List<DEmployee>();
            string sql = @"select e.Id, e.Name, e.Dob, e.Sex, e.Position, e.Department, d.Name dn from Employee e inner 
                            join Department d on e.Department = d.Id where e.Sex = '" + name + "'";
            DataTable dt = DAO.getDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                lstEm.Add(new DEmployee(Convert.ToInt32(dr["Id"]),
                                        dr["Name"].ToString(),
                                        Convert.ToDateTime(dr["Dob"]),
                                        dr["Sex"].ToString(),
                                        dr["Position"].ToString(),
                                        Convert.ToInt32(dr["Department"]),
                                        dr["dn"].ToString()));
            }
            return lstEm;
        }
    }
}
