using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11._5
{
    class Account: IComparable<Account>
    {
        string username, password;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Account()
        {
        }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public virtual void Input()
        {
            Console.WriteLine("Username:");
            Username = Console.ReadLine();
            Console.WriteLine("Password:");
            Password = Console.ReadLine();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Account)) return false;
            Account a = (Account)obj;
            return this.Username.Equals(a.Username);
        }

        public override string ToString()
        {
            return $"{Username} - {Password}";
        }

        public int CompareTo(Account other)
        {
            //dinh nghia cach so sanh giua this va other
            //can return ve 1 so nguyen, trong do:
            //so < 0 dai dien cho this < other
            //= 0 dai dien this == other
            //>0 dai dien this > other
            return (this.Username.CompareTo(other.Username));
        }
    }

    class Customer: Account
    {
        public DateTime DOB { get; set; }
        public string Name { get; set; }

        public Customer()
        {
        }

        public Customer(string username, string password, DateTime dOB, string name):base(username, password)
        {
            DOB = dOB;
            Name = name;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("DOB(dd-MM-yyyy):");
            //DOB = DateTime.Parse(Console.ReadLine());
            DOB = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"{DOB}-{Name}";
        }
    }
}
