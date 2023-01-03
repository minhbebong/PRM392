using System;
using System.Collections.Generic;

#nullable disable

namespace LAB2_Courses.Models
{
    public partial class Student
    {
        public Student()
        {
            RollCallBooks = new HashSet<RollCallBook>();
            StudentCourses = new HashSet<Student_Course>();
        }

        public int StudentId { get; set; }
        public string Roll { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<RollCallBook> RollCallBooks { get; set; }
        public virtual ICollection<Student_Course> StudentCourses { get; set; }
    }
}
