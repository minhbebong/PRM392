using Assignment1.DAL;
using Assignment1.DTL;
using System.Data;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private string? _loginAccount;
        public string? LoginAccount
        {
            get => _loginAccount;
            set
            {
                _loginAccount = value;
                bool isShow = (value != null);

                menuStrip1.Items[0].Text = isShow ? $"Logout ({LoginAccount})" : $"Login";
                dataGridView1.Columns["Edit"].Visible = isShow;
                dataGridView1.Columns["Delete"].Visible = isShow;
                btnAddnew.Visible = isShow;
            }
        }
        public Form1()
        {
            InitializeComponent();
            bindGrid();

            LoginAccount = null;
        }
        private void bindGrid()
        {

            DataTable dt = CarDAO.GetInstance().GetDataTable();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt;
            label1.Text = "The numbers of cars: " + dt.Rows.Count;
            int count = dataGridView1.Columns.Count;


            
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count, btnDelete);
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count, btnEdit);
            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Text = "Detail",
                Name = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count, btnDetail);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Detail"].Index)
            {
                Car car = CarDAO.GetInstance().getCarById((int)dataGridView1.Rows[e.RowIndex].Cells["carId"].Value);
                CarDetailGUI carDetailGUI = new CarDetailGUI(car);
                DialogResult dialogResult = carDetailGUI.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    bindGrid();
            }
            else
                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                new CarAddEditGUI(){
                    Car = CarDAO.GetInstance().getCarById((int)dataGridView1.Rows[e.RowIndex].Cells["carId"].Value)
                }.ShowDialog();
                bindGrid();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int carId=(int)dataGridView1.Rows[e.RowIndex].Cells["carId"].Value;
                DialogResult dialogResult = MessageBox.Show($"Are you sure to delete ?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CarDAO.GetInstance().Delete(carId);
                    bindGrid();
                }
            }


        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginAccount != null)
            {
                LoginAccount = null;
                return;
            }

            // Show Login Form
            LoginGUI loginGUI = new LoginGUI();
            if (loginGUI.ShowDialog() == DialogResult.OK)
            {
                LoginAccount = loginGUI.LoginAccount;
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            new CarAddEditGUI().ShowDialog();
            bindGrid();
        }
    }
}