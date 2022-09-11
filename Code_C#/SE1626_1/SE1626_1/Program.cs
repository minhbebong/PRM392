// See https://aka.ms/new-console-template for more information
int a, b, c = 0;
a = 10;
b = 20;
c = add(a, b , ref c);

Console.WriteLine($"{a} + {b} = {c}");

swap(ref a,ref b);

Console.WriteLine($" After swap(): a={a}, b={b} ");

void swap(ref int a,ref int b)
{
    int tmp;
    tmp = a;
    a = b;
    b = tmp;
}
//ref là gán địa chỉ
void add(int a, int b, ref int c)
{
    c = a + b;
}