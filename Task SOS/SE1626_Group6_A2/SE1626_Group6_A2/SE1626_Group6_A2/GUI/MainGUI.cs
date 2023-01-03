using SE1626_Group6_A2.GUI;
using SE1626_Group6_A2.Models;
using System.Text;

namespace SE1626_Group6_A2
{

    public partial class MainGUI : Form
    {

        public List<Album> albums { get; set; }

        public string cartID { get; set; }
        public User user { get; set; }

        private string RandomString(int size)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                sb.Append(c);
            }


            return sb.ToString().ToLower();

            return sb.ToString();
        }
        public MainGUI(User user)
        {
            InitializeComponent();

            this.user = user;
            if (user != null)
            {
                cartID = user.UserName;
                Name = user.FirstName + " " + user.LastName;

            }
            else
            {
                cartID = RandomString(30);

            }
            if (this.user != null)
            {
                if (this.user.Role == 1)
                {
                    lbAdmin.Visible = true;
                }
                else
                {
                    lbAdmin.Visible = false;
                }
                lblLog.Text = $"Logout({this.user.UserName})";
                lblLog.Click += lbLogout_Click;

            }
            else
            {
                lbAdmin.Visible = false;
                lblLog.Text = "Login";
                lblLog.Click += lbLogin_Click;


            }

            //Bat dau load shoppingGui page = 1 , list de phan trang la all 

        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGUI login = new LoginGUI();
            login.ShowDialog();
            this.Show();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void lbShopping_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ShoppingGUI gui = new ShoppingGUI(cartID);
            gui.TopLevel = false;
            gui.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(gui);
            gui.Show();

        }

        private void lbCart_Click(object sender, EventArgs e)
        {
            CartGUI carts = new CartGUI(cartID);
            this.Hide();
            carts.ShowDialog();
            this.Show();
        }

        private void lbAdmin_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AlbumsGUI gui = new AlbumsGUI();
            gui.TopLevel = false;
            gui.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(gui);
            gui.Show();

        }


    }
}