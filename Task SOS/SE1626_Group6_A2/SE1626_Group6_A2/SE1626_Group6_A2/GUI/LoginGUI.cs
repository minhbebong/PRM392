using SE1626_Group6_A2.DAO;
using SE1626_Group6_A2.Models;

namespace SE1626_Group6_A2.GUI
{
    public partial class LoginGUI : Form
    {
        public Form form { get; set; }
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountDAO dao = new AccountDAO();
            User user = dao.GetUserByUsernameAndPassword(txbUser.Text, txbPass.Text);
            if (user != null)
            {
                this.Hide();
                MainGUI userGUI = new MainGUI(user);
                userGUI.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
