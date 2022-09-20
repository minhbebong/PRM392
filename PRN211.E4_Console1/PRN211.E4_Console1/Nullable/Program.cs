// See https://aka.ms/new-console-template for more information
int[] arr = null;
//Console.WriteLine($"Length of arr = {arr.Length.ToString()}");
Console.WriteLine($"Length of arr = {arr?.Length.ToString()}");
int m = 10;
int? m1 = null;
m = m1??0;

