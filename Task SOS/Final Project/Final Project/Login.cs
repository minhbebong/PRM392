using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Login : Form
    {
        Controller.UserDAO uDAO = new Controller.UserDAO();
        public Login()
        {
            InitializeComponent();
        }


        private void btlogin_Click(object sender, EventArgs e)
        {
            String user = tbuser.Text;
            String pass = tbpass.Text;
            Boolean checkRb = cbRb.Checked;
            if (uDAO.checkLogin(user, pass, checkRb))
            {
                Home home = new Home();
                this.Hide();
                home.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }

    }
}
