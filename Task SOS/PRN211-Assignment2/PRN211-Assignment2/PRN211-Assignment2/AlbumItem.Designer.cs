namespace PRN211_Assignment2
{
    partial class AlbumItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.labelAlbumName1 = new System.Windows.Forms.Label();
            this.buttonAddToCart1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labelPrice1);
            this.groupBox1.Controls.Add(this.labelAlbumName1);
            this.groupBox1.Controls.Add(this.buttonAddToCart1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 300);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 158);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelPrice1
            // 
            this.labelPrice1.Location = new System.Drawing.Point(6, 183);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(238, 27);
            this.labelPrice1.TabIndex = 2;
            this.labelPrice1.Text = "Price";
            this.labelPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlbumName1
            // 
            this.labelAlbumName1.Location = new System.Drawing.Point(6, 210);
            this.labelAlbumName1.Name = "labelAlbumName1";
            this.labelAlbumName1.Size = new System.Drawing.Size(238, 27);
            this.labelAlbumName1.TabIndex = 1;
            this.labelAlbumName1.Text = "AuthorName";
            this.labelAlbumName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddToCart1
            // 
            this.buttonAddToCart1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddToCart1.Location = new System.Drawing.Point(56, 240);
            this.buttonAddToCart1.Name = "buttonAddToCart1";
            this.buttonAddToCart1.Size = new System.Drawing.Size(144, 23);
            this.buttonAddToCart1.TabIndex = 0;
            this.buttonAddToCart1.Text = "Add to cart";
            this.buttonAddToCart1.UseVisualStyleBackColor = false;
            this.buttonAddToCart1.Click += new System.EventHandler(this.buttonAddToCart1_Click);
            // 
            // AlbumItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AlbumItem";
            this.Size = new System.Drawing.Size(252, 300);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label labelPrice1;
        private Label labelAlbumName1;
        private Button buttonAddToCart1;
    }
}
