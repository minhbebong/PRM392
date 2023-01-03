namespace IO
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Age = {Age}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() { 
                new Student{Id = 1, Name = "Nguyen Van An", Age = 20},
                new Student{Id = 2, Name = "Nguyen Thi Mai", Age=20}
            };

            StreamWriter sw = new StreamWriter("ListStudents.txt");
            foreach(Student student in students)
                sw.WriteLine($"{student.Id}\t{student.Name}\t{student.Age}");

            sw.Close();

            students.Clear();
            if (!File.Exists("ListStudents.txt"))
            {
                Console.WriteLine("File does not exist!");
                return;
            }
            Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
            StreamReader sr = new StreamReader("ListStudents.txt");
            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] tokens = line.Split('\t');
                Student student = new Student()
                {
                    Id = int.Parse(tokens[0]),
                    Name = tokens[1],
                    Age = int.Parse(tokens[2])
                };
                students.Add(student);
            }
            sr.Close();
            Console.WriteLine("List of students");
            foreach(Student student in students)
                Console.WriteLine(student);

        }
    }
}