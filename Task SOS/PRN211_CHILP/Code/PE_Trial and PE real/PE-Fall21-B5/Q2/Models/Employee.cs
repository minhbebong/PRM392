using System;
using System.Collections.Generic;

#nullable disable

namespace Q2.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        public string Position { get; set; }
        public int? Department { get; set; }

        public Employee()
        {
        }

        public Employee(string name, DateTime dob, string sex, string position)
        {
            Name = name;
            Dob = dob;
            Sex = sex;
            Position = position;
        }

        public Employee(int id, string name, DateTime dob, string sex, string position)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Sex = sex;
            Position = position;
        }

        public virtual Department DepartmentNavigation { get; set; }
    }
}
