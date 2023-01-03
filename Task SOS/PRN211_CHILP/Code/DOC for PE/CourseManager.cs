using DemoCRUDMVCCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCRUDMVCCore.Logics
{
    public class CourseManager
    {
        APContext context;

        public CourseManager()
        {
            context = new APContext();
        }

        public List<Course> GetCourses(int SubjectID)
        {
            context.Subjects.ToList();
            if (SubjectID == 0)
                return context.Courses.ToList();
            else
                return context.Courses.Where(x => x.SubjectId == SubjectID).ToList();
        }

        public Course GetCourse(int CourseId)
        {
            return context.Courses.FirstOrDefault(x => x.CourseId == CourseId);
        }

        public List<Student> GetStudentsOfCourse(int CourseId)
        {
            return context.StudentCourses.Where(x => x.CourseId == CourseId)
                        .Join(context.Students,
                        stucourse => stucourse.StudentId,
                        stu => stu.StudentId,
                        (stucourse, stu) => stu
                        ).ToList();
        }

        public void Edit(Course NewCourse)
        {
            Course c = context.Courses.FirstOrDefault(x => x.CourseId == NewCourse.CourseId);
            c.CourseCode = NewCourse.CourseCode;
            c.CourseDescription = NewCourse.CourseDescription;
            c.SubjectId = NewCourse.SubjectId;
            context.SaveChanges();      
        }

        public void Delete(int CourseId)
        {
            //cu de day da.
        }
    }
}
