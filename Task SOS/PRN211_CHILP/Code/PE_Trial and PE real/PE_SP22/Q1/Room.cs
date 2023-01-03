using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Room
    {
        public string Title { get; set; }
        public int Square { get; set; }
        public int Floor { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

        public Room()
        {
        }

        public Room(string title, int square, int floor, string description, string comment)
        {
            Title = title;
            Square = square;
            Floor = floor;
            Description = description;
            Comment = comment;
        }
    }
}
