using PRN211.M4_OOP;

namespace ConsoleApp1
{
    class Gradute:Student
    {
        public void Display()
        {
            Console.WriteLine($"id = {id}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            
            Console.WriteLine("Hello, World!");
        }
    }
}