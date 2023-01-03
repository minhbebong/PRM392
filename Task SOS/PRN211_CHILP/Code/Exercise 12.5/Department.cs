using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12._5
{
    class Department: IDisplayable
    {
        public string DepartmentName { get; set; }
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
            Console.WriteLine($"Department: {DepartmentName}");
            Console.WriteLine("List of accounts:");
            foreach (Account a in accounts)
                Console.WriteLine(a);
        }

        public void ReadFromFile(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                DepartmentName = reader.ReadLine();
                if (DepartmentName == null || DepartmentName.Equals(string.Empty))
                    throw new FileFormatException("Loi doc file", "Noi dung file rong");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string type = line.Substring(0, line.IndexOf("|"));
                    Account a = null;
                    if (type.ToLower().Equals("account"))
                        a = new Account();
                    else if (type.ToLower().Equals("customer"))
                        a = new Customer();
                    if (a != null)
                    {
                        try
                        {
                            a.ReadFromLine(line);
                            AddAccount(a);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine($"Tai dong: {line}");
                        }
                        catch (FileFormatException e)
                        {
                            Console.WriteLine(e.Message + " - " + e.DetailMessage);
                            Console.WriteLine($"Tai dong: {line}");
                        }
                    }
                }
                reader.Close();
            }

           
        }
    }
}
