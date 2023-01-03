using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q2.Models;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataFromDB()
        {
            using (var context = new PE_Fall21B5Context())
            {
                dataGridView1.DataSource = context.Employees.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Sex,
                    x.Dob,
                    x.Position
                }).ToList();
                List<string> lstPos = new List<string>{ "Developer", "Tester", "Leader", "Manager" };
                cbPosition.DataSource = lstPos;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromDB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id"].Value);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    using (var context = new PE_Fall21B5Context())
                    {
                        int empID = Convert.ToInt32(cellValue);
                        Employee emp = context.Employees.FirstOrDefault(x => x.Id == empID);
                        tbID.Text = emp.Id.ToString();
                        tbName.Text = emp.Name;
                        if (emp.Sex.Equals("Male"))
                        {
                            rbMale.Checked = true;
                        } else
                        {
                            rbFemale.Checked = true;
                        }
                        dateTimePicker1.Value = emp.Dob;
                        cbPosition.SelectedItem = emp.Position;
                    }
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            cbPosition.SelectedIndex = 0;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            using (var context = new PE_Fall21B5Context())
            {
                string sex = "";
                if (rbMale.Checked)
                {
                    sex = "Male";
                } else
                {
                    sex = "Female";
                }
                Employee emp = new Employee(tbName.Text, dateTimePicker1.Value, sex, cbPosition.SelectedItem.ToString());
                context.Add(emp);
                context.SaveChanges();
            }
            LoadDataFromDB();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int emp_id = Convert.ToInt32(tbID.Text);
            string sex = "";
            if (rbMale.Checked) sex = "Male";
            else sex = "Female";
            Employee emp1 = new Employee(emp_id, tbName.Text, dateTimePicker1.Value, sex, cbPosition.SelectedItem.ToString());
            using (var context = new PE_Fall21B5Context())
            {
                context.Update(emp1);
                context.SaveChanges();
                
            }
            LoadDataFromDB();
            cbPosition.SelectedItem = emp1.Position;
        }
    }
}
