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
    public partial class MainGUI : Form
    {
        private User userLogin = null;
        private ShoppingGUI shoppingGUI;
        private AlbumGUI albumGUI;
        private ShoppingCart shopCart;
        public MainGUI()
        {
            InitializeComponent();
            shopCart = ShoppingCart.GetCart(null);
        }

        private void shoppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shoppingGUI = new ShoppingGUI(shopCart);
            shoppingGUI.TopLevel = false;
            shoppingGUI.FormBorderStyle = FormBorderStyle.None;
            shoppingGUI.Show();
            shoppingGUI.changeCart += changeCart;
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(shoppingGUI);

        }

        private void changeCart(object sender, EventArgs e)
        {
            countCart();
        }

        private void countCart()
        {
            cartToolStripMenuItem.Text = "Cart(" + shopCart.GetCount() + ")";
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartGUI cartGUI = new CartGUI(shopCart, userLogin);
            cartGUI.changeCart += changeCart;
            cartGUI.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userLogin != null)
            {
                userLogin = null;
                loginToolStripMenuItem.Text = "Login";
                albumToolStripMenuItem.Visible = false;
                shopCart = ShoppingCart.GetCart(null);
                countCart();
                toolStripContainer1.ContentPanel.Controls.Clear();
            }
            else
            {
                LoginGUI login = new LoginGUI();
                DialogResult dr = login.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    this.userLogin = login.user;

                    string role = "user";
                    if (userLogin.Role == 1)
                    {
                        role = "admin";
                        albumToolStripMenuItem.Visible = true;
                    };


                    loginToolStripMenuItem.Text = $"Logout ({role})";
                    string oldID = shopCart.GetCartId();
                    shopCart = ShoppingCart.GetCart(userLogin.UserName);
                    if (shoppingGUI != null)
                    {
                        shoppingGUI.sc = shopCart;
                    }
                    shopCart.MigrateCart(oldID);
                    countCart();
                }
            }

        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            albumGUI = new AlbumGUI();
            albumGUI.TopLevel = false;
            albumGUI.FormBorderStyle = FormBorderStyle.None;
            albumGUI.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(albumGUI);
        }
    }
}
