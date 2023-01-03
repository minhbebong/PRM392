using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PRN211_Assignment2
{
    public partial class CartGUI : Form
    {
        public delegate void OnCartChangeEvent();
        public OnCartChangeEvent OnCartChange { get; set; }

        public List<Cart>? Carts { get; set; }

        public CartGUI()
        {
            InitializeComponent();
        }

        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    // Add to cart
                    CartHandler.Instance.AddToCart((dataGridViewCart[0, e.RowIndex].Value as Cart)?.Album!);
                    LoadData();
                    OnCartChange?.Invoke();
                    break;
                case 2:
                    // AlbumId
                    break;
                case 3:
                    // Count
                    break;
                case 4:
                    // DateCreated
                    break;
                case 5:
                    // Remove from cart
                    CartHandler.Instance.Remove((dataGridViewCart[0, e.RowIndex].Value as Cart)?.Album!);
                    LoadData();
                    OnCartChange?.Invoke();
                    break;
                default:
                    break;
            }
        }

        private void CartGUI_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            this.Carts = CartHandler.Instance.GetCartItems();

            dataGridViewCart.Rows.Clear();

            if (this.Carts is null)
            {
                MessageBox.Show("Cannot load Carts data!");
                return;
            }

            decimal? total = 0;

            foreach (var cart in this.Carts)
            {
                dataGridViewCart.Rows.Add(cart, "Add to cart", cart.AlbumId, cart.Count, cart.DateCreated, "Remove from cart");
                total += cart.Album?.Price * cart.Count;
            }

            textBoxTotal.Text = total.ToString();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (Carts?.Count == 0 || Program.Settings.User is null) return;

            CheckoutGUI checkoutGUI = new CheckoutGUI();
            if (checkoutGUI.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                OnCartChange?.Invoke();
            }
        }
    }
}
