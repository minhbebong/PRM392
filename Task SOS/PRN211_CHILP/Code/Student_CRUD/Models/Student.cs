using System;
using System.Collections.Generic;

#nullable disable

namespace Student_CRUD.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Roll { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }

        public Student(int studentId, string roll, string firstName, string midName, string lastName)
        {
            StudentId = studentId;
            Roll = roll;
            FirstName = firstName;
            MidName = midName;
            LastName = lastName;
        }

        public Student()
        {
        }
    }
}
