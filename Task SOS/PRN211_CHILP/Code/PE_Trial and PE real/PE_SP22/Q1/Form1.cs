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
            List<int> lstIN = new List<int>() { 133, 138, 154, 164, 180};
            comboBox1.DataSource = lstIN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoom.Text))
            {
                MessageBox.Show("Room title cannot be null!");
                return;
            }
            Room r = new Room(tbRoom.Text, Convert.ToInt32(comboBox1.SelectedItem), Convert.ToInt32(numericUpDown1.Value), tbDes.Text, tbCom.Text);
            int n = DAO.addRoom(r);
            MessageBox.Show("Add successfully!");
        }
    }
}
