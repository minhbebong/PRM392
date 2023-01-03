using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }  
        public string Origin { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product(int id, string name, int categoryId, string origin, int quantity, string description)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Origin = origin;
            Quantity = quantity;
            Description = description;
        }

        public Product()
        {
        }
    }
}
