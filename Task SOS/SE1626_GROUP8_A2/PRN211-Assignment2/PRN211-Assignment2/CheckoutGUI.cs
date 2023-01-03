using PRN211_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Assignment2
{
    public partial class CheckoutGUI : Form
    {
        public CheckoutGUI()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Program.Settings.User is null) return;

            Order order = new Order()
            {
                UserName = Program.Settings.User.UserName,
                Address = textBoxAddress.Text,
                City = textBoxCity.Text,
                Country = textBoxCountry.Text,
                Email = textBoxEmail.Text,
                FirstName = textBoxFisrtName.Text,
                LastName = textBoxLastName.Text,
                OrderDate = DateTime.Now,
                Phone = textBoxPhone.Text,
                State = textBoxState.Text,
                Total = decimal.Parse(textBoxTotal.Text)
            };

            if (CartHandler.Instance.CreateOrder(order) is int id && id > -1)
            {
                MessageBox.Show($"Order id {id} is saved!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show($"Order Error!");
                DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CheckoutGUI_Load(object sender, EventArgs e)
        {
            textBoxTotal.Text = CartHandler.Instance.GetTotal().ToString();
            textBoxAddress.Text = Program.Settings.User?.Address;
            textBoxCity.Text = Program.Settings.User?.City;
            textBoxCountry.Text = Program.Settings.User?.Country;
            textBoxEmail.Text = Program.Settings.User?.Email;
            textBoxFisrtName.Text = Program.Settings.User?.FirstName;
            textBoxLastName.Text = Program.Settings.User?.LastName;
            textBoxPhone.Text = Program.Settings.User?.Phone;
            textBoxState.Text = Program.Settings.User?.State;
        }
    }
}
