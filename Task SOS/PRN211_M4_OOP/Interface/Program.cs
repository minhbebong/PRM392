using System.Text.RegularExpressions;

namespace Interface
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
                        return value;
                }
                catch
                {
                    Console.WriteLine("\nMust be integer");
                }

            } while (true);
        }

        string IUtility.GetString(string msg, string pattern)
        {
            string value;
            do
            {
                Console.Write(msg);
                value = Console.ReadLine();
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(value))
                    return value;

            } while (true);
        }

        //public int GetInt(string msg, int min, int max)
        //{
        //    throw new NotImplementedException();
        //}

        //public string GetString(string msg, string pattern)
        //{
        //    throw new NotImplementedException();
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int no;
            string name, id;
            Utility u = new Utility();
            
            no = (u as IUtility).GetInt("Enter no (from 1 to 10):", 1, 10);
            name = (u as IUtility).GetString("Enter name (not empty):", @"\S+");
            id = (u as IUtility).GetString("Enter id (HE123456):",@"^HE\d{6}$");
            Console.WriteLine($"No = {no}, Name = {name}, Id = {id}");
        }
    }
}