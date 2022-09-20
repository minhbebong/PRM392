namespace Collections
{
    class Person: IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }

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

    class SortByNameIdDes : IComparer<Person>
    {
         public int Compare(Person? x, Person? y)
         {
                var result = x.Name.CompareTo(y.Name);

                if (result != 0) return result;
                return -x.Id.CompareTo(y.Id);
         }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person { Name = "B", Id = 2});
            list.Add(new Person { Name = "C", Id = 3}); 
            list.Add(new Person { Name = "A", Id = 1});
            foreach(Person p in list)
                Console.WriteLine(p);
            
            Console.WriteLine("\nList sorted by name");
            list.Sort(new SortedByName());
            foreach (Person p in list)
                Console.WriteLine(p);

            Console.WriteLine("\nList sorted by nameiddes");
            list.Sort(new SortByNameIdDes());
            foreach (Person p in list)
                Console.WriteLine(p);

            SetConsoleOutputCP(65001);
        Console.OutputEncoding = Encoding.UTF8;

        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            { "hello", "xin chào" },
            {"good bye", "tạm biệt" },
            {"smile", "cười" }
        };

       
        Console.Write("Tìm từ: ")
        var searchKey = Console.ReadLine().Trim();

        if (dict.ContainsKey(searchKey))
        {
            Console.WriteLine($"{searchKey} trong tiếng việt là {dict[searchKey]}");
        }
        else Console.WriteLine("Không tồn tại từ này trong từ điển");
            }
        }

        }
        }
    }
}