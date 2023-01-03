using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    public class Account
    {
        string username, password;
        public string Password { get; set; }
        public string Username { get; set; }

        public Account()
        {
        }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Account)) return false;
            Account a = (Account)obj;
            return this.Username == a.Username &&
                   this.Password == a.Password;
        }
        public void Input()
        {
            Console.WriteLine("enter your username: ");
            Username = Console.ReadLine();
            Console.WriteLine("enter your password: ");
            Password = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Account: {Username} - {Password}";
        }
    }
    public class Customer: Account
    {
        public DateTime DOB { get; set; }
        public string Name { get; set; }

        public Customer()
        {
        }

        public Customer(string password, string username, DateTime dOB, string name): base(password, username)
        {
            DOB = dOB;
            Name = name;
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("Enter your DOB: ");
            DOB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString() + $"Customer: {Name} - {DOB}";
        }
    }
    public class Employee: Account
    {
        public string Role { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
        }
        public Employee(string password, string username, string role, double salary): base(password, username)
        {
            Role = role;
            Salary = salary;
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("Enter your role: ");
            Role = Console.ReadLine();
            Console.WriteLine("Enter your salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString() + $"Employee: {Role} - {Salary}";
        }
    }
    class DemoStatic
    {
        int id;
        public static int count;

        public DemoStatic()
        {
            count++;
        }

        public DemoStatic(int id)
        {
            count++;
            this.id = id;
        }
        public void Display()
        {
            Console.WriteLine($"{id - count}");
        }
        public static void DisplayS()
        {
            Console.WriteLine($"New: {id - count}");
        }
    }
}
