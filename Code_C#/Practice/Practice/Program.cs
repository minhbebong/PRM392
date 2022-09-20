namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 12;
            int number3 = 13;
            int sum = number1 + number2;

            Console.WriteLine("Sum of number 1 and number 2:" + sum);

            float floatNumber1 = 1.2f;
            float floatNumber2 = 1.3F;
            float sumFloat = floatNumber1 + floatNumber2;
            float divFloat = floatNumber1 / floatNumber2;
            float multiFloat = floatNumber1 * floatNumber2;

            Console.WriteLine("Sum of " + floatNumber1 + " and " + floatNumber2 + ":" + sumFloat);
            Console.WriteLine("Division of " + floatNumber1 + " and " + floatNumber2 + ":" + divFloat);
            Console.WriteLine("Multiple of " + floatNumber1 + " and " + floatNumber2 + ":" + multiFloat);


            Console.Read();

            Console.WriteLine("Hello, World!");
        }
    }
}