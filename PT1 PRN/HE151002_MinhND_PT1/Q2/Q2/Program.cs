class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Foods
{
    public string foodTile { get; set; }

    public List<Food> listOfFoods { get; set; }

    public Foods(string tile, List<Food> foods)
    {
        foodTile = tile;
        listOfFoods = foods;
    }

    public override string ToString()
    {
        string result = $"Title: {foodTile}\nList of foods:\n";

        foreach (var food in listOfFoods)
        {
            result += $"Food: {food.Id} - {food.Name}\n";
        }

        return result;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        List<Food> fl = new List<Food>();
        int numberFoods;
        Console.Write("Enter the number of foods:");
        numberFoods = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberFoods; i++)
        {
            Food food = new Food();
            Console.Write("Enter ID:");
            food.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter name:");
            food.Name = Console.ReadLine();
            fl.Add(food);
        }
        Foods foods = new Foods("Fruit", fl);

        Console.WriteLine("OUTPUT:");
        Console.Write(foods);

        Console.ReadLine();
    }

}
