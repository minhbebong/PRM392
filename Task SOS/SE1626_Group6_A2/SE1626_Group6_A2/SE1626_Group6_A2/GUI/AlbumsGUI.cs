using SE1626_Group6_A2.DAO;
using SE1626_Group6_A2.Models;


namespace SE1626_Group6_A2.GUI
{
    public partial class AlbumsGUI : Form
    {
        MusicStoreContext music = new MusicStoreContext();
        AlbumDAO albumDAO = new AlbumDAO();
        public AlbumsGUI()
        {
            InitializeComponent();
            LoadData();

        }
        void LoadData()
        {
            cbGenre.DataSource = music.Genres.ToList();
            cbGenre.DisplayMember = "Name";
            cbTitle.DataSource = music.Albums.ToList();
            cbTitle.DisplayMember = "Title";
            cbTitle.ValueMember = "Title";
            cbTitle.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            dataGridView1.DataSource = albumDAO.LoadAllAlbum();
        }

        private void cbGenre_SelectedValueChanged(object sender, EventArgs e)
        {

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Genre genre = (Genre)cb.SelectedValue;
                dataGridView1.DataSource = albumDAO.LoadAlbumByGenre(genre.GenreId);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = albumDAO.LoadAlbumByTitle(cbTitle.Text);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AlbumAddEditGUI albumAE = new AlbumAddEditGUI("add", -1);
            this.Hide();

            albumAE.ShowDialog();
            this.LoadData();
            this.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult res = MessageBox.Show("Do you want to delete", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    AlbumDAO dao = new AlbumDAO();
                    dao.Delete((int)dataGridView1.Rows[e.RowIndex].Cells["albumId"].Value);
                    this.LoadData();
                }
                if (res == DialogResult.No)
                {

                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {

                AlbumAddEditGUI albumAE = new AlbumAddEditGUI("edit", (int)dataGridView1.Rows[e.RowIndex].Cells["albumId"].Value);
                this.Hide();
                albumAE.ShowDialog();
                this.LoadData();
                this.Show();
            }
        }


    }
}
