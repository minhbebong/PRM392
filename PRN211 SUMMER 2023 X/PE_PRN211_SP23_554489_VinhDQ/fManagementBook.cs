using Microsoft.EntityFrameworkCore;
using PE_PRN211_SP23_554489_VinhDQ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_PRN211_SP23_554489_VinhDQ
{
    public partial class fManagementBook : Form
    {
        private BookManagement2023DBContext con = new BookManagement2023DBContext();
        public fManagementBook()
        {
            InitializeComponent();
        }

        private void fManagementBook_Load(object sender, EventArgs e)
        {
            loadInfor();
        }

        public void loadInfor()
        {
            dataGridView1.DataSource = con.Books.Include(x => x.BookCategory).Select(x => new
            {
                x.BookId,
                x.BookName,
                x.Description,
                x.ReleaseDate,
                x.Quantity,
                x.Price,
                x.Author,
                x.BookCategory
            }).ToList();
            categorybook.DataSource = con.BookCategories.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int check = -1;
            try
            {
                check = Convert.ToInt32(this.Tag);
            }
            catch
            (Exception ex)
            {
                check = -1;
            }

            if (check == 1)
            {

                string namebook = txtnameBook.Text;
                List<Book> list = con.Books.Include(x => x.BookCategory).Where(x => x.BookName.Contains(namebook)).ToList<Book>();
                dataGridView1.DataSource = list.Select(x => new
                {
                    x.BookId,
                    x.BookName,
                    x.Description,
                    x.ReleaseDate,
                    x.Quantity,
                    x.Price,
                    x.Author,
                    x.BookCategory
                });
                categorybook.DataSource = con.BookCategories.ToList();
            }
            else
            {
                MessageBox.Show("You have no permission to access this function");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            if(row >= 0)
            {
                txtid.Value= (int)dataGridView1[row, 0].Value;
                txtnameBook.Text = dataGridView1[row, 1].Value.ToString();
               txtdesc.Text = dataGridView1[row, 2].Value.ToString();
                
            }
        }
    }
}
