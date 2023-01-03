using Microsoft.AspNetCore.Mvc;
using System;
using Student_Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Student_Web.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult ListStudent()
        {
            List<Student> lst = new List<Student>();
            using (var context = new APContext())
            {
                lst = context.Students.ToList();
            }
            return View(lst);
        }
        public IActionResult Index()
        {
            ViewData["id"] = 4;
            ViewBag.Name = "Tien Anh";
            //Students s = new Students(1, "TIEN ANH");
            return View();
        }
        //public string Search(string para1, int para2)
        //{
        //    string result = "";
        //    List<Students> lst = new List<Students>();
        //    using (var context = new SE1619_DemoContext())
        //    {
        //        lst = context.Students.Where(x => x.Major.Equals(para1) && x.EntryYear == para2).ToList();
        //    }
        //    if (lst.Count == 0)
        //    {
        //        return "List is empty!";
        //    }
        //    foreach (Students s in lst)
        //    {
        //        result += s.ToString();
        //    }
        //    return result;
        //}
        //public string searchID(int para1)
        //{
        //    string s = "";
        //    List<Students> lst = new List<Students>();
        //    using (var context = new SE1619_DemoContext())
        //    {
        //        lst = context.Students.Where(x => x.Id == para1).ToList();
        //    }
        //    if (lst.Count == 0)
        //    {
        //        return "Student is not found!";
        //    }
        //    foreach (Students s1 in lst){
        //        s += s1.ToString();
        //    }
        //    return s;
        //}
    }
}
