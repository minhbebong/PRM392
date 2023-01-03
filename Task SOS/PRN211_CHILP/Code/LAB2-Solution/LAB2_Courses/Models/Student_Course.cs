using System;
using System.Collections.Generic;

#nullable disable

namespace LAB2_Courses.Models
{
    public partial class Student_Course
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public Student_Course(int courseId, int studentId)
        {
            CourseId = courseId;
            StudentId = studentId;
        }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
