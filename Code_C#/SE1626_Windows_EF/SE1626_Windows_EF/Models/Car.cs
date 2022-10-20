using System;
using System.Collections.Generic;

namespace SE1626_Windows_EF.Models
{
    public partial class Car
    {
        public Car()
        {
            Orders = new HashSet<Order>();
        }

        public int CarId { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public string PetName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
