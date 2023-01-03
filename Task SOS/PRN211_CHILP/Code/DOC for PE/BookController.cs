using Microsoft.AspNetCore.Mvc;
using Q3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Q3.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Book> lstBoo = new List<Book>();
            using (var context = new PRN211_Demo1Context())
            {
                lstBoo = context.Books.ToList();
            }
            return View(lstBoo);
        }
        public IActionResult Delete(int para1)
        {

            using (var context = new PRN211_Demo1Context())
            {
                Book b1 = context.Books.FirstOrDefault(x => x.Id == para1);
                List<AuthorBook> lstAutho = context.AuthorBooks.Where(x => x.BookId == b1.Id).ToList();
                foreach (AuthorBook authorBook in lstAutho)
                {
                    context.Remove(authorBook);
                    context.SaveChanges();
                }
                context.Remove(b1);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
