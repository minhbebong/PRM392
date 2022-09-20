// See https://aka.ms/new-console-template for more information
int Volumn(int length, int wide, int height)
{
    return height * Area();

    int Area()
    {
        return length * wide;
    }
    
}
Console.WriteLine($"Volumn = {Volumn(10, 20, 10)}");