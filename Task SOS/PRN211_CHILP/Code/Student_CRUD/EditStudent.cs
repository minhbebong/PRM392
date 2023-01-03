using Student_CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_CRUD
{
    public partial class EditStudent : Form
    {
        public Student CurrentStudent { get; }
        public EditStudent()
        {
            InitializeComponent();
        }
        public EditStudent(Student s)
        {
            InitializeComponent();
            CurrentStudent = s;
        }
        private void EditStudent_Load(object sender, EventArgs e)
        {
            if (CurrentStudent != null)
            {
                editID.Text = CurrentStudent.StudentId.ToString();
                editRoll.Text = CurrentStudent.Roll;
                editFname.Text = CurrentStudent.FirstName;
                editMname.Text = CurrentStudent.MidName;
                editLname.Text = CurrentStudent.LastName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(editID.Text);
            string roll = editRoll.Text;
            string fname = editFname.Text;
            string mname = editMname.Text;
            string lname = editLname.Text;
            Student s = new Student(id, roll, fname, mname, lname);
            DialogResult result = MessageBox.Show("Are you sure about that?", "Confirm",
                MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        using (var context = new APContext())
                        {
                            context.Update(s);
                            context.SaveChanges();
                        }
                        MessageBox.Show("Update successfully!");
                        this.Text = "[OK]";
                        this.Close();
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
