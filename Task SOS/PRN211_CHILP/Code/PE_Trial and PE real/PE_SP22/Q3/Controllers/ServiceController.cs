using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Q3.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Search()
        {
            List<ServiceEm> lstEm = DAO.getAllService();
            return View(lstEm);
        }
        public IActionResult doSearch(string para1, string para2)
        {
            string s = "";
            if (string.IsNullOrEmpty(para1))
            {
                s = "where se.Month = " + para2;
            }
            if (string.IsNullOrEmpty(para2))
            {
                s = "where se.RoomTitle like '%" + para1 + "%' ";
            }
            if (!string.IsNullOrEmpty(para1) && !string.IsNullOrEmpty(para2))
            {
                s = "where se.Month = " + para2 + " and se.RoomTitle like '%" + para1 + "%'";
            }
            List<ServiceEm> lstEm = DAO.search(s);
            ViewBag.PA1 = para1;
            ViewBag.PA2 = para2;
            return View("/Views/Service/Search.cshtml", lstEm);
        }
    }
}
