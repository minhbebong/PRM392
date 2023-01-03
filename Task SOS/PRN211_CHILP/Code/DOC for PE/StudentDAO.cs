using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataGridView
{
    internal class StudentDAO
    {
        public static List<Student> GetListStudents()
        {
            string sql = "select * from Students";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Student> list = new List<Student>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new Student(
                    Convert.ToInt32(dr["Id"]),
                    dr["Name"].ToString(),
                    Convert.ToDateTime(dr["Dob"]),
                    dr["Major"].ToString(),
                    Convert.ToInt32(dr["EntryDate"]),
                    Convert.ToDouble(dr["Scholarship"])));
            return list;
        }
        public static void UpdateStudent(String Name, String Dob, String Major,
            String EntryDate, String Scholarship, String Id)
        {
            string sql = "update students set" +
                " Name='" + Name + " ', " +
                "Dob= '" + Dob + "'," +
                " Major = '" + Major + "' ," +
                "EntryDate = '" + EntryDate + "', " +
                "ScholarShip = " + Scholarship + " " +
                "where Id = " + Id;
            DAO.UpdateSql(sql);
        }
        public static int EditStu(Student s)
        {
            String sql = @"update students set
                            Name = @name, 
                            Dob = @dob,
                            Major = @major,
                            EntryDate = @eYear,
                            ScholarShip = @scholar 
                            where Id = @id";
            SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
            p1.Value = s.Id;
            SqlParameter p2 = new SqlParameter("@name", SqlDbType.NVarChar);
            p2.Value = s.Name;
            SqlParameter p3 = new SqlParameter("@dob", SqlDbType.Date);
            p3.Value = s.Dob;
            SqlParameter p4 = new SqlParameter("@major", SqlDbType.NVarChar);
            p4.Value = s.Major;
            SqlParameter p5 = new SqlParameter("@eYear", SqlDbType.Int);
            p5.Value = s.EntryYear;
            SqlParameter p6 = new SqlParameter("@scholar", SqlDbType.Float);
            p6.Value = s.Scholarship;
            return DAO.executeSql(sql, p1, p2, p3, p4, p5, p6);
        }
        public static void AddStudent(String Id, String Name, String Dob, String Major,
            String EntryDate, String Scholarship)
        {
            string sql = "insert into students (Id, Name, Dob, Major, EntryDate, Scholarship)" +
                " values( " + Id + ", '" + Name + "', '" + Dob + "', '" + Major + "', " + EntryDate + ", " + Scholarship + " )";
            DAO.UpdateSql(sql);
        }
        public static void DeleteStudent(String Id)
        {
            string sql = "delete from students " +
                "where Id = " + Id;
            DAO.UpdateSql(sql);
        }
    }
}
