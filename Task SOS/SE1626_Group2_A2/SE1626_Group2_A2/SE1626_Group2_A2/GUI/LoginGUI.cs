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
    public partial class LoginGUI : Form
    {
        public User user { get; set; }
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userIn = tbUser.Text;
            string passIn = tbPass.Text;
            using (MusicStoreContext msc = new MusicStoreContext())
            {
                User u = msc.Users.Where(u => u.UserName == userIn && u.Password == passIn).FirstOrDefault();
                if (u != null)
                {
                    this.user = u;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("That member does not exist!");
                }
            }
        }
    }
}
