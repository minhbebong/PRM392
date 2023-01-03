namespace Collections
{
    class Person:IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"Id = {Id}, Name = {Name}";

        int IComparable<Person>.CompareTo(Person? other)
        {
            return Id - other.Id;
        }
    }

    class SortedByName : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person? x, Person? y)
        {
            return -x.Name.CompareTo(y.Name);
        }
    }

    class SortedByNameIdDes : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person? x, Person? y)
        {
            if (x.Name.CompareTo(y.Name) == 0)

            {
                return -(x.Id - y.Id);

            }

            return x.Name.CompareTo(y.Name);
        }

    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person { Id = 2, Name = "B"});
            list.Add(new Person { Id = 3, Name = "C"});
            list.Add(new Person { Id = 1, Name = "A"});
            list.Add(new Person { Id = 5, Name = "A" });

            foreach (Person p in list)
                Console.WriteLine(p);

            list.Sort();
            Console.WriteLine("list sorted by Id");
            foreach (Person p in list)
                Console.WriteLine(p);

            list.Sort(new SortedByName());
            Console.WriteLine("list sorted by Name");
            foreach (Person p in list)
                Console.WriteLine(p);

            list.Sort(new SortedByNameIdDes());
            Console.WriteLine("list sorted by Name ascending, Id descending");
            foreach (Person p in list)
                Console.WriteLine(p);
        }
    }
}