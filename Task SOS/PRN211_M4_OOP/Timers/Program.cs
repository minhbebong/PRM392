namespace Timers
{
    internal class Program
    {
        static void PrintTime(object obj)
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }
        static void Main(string[] args)
        {
            Timer timer = new Timer(
                new TimerCallback(PrintTime), null, 0, 3000);

            Console.ReadLine();
        }
    }
}