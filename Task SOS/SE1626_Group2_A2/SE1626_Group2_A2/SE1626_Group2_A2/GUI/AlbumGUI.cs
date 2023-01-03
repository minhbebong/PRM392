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
    public partial class AlbumGUI : Form
    {
        private List<Album> albumList;
        public AlbumGUI()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadDGVAlbums();
        }

        private void loadCbGenre()
        {
            using (MusicStoreContext db = new MusicStoreContext())
            {
                List<Genre> genreList = db.Genres.ToList();
                genreList.Insert(0, new Genre() { GenreId = 0, Name = "All" });
                cbGenre.DisplayMember = "Name";
                cbGenre.ValueMember = "GenreId";
                cbGenre.SelectedItem = 0;
                cbGenre.DataSource = genreList;
            }
        }

        private void formatDGVAlbums()
        {
            dgvAlbums.AutoGenerateColumns = false;
            dgvAlbums.Columns.Add("albumIdCol", "AlbumId");
            dgvAlbums.Columns["albumIdCol"].DataPropertyName = "AlbumId";
            dgvAlbums.Columns["albumIdCol"].Visible = false;
            dgvAlbums.Columns.Add("artistIdCol", "ArtistId");
            dgvAlbums.Columns["artistIdCol"].DataPropertyName = "ArtistId";
            dgvAlbums.Columns.Add("titleCol", "Title");
            dgvAlbums.Columns["titleCol"].DataPropertyName = "Title";
            dgvAlbums.Columns.Add("priceCol", "Price");
            dgvAlbums.Columns["priceCol"].DataPropertyName = "Price";
            dgvAlbums.Columns.Add("albumUrlCol", "AlbumUrl");
            dgvAlbums.Columns["albumUrlCol"].DataPropertyName = "AlbumUrl";

            DataGridViewButtonColumn editcol = new DataGridViewButtonColumn();
            editcol.Name = "Edit";
            editcol.HeaderText = "Edit";
            editcol.Text = "Edit";
            editcol.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deletecol = new DataGridViewButtonColumn();
            deletecol.Name = "Delete";
            deletecol.HeaderText = "Delete";
            deletecol.Text = "Delete";
            deletecol.UseColumnTextForButtonValue = true;
            dgvAlbums.Columns.Add(editcol);
            dgvAlbums.Columns.Add(deletecol);
        }

        private void loadDGVAlbums()
        {
            int genreId = Convert.ToInt32(cbGenre.SelectedValue.ToString());
            string rg = txtTitle.Text;
            using (MusicStoreContext db = new MusicStoreContext())
            {
                if (genreId == 0)
                {
                    albumList = db.Albums.Where(a => a.Title.Contains(rg)).ToList();
                }
                else
                {
                    albumList = db.Albums.Where(a => a.Title.Contains(rg) && a.GenreId == genreId).ToList();
                }
                dgvAlbums.DataSource = albumList;
                lbCount.Text = $"The number of albums:  {albumList.Count()}";
            }
        }

        private void AlbumGUI_Load(object sender, EventArgs e)
        {
            loadCbGenre();
            formatDGVAlbums();
            loadDGVAlbums();
        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MusicStoreContext db = new MusicStoreContext())
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvAlbums.Columns[e.ColumnIndex].Name == "Edit")
                    {
                        int albumId = (int)dgvAlbums.Rows[e.RowIndex].Cells["albumIdCol"].Value;
                        AlbumAddEditGUI frm = new AlbumAddEditGUI(albumId);
                        frm.ShowDialog();
                    }
                    else if (dgvAlbums.Columns[e.ColumnIndex].Name == "Delete")
                    {
                        var rs = MessageBox.Show("Do you want to delete?",
                            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            try
                            {
                                db.Albums.Remove(db.Albums.ToList()[e.RowIndex]);
                                if (db.SaveChanges() > 0)
                                {
                                    MessageBox.Show("That album is deleted!");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("That album can not be deleted!");
                            }
                        }
                    }
                }
            }
            loadDGVAlbums();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AlbumAddEditGUI frm = new AlbumAddEditGUI(-1);
            frm.ShowDialog();
            loadDGVAlbums();
        }
    }
}
