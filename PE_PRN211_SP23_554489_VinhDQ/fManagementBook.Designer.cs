namespace PE_PRN211_SP23_554489_VinhDQ
{
    partial class fManagementBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnadd = new Button();
            dataGridView1 = new DataGridView();
            btnupdate = new Button();
            btndelete = new Button();
            label1 = new Label();
            txtid = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            txtdesc = new RichTextBox();
            label4 = new Label();
            dtpk = new DateTimePicker();
            label5 = new Label();
            quantity = new NumericUpDown();
            label6 = new Label();
            price = new NumericUpDown();
            label7 = new Label();
            txtauthor = new TextBox();
            label8 = new Label();
            categorybook = new ComboBox();
            txtnameBook = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.Location = new Point(12, 358);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 0;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(689, 345);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(302, 358);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 2;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(601, 358);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(754, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "BookID";
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(891, 18);
            txtid.Name = "txtid";
            txtid.Size = new Size(268, 27);
            txtid.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(754, 84);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 6;
            label2.Text = "BookNBame";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(863, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(761, 147);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(863, 144);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(296, 120);
            txtdesc.TabIndex = 9;
            txtdesc.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(761, 286);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 10;
            label4.Text = "ReleaseDate";
            // 
            // dtpk
            // 
            dtpk.Location = new Point(863, 286);
            dtpk.Name = "dtpk";
            dtpk.Size = new Size(194, 27);
            dtpk.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(761, 335);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 13;
            label5.Text = "Quantity";
            // 
            // quantity
            // 
            quantity.Enabled = false;
            quantity.Location = new Point(863, 335);
            quantity.Name = "quantity";
            quantity.Size = new Size(150, 27);
            quantity.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(761, 374);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 15;
            label6.Text = "Price";
            // 
            // price
            // 
            price.Enabled = false;
            price.Location = new Point(863, 374);
            price.Name = "price";
            price.Size = new Size(150, 27);
            price.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(761, 423);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 17;
            label7.Text = "Author";
            // 
            // txtauthor
            // 
            txtauthor.Enabled = false;
            txtauthor.Location = new Point(863, 416);
            txtauthor.Name = "txtauthor";
            txtauthor.Size = new Size(283, 27);
            txtauthor.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(761, 464);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 19;
            label8.Text = "BookCategory";
            // 
            // categorybook
            // 
            categorybook.FormattingEnabled = true;
            categorybook.Location = new Point(870, 464);
            categorybook.Name = "categorybook";
            categorybook.Size = new Size(278, 28);
            categorybook.TabIndex = 20;
            // 
            // txtnameBook
            // 
            txtnameBook.Location = new Point(12, 416);
            txtnameBook.Name = "txtnameBook";
            txtnameBook.Size = new Size(202, 27);
            txtnameBook.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(281, 422);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Search Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fManagementBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 570);
            Controls.Add(button1);
            Controls.Add(txtnameBook);
            Controls.Add(categorybook);
            Controls.Add(label8);
            Controls.Add(txtauthor);
            Controls.Add(label7);
            Controls.Add(price);
            Controls.Add(label6);
            Controls.Add(quantity);
            Controls.Add(label5);
            Controls.Add(dtpk);
            Controls.Add(label4);
            Controls.Add(txtdesc);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtid);
            Controls.Add(label1);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(dataGridView1);
            Controls.Add(btnadd);
            Name = "fManagementBook";
            Text = "fManagementBook";
            Load += fManagementBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtid).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadd;
        private DataGridView dataGridView1;
        private Button btnupdate;
        private Button btndelete;
        private Label label1;
        private NumericUpDown txtid;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private RichTextBox txtdesc;
        private Label label4;
        private DateTimePicker dtpk;
        private Label label5;
        private NumericUpDown quantity;
        private Label label6;
        private NumericUpDown price;
        private Label label7;
        private TextBox txtauthor;
        private Label label8;
        private ComboBox categorybook;
        private TextBox txtnameBook;
        private Button button1;
    }
}