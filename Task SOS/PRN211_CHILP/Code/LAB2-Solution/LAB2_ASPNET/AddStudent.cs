using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB2_ASPNET.Models;
using LAB2_ASPNET.Logics;

namespace LAB2_ASPNET
{
    public partial class AddStudent : Form
    {
        int CourseID { get; set; }
        List<CStudent> lstStudentNot { get; set; }
        public AddStudent()
        {
            InitializeComponent();
        }
        public AddStudent(int id)
        {
            CourseID = id;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataGridViewButtonColumn addCol = new DataGridViewButtonColumn();
            addCol.Name = "Action";
            addCol.Text = "Add";
            addCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(addCol);
            lstStudentNot = CourseManger.getAllStudentNotInCourse(CourseID.ToString());
            dataGridView1.DataSource = lstStudentNot;
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Action"))
            {
                string idSt = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                int n = CourseManger.addNewStudent(idSt, CourseID.ToString());
                MessageBox.Show("Add Successfully!");
                Close();
            }
        }
    }
}
