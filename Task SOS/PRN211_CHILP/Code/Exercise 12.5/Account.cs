using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12._5
{
    class Account
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

        public override bool Equals(object obj)
        {
            if (!(obj is Account)) return false;
            Account a = (Account)obj;//unboxing
            return this.Username.Equals(a.Username);
        }

        public override string ToString()
        {
            return $"{Username}-{Password}";
        }

        public virtual void Input()
        {
            Console.WriteLine("Username:");
            Username = Console.ReadLine();
            Console.WriteLine("Password:");
            Password = Console.ReadLine();
        }

        public virtual void ReadFromLine(string line)
        {
            string[] items = line.Split("|");
            if (items.Length != 3)
                throw new FileFormatException("Loi doc file", "Thong tin ve account khong dung format");
            Username = items[1];
            Password = items[2];
        }
    }

    class Customer: Account
    {
        public DateTime DOB { get; set; }
        public string Name { get; set; }

        public Customer()
        {
        }

        public Customer(string username, string password, string name, DateTime dOB): base(username, password)
        {
            DOB = dOB;
            Name = name;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("DOB(dd-MM-yyyy):");
            DOB = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            Console.Write("Name:");
            Name = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"-{Name}-{DOB.ToShortDateString()}";
        }

        public override void ReadFromLine(string line)
        {
            string[] items = line.Split("|");
            if (items.Length != 5)
                throw new FileFormatException("Loi doc file", "Thong tin ve customer khong dung format");
            Username = items[1];
            Password = items[2];
            Name = items[3];
            DOB = Convert.ToDateTime(items[4]);
        }
    }
}
