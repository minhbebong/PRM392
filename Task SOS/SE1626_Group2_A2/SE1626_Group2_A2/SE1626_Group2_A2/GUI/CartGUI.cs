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
    public partial class CartGUI : Form
    {
        public event EventHandler changeCart;
        private ShoppingCart cart;
        private User user;
        public CartGUI(ShoppingCart c, User login)
        {
            InitializeComponent();
            cart = c;
            user = login;
            if (user == null)
            {
                btnCheckout.Enabled = false;
            }
            renderDGV();
        }

        private void renderDGV()
        {
            {
                dgvOrders.AutoGenerateColumns = false;
                dgvOrders.DataSource = null;
                dgvOrders.Columns.Clear();

                DataGridViewButtonColumn add = new DataGridViewButtonColumn();
                add.Name = "btnAdd";
                add.HeaderText = "Add";
                add.Text = "Add to cart";
                add.UseColumnTextForButtonValue = true;
                dgvOrders.Columns.Add(add);


                dgvOrders.Columns.Add("id", "AlbumId");
                dgvOrders.Columns["id"].DataPropertyName = "AlbumId";

                dgvOrders.Columns.Add("count", "Count");
                dgvOrders.Columns["count"].DataPropertyName = "Count";

                dgvOrders.Columns.Add("date", "DateCreated");
                dgvOrders.Columns["date"].DataPropertyName = "DateCreated";

                DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
                remove.Name = "btnRemove";
                remove.HeaderText = "Remove";
                remove.Text = "Remove from cart";
                remove.UseColumnTextForButtonValue = true;
                dgvOrders.Columns.Add(remove);

                
                double totalDouble = (double)cart.GetTotal();
                tbTotal.Text = totalDouble.ToString();

                dgvOrders.DataSource = cart.GetCartItems();

            }
        }




        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            //get cell click value
            int id = int.Parse(dgvOrders.Rows[e.RowIndex].Cells["id"].Value.ToString());
            List<Cart> c = cart.GetCartItems();

            int recordID = c[e.RowIndex].RecordId;

            using (MusicStoreContext db = new MusicStoreContext())
            {
                Album a = db.Albums.Where(ab => ab.AlbumId == id).FirstOrDefault();
                if (a == null) return;
                if (e.ColumnIndex == 0)
                {
                    cart.AddToCart(a, recordID);
                    changeCart.Invoke(sender, e);
                }
                else if (e.ColumnIndex == 4)
                {
                    cart.RemoveFromCart(recordID);
                    changeCart.Invoke(sender, e);
                }
            }
            renderDGV();

        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cart.GetCount() == 0)
            {
                MessageBox.Show("Your cart is empty!");
                return;
            }
            CheckoutGUI checkoutGUI = new CheckoutGUI(cart, user);
            checkoutGUI.ShowDialog();
            renderDGV();
        }


    }
}
