using System.Reflection;

namespace LINQ
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
        static int[] ids = { 1, 2, 4 };
        static string[] names = { "A", "B" };
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Age = 20, Name = "A"});
            students.Add(new Student { Id = 2, Age = 20, Name = "B" });
            students.Add(new Student { Id = 3, Age = 21, Name = "C" });
            students.Add(new Student { Id = 4, Age = 20, Name = "D" });
            students.Add(new Student { Id = 5, Age = 20, Name = "E" });

            var students2 = students.OrderByDescending(s => s.Name);
            foreach (Student student in students2)
                Console.WriteLine(student);

            var students3 = students.GroupBy(s => s.Age)
                .Select(g => new {Key = g.Key, Count = g.Count()});

            foreach (var group in students3)
                Console.WriteLine($"Age = {group.Key}, Count = {group.Count}");

            int maxAge = students.Select(s => s.Age).Max();
            int minAge = students.Select(s => s.Age).Min();
            Console.WriteLine($"maxAge = {maxAge}, minAge = {minAge}");

            Console.WriteLine("List of students whose Id >=2 and Age > 20");
            var list1 = students.Where(s => s.Id >= 2 && s.Age > 20);
            foreach(Student s in list1)
                Console.WriteLine(s);

            Console.WriteLine("List of student whose id in ids[]");
            var list = students.Where(filterId);
            foreach (Student student in list)
                Console.WriteLine(student);


            Console.WriteLine("List of student whose id in ids[] and name in names[]");
            var list2 = students.Where(filterIdName);
            foreach (Student student in list2)
                Console.WriteLine(student);

        }

        static bool filterId(Student s)
        {
            bool filterId = false;
            foreach (int id in ids)
                filterId = filterId || s.Id == id;

             return filterId;
        }

        static bool filterIdName(Student s)
        {
            bool filterId = false;
            foreach (int id in ids)
                filterId = filterId || s.Id == id;

            bool filterName = false;
            foreach (string name in names)
                filterName = filterName || s.Name == name;

            return filterId && filterName;
        }
    }
}

    
    
