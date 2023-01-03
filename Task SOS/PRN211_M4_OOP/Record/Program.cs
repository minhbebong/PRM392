namespace Record
{
    // class or record
    record Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Id = 1, Name = "A"};
            Person person2 = new Person { Id = 1, Name = "A"};
            Console.WriteLine($"person1 = person2: {person1 == person2}");
        }
    }
}