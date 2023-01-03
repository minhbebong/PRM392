using Q1.DAO;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSubject.DAO
{
    internal class DAOemp
    {
        public static List<Employees> getAllEMP()
        {
            string sql = @"select * from employee";
            DataTable dt = DBContext.GetDataBySql(sql);
            List<Employees> list = new List<Employees>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new Employees(
                    dr[0].ToString(),
                    dr[1].ToString(),
                    Convert.ToDateTime(dr[2]).ToString("dd/MM/yyyy")
                    ,
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString()
                    ));
            return list;
        }

        public static List<Employees> getAllEMPbyName(string a)
        {
            string sql = @"select * from employee where [name] like '%"+a+"%'";
            DataTable dt = DBContext.GetDataBySql(sql);
            List<Employees> list = new List<Employees>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new Employees(
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString()
                    ));
            return list;
        }

        /*   public static List<Employees> getAllStudentInCourse(string s)
           {
               string sql = @"select * from STUDENTS where StudentId in (
   select StudentId from STUDENT_COURSE where CourseId = "+s+")";
               DataTable dt = DBContext.GetDataBySql(sql);
               List<MStudent> list = new List<MStudent>();
               foreach (DataRow dr in dt.Rows)
                   list.Add(new MStudent(
                       dr[0].ToString(),
                       dr["roll#"].ToString(),
                       dr["firstname"].ToString(),
                       dr["midname"].ToString(),
                       dr["lastname"].ToString()));
               return list;
           }

           public static List<Mcourse> GetListCourses()
           {
               string sql1 = @"select a.CourseId, a.CourseCode, a.CourseDescription, 
   b.SubjectCode, e.instructorfirstname , c.TermName, d.CampusName
   from courses a inner join 
   subjects b on a.subjectid = b.subjectid 
   inner join TERMS c on a.TermId = c.TermId 
   inner join CAMPUSES d on a.CampusID = d.CampusId 
   inner join INSTRUCTORS e on a.InstructorId = e.InstructorId";

               DataTable dt = DBContext.GetDataBySql(sql1);
               List<Mcourse> list = new List<Mcourse>();
               foreach (DataRow dr in dt.Rows)
                   list.Add(new Mcourse(
                       dr[0].ToString(),
                       dr[1].ToString(),
                       dr[2].ToString(),
                       dr[3].ToString(),
                       dr[4].ToString(),
                       dr[5].ToString(),
                       dr[6].ToString()
                       ));
               return list;
           }

           public static int kickStudentInCourse(string id)
           {
               int n = 0;
               string sql = @"delete from STUDENT_COURSE where StudentId = " + id;
               n = DBContext.executeSQL(sql);
               return n;
           }

           public static int addStudentCourse(string id, string course)
           {
               int n = 0;
               string sql = @"insert into STUDENT_COURSE(CourseId, StudentId) 
   values("+course+", "+id+")" ;
               n = DBContext.executeSQL(sql);
               return n;
           }*/
    }
}
