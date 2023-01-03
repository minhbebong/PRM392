using Assignment1.Entity;
using Assignment1.Model;
using System.Data.SqlClient;

namespace Assignment1
{
    public partial class CarGUI : Form
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
                buttonAddNew.Visible = isShow;
            }
        }

        public CarGUI()
        {
            InitializeComponent();
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

        private void CarGUI_Load(object sender, EventArgs e) => LoadDataFromDB();

        private void LoadDataFromDB()
        {
            // Load All Cars
            var carList = CarModel.GetAllCars();

            // Bind to the grid
            dataGridView1.Rows.Clear();

            foreach (var car in carList)
            {
                dataGridView1.Rows.Add(new object[] { car, car.Make, car.Color, car.PetName, "Detail", "Edit", "Delete" });
            }

            labelNumberOfCars.Text = carList.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 4: // Detail 
                    new CarDetailGUI()
                    {
                        Car = (Car)dataGridView1.Rows[e.RowIndex].Cells[0].Value
                    }.ShowDialog();
                    break;
                case 5: // Edit
                    new CarAddEditGUI()
                    {
                        Car = (Car)dataGridView1.Rows[e.RowIndex].Cells[0].Value
                    }.ShowDialog();
                    LoadDataFromDB();
                    break;
                case 6: // Delete
                    if (MessageBox.Show("Are you sure to delete this car?", "Delete Car", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CarModel.DeleteCar((Car)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        LoadDataFromDB();
                    }
                    break;
                default:
                    break;
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            new CarAddEditGUI().ShowDialog();
            LoadDataFromDB();
        }
    }
}