using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11._5
{
    class Department: IDisplayable
    {
        string DepartmentName;
        List<Account> accounts;

        public Department()
        {
            accounts = new List<Account>();
        }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            accounts = new List<Account>();
        }

        public void AddAccount(Account c)
        {
            accounts.Add(c);
        }

        public void Display()
        {
            Console.WriteLine($"Department name: {DepartmentName}");
            Console.WriteLine("List of accounts:");
            foreach (Account a in accounts)
                Console.WriteLine(a);            
        }

        public void Sort()
        {
            accounts.Sort();
        }

        public void SortByUserNameDesc()
        {
            accounts.Sort(new DescUserNameComparer());
        }
        public void SortByPassword()
        {
            accounts.Sort(new PasswordComparer());
        }

        public void SortByType()
        {
            accounts.Sort(new TypeComparer());
        }
        public void ReadFromFile(string FileName)
        {
            Console.WriteLine("Noi dung trong file: ");
            string[] a = File.ReadAllLines(FileName);
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(i + ". ");
                Console.WriteLine(a[i]);
            }

            Console.ReadKey();
        }
        public void WriteFromFile(string FileName)
        {
           int count = 0;
           StreamReader read = new StreamReader(FileName);
           string line;
           while ((line = read.ReadLine()) != null)
           {
                count++;
                try
                {
                    if (count == 1)
                    {
                        string[] data = line.Split(' ');
                        if (data[0].Equals("Department"))
                        {
                            DepartmentName = data[1];
                        }
                    }  else
                    {
                        string[] data = line.Split('|');
                        if (data[0].Equals("Account"))
                        {
                            AddAccount(new Account(data[0], data[1]));
                        }
                        if (data[0].Equals("Customer"))
                        {
                            //AddAccount(new Customer(data[1], data[2], data[3], data[4]));
                        }
                    }
                }
                catch (Exception e)
                {

                }
           }
        }
      
    }
}
