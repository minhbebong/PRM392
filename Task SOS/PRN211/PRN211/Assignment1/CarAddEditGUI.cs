using Assignment1.Entity;
using Assignment1.Model;
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
        public Car Car { get; set; }

        public CarAddEditGUI()
        {
            InitializeComponent();
        }

        private void CarAddEditGUI_Load(object sender, EventArgs e)
        {
            if (Car is not null)
            {
                textBoxCarID.Text = Car.CarID.ToString();
                textBoxCarID.ReadOnly = true;

                textBoxMake.Text = Car.Make;
                textBoxColor.Text = Car.Color?.Trim();
                textBoxPetname.Text = Car.PetName;
            }
        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            var color = Color.FromName((sender as Control).Text);
            panelColor.BackColor = color.A != 0 ? color : Color.White;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCarID.Text, out int carID))
            {
                if (carID >= 0)
                {
                    Car car = new Car()
                    {
                        CarID = carID,
                        Make = textBoxMake.Text,
                        Color = textBoxColor.Text,
                        PetName = textBoxPetname.Text
                    };

                    if (Car is not null)
                    {
                        CarModel.UpdateCar(car);
                        MessageBox.Show("This Car is updated!");
                        Close();
                    }
                    else
                    {
                        if (!CarModel.IsCarExist(car))
                        {
                            CarModel.AddCar(car);
                            MessageBox.Show("A new Car is added!");
                            Close();
                        }
                        else MessageBox.Show("This car is already exist!");
                    }
                }
                else MessageBox.Show("Car ID must be >= 0!");
            }
            else MessageBox.Show("Car ID must be a integer!");
        }
    }
}
