namespace Threads
{
    class ParaAdd
    {
        public int A { get; set; }
        public int B { get; set; }
    }
    class Utility
    {
        public void Add(object ParaAdd)
        {
            ParaAdd paraAdd = ParaAdd as ParaAdd;
            Thread.Sleep(4000);
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} is executing Add()");
            Console.WriteLine($"{paraAdd.A} + {paraAdd.B} = {paraAdd.A + paraAdd.B}");
        }
        public void PrintNumber()
        {
            lock (this)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} is executing PrintNumber()");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{i} ");
                    Thread.Sleep(1000);
                }
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Primary";
            Utility u = new Utility();
            //u.PrintNumber();
            //Thread thread = new Thread(new ThreadStart(u.PrintNumber));
            //thread.Name = "Secondary";
            ////thread.IsBackground = true;
            //thread.Start();

            //Thread thread = new Thread(new ParameterizedThreadStart(u.Add));
            //thread.Name = "Secondary";
            //thread.Start(new ParaAdd { A = 10, B = 20});

            Thread[] threads = new Thread[10];
            for(int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(u.PrintNumber);
                threads[i].Name = $"{i + 1}";
                threads[i].Start();
            }    

            Console.WriteLine("\nEnd of Main()");
        }
    }
}