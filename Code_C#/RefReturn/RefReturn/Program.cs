namespace RefReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int search = 4;
            ref int value =ref findNumber(numbers, search);
            if (value == search)
            {
                value *= 2;
            }
            Console.WriteLine(String.Join(" ",numbers));

            string[] strings = {"Mango" , "Banana" , "Apple"};
            string searchString = "Banana";
            ref string valueString = ref findString(strings, searchString);
            if (valueString = searchString)
            {
                valueString = "Orange";
            }
            Console.WriteLine(String.Join(" ", strings));
        }

        static ref string findString(string[] strings , string searchString)
        {
            ref string value = ref strings[0];
            for (int i = 1; i < strings.Length; i++)
            {
                if (strings[i] == searchString)
                {
                    value = ref strings[i];
                    return ref value;
                }
            }
        }

        static ref int findNumber(int[] numbers, int search)
        {
            ref int value = ref numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    value = ref numbers[i];
                    return ref value;
                }
            }
            return ref value;
        }
    }
}