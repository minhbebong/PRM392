using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11._5
{
    class DemoStatic
    {
        int id;
        public static int count=0;

        public DemoStatic()
        {
            count++;
        }

        public DemoStatic(int id)
        {
            count++;
            this.id = id;
        }

        public void Display()
        {
            Console.WriteLine($"{id-count}");
        }

        public static void DisplayS()
        {
            Console.WriteLine($"{count}");
        }
    }
}
