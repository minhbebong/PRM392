using Microsoft.AspNetCore.Mvc;
using SessionAndCookie.Models;
using System.Collections.Generic;
using System.Linq;

namespace SessionAndCookie.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int para1)
        {
            List<Product> lstPr = new List<Product>();
            List<Category> lstCategories = new List<Category>();
            using (var context = new NorthwindContext())
            {
                if (para1 == 0)
                {
                    lstPr = context.Products.ToList();
                } else
                {
                    lstPr = context.Products.Where(x => x.CategoryId == para1).ToList();
                }
                lstCategories = context.Categories.ToList();
            }
            ViewBag.lstCategories = lstCategories;
            return View(lstPr);
        }
        public string addToCart(int para1)
        {
            
            return "add successfully!";
        }
    }
}
