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
    public partial class AlbumAddEditGUI : Form
    {
        public AlbumAddEditGUI()
        {
            InitializeComponent();
        }

        public AlbumAddEditGUI(int albumId)
        {
            InitializeComponent();
            txtAlbumId.Text = albumId.ToString();
            if (albumId != -1)
            {
                using (MusicStoreContext db = new MusicStoreContext())
                {
                    Album album = db.Albums.Find(albumId);
                    txtGenre.Text = album.GenreId.ToString();
                    txtArtist.Text = album.ArtistId.ToString();
                    txtTitle.Text = album.Title;
                    txtPrice.Text = album.Price.ToString();
                    txtFile.Text = album.AlbumUrl;
                }
            }
        }

        private void loadCB()
        {
            using (MusicStoreContext db = new MusicStoreContext())
            {
                List<Genre> genreList = db.Genres.ToList();
                cbGenre.DisplayMember = "Name";
                cbGenre.ValueMember = "GenreId";
                cbGenre.DataSource = genreList;

                List<Artist> artistList = db.Artists.ToList();
                cbArtist.DataSource = artistList;
                cbArtist.DisplayMember = "Name";
                cbArtist.ValueMember = "ArtistId";

                if (int.Parse(txtAlbumId.Text) != -1)
                {
                    cbGenre.SelectedItem = db.Genres.Where(g => g.GenreId == int.Parse(txtGenre.Text)).FirstOrDefault();
                    cbArtist.SelectedItem = db.Artists.Where(a => a.ArtistId == int.Parse(txtArtist.Text)).FirstOrDefault();
                    try
                    {
                        ptbImg.Image = Image.FromFile($@"Assets\{txtFile.Text.Substring(1)}");

                    }
                    catch
                    {
                        ptbImg.Image = Image.FromFile($@"Assets\Images\placeholder.gif");
                    }
                }
            }
        }

        private void AlbumAddEditGUI_Load(object sender, EventArgs e)
        {
            loadCB();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string getFileName(string path)
        {
            string[] arr = path.Split('\\');
            return @$"/Images/{arr[arr.Length - 1]}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtPrice.Text == "" || txtFile.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                using (MusicStoreContext db = new MusicStoreContext())
                {
                    if (int.Parse(txtAlbumId.Text) == -1)
                    {
                        Album album = new Album();
                        album.Title = txtTitle.Text;
                        try
                        {
                            album.Price = decimal.Parse(txtPrice.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Price is number!!!");
                            return;
                        }
                        album.GenreId = int.Parse(cbGenre.SelectedValue.ToString());
                        album.ArtistId = int.Parse(cbArtist.SelectedValue.ToString());
                        album.AlbumUrl = txtFile.Text;
                        db.Albums.Add(album);
                        db.SaveChanges();
                    }
                    else
                    {
                        Album album = db.Albums.Find(int.Parse(txtAlbumId.Text));
                        album.Title = txtTitle.Text;
                        try
                        {
                            album.Price = decimal.Parse(txtPrice.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Price is number!!!");
                            return;
                        }
                        album.GenreId = int.Parse(cbGenre.SelectedValue.ToString());
                        album.ArtistId = int.Parse(cbArtist.SelectedValue.ToString());
                        album.AlbumUrl = txtFile.Text;
                        db.Albums.Update(album);
                        db.SaveChanges();
                    }
                }
                this.Close();
            }
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string filebinImg = $@"{Environment.CurrentDirectory}\Assets\Images\";
            ofd.InitialDirectory = filebinImg;
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png|All File (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string check = getFileName(ofd.FileName);
                check = check.Split("/")[2];
                if (!@$"{Directory.GetParent(ofd.FileName).FullName}\".Equals(filebinImg))
                {
                    while (checkDuplicate(check))
                    {
                        check = newFileName(check);
                    }
                    copyFile(ofd.FileName, check);
                }
                txtFile.Text = getFileName(check);
            }
        }

        //copy file to other folder
        private void copyFile(string sourceFile, string destination)
        {
            string destinationFile1 = $@"{Environment.CurrentDirectory}\Assets\Images\{destination}";
            string destinationFile2 = $@"{getRootPath()}\Assets\Images\{destination}";

            System.IO.File.Copy(sourceFile, destinationFile1, true);
            System.IO.File.Copy(sourceFile, destinationFile2, true);
        }

        //get root path of solution
        private string getRootPath()
        {
            string path = Environment.CurrentDirectory;
            string[] arr = path.Split("\\");
            string rootPath = "";
            for (int i = 0; i < arr.Length - 3; i++)
            {
                rootPath += arr[i] + "\\";
            }
            return rootPath;
        }

        //check duplicate filename in project root path
        private bool checkDuplicate(string filename)
        {
            string[] arr = filename.Split('\\');
            string[] files = System.IO.Directory.GetFiles($@"{Environment.CurrentDirectory}\Assets\Images\", "*.*", System.IO.SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string[] arrFile = file.Split('\\');
                if (arr[arr.Length - 1].ToLower() == arrFile[arrFile.Length - 1].ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private string newFileName(string x)
        {
            string name = x.Split(".")[0];
            string tail = x.Split(".")[1];
            return name + "1." + tail;
        }


        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ptbImg.Image = Image.FromFile($@"Assets\{txtFile.Text.Substring(1)}");
            }
            catch
            {
                ptbImg.Image = Image.FromFile($@"Assets\Images\placeholder.gif");
            }
        }
    }
}
