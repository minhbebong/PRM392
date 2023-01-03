using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PRN211_Assignment2.Models;
using System.Windows.Forms;

namespace PRN211_Assignment2
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();

            albumItem1.OnCartChange += OnCartChange;
            albumItem2.OnCartChange += OnCartChange;
            albumItem3.OnCartChange += OnCartChange;
        }

        public List<Cart>? Carts { get; set; }

        public User? User
        {
            get { return Program.Settings.User; }
            set
            {
                Program.Settings.User = value!;
                CartHandler.Instance.MigrateCart();
                Program.Settings.CartId = value?.UserName;
                OnUserChange();
            }
        }

        private void OnUserChange()
        {
            loginToolStripMenuItem.Visible = User is null;
            logoutToolStripMenuItem.Visible = !loginToolStripMenuItem.Visible;
            albumsToolStripMenuItem.Visible = !loginToolStripMenuItem.Visible;

            logoutToolStripMenuItem.Text = $"Logout ({User?.UserName ?? string.Empty})";

            albumsToolStripMenuItem.Visible = User is User u && u.IsAdmin;

            // Load carts
            OnCartChange();
        }

        private void OnCartChange()
        {
            this.Carts = CartHandler.Instance.GetCartItems();
            cartToolStripMenuItem.Text = $"Cart ({CartHandler.Instance.GetCount()})";
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGUI loginGUI = new LoginGUI();

            if (loginGUI.ShowDialog() == DialogResult.OK)
            {
                this.User = loginGUI.LoginUser;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.User = null;
        }

        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdmin.BringToFront();
            if (panelAdmin.Visible) return;
            panelAdmin.Visible = true;

            foreach (var genre in Program.MusicStoreContext?.Genres!)
            {
                comboBoxAdminSearch.Items.Add(genre);
            }

            AdminLoad();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartGUI cartGUI = new CartGUI();
            cartGUI.OnCartChange += OnCartChange;
            cartGUI.Show();
        }

        private void shoppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShopping.BringToFront();
            if (panelShopping.Visible) return;
            panelShopping.Visible = true;

            foreach (var genre in Program.MusicStoreContext?.Genres!)
            {
                comboBoxSearch.Items.Add(genre);
            }

            if (comboBoxSearch.Items.Count > 0) comboBoxSearch.SelectedIndex = 0;

            buttonSearch.PerformClick();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private int _currentPage = 0;
        private int _pageSize = 0;
        private List<Album>? _searchResult;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Genre? genre = comboBoxSearch.SelectedItem as Genre;

            if (genre is null) return;

            string title = textBoxSearch.Text.ToLower();

            _searchResult = Program.MusicStoreContext?.Albums.Include(e => e.Artist).Where(e => e.Title.ToLower().Contains(title) && e.GenreId == genre.GenreId).ToList();

            if (_searchResult is null) return;

            _currentPage = -1;
            _pageSize = decimal.ToInt32(Math.Ceiling((decimal)_searchResult.Count() / 3));
            buttonNext_Click(null, null);
        }

        private void SetAlbum(AlbumItem group, Album? album)
        {
            group.Visible = album is not null;

            if (album is null) return;
            group.Album = album;
        }

        private void SetSearchResult()
        {
            var GBS = new AlbumItem[] { albumItem1, albumItem2, albumItem3 };

            for (int i = 0; i < GBS.Length; i++)
                SetAlbum(GBS[i], (_currentPage * 3 + i < _searchResult?.Count) ? _searchResult?[_currentPage * 3 + i] : null);

            buttonPrevious.Enabled = _currentPage > 0;
            buttonNext.Enabled = _currentPage < _pageSize - 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _currentPage = Math.Min(_currentPage + 1, _pageSize - 1);
            SetSearchResult();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            _currentPage = Math.Max(_currentPage - 1, 0);
            SetSearchResult();
        }


        // Admin 
        private void AdminLoad(Func<Album, bool> predict = null!)
        {
            var allAlbums = Program.MusicStoreContext?.Albums.Where(predict ?? (_ => true)).ToList();
            dataGridView1.Rows.Clear();

            foreach (var album in allAlbums!)
            {
                dataGridView1.Rows.Add(album, album.ArtistId, album.Title, album.Price, album.AlbumUrl, "Edit", "Delete");
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            labelAlbumCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private void buttonAdminCreate_Click(object sender, EventArgs e)
        {
            AlbumAddEditGUI albumAddEditGUI = new AlbumAddEditGUI();
            if (albumAddEditGUI.ShowDialog() == DialogResult.OK) buttonAdminSearch.PerformClick();
        }

        private void buttonAdminSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxAdminSearch.SelectedItem is not null)
            {
                int genreId = (comboBoxAdminSearch.SelectedItem as Genre)!.GenreId;
                string title = textBoxAdminSearch.Text.ToLower();

                AdminLoad(e => e.GenreId == genreId && e.Title.ToLower().Contains(title));
            }
            else
            {
                AdminLoad();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    // ArtistId
                    break;
                case 2:
                    // Title
                    break;
                case 3:
                    // Price
                    break;
                case 4:
                    // AlbumUrl
                    break;
                case 5:
                    // Edit
                    AlbumAddEditGUI albumAddEditGUI = new AlbumAddEditGUI();
                    albumAddEditGUI.Album = (Album)dataGridView1[0, e.RowIndex].Value;
                    if (albumAddEditGUI.ShowDialog() == DialogResult.OK) buttonAdminSearch.PerformClick();
                    break;
                case 6:
                    // Delete
                    if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Album album = (Album)dataGridView1[0, e.RowIndex].Value;

                        album = Program.MusicStoreContext?.Albums.FirstOrDefault(e => e.AlbumId == album.AlbumId)!;

                        if (album is not null)
                        {
                            Program.MusicStoreContext?.Albums.Remove(album);
                            Program.MusicStoreContext?.SaveChanges();
                            MessageBox.Show("That album is deleted!");
                        }

                        buttonAdminSearch.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}