using LAB2_ASPNET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_ASPNET.DataAccess
{
    internal class CourseDAO
    {
        public static List<SCourse> GetAllCourse()
        {
            string sql1 = @"select a.CourseId, a.CourseCode, a.CourseDescription, 
                            b.SubjectCode, e.instructorfirstname , c.TermName, d.CampusName
                            from courses a inner join 
                            subjects b on a.subjectid = b.subjectid 
                            inner join TERMS c on a.TermId = c.TermId 
                            inner join CAMPUSES d on a.CampusID = d.CampusId 
                            inner join INSTRUCTORS e on a.InstructorId = e.InstructorId";
            DataTable dt = DAO.getDataBySql(sql1);
            List<SCourse> list = new List<SCourse>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new SCourse(
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString()
                    ));
            }
            return list;
        }
        public static List<CStudent> getAllStudentInCourse(string id)
        {
            string sql = @"select * from STUDENTS where StudentId in (
                            select StudentId from STUDENT_COURSE where CourseId = " + id + ")";
            DataTable dt = DAO.getDataBySql(sql);
            List<CStudent> list = new List<CStudent>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new CStudent(
                    dr[0].ToString(),
                    dr["roll#"].ToString(),
                    dr["firstname"].ToString(),
                    dr["midname"].ToString(),
                    dr["lastname"].ToString()));
            return list;
        }
        public static int RemoveStudent(string id)
        {
            int n = 0;
            string sql = @"delete from STUDENT_COURSE where StudentId = " + id;
            n = DAO.ExecuteSql(sql);
            return n;
        }
        public static List<CStudent> getAllStudentsNotInClass(string id)
        {
            string sql = @"select * from STUDENTS where StudentId not in (
                            select StudentId from STUDENT_COURSE where CourseId = " + id + ")";
            DataTable dt = DAO.getDataBySql(sql);
            List<CStudent> list = new List<CStudent>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new CStudent(
                    dr[0].ToString(),
                    dr["roll#"].ToString(),
                    dr["firstname"].ToString(),
                    dr["midname"].ToString(),
                    dr["lastname"].ToString()));
            return list;
        }
        public static int addStudentInCourse(string id, string course)
        {
            string sql = @"insert into STUDENT_COURSE(CourseId, StudentId)
                        values(" + course + ", " + id + ")";
            return DAO.ExecuteSql(sql);
        }
    }
}
