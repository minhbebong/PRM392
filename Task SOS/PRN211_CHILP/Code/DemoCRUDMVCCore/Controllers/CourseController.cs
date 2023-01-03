using DemoCRUDMVCCore.Logics;
using DemoCRUDMVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCRUDMVCCore.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult List(int id)
        {
            CourseManager courseManager = new CourseManager();
            SubjectManager subjectManager = new SubjectManager();
            List<Subject> subjects = subjectManager.GetSubjects();
            List<Course> courses = courseManager.GetCourses(id);
            ViewBag.Subjects = subjects;
            ViewBag.CurSubject = id;
            return View(courses);
        }

        public IActionResult Edit(int id)
        {
            CourseManager courseManager = new CourseManager();
            SubjectManager subjectManager = new SubjectManager();
            ViewBag.Subjects = subjectManager.GetSubjects();
            return View(courseManager.GetCourse(id));
        }

        public IActionResult DoEdit(Course NewCourse)
        {
            CourseManager courseManager = new CourseManager();
            courseManager.Edit(NewCourse);
            return RedirectToAction("List", new { Id = NewCourse.SubjectId });
        }

        public IActionResult DoDelete(int id)
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
