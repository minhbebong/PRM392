using LAB2_ASPNET.DataAccess;
using LAB2_ASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_ASPNET.Logics
{
    internal class CourseManger
    {
        public static List<SCourse> GetAllCourseFromDB()
        {
            return CourseDAO.GetAllCourse();
        }
        public static List<CStudent> GetAllStudentInCourse(string id)
        {
            return CourseDAO.getAllStudentInCourse(id);
        }
        public static int DeleteStudent(string id)
        {
            return CourseDAO.RemoveStudent(id);
        }
        public static List<CStudent> getAllStudentNotInCourse(string id)
        {
            return CourseDAO.getAllStudentsNotInClass(id);
        }
        public static int addNewStudent(string id, string courseID)
        {
            return CourseDAO.addStudentInCourse(id, courseID);
        }
    }
}
