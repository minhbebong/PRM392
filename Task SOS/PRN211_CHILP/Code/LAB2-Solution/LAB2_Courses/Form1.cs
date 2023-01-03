using LAB2_Courses.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_Courses
{

    public partial class Form1 : Form
    { 
        List <Course> lstCourse { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private List<string> getAllTerm()
        {
            List<string> items = new List<string>();
            using (var context = new APContext())
            {
                items = context.Courses.Select(x => x.Term.TermName).Distinct().ToList();
                items.Insert(0, "All Terms");
            }
            return items;
        }
        private List<string> getAllSubject()
        {
            List<string> items = new List<string>();
            using (var context = new APContext())
            {
                items = context.Courses.Select(x => x.Subject.SubjectName).Distinct().ToList();
                items.Insert(0, "All Subject");
            }
            return items;
        }
        private List<string> getAllCampus()
        {
            List<string> items = new List<string>();
            using (var context = new APContext())
            {
                items = context.Courses.Select(x => x.Campus.CampusName).Distinct().ToList();
                items.Insert(0, "All Campus");
            }
            return items;
        }
        private void LoadData()
        {
            using (var context = new APContext())
            {
                dtgCourses.DataSource = context.Courses.Select(x => new
                {
                    x.CourseId,
                    x.CourseCode,
                    x.CourseDescription,
                    x.Subject.SubjectName,
                    x.Instructor.InstructorFirstName,
                    x.Term.TermName,
                    x.Campus.CampusName
                }).ToList();
                cbSubject.DataSource = getAllSubject();
                cbCampus.DataSource = getAllCampus();
                cbTerm.DataSource = getAllTerm();
            }
        }
        private void LoadData1(object sender, EventArgs e)
        {
            using (var context = new APContext())
            {
                dtgCourses.DataSource = context.Courses.Select(x => new
                {
                    x.CourseId,
                    x.CourseCode,
                    x.CourseDescription,
                    x.Subject.SubjectName,
                    x.Instructor.InstructorFirstName,
                    x.Term.TermName,
                    x.Campus.CampusName
                }).ToList();
            }
        }
        private void dtgCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //using (var context = new APContext())
            //{
            //    //lstSTC = context.Join()
            //}
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dtgCourses.Columns[e.ColumnIndex].Name.Equals("detailCol"))
            {
                string idC = dtgCourses.Rows[e.RowIndex].Cells["CourseId"].Value.ToString();
                DetailCourses newform = new DetailCourses(idC);
                newform.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn detailCol = new DataGridViewButtonColumn();
            detailCol.Name = "detailCol";
            detailCol.Text = "Detail";
            detailCol.UseColumnTextForButtonValue = true;
            dtgCourses.Columns.Add(detailCol);
            LoadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbCampus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void searchBySubject(string s)
        {
            s = cbSubject.Text;
            using (var context = new APContext())
            {
                dtgCourses.DataSource = context.Courses.Where(x => x.SubjectId == Convert.ToInt32(s)).ToList();
            }
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            if (lstCourse is null)
            {
                MessageBox.Show("No data to search!");
            }
            if (cbSubject.SelectedIndex != 0)
            {
                //dtgCourses.DataSource = searchBySubject(lstCourse, cbSubject.SelectedItem);
            }
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string s = cbSubject.Text;
            //string s1 = cbCampus.Text;
            //string s2 = cbTerm.Text;
            //List<Course> Result = new List<Course>();
            ////MessageBox.Show(s + s1 + s2);
            //using (var context = new APContext())
            //{

            //    if (cbSubject.SelectedIndex != 0)
            //    {
            //        Result.AddRange(context.Courses.Where(x => x.Subject.SubjectName.Equals(s)).ToList());
            //    }
            //    if (cbTerm.SelectedIndex != 0)
            //    {
            //        Result.AddRange(context.Courses.Where(x => x.Campus.CampusName.Equals(s1)).ToList());
            //    }
            //    if (cbCampus.SelectedIndex != 0)
            //    {
            //        Result.AddRange(context.Courses.Where(x => x.Term.TermName.Equals(s2)).ToList());
            //    }
            //    //if (cbSubject.SelectedIndex != 0 && cbCampus.SelectedIndex != 0 && cbTerm.SelectedIndex != 0)
            //    //{
            //    //    dtgCourses.DataSource = context.Courses.Where(x => x.Subject.SubjectName.Equals(s)).Where(x => x.Campus.CampusName.Equals(s1)).
            //    //    Where(x => x.Term.TermName.Equals(s2)).ToList();
            //    //}
            //    dtgCourses.DataSource = Result;
            //}
        }
    }
}
