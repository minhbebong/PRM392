using Microsoft.AspNetCore.Mvc;
using Q3.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Q3.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            List<CourseSchedule> courses = new List<CourseSchedule>();
            List<Course> lstCo = new List<Course>();
            using (var context = new PRN292_Summer2020_B1Context())
            {
                courses = context.CourseSchedules.ToList();
                lstCo = context.Courses.ToList();

                //courses = context.CourseSchedules.Select(x => new
                //{
                //    x.Course.CourseCode,
                //    x.TeachingDate,
                //    x.Slot,
                //    x.Room.RoomCode,
                //    x.Description
                //}).ToList();
            }
            return View(courses);
        }
    }
}
