const double PI = 3.14;
Console.Write("Enter radius of cricle: ");
double radius = double.TryParse(Console.ReadLine());
double area = radius * radius * PI;
Console.WriteLine("Area of circle:{0}", area);
Console.Read();

