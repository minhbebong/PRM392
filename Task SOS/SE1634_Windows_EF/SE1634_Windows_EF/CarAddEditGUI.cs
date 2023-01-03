using SE1634_Windows_EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE1634_Windows_EF
{
    public partial class CarAddEditGUI : Form
    {
        CarsContext context;
        public CarAddEditGUI(int carId, CarsContext context)
        {
            InitializeComponent();
            txtCarId.Text = carId.ToString();
            this.context = context;
            if(carId != -1)
            {
                Car car = context.Cars.Find(carId);
                txtMake.Text = car.Make;
                txtColor.Text = car.Color;
                txtPetName.Text = car.PetName;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
    
            // Add
            if (int.Parse(txtCarId.Text) == -1)
            {
                Car car = new Car
                {
                    Make = txtMake.Text,
                    Color = txtColor.Text,
                    PetName = txtPetName.Text
                };
                try
                {
                    context.Cars.Add(car);
                    context.SaveChanges();
                    MessageBox.Show("Added");
                }
                catch
                {
                    MessageBox.Show("Failled!");
                }
                
            }
            else
            {

                try
                {
                    Car car = context.Cars.Find(int.Parse(txtCarId.Text));
                    car.Make = txtMake.Text;
                    car.Color = txtColor.Text;
                    car.PetName = txtPetName.Text;
                    context.Cars.Update(car);
                    context.SaveChanges();
                    MessageBox.Show("Edited!");
                }
                catch
                {
                    MessageBox.Show("Failled!");
                }
            }
        }
    }
}
