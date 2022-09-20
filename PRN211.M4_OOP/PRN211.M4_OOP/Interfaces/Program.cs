using System.Text.RegularExpressions;

namespace Interfaces
{
    interface IUtility
    {
        int GetInt(string msg, int min, int max);
        string GetString(string msg, string pattern);
    }

    class Utility : IUtility
    {
        int IUtility.GetInt(string msg, int min, int max)
        {
            int value;
            do
            {
                Console.Write(msg);
                try
                {
                    value = int.Parse(Console.ReadLine());
                    if (value < min || value > max)
                        Console.WriteLine($"Must be from {min} to {max}");
                    else
                        break;
                }catch
                {
                    Console.WriteLine("Must be integer!\n");
                }
            }  while(true);  
            return value;
        }

        string IUtility.GetString(string msg, string pattern)
        {
            string value;
            do
            {
                Console.Write(msg);
                value = Console.ReadLine();
                Regex regex = new Regex(pattern);
                if(regex.IsMatch(value)) return value;
            } while (true); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int no;
            string name;
            string roleId;

            Utility u = new Utility();
            no = (u as IUtility).GetInt("Enter no (from 1 to 10):", 1, 10);
            name = (u as IUtility).GetString("Enter name (not empty):", @"\S+");
            roleId = (u as IUtility).GetString("Enter roleId (HE123456):", @"^HE\d{6}$");
            Console.WriteLine($"No = {no}, name = {name}, roleId = {roleId}");
        }
    }
}