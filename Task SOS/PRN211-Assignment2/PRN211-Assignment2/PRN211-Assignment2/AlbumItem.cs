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
    public partial class AlbumItem : UserControl
    {
        private Album album;

        public Album Album
        {
            get { return album; }
            set { album = value; Change(); }
        }


        public AlbumItem()
        {
            InitializeComponent();
        }

        private void Change()
        {
            if (Album is not null)
            {
                this.groupBox1.Text = Album.Title;
                this.labelPrice1.Text = "$" + Album.Price.ToString();
                this.labelAlbumName1.Text = Album.Artist?.Name;
                //this.pictureBox1.Load(Album.AlbumUrl);
            }
        }

        public delegate void OnCartChangeEvent();
        public OnCartChangeEvent OnCartChange { get; set; }
        private void buttonAddToCart1_Click(object sender, EventArgs e)
        {
            CartHandler.Instance.AddToCart(this.Album);
            OnCartChange?.Invoke();
        }
    }
}
