using System;

namespace Exercise_12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\data.txt";
            Department d = new Department();
            try
            {
                d.ReadFromFile(path);
                d.Display();
            }
            catch (FileFormatException e)
            {
                Console.WriteLine(e.Message + " - " + e.DetailMessage);
            }

        }
    }
}
