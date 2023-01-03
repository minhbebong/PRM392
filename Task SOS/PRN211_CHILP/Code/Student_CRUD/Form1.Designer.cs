namespace Student_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRoll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.tbLname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbMname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbFname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbRoll);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(538, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 362);
            this.panel1.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btAdd.ForeColor = System.Drawing.Color.Aqua;
            this.btAdd.Location = new System.Drawing.Point(53, 312);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(162, 29);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Add to database";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbLname
            // 
            this.tbLname.BackColor = System.Drawing.Color.DarkGreen;
            this.tbLname.ForeColor = System.Drawing.Color.Bisque;
            this.tbLname.Location = new System.Drawing.Point(122, 257);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(125, 27);
            this.tbLname.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.Location = new System.Drawing.Point(15, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Name";
            // 
            // tbMname
            // 
            this.tbMname.BackColor = System.Drawing.Color.DarkGreen;
            this.tbMname.ForeColor = System.Drawing.Color.Bisque;
            this.tbMname.Location = new System.Drawing.Point(122, 189);
            this.tbMname.Name = "tbMname";
            this.tbMname.Size = new System.Drawing.Size(125, 27);
            this.tbMname.TabIndex = 9;
            this.tbMname.TextChanged += new System.EventHandler(this.tbMname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Location = new System.Drawing.Point(15, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Middle Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbFname
            // 
            this.tbFname.BackColor = System.Drawing.Color.DarkGreen;
            this.tbFname.ForeColor = System.Drawing.Color.Bisque;
            this.tbFname.Location = new System.Drawing.Point(122, 126);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(125, 27);
            this.tbFname.TabIndex = 7;
            this.tbFname.TextChanged += new System.EventHandler(this.tbFname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbRoll
            // 
            this.tbRoll.BackColor = System.Drawing.Color.DarkGreen;
            this.tbRoll.ForeColor = System.Drawing.Color.Bisque;
            this.tbRoll.Location = new System.Drawing.Point(125, 67);
            this.tbRoll.Name = "tbRoll";
            this.tbRoll.Size = new System.Drawing.Size(125, 27);
            this.tbRoll.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Roll";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.DarkGreen;
            this.tbID.ForeColor = System.Drawing.Color.Bisque;
            this.tbID.Location = new System.Drawing.Point(122, 10);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(125, 27);
            this.tbID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(538, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter data here to add";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Purple;
            this.btDelete.ForeColor = System.Drawing.Color.Silver;
            this.btDelete.Location = new System.Drawing.Point(359, 28);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(500, 341);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(44, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 35);
            this.label7.TabIndex = 4;
            this.label7.Text = "Students Managerment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbRoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
    }
}
