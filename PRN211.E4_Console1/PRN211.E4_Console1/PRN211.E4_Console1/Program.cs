// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

var myInt = 10;
var myChar = 'a';
Console.WriteLine(myChar.GetType().Name);

var myName = "Tran Van Tu";
var mySalary = 200.124;
Console.WriteLine($"My name:{myName, -20}, My salary:{mySalary, 10:N2}");

int a = 10, b = 20, sum;
add(a, b, out sum);
Console.WriteLine($"{a} + {b} = {sum}");
Console.WriteLine($"After add():a = {a}, b = {b}");
swap(ref a, ref b);
Console.WriteLine($"After swap():a = {a}, b = {b}");


foreach (string s in args)
{
    Console.WriteLine(s);
}

void add(int a, int b, out int sum)
{
    sum = a + b;
    a = 100;
}
void swap(ref int a, ref int b)
{
    int tmp;
    tmp = a; 
    a = b; 
    b = tmp;
}