using System;
using System.Collections.Generic;

#nullable disable

namespace LAB2_Courses.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Courses = new HashSet<Course>();
        }

        public int InstructorId { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorMidName { get; set; }
        public string InstructorLastName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
