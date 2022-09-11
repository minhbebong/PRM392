namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, sum, sub, mul;
            myMethod(a, b, out sum, out sub, out mul);
            Console.WriteLine($"{a} +{b} ={sum}," +
                $"{a} - {b} ={sub}," +
                $"{a} * {b} ={mul}");

            (int sum, int sub, int mul) solution = myMethod1(a, b);
            Console.WriteLine($"{a}+{b} = {solution.Item1}," +
                $"{a}-{b} = {solution.Item2}," +
                $"{a}*{b} = {solution.Item3}");
        }
        static(int sum, int sub, int mul)myMethod1(int a, int b)
        {
            (int, int, int) value;
            value.Item1 = a + b;
            value.Item2 = a - b;
            value.Item3 = a * b;
        }
        static void myMethod(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
        }
    }
}