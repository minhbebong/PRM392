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
    public partial class EditStudent : Form
    {
        int courseIDD { get; set; }
        public EditStudent()
        {
            InitializeComponent();
        }
        public EditStudent(int id)
        {
            courseIDD = id;
            InitializeComponent();
            LoadStudent();
        }

        private void loadAddForm()
        {
            //int courseIDs = Convert.ToInt32(courseIDD);
            //courseIDs
        }
        private void loadAddForm(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStudent()
        {
            using (var context = new APContext())
            {
                dataGridView1.DataSource = context.Students.Select(x => new
                {
                    x.StudentId,
                    x.Roll,
                    x.FirstName,
                    x.MidName,
                    x.LastName
                }).ToList();
            }
        }
        private void LoadStudent(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new APContext())
            {
                dataGridView1.DataSource = context.Students.Select(x => new
                {
                    x.StudentId,
                    x.Roll,
                    x.FirstName,
                    x.MidName,
                    x.LastName
                });
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Action"))
            {
                try
                {
                    string idSt = dataGridView1.Rows[e.RowIndex].Cells["StudentId"].Value.ToString();
                    int st_id = Convert.ToInt32(idSt);
                    using (var context = new APContext())
                    {
                        Student_Course stc = new Student_Course(courseIDD, st_id);
                        context.Add(stc);
                        context.SaveChanges();
                        MessageBox.Show("Add Success fully!");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This student is already in this course!");
                }
            }
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn addCol = new DataGridViewButtonColumn();
            addCol.Name = "Action";
            addCol.Text = "Add";
            addCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(addCol);
            LoadStudent();
        }
    }
}
