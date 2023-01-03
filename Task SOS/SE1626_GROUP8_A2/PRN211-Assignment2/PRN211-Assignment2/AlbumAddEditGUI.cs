using PRN211_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Assignment2
{
    public partial class AlbumAddEditGUI : Form
    {
        public Album? Album { get; set; }

        public AlbumAddEditGUI()
        {
            InitializeComponent();
        }

        private void AlbumAddEditGUI_Load(object sender, EventArgs e)
        {
            var genres = Program.MusicStoreContext?.Genres.ToArray()!;
            var artists = Program.MusicStoreContext?.Artists.ToArray()!;

            comboBoxGenre.Items.AddRange(genres);
            comboBoxArtist.Items.AddRange(artists);

            if (Album is not null)
            {
                comboBoxGenre.SelectedIndex = comboBoxGenre.Items.IndexOf(genres.FirstOrDefault(e => e.GenreId == Album.GenreId));
                comboBoxArtist.SelectedIndex = comboBoxArtist.Items.IndexOf(artists.FirstOrDefault(e => e.ArtistId == Album.ArtistId));

                textBoxTitle.Text = Album.Title;
                textBoxPrice.Text = Album.Price.ToString();
                textBoxImage.Text = Album.AlbumUrl;

                try
                {
                    pictureBox1.Load(Path.Combine(Directory.GetCurrentDirectory(), Album?.AlbumUrl.Remove(0, 1)));
                }
                catch
                {
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Album is not null)
            {
                var album = Program.MusicStoreContext?.Albums.FirstOrDefault(e => e.AlbumId == Album.AlbumId);

                if (album is null) return;

                album.Title = textBoxTitle.Text;
                album.Price = decimal.Parse(textBoxPrice.Text);
                album.AlbumUrl = textBoxImage.Text;
                if (comboBoxGenre.SelectedItem is not null) album.GenreId = (comboBoxGenre.SelectedItem as Genre).GenreId;
                if (comboBoxArtist.SelectedItem is not null) album.ArtistId = (comboBoxArtist.SelectedItem as Artist)!.ArtistId;
            }
            else
            {
                var album = new Album();

                album.Title = textBoxTitle.Text;
                album.Price = decimal.Parse(textBoxPrice.Text);
                album.AlbumUrl = textBoxImage.Text;
                if (comboBoxGenre.SelectedItem is not null) album.GenreId = (comboBoxGenre.SelectedItem as Genre).GenreId;
                if (comboBoxArtist.SelectedItem is not null) album.ArtistId = (comboBoxArtist.SelectedItem as Artist)!.ArtistId;

                Program.MusicStoreContext?.Albums.Add(album);
            }
            Program.MusicStoreContext?.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select Image";
            var currentPath = Directory.GetCurrentDirectory();

            openFileDialog.InitialDirectory = Path.Combine(currentPath, "Images");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;

                if (path.StartsWith(currentPath))
                {
                    path = path.Remove(0, currentPath.Length);
                }

                textBoxImage.Text = path;

                try
                {
                    pictureBox1.Load(openFileDialog.FileName);
                }
                catch
                {
                }
            }
        }
    }
}
