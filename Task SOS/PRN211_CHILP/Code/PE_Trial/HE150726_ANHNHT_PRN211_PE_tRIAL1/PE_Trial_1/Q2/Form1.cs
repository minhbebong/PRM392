using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q2.Models;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData(object sender, EventArgs e)
        {
            List<int> lstYear = new List<int>();
            for (int i = 2000; i <= 2010; i++)
            {
                lstYear.Add(i);
            }
            using (var context = new PRN211_Demo1Context())
            {
                cbBook.DataSource = context.Books.Select(x => x.Title).ToList();
                cbYear.DataSource = lstYear;
                lbAuthors.DataSource = context.Authors.Select(x => x.Name).ToList();
            }
            cbBook_SelectedIndexChanged(sender, e);
        }
        public Boolean winCf()
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(sender, e);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (winCf())
            {
                using (var context = new PRN211_Demo1Context())
                {
                    AuthorBook auBo = context.AuthorBooks.FirstOrDefault(x => x.Author.Name.Equals(lbAuthors.SelectedItem));
                    context.Remove(auBo);
                    context.SaveChanges();
                }
            }
            LoadData(sender, e);
        }

        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new PRN211_Demo1Context())
            {
                Book b1 = context.Books.FirstOrDefault(x => x.Title.Equals(cbBook.SelectedItem));
                cbYear.SelectedItem = b1.Year;
                lbAuthors.DataSource = context.Authors.Select(x => x.Name).ToList();
                List<AuthorBook> lstAuBok = context.AuthorBooks.Where(x => x.Book.Title.Equals(cbBook.SelectedItem)).ToList();
                List<string> auName = new List<string>();
                List<int> auID = lstAuBok.Select(x => x.AuthorId).ToList();
                foreach (int id in auID)
                {
                    Author au = context.Authors.FirstOrDefault(x => x.Id == id);
                    auName.Add(au.Name);
                }
                lbAuthors.DataSource = auName;
            }
        }
    }
}
