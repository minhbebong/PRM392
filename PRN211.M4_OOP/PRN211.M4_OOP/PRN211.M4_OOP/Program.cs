namespace PRN211.M4_OOP
{
    public class Student
    {
        protected internal int id;
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student
            {
                Id = 1,
                Name = "Nguyen van Nam"
            };
           
            Console.WriteLine(s.Name);
        }
    }
}