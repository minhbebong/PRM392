using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class room
    {
        public string title { get; set; }
        public string description { get; set; }
        public string roomSquare { get; set; }
        public string floor { get; set; }
        public string comment { get; set; }

        public room()
        {
        }

        public room(string title, string description, string roomSquare, string floor, string comment)
        {
            this.title = title;
            this.description = description;
            this.roomSquare = roomSquare;
            this.floor = floor;
            this.comment = comment;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
