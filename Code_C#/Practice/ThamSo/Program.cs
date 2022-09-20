namespace ThamSo
{
    class Student
    {
        public string StudentName { get; set; }
    }
    internal class Program
    {
        static void changeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
        static void changRefenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }
        static void Main(string[] args)
        {
            //int i = 100;
            //console.writeline(i);

            //changevalue(i);

            //console.writeline(i);

            Student std1 = new Student();
            std1.StudentName = "Bill";
            Console.WriteLine(std1.StudentName);
            Console.Read();
        }
    }
}