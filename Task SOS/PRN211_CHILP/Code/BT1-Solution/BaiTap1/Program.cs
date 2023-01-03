using System;

namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account a = new Account("chilp", "123456");
            //Console.WriteLine("Account: ");
            //Console.WriteLine(a);
            //Console.WriteLine();

            //Employee e1 = new Employee("trungnb", "123457", "Admin", 1200.4);
            //Employee e2 = new Employee();
            //Console.WriteLine("Input Employee's info:");
            //e2.Input();
            //Console.WriteLine($"Employee: {e1}");
            //Console.WriteLine($"Employee: {e2}");
            //Console.WriteLine();

            //Customer c1 = new Customer("trungnb", "123457", new DateTime(1987, 12, 1), "Bao Trung");
            //Customer c2 = new Customer();
            //Console.WriteLine("Input Customer's info:");
            //c2.Input();
            //Console.WriteLine($"Customer: {c1}");
            //Console.WriteLine($"Customer: {c2}");
            //Console.ReadLine();
            Account a1 = new Account("anh", "1234");
            Account a2 = new Account("anh", "22314");
            if (a1.Equals(a2)) Console.WriteLine("equal");
            else Console.WriteLine("not equal");
            DemoStatic de = new DemoStatic();
            DemoStatic de1 = new DemoStatic();
            DemoStatic de2 = new DemoStatic(11);
            DemoStatic de3 = new DemoStatic(12);
            DemoStatic de4 = new DemoStatic(13);
            Console.WriteLine(DemoStatic.count);
        }
    }
}
