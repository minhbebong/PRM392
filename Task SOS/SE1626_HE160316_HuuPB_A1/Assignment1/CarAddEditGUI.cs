using Assignment1.DAL;
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

namespace Assignment1
{
    public partial class CarAddEditGUI : Form
    {
        public Car Car  { get; set; }
        public CarAddEditGUI()
        {
            InitializeComponent();
        }

        private void CarAddEditGUI_Load(object sender, EventArgs e)
        {
            if (Car is not null)
            {
                txtCarID.Text = Car.CarId.ToString();
                txtCarID.ReadOnly = true;

                txtMake.Text = Car.Make;
                txtColor.Text = Car.Color?.Trim();
                txtPetname.Text = Car.PetName;
            }
        }
        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            var color1 = Color.FromName((sender as Control).Text);
            color.BackColor = color1.A != 0 ? color1 : Color.White;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCarID.Text, out int carID))
            {
                if (carID >= 0)
                {
                    Car car = new Car()
                    {
                        CarId = carID,
                        Make = txtMake.Text,
                        Color = txtColor.Text,
                        PetName = txtPetname.Text
                    };

                    if (Car is not null)
                    {
                        CarDAO.GetInstance().Edit(car);
                        MessageBox.Show("This Car is updated!");
                        Close();
                    }
                    else
                    {
                        if (!CarDAO.GetInstance().isCarExist(car))
                        {
                            CarDAO.GetInstance().Insert(car);
                            MessageBox.Show("This Car is added!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("This Car is already exist!");
                        }                        
                    }

                }
                else MessageBox.Show("Car ID must be >= 0!");
            }
            else MessageBox.Show("Car ID must be a integer!");
        }
    }
}
