namespace Delegate
{
    class Utility
    {
        public void Add(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
        public void Sub(int a, int b) => Console.WriteLine($"{a} - {b} = {a - b}");

        public int add(int a, int b) => a + b;
    }
    internal class Program
    {
        delegate void myDelegate(int a, int b);
        static void Main(string[] args)
        {
            Utility u = new Utility();
            myDelegate myDelegate = u.Add;
            myDelegate += u.Sub;
            myDelegate += u.Add;
            myDelegate -= u.Add;

            myDelegate(10, 20);

            Action<int, int> action = u.Add;
            action += u.Sub;
            action(10, 20);
            
            int a = 10, b = 20;

            Func<int, int, int> func = u.add;
            Console.WriteLine($"{a} + {b} = {func(a, b)}");


        }
    }
}