using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_ASPNET.Models
{
    internal class StudentCoures
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public StudentCoures(int courseId, int studentId)
        {
            CourseId = courseId;
            StudentId = studentId;
        }

        public StudentCoures()
        {
        }
    }
}
