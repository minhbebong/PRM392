namespace LocalFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            dientich(10);

            void dientich(int r)
            {
                Console.WriteLine($"Dien tich = { pi * r * r}");
                chuvi();
                void chuvi()
                {
                    Console.WriteLine($"Chu vi = {2 * pi * r , 5:N2} ");
                }
            }
        }
    }
}