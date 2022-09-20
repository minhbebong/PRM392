namespace Gender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    int a;
    int b;
    Console.WriteLine("Enter number a:");
a = Console.ToInt32(Console.ReadLine());
Console.Write("Enter number b:");
b = Console.ToInt32(Console.ReadLine());
int total = a + b;
    Console.WriteLine("Sum of{0} and {1} is {2}", a, b, total);

Console.Read();
}