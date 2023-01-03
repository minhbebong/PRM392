using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_Courses.Models
{
    internal class StudentInCourse
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public string Roll { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }

        public StudentInCourse()
        {
        }

        public StudentInCourse(int courseID, int studentID, string roll, string firstName, string midName, string lastName)
        {
            CourseID = courseID;
            StudentID = studentID;
            Roll = roll;
            FirstName = firstName;
            MidName = midName;
            LastName = lastName;
        }
    }
}
