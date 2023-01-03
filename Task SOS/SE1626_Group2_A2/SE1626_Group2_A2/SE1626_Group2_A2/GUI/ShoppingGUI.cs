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
    public partial class ShoppingGUI : Form
    {


        private MusicStoreContext db;
        private PageList<Album> pageList;
        public ShoppingCart sc { get; set; }

        public event EventHandler changeCart;

        public ShoppingGUI(ShoppingCart s)
        {
            InitializeComponent();
            db = new MusicStoreContext();
            sc = s;
            CreateComboBoxGenre();
            bindPanel(1);
        }

        private void CreateComboBoxGenre()
        {
            List<Genre> genreList = db.Genres.ToList();
            genreList.Insert(0, new Genre() { GenreId = 0, Name = "All" });
            cbGenre.DataSource = genreList;
            cbGenre.DisplayMember = "Name";
            cbGenre.ValueMember = "GenreId";
        }

        void bindPanel(int pageIndex)
        {
            int id = int.Parse(cbGenre.SelectedValue.ToString());
            string title = txtTilte.Text;
            IQueryable<Album> albums;
            if (id == 0)
            {
                albums = db.Albums.Where(a => a.Title.Contains(title));
            }
            else
            {
                albums = db.Albums.Where(a => a.Title.Contains(title) && a.GenreId == id);
            }

            pageList = PageList<Album>.Create(albums, pageIndex, 3);
            btnPrevious.Enabled = pageList.HasPreviousPage;
            btnNext.Enabled = pageList.HasNextPage;

            panel1.Controls.Clear();
            int height = panel1.Height - 20;
            int width = (panel1.Width - 30) / 3;
            int i = 0;
            foreach (Album a in pageList)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = a.Title;
                groupBox.Height = height;
                groupBox.Width = width;
                groupBox.Location = new Point(20 + i * width + i * 5, 10);

                PictureBox pb = new PictureBox();
                pb.Size = new Size(125, 80);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.BackColor = Color.White;
                try
                {
                    pb.Image = Image.FromFile("Assets" + a.AlbumUrl);
                }
                catch
                {
                    pb.Image = Image.FromFile("Assets/Images/placeholder.gif");
                }
                pb.Location = new Point(width / 2 - pb.Width / 2, 40);
                groupBox.Controls.Add(pb);

                Label lbPrice = new Label();
                lbPrice.AutoSize = true;
                lbPrice.TextAlign = ContentAlignment.MiddleCenter;
                lbPrice.Text = "$" + a.Price.ToString();
                lbPrice.Location = new Point(width / 2 - lbPrice.Width / 3, 130);
                groupBox.Controls.Add(lbPrice);

                Label lbArtist = new Label();
                lbArtist.AutoSize = true;
                lbArtist.Text = db.Artists.Where(t => t.ArtistId == a.ArtistId).FirstOrDefault().Name;
                lbArtist.TextAlign = ContentAlignment.MiddleCenter;
                lbArtist.Location = new Point(width / 2 - lbArtist.Width / 2, 160);
                groupBox.Controls.Add(lbArtist);

                Button bt = new Button();
                bt.Text = "Add to cart";
                bt.BackColor = Color.Blue;
                bt.ForeColor = Color.White;
                bt.Size = new Size(94, 42);
                bt.Location = new Point(width / 2 - bt.Width / 2, 190);
                bt.Click += btnAddOnClick;

                groupBox.Controls.Add(bt);

                Label lbID = new Label();
                lbID.Visible = false;
                lbID.Text = a.AlbumId.ToString();
                groupBox.Controls.Add(lbID);

                panel1.Controls.Add(groupBox);
                i++;
            }

        }

        private void btnAddOnClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            GroupBox gb = (GroupBox)bt.Parent;
            Label lbID = (Label)gb.Controls[4];
            int id = int.Parse(lbID.Text);
            Album album = db.Albums.Where(a => a.AlbumId == id).FirstOrDefault();

            sc.AddToCart(album, -1);
            changeCart.Invoke(sender, e);
            MessageBox.Show("Added!");

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindPanel(pageList.PageIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindPanel(pageList.PageIndex + 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindPanel(1);
        }

    }
}
