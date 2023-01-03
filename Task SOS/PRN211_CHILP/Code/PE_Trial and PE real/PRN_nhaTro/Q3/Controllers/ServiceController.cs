using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Q3.Controllers
{
    public class ServiceController : Controller
    {
        DAOEMP dao = new DAOEMP();
        public IActionResult search()
        {
            
            List<Service> list = new List<Service>();
            list = dao.listAll();
            ViewBag.ser = new Service();
            return View(list);
        }

        public IActionResult dosearch(Service SearchSe)
        {
            string where = "";
            if (string.IsNullOrEmpty(SearchSe.title) && string.IsNullOrEmpty(SearchSe.Month))
            {
                where = "";
            }
            else
                where = "  where";
            if (!string.IsNullOrEmpty(SearchSe.title))
            {
                where += " a.RoomTitle like '%"+ SearchSe.title + "%'";
            }
            if (!string.IsNullOrEmpty(SearchSe.Month))
            {
                where += " a.month like '%" + SearchSe.Month + "%'";
            }
            if(!string.IsNullOrEmpty(SearchSe.title) && !string.IsNullOrEmpty(SearchSe.Month))
            {
                where = @"where a.RoomTitle like '%" + SearchSe.title + "%' " +
                    "and a.Month = " + SearchSe.Month;
            }
            List<Service> list = new List<Service>();
            list = dao.listAll(where);
            ViewBag.ser = SearchSe;
            return View("views/service/search.cshtml", list);
            
        }
    }
}
