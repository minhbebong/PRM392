// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");

int[] numbers = {1, 2, 3, 4, 5, 6};
Console.WriteLine(string.Join(" ", numbers));

int searchNumber = 3;
ref int value = ref findNumber(numbers, searchNumber);
if(value == searchNumber) value *= 2;

Console.WriteLine(string.Join(" ", numbers));

string[] strings = { "Mango", "Banana", "Apple" };
string searchString = "Demo";

ref string s = ref findString(strings, searchString);
if(s == searchString) s = "Orange";

Console.WriteLine(string.Join(" ", strings));

ref int findNumber(int[] numbers, int target)
{
    ref int value = ref numbers[0];   
    for(int i = 0; i < numbers.Length; i++)
        if(numbers[i] == target)
        {
            value = ref numbers[i];
            return ref value;
        }
    return ref value;
}
ref string findString(string[] strings, string search)
{
    ref string value = ref strings[0];

    for (int i = 0; i < strings.Length; i++)
        if (strings[i] == search)
        {
            value = ref strings[i];
            break;
        }

    return ref value;
}

