using System;
using System.Collections.Generic;

namespace SE1626_Windows_EF.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustId { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
