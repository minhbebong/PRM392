using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataTxt
{
    internal class Student
    {
        public int mssv { get; set; }
        public String name { get; set; }
        public String nganh { get; set; }
        public DateTime birtDate { get; set; }
        public int NamHoc { get; set; }
        public double HocBong { get; set; }

        public Student()
        {
        }

        public Student(int mssv, string name, string nganh, DateTime birtDate, int namHoc, double hocBong)
        {
            this.mssv = mssv;
            this.name = name;
            this.nganh = nganh;
            this.birtDate = birtDate;
            NamHoc = namHoc;
            HocBong = hocBong;
        }

        public override string ToString()
        {
            return mssv + "|" + name + "|" + nganh + "|" + birtDate.ToString("dd/MMM/yyyy") + "|" + NamHoc + "|" + HocBong.ToString() + "\n";
        }

        public Student ConvertStu(string line)
        {
            string[] re = line.Split("|");
            try
            {
                int id = Convert.ToInt32(re[0]);
                String name = re[1];
                String nganh = re[2];
                DateTime birth = Convert.ToDateTime(re[3]);
                int nam = Convert.ToInt32(re[4]);
                double tien = Convert.ToDouble(re[5]);
                Student s = new Student(id, name, nganh, birth, nam, tien);
                return s;
            }
            catch (Exception)
            {
                Console.WriteLine("cai nay bi loi roi");
            }

            return null;
        }
    }

    internal class ReadFile
    {
        String path = @"F:\PRN211\LinQ_exc\ReadStudent.txt";
        public List<Student> readStr(String a)
        {
            List<Student> lstSt = new List<Student>();
            Student stu = new Student();
            String line;
            try
            {
                line = System.IO.File.ReadAllText(a).Trim();
            }
            catch
            {
                line = "";
            }

            // Console.WriteLine(line);
            List<string> lst = new List<String>();
            String student;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '\n')
                {
                    student = line.Substring(0, i - 1);
                    lst.Add(student);
                    line = line.Substring(i + 1);
                    i = 0;
                }
            }
            lst.Add(line);
            foreach (string s in lst)
            {
                //   Console.WriteLine("cai nay la list chua convert: "+s);
                try
                {
                    Student s0 = stu.ConvertStu(s);
                    lstSt.Add(s0);
                }
                catch
                {
                    Console.WriteLine("some things is not right");
                }
            }

            return lstSt;
        }


        public List<Student> SearchByID(List<Student> list, int id)
        {
            return list.Where(x => x.mssv == id).ToList();
        }

        public List<Student> SearchByName(List<Student> list, string nameT)
        {
            return list.Where(x => x.name.ToLower().Contains(nameT.ToLower())).ToList();
        }

        public List<Student> SearchByClass(List<Student> list, string name)
        {
            return list.Where(x => x.nganh.ToLower().Equals(name.ToLower())).ToList();
        }

        public List<Student> SearchByClassVaTien(List<Student> list, string classN, double tien)
        {
            return list.Where(x => x.nganh.ToLower().Equals(classN.ToLower()) && x.HocBong >= tien).ToList();
        }

        public List<Student> SearchByYearBirth(List<Student> list, int nam)
        {
            return list.Where(x => x.birtDate.Year == nam).ToList();
        }

        public List<Student> FromYearToYear(List<Student> list, DateTime min, DateTime max)
        {
            return list.Where(x => DateTime.Compare(x.birtDate, min) > 0 && DateTime.Compare(x.birtDate, max) < 0).ToList();
        }

        public List<Student> FindYear(List<Student> list, int Year)
        {
            return list.Where(x => x.NamHoc == Year).ToList();
        }

        public List<Student> FindHocBong(List<Student> list, double min, double max)
        {
            return list.Where(x => x.HocBong >= min && x.HocBong <= max).ToList();
        }

        public String[] showNganh(List<Student> list)
        {
            List<String> a = list.Select(x => x.nganh).Distinct().ToList();

            a.Insert(0, "Show all");
            return a.ToArray();
        }

        public String[] showYearBirth(List<Student> list)
        {
            List<Student> lstS = list.OrderBy(x => x.birtDate.Year).ToList();
            List<String> a = lstS.Select(x => x.birtDate.Year.ToString()).Distinct().ToList();
            a.Insert(0, "Show all");
            return a.ToArray();
        }

        public String[] showEntryYear(List<Student> list)
        {
            List<Student> lstS = list.OrderBy(x => x.NamHoc).ToList();
            List<String> a = lstS.Select(x => x.NamHoc.ToString()).Distinct().ToList();
            a.Insert(0, "Show all");
            return a.ToArray();
        }

        public int setIDStu(List<Student> list)
        {
            int sid = 0;
            foreach (Student s in list)
            {
                sid = s.mssv;
            }

            return sid + 1;
        }

        public int checkInt(String s)
        {
            int a;
            try
            {
                a = Convert.ToInt32(s);
            }
            catch
            {
                DateTime d = DateTime.Today;
                a = d.Year;
            }
            return a;
        }

    }
}
