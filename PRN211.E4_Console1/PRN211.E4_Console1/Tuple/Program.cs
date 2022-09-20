// See https://aka.ms/new-console-template for more information
int a, b, sum, sub, mul;
a = 10;
b = 20;
myMethod(a, b, out sum, out sub, out mul);
Console.WriteLine($"{a} + {b} = {sum}, " +
    $"{a} - {b} = {sub}, " +
    $"{a} * {b} = {mul}");

(int, int, int) solution = myMethod1(a, b);
Console.WriteLine($"{a} + {b} = {solution.Item1}, " +
    $"{a} - {b} = {solution.Item2}, " +
    $"{a} * {b} = {solution.Item3}");

(int, int, int) myMethod1(int a, int b)
{
    (int, int, int) value;
    value.Item1 = a + b;
    value.Item2 = a - b;
    value.Item3 = a * b;
    return value;
}

void myMethod(int a, int b, out int sum, out int sub, out int mul)
{
    sum = a + b;
    sub = a - b;
    mul = a * b;
}
