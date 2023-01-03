using Microsoft.EntityFrameworkCore;
using SE1626_Group6_A2.DAO;
using SE1626_Group6_A2.Models;
using System.Data;



namespace SE1626_Group6_A2.GUI
{
    public partial class AlbumAddEditGUI : Form
    {
        AlbumDAO dao = new AlbumDAO();
        MusicStoreContext music = new MusicStoreContext();
        private string action;
        private int id;
        public MainGUI form;
        public string Action { get => action; set => action = value; }
        public int Id { get => id; set => id = value; }
        public AlbumAddEditGUI(string action, int id)
        {
            InitializeComponent();
            this.action = action;
            this.form = form;
            this.id = id;
            LoadGUI();
        }
        public AlbumAddEditGUI(string action)
        {
            InitializeComponent();
            this.action = action;
            LoadGUI();
        }

        void LoadGUI()
        {

            cbGenre.DataSource = music.Genres.ToList();
            cbGenre.DisplayMember = "Name";
            cbGenre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbArtist.DataSource = music.Artists.ToList();
            cbArtist.DisplayMember = "Name";
            cbArtist.AutoCompleteSource = AutoCompleteSource.CustomSource;
            if (this.action == "edit")
            {
                Album album = dao.LoadAlbumByID(this.id);
                cbArtist.Text = music.Artists.Where(p => p.ArtistId == album.ArtistId).FirstOrDefault().Name;
                cbGenre.Text = music.Genres.Where(p => p.GenreId == album.GenreId).FirstOrDefault().Name;
                txbPrice.Text = album.Price.ToString();
                txbTitle.Text = album.Title;
                pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, $"Resources{album.AlbumUrl}");
                txbImgUrl.Text = album.AlbumUrl;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Image file";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*gif)| *.jpg;*.jpeg;*.png;*.gif";

                ofd.ShowDialog();
                if (ofd.FileName == "")
                    return;
                string filename = ofd.FileName;
                string[] str = filename.Split("\\");
                pictureBox1.ImageLocation = filename;
                //luu vao resources cua chuong trinh(Application.StartupPath(bin\.net 6) + "Resources\\Images\\" + str.Last()), luu duong dan cua resouces toi database(\\Images\\str.Last())
                File.Copy(pictureBox1.ImageLocation, Application.StartupPath + str.Last(), true);
                txbImgUrl.Text = "\\Images\\" + str.Last();
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.action == "add")
            {

                AlbumDAO album = new AlbumDAO();
                album.AddAlbums(new Album()
                {
                    GenreId = (int)cbGenre.Tag,
                    ArtistId = (int)cbArtist.Tag,
                    Price = Decimal.Parse(txbPrice.Text),
                    Title = txbTitle.Text,
                    AlbumUrl = txbImgUrl.Text,
                });
            }
            else if (this.action == "edit")
            {
                Album album = dao.LoadAlbumByID(this.id);
                album.GenreId = (int)cbGenre.Tag;
                album.ArtistId = (int)cbArtist.Tag;
                album.Price = Decimal.Parse(txbPrice.Text);
                album.Title = txbTitle.Text;
                album.AlbumUrl = txbImgUrl.Text;
                music.Entry(album).State = EntityState.Modified;
            }

            music.SaveChanges();
            this.Close();


        }

        private void cbGenre_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue != null)
            {
                Genre genre = (Genre)cb.SelectedValue;
                cb.Tag = genre.GenreId;

            }
        }

        private void cbArtist_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue != null)
            {
                Artist artist = (Artist)cb.SelectedValue;
                cb.Tag = artist.ArtistId;

            }
        }

        private void AlbumAddEditGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
