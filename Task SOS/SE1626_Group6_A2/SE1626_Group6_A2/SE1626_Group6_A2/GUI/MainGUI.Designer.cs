namespace SE1626_Group6_A2
{
    partial class MainGUI
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
            this.components = new System.ComponentModel.Container();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbCart = new System.Windows.Forms.Label();
            this.lbShopping = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCart
            // 
            this.lbCart.AutoSize = true;
            this.lbCart.Location = new System.Drawing.Point(110, 16);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(29, 15);
            this.lbCart.TabIndex = 1;
            this.lbCart.Text = "Cart";
            this.lbCart.Click += new System.EventHandler(this.lbCart_Click);
            // 
            // lbShopping
            // 
            this.lbShopping.AutoSize = true;
            this.lbShopping.Location = new System.Drawing.Point(10, 15);
            this.lbShopping.Name = "lbShopping";
            this.lbShopping.Size = new System.Drawing.Size(58, 15);
            this.lbShopping.TabIndex = 0;
            this.lbShopping.Text = "Shopping";
            this.lbShopping.Click += new System.EventHandler(this.lbShopping_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(182, 16);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(45, 15);
            this.lblLog.TabIndex = 2;
            this.lblLog.Text = "Logout";
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Location = new System.Drawing.Point(303, 16);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(48, 15);
            this.lbAdmin.TabIndex = 3;
            this.lbAdmin.Text = "Albums";
            this.lbAdmin.Click += new System.EventHandler(this.lbAdmin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(942, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(492, 17);
            this.toolStripStatusLabel3.Text = "Author: Group6 - Vu Duy Phuc - Mai Hoang Anh - Nguyen Duy Hung - Nguyen Minh Hieu" +
    "";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 534);
            this.panel1.TabIndex = 5;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lbShopping);
            this.Controls.Add(this.lbCart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGUI";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbCart;
        private Label lbShopping;
        private Label lblLog;
        private Label lbAdmin;
        private BindingSource albumBindingSource;
        private DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn albumUrlDataGridViewTextBoxColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
    }