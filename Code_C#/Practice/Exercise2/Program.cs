Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.Write("Enter your phone number:");
string phoneNumber = Console.ReadLine();
bool gender = Console.ReadLine() == "Male";

Console.WriteLine("Name:{0}, phone number:{1} and gender:{2}", name, phoneNumber, gender);
Console.Read();
