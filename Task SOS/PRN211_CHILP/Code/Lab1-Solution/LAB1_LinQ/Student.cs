using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB1_LinQ
{
    internal class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public DateTime Dob { get; set; }
        public int Year { get; set; }
        public float Scholar { get; set; }

        public Student()
        {

        }

        public Student(int rollNumber, string name, string major, DateTime dob, int year, float solar)
        {
            RollNumber = rollNumber;
            Name = name;
            Major = major;
            Dob = dob;
            Year = year;
            Scholar = solar;
        }
        public override string ToString()
        {
            return $"Student: {RollNumber} - {Name} - {Major} - {Dob.ToString("dd-MMM-yyyy")} - {Year} - {Scholar}";
        }

    }
}
