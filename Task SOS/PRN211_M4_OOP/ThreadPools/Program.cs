namespace ThreadPools
{
    class Utility
    {
        public void PrintNumber(object obj)
        {

            lock (this)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is executing PrintNumber()");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Utility u = new Utility();
            Console.WriteLine($"Main thread {Thread.CurrentThread.ManagedThreadId} is started");
            WaitCallback waitCallback = new WaitCallback(u.PrintNumber);

            for(int i = 0; i < 10; i++)
                ThreadPool.QueueUserWorkItem(waitCallback);

            //Console.ReadLine();
        }
    }
}