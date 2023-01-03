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
    public partial class Form1 : Form
    {
        List<SCourse> lstCo;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            lstCo = CourseManger.GetAllCourseFromDB();
            dtgCourses.DataSource = lstCo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn detailCol = new DataGridViewButtonColumn();
            detailCol.Name = "detailCol";
            detailCol.Text = "Detail";
            detailCol.UseColumnTextForButtonValue = true;
            dtgCourses.Columns.Add(detailCol);
            loadData();
        }
        private void dtgCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dtgCourses.Columns[e.ColumnIndex].Name.Equals("detailCol"))
            {
                string idC = dtgCourses.Rows[e.RowIndex].Cells["CourseId"].Value.ToString();
                int Cou_id = Convert.ToInt32(idC);
                DetailCourse formDe = new DetailCourse(Cou_id);
                formDe.Show();
            }
        }

        private void dtgCourses_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dtgCourses.Columns[e.ColumnIndex].Name.Equals("detailCol"))
            {
                string idC = dtgCourses.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                int Cou_id = Convert.ToInt32(idC);
                DetailCourse formDe = new DetailCourse(Cou_id);
                formDe.Show();
            }
        }
    }
}
