namespace DelegateEvent
{
    class Student
    {
        public event Action<string> LowMarks;
        public int Id { get; set; }
        public string Name { get; set; }

        double marks;
        public double Marks {get { return marks; } 
            set { marks = value; if(LowMarks != null) LowMarks($"Student:{Name}, Marks:{Marks}");}
          }

        public void CheckMarks()
        {
            if (Marks < 4) LowMarks($"Student:{Name}, Marks:{Marks}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "A", Marks = 8.5 });
            students.Add(new Student { Id = 2, Name = "B", Marks = 5.5 });
            students.Add(new Student { Id = 3, Name = "C", Marks = 3.5 });
            students.Add(new Student { Id = 4, Name = "D", Marks = 4.5 });

            foreach(Student student in students)
            {
                student.LowMarks += Student_LowMarks;
                student.CheckMarks();
            }

            students[1].Marks = 10;
        }

        private static void Student_LowMarks(string obj)
        {
            Console.WriteLine(obj);
        }
    }
}