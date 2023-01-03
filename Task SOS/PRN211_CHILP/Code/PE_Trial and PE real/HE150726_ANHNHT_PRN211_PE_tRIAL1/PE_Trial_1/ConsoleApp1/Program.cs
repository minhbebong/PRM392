using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime da = new DateTime();
            List<string> authors = new List<string>();
            authors.Add("Author1");
            authors.Add("Author2");
            authors.Add("Author3");
            authors.Add("Author4");
            try
            {
                Console.WriteLine("TC1:");
                Book b1 = new Book(1, "", 2018);
                Console.WriteLine(b1.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nTC2:");
            Book b2 = new Book(1, "Refactoring: Improving the Design of Existing Code", 2019);
            Console.WriteLine("Add Authors:");
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter author's name (empty to stop):");
                    string s = Console.ReadLine();
                    if (s.Equals(string.Empty)) break;
                    b2.AddAuthor(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine(b2.ToString());
            Console.ReadLine();

        }
    }
}
