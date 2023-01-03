using SE1634_Windows_EF.Models;

namespace SE1634_Windows_EF
{
    public partial class Form1 : Form
    {
        CarsContext context;
        public Form1()
        {
            InitializeComponent();
            context = new CarsContext();
            bindGrid();
        }

        private void bindGrid()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = context.Cars.ToList();
            dataGridView1.Columns["Orders"].Visible = false;
            
            int count = dataGridView1.Columns.Count;
            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Text = "Details",
                Name = "Details",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count, btnDetail);

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count + 1, btnEdit);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count + 2, btnDelete);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int carId = (int) dataGridView1.Rows[e.RowIndex].Cells["CarId"].Value;
                DialogResult dr = MessageBox.Show("Do you want to delete?", "Confirm", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    try
                    {
                        Car car = context.Cars.Find(carId);
                        context.Cars.Remove(car);
                        context.SaveChanges();
                        MessageBox.Show("Deleted!");
                        bindGrid();
                    }
                    catch
                    {
                        MessageBox.Show("Failled!");
                    }
                }
            }
            if(e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int carId = (int)dataGridView1.Rows[e.RowIndex].Cells["CarId"].Value;
                CarAddEditGUI carAddEditGUI = new CarAddEditGUI(carId, context);
                DialogResult dr = carAddEditGUI.ShowDialog();
                if(dr == DialogResult.OK)
                    bindGrid();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CarAddEditGUI carAddEditGUI = new CarAddEditGUI(-1, context);
            DialogResult dr = carAddEditGUI.ShowDialog();
            if (dr == DialogResult.OK)
                bindGrid();
        }
    }
}