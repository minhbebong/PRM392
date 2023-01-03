using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_ASPNET.Models
{
    internal class Students
    {
        public int StudentId { get; set; }
        public string Roll { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }

        public Students()
        {
        }

        public Students(int studentId, string roll, string firstName, string midName, string lastName)
        {
            StudentId = studentId;
            Roll = roll;
            FirstName = firstName;
            MidName = midName;
            LastName = lastName;
        }
    }
}
