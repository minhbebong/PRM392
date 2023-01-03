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

        private void LoadData()
        {
            using (var context = new PRN292_Summer2020_B1Context())
            {
                List<Room> lst = context.Rooms.ToList();
                listBox1.DataSource = lst.Select(x =>x.RoomCode).ToList();
                cbCourse.DataSource = context.Courses.Select(x => x.CourseCode).ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox1.Text == null)
            {
                MessageBox.Show("Description is not allow null!");
                return;
            }
            string courecode = cbCourse.SelectedItem.ToString();
            string romcode = listBox1.SelectedItem.ToString();
            using (var context = new PRN292_Summer2020_B1Context())
            {
                Course c = context.Courses.FirstOrDefault(x => x.CourseCode.Equals(courecode));
                int courID = c.CourseId;
                Room ro = context.Rooms.FirstOrDefault(x => x.RoomCode.Equals(romcode));
                int roID = ro.RoomId;
                int slot = Convert.ToInt32(numericUpDown1.Value);
                DateTime techdte = dateTimePicker1.Value;
                string des = textBox1.Text;
                CourseSchedule cousc = new CourseSchedule(courID, techdte, slot, roID, des);
                context.Add(cousc);
                context.SaveChanges();
                MessageBox.Show("Add successfully!");
            }
        }
    }
}
