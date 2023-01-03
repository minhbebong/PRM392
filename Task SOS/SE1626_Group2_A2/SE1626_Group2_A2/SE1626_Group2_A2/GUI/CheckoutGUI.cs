using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE1626_Group3_A2.Models;

namespace SE1626_Group3_A2.GUI
{
    public partial class CheckoutGUI : Form
    {
        private ShoppingCart cart;
        private User userLogin;
        public CheckoutGUI(ShoppingCart c, User user)
        {
            InitializeComponent();
            this.cart = c;
            this.userLogin = user;
            FillForm();
        }

        private void FillForm()
        {
            tbFirst.Text = userLogin.FirstName;
            tbLast.Text = userLogin.LastName;
            tbAddr.Text = userLogin.Address;
            tbCity.Text = userLogin.City;
            tbState.Text = userLogin.State;
            tbCountry.Text = userLogin.Country;
            tbPhone.Text = userLogin.Phone;
            tbEmail.Text = userLogin.Email;
            tbTotal.Text = ((double)cart.GetTotal()).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.OrderDate = DateTime.Now;
            order.FirstName = tbFirst.Text;
            order.LastName = tbLast.Text;
            order.Address = tbAddr.Text;
            order.City = tbCity.Text;
            order.State = tbState.Text;
            order.Country = tbCountry.Text;
            order.Phone = tbPhone.Text;
            order.Email = tbEmail.Text;
            order.UserName = userLogin.UserName;
            order.Total = cart.GetTotal();
 
            int id = cart.CreateOrder(order);
            MessageBox.Show($"Order id {id} saved!");
            this.Close();
        }
    }
}
