using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q1.Models;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2020,3,23);
            using (var context = new PRN292_Spr2020_B1Context())
            {
                listBox1.DataSource = context.DailyReports.Select(x => x.Country).Distinct().ToList();
                dataGridView1.DataSource = context.DailyReports.Where(x => x.Country.Equals("China") && x.Date == dateTimePicker1.Value).Select(x => new
                {
                    x.Country,
                    x.Date,
                    x.NewCases
                }).ToList();
            }
            listBox1.SelectedItem = "China";
            listBox1_SelectedIndexChanged(sender, e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lstStr = new List<string>();
            foreach (object i in listBox1.SelectedItems)
            {
                lstStr.Add(i.ToString());
            }
            using (var context = new PRN292_Spr2020_B1Context())
            {
                foreach(string a in lstStr)
                {
                    dataGridView1.DataSource = context.DailyReports.Where(x => x.Country.Equals(a) && x.Date == dateTimePicker1.Value).Select(x => new
                    {
                        x.Country,
                        x.Date,
                        x.NewCases
                    }).ToList();
                }
            }
        }
    }
}
