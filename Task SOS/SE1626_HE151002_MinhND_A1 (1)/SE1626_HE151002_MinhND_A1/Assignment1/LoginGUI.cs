using Assignment1.DAL;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
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
    public partial class LoginGUI : Form
    {
        public string LoginAccount { get; set; }
        public LoginGUI()
        {
            InitializeComponent();
        }
        public Account loadJson()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
            Account account = new Account();
            account.Username = config.GetSection("Admin").GetSection("User").Value;
            account.Password = config.GetSection("Admin").GetSection("Password").Value;

            return account;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account admin = loadJson();
            if (txtUser.Text == admin.Username && txtPassword.Text == admin.Password)
            {
                MessageBox.Show("Login successfully");
                DialogResult = DialogResult.OK;
                LoginAccount = "admin";
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        
    }
}
