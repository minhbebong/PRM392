namespace SE1626_OOP
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(Id = 1, Name = "A");
            Console.WriteLine(student.Name);
        }
    }
}