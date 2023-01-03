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
    public partial class DetailCourses : Form
    {
        string currentID { get; set; }
        
        public DetailCourses()
        {
            InitializeComponent();
        }
        public DetailCourses(string couId)
        {
            currentID = couId;
            InitializeComponent();
            loadForm();       
            this.dataGridView1.Columns["CourseId"].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loadForm()
        {
            int ID = Convert.ToInt32(currentID);
            using (var context = new APContext())
            {
                dataGridView1.DataSource = context.StudentCourses.Select(x => new
                {
                    x.CourseId,
                    x.StudentId,
                    x.Student.FirstName,
                    x.Student.MidName,
                    x.Student.LastName
                }).Where(X => X.CourseId == ID).ToList();
            }
        }
        private void loadForm(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(currentID);
            using (var context = new APContext())
            {
                dataGridView1.DataSource = context.StudentCourses.Select(x => new
                {
                    x.CourseId,
                    x.StudentId,
                    x.Student.FirstName,
                    x.Student.MidName,
                    x.Student.LastName
                }).Where(x => x.CourseId == ID).ToList();
            }
        }
        private void StudentCourse_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "Action";
            deleteCol.Text = "Remove";
            deleteCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteCol);
            loadForm();
            this.dataGridView1.Columns["CourseId"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Action"))
            {
                string STid = dataGridView1.Rows[e.RowIndex].Cells["StudentId"].Value.ToString();
                using (var context = new APContext())
                {
                    Student_Course stc = new Student_Course(Convert.ToInt32(currentID), Convert.ToInt32(STid));
                    context.StudentCourses.Remove(stc);
                    context.SaveChanges();
                    MessageBox.Show("Delete successfully!");
                }
                loadForm();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int IDCOU = Convert.ToInt32(currentID);
            EditStudent formAdd = new EditStudent(IDCOU);
            formAdd.Show();
            formAdd.FormClosed += loadForm;
        }
    }
}
