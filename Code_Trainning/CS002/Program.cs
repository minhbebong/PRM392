// See https://aka.ms/new-console-template for more information
/*
    Kieu du lieu Ten bien:
    Ten bien
*/
double so_pi;
so_pi = 3.14;

double hai_pi;
hai_pi = 2 * so_pi;
Console.WriteLine(hai_pi);

Console.Title = "Vi du su dung Console";
Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.BackgroundColor = ConsoleColor.Black;

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("xIN CHAO, CHUONG TRINH NHAP DU LIEU");

Console.ResetColor();

Console.Write("Gia tri cua so pi");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(so_pi);
Console.ResetColor();


String HOVATEN;
Console.Write("Ho ten cua ban:");
HOVATEN = Console.ReadLine();

Console.WriteLine("Xin chao {0}", HOVATEN);
