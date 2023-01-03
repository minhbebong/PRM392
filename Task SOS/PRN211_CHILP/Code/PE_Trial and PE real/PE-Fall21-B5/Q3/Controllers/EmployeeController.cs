using Microsoft.AspNetCore.Mvc;
using Q3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Q3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee> lstEm = new List<Employee>();
            using (var context = new PE_Fall21B5Context())
            {
                lstEm = context.Employees.ToList();
            }
            return View(lstEm);
        }
        public IActionResult Delete(int para1)
        {
            using (var context = new PE_Fall21B5Context())
            {
                Employee emp = context.Employees.FirstOrDefault(x => x.Id == para1);
                context.Remove(emp);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
