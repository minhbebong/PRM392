using Assignment1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class CarDetailGUI : Form
    {
        public Car Car { get; set; }

        public CarDetailGUI()
        {
            InitializeComponent();
        }

        private void CarDetailGUI_Load(object sender, EventArgs e)
        {
            textBoxCarID.Text = Car.CarID.ToString();
            textBoxMake.Text = Car.Make;
            textBoxColor.Text = Car.Color?.Trim();
            textBoxPetname.Text = Car.PetName;
        }

        private void buttonBack_Click(object sender, EventArgs e) => Close();

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            var color = Color.FromName((sender as Control).Text);
            panelColor.BackColor = color.A != 0 ? color : Color.White;
        }
    }
}
