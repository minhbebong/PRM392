using Microsoft.Extensions.Configuration;
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
        public class LoginGUISetting
        {
            [ConfigurationKeyName("user")]
            public string? User { get; set; }

            [ConfigurationKeyName("password")]
            public string? Password { get; set; }
        }

        public string LoginAccount { get; set; }

        public LoginGUISetting Setting { get; set; } = new LoginGUISetting();

        public LoginGUI()
        {
            InitializeComponent();

            Program.Configuration.GetSection("login").Bind(Setting);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Setting.User == textBoxUser.Text && Setting.Password == textBoxPassword.Text)
            {
                MessageBox.Show("Login Successful");
                DialogResult = DialogResult.OK;
                LoginAccount = "admin";
                this.Close();
            }
            else {
                MessageBox.Show("Login Failed");
                textBoxUser.Clear();
                textBoxPassword.Clear();
            }
        }
    }
}
