using LAB2_ASPNET.DataAccess;
using LAB2_ASPNET.Models;
using LAB2_ASPNET.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_ASPNET
{
    public partial class DetailCourse : Form
    {
        int courseID { get; set; }
        List<CStudent> lstStudent { get; set; }

        public DetailCourse(int id)
        {
            courseID = id;
            InitializeComponent();
            LoadData();
        }
        public DetailCourse()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "Action";
            deleteCol.Text = "Remove";
            deleteCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteCol);

            lstStudent = CourseManger.GetAllStudentInCourse(courseID.ToString());
            dataGridView1.DataSource = lstStudent;
        }
        private void LoadData1()
        {
            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "Action";
            deleteCol.Text = "Remove";
            deleteCol.UseColumnTextForButtonValue = true;

            lstStudent = CourseManger.GetAllStudentInCourse(courseID.ToString());
            dataGridView1.DataSource = lstStudent;
        }
        private void LoadData(object sender, EventArgs e)
        {
            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "Action";
            deleteCol.Text = "Remove";
            deleteCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteCol);

            lstStudent = CourseManger.GetAllStudentInCourse(courseID.ToString());
            dataGridView1.DataSource = lstStudent;
        }
        private void DetailCourse_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Action"))
            {
                string STid = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                int n = CourseManger.DeleteStudent(STid);
                MessageBox.Show("Delete successfully!");
                LoadData1();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddStudent formAdd = new AddStudent(courseID);
            formAdd.Show();
            formAdd.FormClosed += LoadData;
        }
    }
}
