using SE1626_Group6_A2.DAO;
using SE1626_Group6_A2.Models;

namespace SE1626_Group6_A2.GUI
{
    public partial class CheckoutGUI : Form
    {
        private User _user { get; set; }
        private List<Cart> _cart { get; set; }
        private CartGUI _cartGUI { get; set; }
        public CheckoutGUI(User user, List<Cart> cart, CartGUI cartGUI)
        {
            InitializeComponent();
            this._user = user;
            this._cart = cart;
            this._cartGUI = cartGUI;
            LoadData();
        }

        void LoadData()
        {
            double price = 0;
            AlbumDAO dao = new AlbumDAO();
            foreach (var item in this._cart)
            {
                price += (double)(dao.LoadAlbumByID(item.AlbumId).Price) * (item.Count);

            }
            txbFirstName.Text = this._user.FirstName;
            txbLastName.Text = this._user.LastName;
            txbEmail.Text = this._user.Email;
            txbTotalPrice.Text = price.ToString("0.###");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MusicStoreContext music = new MusicStoreContext();
                Order order = new Order();
                order.OrderDate = DateTime.Today;
                order.UserName = this._user.UserName;
                order.FirstName = this._user.FirstName;
                order.LastName = this._user.LastName;
                order.Address = txbAddress.Text;
                order.City = txbCity.Text;
                order.State = txbState.Text;
                order.Country = txbCountry.Text;
                order.Email = txbEmail.Text;
                order.Phone = txbPhone.Text;
                order.Total = Decimal.Parse(txbTotalPrice.Text);
                music.Orders.Add(order);
                music.SaveChanges();
                int orderID = order.OrderId;
                MusicStoreContext music_orderDetail = new MusicStoreContext();
                foreach (var item in this._cart)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderId = orderID;
                    orderDetail.AlbumId = item.AlbumId;
                    orderDetail.Quantity = item.Count;
                    AlbumDAO dao = new AlbumDAO();
                    orderDetail.UnitPrice = dao.LoadAlbumByID(item.AlbumId).Price;
                    music_orderDetail.OrderDetails.Add(orderDetail);
                    music_orderDetail.Carts.Remove(item);
                    music_orderDetail.SaveChanges();
                    this._cartGUI.LoadCart();
                    this.Close();
                }
                MessageBox.Show($"OrderID {orderID} checkouted");
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
