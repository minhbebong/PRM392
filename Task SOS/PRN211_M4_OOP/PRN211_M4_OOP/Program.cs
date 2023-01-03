namespace PRN211_M4_OOP
{
    class Student
    {
        int id; 
        public int ID { get; init; }
        public string Name { get;}

        public Student()
        {
            ID = 1;
            Name = "A";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student {ID = 5};
            
            
            Console.WriteLine(student.Name);
        }
    }
}