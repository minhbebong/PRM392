namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 10;
            int? m1 = null;

            m = m1??0;
            string s = null;
            Console.WriteLine($"Length of s = {s.Length}");
            
        }
    }
}