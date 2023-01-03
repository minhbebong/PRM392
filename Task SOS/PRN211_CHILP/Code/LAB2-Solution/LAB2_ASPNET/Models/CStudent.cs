using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_ASPNET.Models
{
    internal class CStudent
    {
        public string Id { get; set; }
        public string Roll { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string Lastname { get; set; }

        public CStudent()
        {
        }

        public CStudent(string id, string roll, string firstName, string midName, string lastname)
        {
            Id = id;
            Roll = roll;
            FirstName = firstName;
            MidName = midName;
            Lastname = lastname;
        }
    }
    internal class SCourse
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }
        public string Term { get; set; }
        public string Campus { get; set; }

        public SCourse(string iD, string code, string description, string subject, string instructor, string term, string campus)
        {
            ID = iD;
            Code = code;
            Description = description;
            Subject = subject;
            Instructor = instructor;
            Term = term;
            Campus = campus;
        }

        public SCourse()
        {
        }
    }
}
