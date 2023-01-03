using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.DAO
{
    internal class Employees
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string dob { get; set; }
        public string sex { get; set; }
        public string position { get; set; }
        public string department { get; set; }

        public Employees()
        {
        }

        public Employees(string iD, string name, string dob, string sex, string position, string department)
        {
            ID = iD;
            this.name = name;
            this.dob = dob;
            this.sex = sex;
            this.position = position;
            this.department = department;
        }
    }
}
