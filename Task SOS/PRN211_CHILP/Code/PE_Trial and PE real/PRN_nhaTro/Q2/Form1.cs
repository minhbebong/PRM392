using Microsoft.EntityFrameworkCore;
using Q2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataForDGV()
        {
            using (var context = new PRN211_Spr22Context())
            {
                dataGridView1.DataSource = context.Services.
                    Select(x => new
                    {
                        x.RoomTitle,
                        x.RoomTitleNavigation.Floor,
                        x.RoomTitleNavigation.Square,
                        x.Month,
                        x.Year,
                        x.FeeType,
                        x.Amount,
                        x.PaymentDate,
                        x.Employee
                    }).
                    ToList();
                cbRoomTitle.DataSource = context.Rooms.Select(x => x.Title).Distinct().ToList();
                cbRoomTitle.Text = null;
                cbFeeType.DataSource = context.Services.Select(x => x.FeeType).Distinct().ToList();
                cbFeeType.Text = null;
            }
        }

        private void combobox_TextChanged()
        {
            using (var context = new PRN211_Spr22Context())
            {
                dataGridView1.DataSource = context.Services.
                    Select(x => new
                    {
                        x.RoomTitle,
                        x.RoomTitleNavigation.Floor,
                        x.RoomTitleNavigation.Square,
                        x.Month,
                        x.Year,
                        x.FeeType,
                        x.Amount,
                        x.PaymentDate,
                        x.Employee
                    }).
                    Where(x => x.RoomTitle.Contains(cbRoomTitle.Text)
                        && x.FeeType.Contains(cbFeeType.Text)
                        ).
                    ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void cbRoomTitle_TextChanged(object sender, EventArgs e)
        {
            combobox_TextChanged();
        }

        private void cbFeeType_TextChanged(object sender, EventArgs e)
        {
            combobox_TextChanged();
        }
    }
}
