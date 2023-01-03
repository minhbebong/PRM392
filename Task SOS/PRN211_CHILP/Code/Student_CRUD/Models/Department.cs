using System;
using System.Collections.Generic;

#nullable disable

namespace Student_CRUD.Models
{
    public partial class Department
    {
        public Department()
        {
            Subjects = new HashSet<Subject>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
