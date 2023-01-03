using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Controller
{
    internal class ProductDAO
    {
        public List<Product> listP =new List<Product>();    
        public void addProduct(Product p)
        {
            listP.Add(p);
        }
    }
}
