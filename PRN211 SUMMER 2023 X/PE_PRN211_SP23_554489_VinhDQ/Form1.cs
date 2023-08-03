using PE_PRN211_SP23_554489_VinhDQ.Models;

namespace PE_PRN211_SP23_554489_VinhDQ
{
    public partial class btnLogin : Form
    {
        public btnLogin()
        {
            InitializeComponent();
        }
        private BookManagement2023DBContext con = new BookManagement2023DBContext();
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string pas = txtpass.Text;
            fManagementBook f = new fManagementBook();
            BookManagementMember b = con.BookManagementMembers.First(x => x.Email.Equals(username) && x.Password.Equals(pas));
            if(b != null) {
                int role = b.MemberRole;
                if(role == 1)
                {
                    this.Hide();
                    f.ShowDialog();
                    f.Tag = 1;
                    this.Show();
                }else if (role== 2)
                {
                    this.Hide();
                    f.ShowDialog();
                    f.Tag = 2;
                    this.Show();
                }
                else
                {
                    this.Hide();
                    f.ShowDialog();
                    f.Tag = 1;
                    this.Show();
                }

            }
            else
            {
                MessageBox.Show("Login fail");
            }
        }
    }
}