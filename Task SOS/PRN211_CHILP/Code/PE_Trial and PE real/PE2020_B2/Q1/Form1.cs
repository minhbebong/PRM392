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
        List<InfectedCase> result = new List<InfectedCase>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (var context = new PRN292_Spr2020_B2Context())
            {
                result = context.InfectedCases.ToList();
                dataGridView1.DataSource = context.InfectedCases.Select(x => new
                {
                    x.Name,
                    x.Age,
                    x.Sex,
                    x.Nationality,
                    x.Province,
                    x.TraveledFrom,
                    x.ConfirmationDate
                }).ToList();
                listBox1.DataSource = context.InfectedCases.Select(
                    x => x.Province).Distinct().ToList();
                listBox1.SelectedItems.Clear();
                listBox1.SelectedItem = "Ha Noi";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            foreach (string o in listBox1.SelectedItems)
            {
                ls.Add(o);
            }
            using (var context = new PRN292_Spr2020_B2Context())
            {
                result = new List<InfectedCase>();
                foreach (string o in ls)
                {
                    List<InfectedCase> l = context.InfectedCases.
                        Where(x => x.Province == o).ToList();
                    result = result.Concat(l).ToList();
                }
                if (cbMale.Checked && cbFemale.Checked)
                {
                    result = result.Where(x => x.Sex == false
                   || x.Sex == true).ToList();
                }
                else if (cbFemale.Checked)
                {
                    result = result.Where(x => x.Sex == false).ToList();
                }
                else if (cbMale.Checked)
                {
                    result = result.Where(x => x.Sex == true).ToList();
                }
            }
            dataGridView1.DataSource = result.Select(x => new
            {
                x.Name,
                x.Age,
                x.Sex,
                x.Nationality,
                x.Province,
                x.TraveledFrom,
                x.ConfirmationDate
            }).ToList();
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            //    bool? gender = true;
            //    if (cbMale.Checked) gender = true;
            //    if (cbFemale.Checked) gender = false;
            //    using (var context = new PRN292_Spr2020_B2Context())
            //    {
            //        if (cbMale.Checked && cbFemale.Checked)
            //        {
            //            dataGridView1.DataSource = context.InfectedCases.Select(x => new
            //            {
            //                x.Name,
            //                x.Age,
            //                x.Sex,
            //                x.Nationality,
            //                x.Province,
            //                x.TraveledFrom,
            //                x.ConfirmationDate
            //            }).Where(x => x.Province.Equals(listBox1.SelectedItem)).ToList();
            //        } else
            //        {
            //            dataGridView1.DataSource = context.InfectedCases.Select(x => new
            //            {
            //                x.Name,
            //                x.Age,
            //                x.Sex,
            //                x.Nationality,
            //                x.Province,
            //                x.TraveledFrom,
            //                x.ConfirmationDate
            //            }).Where(x => x.Sex == gender && x.Province.Equals(listBox1.SelectedItem)).ToList();
            //        }
            //    }
        }
    }
}
