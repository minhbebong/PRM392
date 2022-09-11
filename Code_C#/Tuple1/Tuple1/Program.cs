namespace Tuple1
{
    internal class Program
    {
        
        public static (int solve, double? x1, double? x2) Solve(double a, double b, double c)
        {
            if (a == 0.0)
            {
                if (b == 0.0)
                {
                    return (c == 0 ? -1 : 0, null, null);
                }
                return (1, -c / b, -c / b);
            }

            double delta = b * b - 4 * a * c;

            if (delta > 0.0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return (2, x1, x2);
            }
            else if (delta == 0.0)
            {
                return (1, -b / (2 * a), -b / (2 * a));
            }
            else
            {
                return (0, null, null);
            }
        }

        public static void Main(String[] args)
        {
            // 1 0 -1
            // 1 -2 1
            // 0 0 0
            // 0 0 1
            Console.WriteLine("Solve ax^2 + bx + c = 0: ");

            Console.Write("Enter a: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Console.Write("Enter b: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Console.Write("Enter c: ");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            var result = Solve(a, b, c);

            switch (result.solve)
            {
                case -1:
                    Console.WriteLine("Infinity solutions!");
                    break;
                case 0:
                    Console.WriteLine("No solution!");
                    break;
                case 1:
                    Console.WriteLine($"One solution: \nx = {result.x1}");
                    break;
                case 2:
                    Console.WriteLine($"Two solutions: \nx1 = {result.x1}\nx2 = {result.x2}");
                    break;
                default:
                    Console.WriteLine("Unhandled case!");
                    break;
            }
        }
    }
}