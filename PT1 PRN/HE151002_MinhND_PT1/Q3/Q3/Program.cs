using System.Text.RegularExpressions;

interface IUtility
{
    float GetFloat(string msg, float min, float max);

    string GetString(string msg, string pattern);
}

class Utility : IUtility
{
    public float GetFloat(string msg, float min, float max)
    {
        while (true)
        {
            Console.Write(msg);
            var input = Console.ReadLine();

            if (float.TryParse(input, out float result) && result <= max && result >= min)
            {
                return result;
            }
        }
    }

    public string GetString(string msg, string pattern)
    {
        while (true)
        {
            Console.Write(msg);
            var input = Console.ReadLine();

            if (Regex.IsMatch(input, pattern))
            {
                return input;
            }
        }
    }
}

class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public float Marks { get; set; }

    public override string ToString()
    {
        return $"{Id}-{Name}-{Marks}";
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        Utility utility = new Utility();
        s.Id = utility.GetString("Enter ID (HE123456):", @"^[H][E]\d{6}$");
        s.Name = utility.GetString("Enter name (not empty):", @"\S+");
        s.Marks = utility.GetFloat("Enter marks (from 0 to 10):", 0, 10);

        Console.WriteLine("OUTPUT:");
        Console.WriteLine(s);
        Console.ReadKey();
    }
}
