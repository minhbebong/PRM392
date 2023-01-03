using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddDataTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ReadFile read = new ReadFile();
        List<Student> result = new List<Student>();
        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            String filePa = "";
            dlg.Filter = "Text files (*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePa = dlg.FileName;
            }
            FilePath.Text = filePa;
            List<Student> list = read.readStr(filePa);
            result = list;
            dataGridView1.DataSource = result;

        }


        private void Submit_Click(object sender, EventArgs e)
        {
            if (result.Count == 0)
            {
                MessageBox.Show("load data vao da");
                return;
            }

            InsertID.Text = read.setIDStu(result) + "";
            int id = read.checkInt(InsertID.Text);
            String name = InsertName.Text;
            String major = InsertMajor.Text;
            DateTime biDa = dateTimePicker1.Value;
            int Eyear = read.checkInt(insertEntYear.Text);
            double hocBog;
            try
            {
                hocBog = Convert.ToDouble(InsertSchoolar.Text);
            }
            catch
            {
                hocBog = 0;
            }

            if(name.Equals("") || major.Equals(""))
            {
                MessageBox.Show("dung de trong cai gi ca");
                return;
            }

            Student s = new Student(id, name, major, biDa, Eyear, hocBog);

            result.Add(s);

            dataGridView1.DataSource = result.ToList();
            InsertName.Text = "";
            insertEntYear.Text = "";
            InsertMajor.Text = "";
            InsertSchoolar.Text = "";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (result.Count == 0)
            {
                MessageBox.Show("load giu lieu vao da, lam on");
                return;
            }
            String amen = "";
            foreach (Student s in result)
            {
                amen += s.ToString();
            }
            File.WriteAllText(FilePath.Text, amen.Trim() );
            MessageBox.Show("save thanh cong roi!!!");
        }

        private void btSaveAs_Click(object sender, EventArgs e)
        {
            if (result.Count == 0)
            {
                MessageBox.Show("load giu lieu vao da, lam on");
                return;
            }

            String content = "";
            foreach(Student s in result)
            {
                content += s.ToString();
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text file|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(sfd.FileName);
                w.WriteLine(content.Trim());
                MessageBox.Show("luu thanh cong");
                w.Dispose();
                w.Close();
            }

        }
    }
}
