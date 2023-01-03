using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_LinQ
{
    internal class StudentList
    {
        List<Student> lstStudent = new List<Student>();
        public void addStudent(Student s)
        {
            lstStudent.Add(s);
        }
        public void Display()
        {
            foreach (Student s in lstStudent)
            {
                Console.WriteLine(s.ToString());
            }
        }
        //read file and take data
        public void ReadFromFile(String FileName)
        {
            StreamReader read = new StreamReader(FileName);
            string line;
            while ((line = read.ReadLine()) != null)
            {
                string[] split = line.Split('|');
                int id = Convert.ToInt32(split[0]);
                DateTime DateOfBirth = Convert.ToDateTime(split[3]);
                int year = Convert.ToInt32(split[4]);
                float schor = float.Parse(split[5]);
                if (split.Length == 6)
                {
                    addStudent(new Student(id, split[1], split[2], DateOfBirth, year, schor));
                }
            }
        }
        //search student by rollnumber
        public void searchByID(int id)
        {
            lstStudent.Where(x => x.RollNumber == id).ToList().Display();

        }
        //search student by major
        public void searchByMajor(string major)
        {
            lstStudent.Where(x => x.Major.ToLower().Equals(major.ToLower())).ToList().Display();
        }
        //search student by major and scholar
        public void SearchMajorScholar(string major, int scholar)
        {
            lstStudent.Where(x => x.Major.ToLower().Equals(major.ToLower()) && x.Scholar >= scholar).ToList().Display();
        }
        //search student by year of birth
        public void SearchByYearOfBirth(int year)
        {
            lstStudent.Where(x => x.Dob.Year == year).ToList().Display();
        }
        //search by date of birth
        public void SearchByDoB(DateTime startDate, DateTime endDate)
        {
            lstStudent.Where(x => DateTime.Compare(x.Dob, startDate) > 0 && DateTime.Compare(x.Dob, endDate) < 0).ToList().Display();
        }
        //search by min, max scholar
        public void SearchByScholar(float min, float max)
        {
            lstStudent.Where(x => x.Scholar >= min && x.Scholar <= max).ToList().Display();
        }
        //search by name of student
        public void SearchByName(string name)
        {
            lstStudent.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList().Display();
        }
        //search by year
        public void SearchByYear(int year)
        {
            lstStudent.Where(x => x.Year == year).ToList().Display(); 
        }
    }
}
