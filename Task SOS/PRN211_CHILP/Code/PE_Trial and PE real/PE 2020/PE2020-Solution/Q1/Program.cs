using System;
using System.Collections;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            Console.WriteLine(u.ToString());
            Console.WriteLine();

            ArrayList lstOfUser = new ArrayList();
            lstOfUser.Add(new User("anhnhthe150726", "anhnhthe150726@fpt.edu.vn", 1));
            lstOfUser.Add(new User("anhnhthe150727", "anhnhthe150727@fpt.edu.vn", 1));
            lstOfUser.Add(new User("anhnhthe150728", "anhnhthe150728@fpt.edu.vn", 2));

            User u1 = new User("anhnhthe150727", "anhnhthe150727@fpt.edu.vn", 2);
            Console.WriteLine("Index of u1 in listOfUser: {0}\n", lstOfUser.IndexOf(u1));
            try
            {
                Object o = new Object();
                Console.WriteLine("Index of o in ListOfUser:");
                Console.WriteLine(lstOfUser.IndexOf(o));
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
