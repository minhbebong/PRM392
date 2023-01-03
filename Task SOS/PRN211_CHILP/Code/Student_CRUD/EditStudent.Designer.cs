namespace Student_CRUD
{
    partial class EditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editLname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editMname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editRoll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editID = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.editLname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.editMname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.editFname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.editRoll);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.editID);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(191, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 378);
            this.panel1.TabIndex = 1;
            // 
            // editLname
            // 
            this.editLname.BackColor = System.Drawing.Color.RosyBrown;
            this.editLname.Location = new System.Drawing.Point(152, 238);
            this.editLname.Name = "editLname";
            this.editLname.Size = new System.Drawing.Size(125, 27);
            this.editLname.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(38, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last Name";
            // 
            // editMname
            // 
            this.editMname.BackColor = System.Drawing.Color.RosyBrown;
            this.editMname.Location = new System.Drawing.Point(152, 178);
            this.editMname.Name = "editMname";
            this.editMname.Size = new System.Drawing.Size(125, 27);
            this.editMname.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(38, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Middle Name";
            // 
            // editFname
            // 
            this.editFname.BackColor = System.Drawing.Color.RosyBrown;
            this.editFname.Location = new System.Drawing.Point(152, 125);
            this.editFname.Name = "editFname";
            this.editFname.Size = new System.Drawing.Size(125, 27);
            this.editFname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(38, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name";
            // 
            // editRoll
            // 
            this.editRoll.BackColor = System.Drawing.Color.RosyBrown;
            this.editRoll.Location = new System.Drawing.Point(152, 73);
            this.editRoll.Name = "editRoll";
            this.editRoll.Size = new System.Drawing.Size(125, 27);
            this.editRoll.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Roll";
            // 
            // editID
            // 
            this.editID.BackColor = System.Drawing.Color.RosyBrown;
            this.editID.Location = new System.Drawing.Point(152, 24);
            this.editID.Name = "editID";
            this.editID.ReadOnly = true;
            this.editID.Size = new System.Drawing.Size(125, 27);
            this.editID.TabIndex = 2;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Green;
            this.btUpdate.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btUpdate.Location = new System.Drawing.Point(104, 308);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 29);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(38, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.TextBox editID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editRoll;
        private System.Windows.Forms.TextBox editFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editMname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editLname;
        private System.Windows.Forms.Label label6;
    }
}