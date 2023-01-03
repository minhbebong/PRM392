using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> lst = new List<int> { 133, 138, 154, 164, 180 };
            comboBox1.DataSource = lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            room ro = new room();
            ro.title = tbTitle.Text;
            if (string.IsNullOrEmpty(ro.title))
            {
                MessageBox.Show("not empty title pls");
                return;
            }
            ro.description = richDes.Text;
            ro.comment = richDes.Text;
            ro.floor = numericUpDown1.Value + "";
            ro.roomSquare = comboBox1.Text;
            DAO dao = new DAO();
            dao.AddRoom(ro);
            MessageBox.Show("add vao thanh cong");
        }
    }
}
