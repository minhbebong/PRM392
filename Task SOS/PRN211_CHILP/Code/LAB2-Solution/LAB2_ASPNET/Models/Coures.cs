using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_ASPNET.Models
{
    internal class Coures
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public int SubjectId { get; set; }
        public int InstructorId { get; set; }
        public int TermId { get; set; }
        public int CampusId { get; set; }

        public Coures()
        {
        }

        public Coures(int courseId, string courseCode, string courseDescription, int subjectId, int instructorId, int termId, int campusId)
        {
            CourseId = courseId;
            CourseCode = courseCode;
            CourseDescription = courseDescription;
            SubjectId = subjectId;
            InstructorId = instructorId;
            TermId = termId;
            CampusId = campusId;
        }
    }
}
