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
            using (var context = new PRN211_Spr22Context())
            {
                cbRoom.DataSource = context.Rooms.Select(x => x.Title).ToList();
                cbFree.DataSource = context.Services.Select(x => x.FeeType).Distinct().ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
