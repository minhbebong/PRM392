using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_LinQ
{
    static class StudentExtension
    {
        public static void Display(this Student s)
        {
            if (s is null) Console.WriteLine("Student is null object!");
            else Console.WriteLine(s.ToString());
        }
        public static void Display(this List<Student> lstSt)
        {
            if (lstSt.Count == 0) Console.WriteLine("Khong co item thoa man dieu kien!");
            else {
                Console.WriteLine("Student in list: ");
                foreach (Student st in lstSt) Console.WriteLine(st.ToString());
            }
        }

    }
}
