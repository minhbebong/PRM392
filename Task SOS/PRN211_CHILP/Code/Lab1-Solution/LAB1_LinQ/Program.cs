using System;
using System.Collections.Generic;

namespace LAB1_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList st = new StudentList();
            int choice;
            st.ReadFromFile(@"D:/student.txt");
            do
            {
                Console.WriteLine("------Student Infomation------");
                Console.WriteLine("Which service do you want to choose: ");
                Console.WriteLine("1. Display all students");
                Console.WriteLine("2. Search by rollnumber");
                Console.WriteLine("3. Search by major");
                Console.WriteLine("4. Search by major and scholar (students learn this major and have scholar greater than or equal this scholar)");
                Console.WriteLine("5. Search by year of birth");
                Console.WriteLine("6. Search by date of birth");
                Console.WriteLine("7. Search by year of admission");
                Console.WriteLine("8. Search by scholar");
                Console.WriteLine("9. Search by name");
                Console.WriteLine("Press 0 to exit!");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("List students: ");
                        st.Display();
                        break;
                    case 2:
                        Console.WriteLine("enter your rollnumber: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        st.searchByID(id);
                        break;
                    case 3:
                        Console.WriteLine("enter your major: ");
                        string major = Console.ReadLine();
                        st.searchByMajor(major);
                        break;
                    case 4:
                        Console.WriteLine("Enter your major: ");
                        string maj = Console.ReadLine();
                        Console.WriteLine("Enter your scholar: ");
                        int scho = Convert.ToInt32(Console.ReadLine());
                        st.SearchMajorScholar(maj, scho);
                        break;
                    case 5:
                        Console.WriteLine("enter your year of birth: ");
                        int year =  Convert.ToInt32(Console.ReadLine());
                        st.SearchByYearOfBirth(year);
                        break;
                    case 6:
                        Console.WriteLine("enter startdate: ");
                        DateTime stDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("enter enddate: ");
                        DateTime enDate = Convert.ToDateTime(Console.ReadLine());
                        st.SearchByDoB(stDate, enDate);
                        break;
                    case 7:
                        Console.WriteLine("enter your year of admission: ");
                        int ye = Convert.ToInt32(Console.ReadLine());
                        st.SearchByYear(ye);
                        break;
                    case 8:
                        Console.WriteLine("enter min of scholar: ");
                        float min = float.Parse(Console.ReadLine());
                        Console.WriteLine("enter max of scholar: ");
                        float max = float.Parse(Console.ReadLine());
                        st.SearchByScholar(min, max);
                        break;
                    case 9:
                        Console.WriteLine("enter your name: ");
                        string name = Console.ReadLine();
                        st.SearchByName(name);
                        break;
                    default:
                        Console.WriteLine("Thanks for using!");
                        Console.WriteLine("Bye!");
                        break;
                }
            } while (choice >= 1 && choice <= 9);
        }
    }
}
