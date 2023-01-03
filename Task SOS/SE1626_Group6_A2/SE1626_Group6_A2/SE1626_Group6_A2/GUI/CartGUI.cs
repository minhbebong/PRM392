using Microsoft.EntityFrameworkCore;
using SE1626_Group6_A2.DAO;
using SE1626_Group6_A2.Models;
using System.Data;

namespace SE1626_Group6_A2.GUI
{
    public partial class CartGUI : Form
    {
        public string username { get; set; }
        public List<Cart> cart = new List<Cart>();
        CartDAO carts = new CartDAO();
        AlbumDAO dao = new AlbumDAO();
        public CartGUI(string userName)
        {
            InitializeComponent();
            this.username = userName;
            LoadCart();
        }

        public void LoadCart()
        {

            cart = carts.GetCartsByUser(this.username);
            double price = 0;
            foreach (var item in cart)
            {
                price += (double)(dao.LoadAlbumByID(item.AlbumId).Price) * (item.Count);
                txbPrice.Text = price.ToString("0.###");

            }
            dataGridView1.DataSource = cart;
        }

        MusicStoreContext music = new MusicStoreContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int albID = (int)dataGridView1.Rows[e.RowIndex].Cells["albumID"].Value;
                Cart alb = cart.Where(p => p.AlbumId == albID).FirstOrDefault();
                int count = (int)dataGridView1.Rows[e.RowIndex].Cells["count"].Value;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Add")
                {
                    count += 1;
                    dataGridView1.Rows[e.RowIndex].Cells["count"].Value = count;
                    alb.Count = count;
                    music.Entry(alb).State = EntityState.Modified;
                    music.SaveChanges();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
                {
                    if (count > 1)
                    {
                        count -= 1;
                        dataGridView1.Rows[e.RowIndex].Cells["count"].Value = count;
                        alb.Count = count;
                        music.Entry(alb).State = EntityState.Modified;
                        music.SaveChanges();

                    }
                    else if (count == 1)
                    {
                        music.Remove(alb);
                        music.SaveChanges();
                        txbPrice.Text = "0";
                    }

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
                {
                    AlbumDAO dao = new AlbumDAO();
                    Album album = dao.LoadAlbumByID(albID);
                    MessageBox.Show($"Album ID: {album.AlbumId}\nAlbum Name:{album.Title}");
                }

                LoadCart();
            }
            catch
            {

            }


        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            LoadCart();
            User user = music.Users.Where(p => p.UserName == this.username).FirstOrDefault();
            string msg = "";
            if (cart.Count == 0)
            {
                MessageBox.Show("Your cart don't have any albums, return to shop to buy some albums");
                btnCheckout.Enabled = false;
            }
            else if (user == null)
            {
                MessageBox.Show("Guest can't check out, return to login and buy albums");
                btnCheckout.Enabled = false;
            }
            else
            {
                CheckoutGUI gui = new CheckoutGUI(user, cart, this);
                this.Hide();
                gui.ShowDialog();
                this.Show();
            }

        }

    }
}
