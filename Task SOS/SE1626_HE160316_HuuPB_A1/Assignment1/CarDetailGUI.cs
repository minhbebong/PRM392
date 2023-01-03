using Assignment1.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Assignment1
{
    public partial class CarDetailGUI : Form
    {
        public CarDetailGUI(Car car)
        {
            InitializeComponent();
            txtCarid.Text = car.CarId.ToString();
            txtMake.Text = car.Make;
            txtColor.Text = car.Color;
            txtPetname.Text = car.PetName;
            var color = Color.FromName(car.Color.Trim());
            if (color.A!=0)
            {
                bgcolor.BackColor = color;
            }
            else
            {
                bgcolor.BackColor = Color.White;
            }

        }
    }
}
