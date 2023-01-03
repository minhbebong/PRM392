using System;
using System.Collections.Generic;

#nullable disable

namespace Student_CRUD.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public int SubjectId { get; set; }
        public int? InstructorId { get; set; }
        public int? TermId { get; set; }
        public int? CampusId { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
