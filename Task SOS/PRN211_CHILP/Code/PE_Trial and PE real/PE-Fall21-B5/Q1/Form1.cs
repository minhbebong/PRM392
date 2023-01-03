using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q1.DataAccess;
using Q1.Models;

namespace Q1
{
    public partial class Form1 : Form
    {
        List<DEmployee> lstEm { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataToForm(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Managerment.listAllEmployee();
            cbPosition.DataSource = Managerment.listAllPosition();
            tbName_TextChanged(sender, e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToForm(sender, e);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tbName.Text))
            //    lstEm = EmployeeDAO.getAllEmployee();
            ////else lstEm = EmployeeDAO.searchByName(tbName.Text);
            //else
            //{
            //    lstEm = lstEm.Where(x => x.Name.ToLower().Contains(tbName.Text.ToLower())).ToList();
            //}

            //if (cbPosition.SelectedIndex == 0)
            //    lstEm = lstEm;
            ////lstEm = EmployeeDAO.getAllEmployee();
            //else
            //{
            //    lstEm = lstEm.Where(x => x.Position.Equals(cbPosition.SelectedItem.ToString())).ToList();
            //}

            //if (rbAllGender.Checked)
            //    lstEm = lstEm.Where(x => x.Sex.ToLower().Contains("male")).ToList();
            //if (rbMale.Checked)
            //    lstEm = lstEm.Where(x => x.Sex.Equals("Male")).ToList();
            //if (rbFemale.Checked)
            //    lstEm = lstEm.Where(x => x.Sex.Equals("Female")).ToList();

            //dataGridView1.DataSource = lstEm;
            string text = tbName.Text;
            if (string.IsNullOrEmpty(text))
            {
                lstEm = Managerment.listAllEmployee();
            }
            else
            {
                lstEm = EmployeeDAO.searchByName(tbName.Text);
            }

            if (cbPosition.SelectedIndex == 0)
            {

            }
            else
            {
                lstEm = lstEm.Where(x => x.Position.ToLower().
                Contains(cbPosition.SelectedItem.ToString()
                .ToLower().Trim())).ToList();
            }

            if (rbAllGender.Checked)
            {
                List<DEmployee> a = lstEm.Where(x => x.Sex.ToLower().Contains("male")).ToList();
                lstEm = a;
            }
            if (rbFemale.Checked)
            {
                List<DEmployee> a = lstEm.Where(x => x.Sex.ToLower().Contains("female")).ToList();
                lstEm = a;
            }
            if (rbMale.Checked)
            {
                List<DEmployee> a = lstEm.Where(x => x.Sex.ToLower().Equals("male")).ToList();
                lstEm = a;
            }
            dataGridView1.DataSource = lstEm;
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
