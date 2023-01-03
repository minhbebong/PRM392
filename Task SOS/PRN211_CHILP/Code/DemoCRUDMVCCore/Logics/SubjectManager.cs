using DemoCRUDMVCCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCRUDMVCCore.Logics
{
    public class SubjectManager
    {
        APContext context;

        public SubjectManager()
        {
            context = new APContext();
        }

        public List<Subject> GetSubjects()
        {
            return context.Subjects.ToList();
        }
    }
}
