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
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        public User? LoginUser { get; set; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            this.LoginUser = Program.MusicStoreContext?.Users.FirstOrDefault(e => e.UserName == username && e.Password == password);

            if (this.LoginUser is not null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("That member is not exist!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}
