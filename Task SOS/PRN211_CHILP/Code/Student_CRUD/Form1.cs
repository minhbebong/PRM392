using Student_CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_CRUD
{
    public partial class Form1 : Form
    {
        List<Student> lstSTU;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbMname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadDataStudent(object sender, EventArgs e)
        {
            using (var context = new APContext())
            {
                dataGridView1.DataSource = context.Students.ToList();
            }
        }
        private void LoadDataStudent()
        {
            using (var context = new APContext())
            {
                dataGridView1.DataSource = context.Students.ToList();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn editcol = new DataGridViewButtonColumn();
            editcol.Name = "editcol";
            editcol.Text = "Edit";
            editcol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editcol);

            DataGridViewButtonColumn deletecol = new DataGridViewButtonColumn();
            deletecol.Name = "DeleteCol";
            deletecol.Text = "Delete";
            deletecol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deletecol);
            LoadDataStudent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("editcol"))
            {
                //C1
                //string Name = dataGridView1.Rows[e.RowIndex].Cells["NameCol"].Value.ToString();

                //C2
                List<Student> students = (List<Student>)dataGridView1.DataSource;
                string roll = students[e.RowIndex].Roll;
                int Id = Convert.ToInt32(students[e.RowIndex].StudentId);
                EditStudent newform = new EditStudent(students[e.RowIndex]);
                newform.FormClosed += LoadDataStudent;
                newform.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("DeleteCol"))
            {
                List<Student> students = (List<Student>)dataGridView1.DataSource;
                int Id = Convert.ToInt32(students[e.RowIndex].StudentId);
                using (var context = new APContext())
                {
                    DialogResult result = MessageBox.Show("Are you sure about that?", "Confirm",
                MessageBoxButtons.OKCancel);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                try
                                {
                                    using (var context1 = new APContext())
                                    {
                                        Student s = context.Students.FirstOrDefault(x => x.StudentId == Id);
                                        context1.Remove(s);
                                        context1.SaveChanges();
                                        MessageBox.Show("Delete successfully");
                                        LoadDataStudent();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Can not delete this student!");
                                }
                                this.Text = "[OK]";
                                break;
                            }
                        case DialogResult.Cancel:
                            {
                                this.Text = "[Cancel]";
                                break;
                            }
                    }
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about that?", "Confirm",
                MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        try
                        {
                            using (var context = new APContext())
                            {
                                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                                {
                                    int id = Convert.ToInt32(row.Cells[1].Value);
                                    Student s = context.Students.FirstOrDefault(x => x.StudentId == id);
                                    context.Remove(s);
                                }
                                context.SaveChanges();
                                MessageBox.Show("Delete successfully");
                                LoadDataStudent();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Can not delete this student!");
                        }
                        this.Text = "[OK]";
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        this.Text = "[Cancel]";
                        break;
                    }
            }

        }
        private static readonly Regex regex = new Regex(@"^\d+$");
        private bool checkStringNumber(string s)
        {
            if (regex.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool isNumber(string s)
        {
            return s.All(char.IsNumber);
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            using (var context = new APContext())
            {
                lstSTU = context.Students.ToList();
            }
            if (lstSTU is null)
            {
                MessageBox.Show("Need to load data");
                return;
            }
            //check data is null
            if (tbID.Text.Equals(String.Empty) || tbRoll.Text.Equals(String.Empty) || tbFname.Text.Equals(String.Empty)
                || tbMname.Text.Equals(String.Empty) || tbLname.Text.Equals(String.Empty))
            {
                MessageBox.Show("Data is not allowed null!");
                return;
            }
            //check id is a number
            if (!isNumber(tbID.Text))
            {
                MessageBox.Show("ID must be a number!");
                return;
            }
            //check id and roll exist
            foreach (Student ss in lstSTU)
            {
                if (Convert.ToInt32(tbID.Text) == ss.StudentId)
                {
                    MessageBox.Show("ID is already exists!");
                    return;
                }
                if (tbRoll.Text.Equals(ss.Roll))
                {
                    MessageBox.Show("Roll is already exists!");
                    return;
                }
            }
            //check roll is string only number
            if (!checkStringNumber(tbRoll.Text))
            {
                MessageBox.Show("Roll must be number only!");
                return;
            }
            Student s = new Student(Convert.ToInt32(tbID.Text), tbRoll.Text, tbFname.Text, tbMname.Text, tbLname.Text);
            DialogResult result = MessageBox.Show("Are you sure about that?", "Confirm",
                MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        using (var context = new APContext())
                        {
                            context.Add(s);
                            context.SaveChanges();
                            MessageBox.Show("Add successfully!");
                            LoadDataStudent();
                        }
                        this.Text = "[OK]";
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        this.Text = "[Cancel]";
                        break;
                    }
            }


        }
    }
}
