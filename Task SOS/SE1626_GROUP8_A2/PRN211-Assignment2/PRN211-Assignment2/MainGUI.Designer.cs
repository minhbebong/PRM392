namespace PRN211_Assignment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelShopping = new System.Windows.Forms.Panel();
            this.albumItem3 = new PRN211_Assignment2.AlbumItem();
            this.albumItem2 = new PRN211_Assignment2.AlbumItem();
            this.albumItem1 = new PRN211_Assignment2.AlbumItem();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelAlbumCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdminCreate = new System.Windows.Forms.Button();
            this.buttonAdminSearch = new System.Windows.Forms.Button();
            this.textBoxAdminSearch = new System.Windows.Forms.TextBox();
            this.comboBoxAdminSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelShopping.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shoppingToolStripMenuItem,
            this.cartToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.albumsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shoppingToolStripMenuItem
            // 
            this.shoppingToolStripMenuItem.Name = "shoppingToolStripMenuItem";
            this.shoppingToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.shoppingToolStripMenuItem.Text = "Shopping";
            this.shoppingToolStripMenuItem.Click += new System.EventHandler(this.shoppingToolStripMenuItem_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.cartToolStripMenuItem.Text = "Cart (0)";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Visible = false;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // albumsToolStripMenuItem
            // 
            this.albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
            this.albumsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.albumsToolStripMenuItem.Text = "Albums";
            this.albumsToolStripMenuItem.Visible = false;
            this.albumsToolStripMenuItem.Click += new System.EventHandler(this.albumsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(914, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(502, 20);
            this.toolStripStatusLabel1.Text = "Author: SE1626 -Group 8 - NguyenDinhMinh - DangAnhTuyet - VuNamAnh";
            // 
            // panelShopping
            // 
            this.panelShopping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShopping.Controls.Add(this.albumItem3);
            this.panelShopping.Controls.Add(this.albumItem2);
            this.panelShopping.Controls.Add(this.albumItem1);
            this.panelShopping.Controls.Add(this.buttonNext);
            this.panelShopping.Controls.Add(this.buttonPrevious);
            this.panelShopping.Controls.Add(this.buttonSearch);
            this.panelShopping.Controls.Add(this.textBoxSearch);
            this.panelShopping.Controls.Add(this.comboBoxSearch);
            this.panelShopping.Controls.Add(this.label2);
            this.panelShopping.Controls.Add(this.label1);
            this.panelShopping.Location = new System.Drawing.Point(14, 69);
            this.panelShopping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelShopping.Name = "panelShopping";
            this.panelShopping.Size = new System.Drawing.Size(887, 497);
            this.panelShopping.TabIndex = 3;
            this.panelShopping.Visible = false;
            // 
            // albumItem3
            // 
            this.albumItem3.Album = null;
            this.albumItem3.Location = new System.Drawing.Point(593, 55);
            this.albumItem3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.albumItem3.Name = "albumItem3";
            this.albumItem3.OnCartChange = null;
            this.albumItem3.Size = new System.Drawing.Size(288, 400);
            this.albumItem3.TabIndex = 11;
            // 
            // albumItem2
            // 
            this.albumItem2.Album = null;
            this.albumItem2.Location = new System.Drawing.Point(298, 55);
            this.albumItem2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.albumItem2.Name = "albumItem2";
            this.albumItem2.OnCartChange = null;
            this.albumItem2.Size = new System.Drawing.Size(288, 400);
            this.albumItem2.TabIndex = 11;
            // 
            // albumItem1
            // 
            this.albumItem1.Album = null;
            this.albumItem1.Location = new System.Drawing.Point(3, 55);
            this.albumItem1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.albumItem1.Name = "albumItem1";
            this.albumItem1.OnCartChange = null;
            this.albumItem1.Size = new System.Drawing.Size(288, 400);
            this.albumItem1.TabIndex = 10;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(96, 463);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(86, 31);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(3, 463);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(86, 31);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(682, 16);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(106, 31);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(507, 16);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 27);
            this.textBoxSearch.TabIndex = 3;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(193, 16);
            this.comboBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(207, 28);
            this.comboBoxSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre:";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdmin.Controls.Add(this.dataGridView1);
            this.panelAdmin.Controls.Add(this.labelAlbumCount);
            this.panelAdmin.Controls.Add(this.label5);
            this.panelAdmin.Controls.Add(this.buttonAdminCreate);
            this.panelAdmin.Controls.Add(this.buttonAdminSearch);
            this.panelAdmin.Controls.Add(this.textBoxAdminSearch);
            this.panelAdmin.Controls.Add(this.comboBoxAdminSearch);
            this.panelAdmin.Controls.Add(this.label3);
            this.panelAdmin.Controls.Add(this.label4);
            this.panelAdmin.Location = new System.Drawing.Point(14, 69);
            this.panelAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(887, 497);
            this.panelAdmin.TabIndex = 12;
            this.panelAdmin.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.ArtistId,
            this.Title,
            this.Price,
            this.AlbumUrl,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(887, 380);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Visible = false;
            this.Data.Width = 125;
            // 
            // ArtistId
            // 
            this.ArtistId.HeaderText = "ArtistId";
            this.ArtistId.MinimumWidth = 6;
            this.ArtistId.Name = "ArtistId";
            this.ArtistId.ReadOnly = true;
            this.ArtistId.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // AlbumUrl
            // 
            this.AlbumUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlbumUrl.HeaderText = "AlbumUrl";
            this.AlbumUrl.MinimumWidth = 6;
            this.AlbumUrl.Name = "AlbumUrl";
            this.AlbumUrl.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 125;
            // 
            // labelAlbumCount
            // 
            this.labelAlbumCount.AutoSize = true;
            this.labelAlbumCount.Location = new System.Drawing.Point(193, 89);
            this.labelAlbumCount.Name = "labelAlbumCount";
            this.labelAlbumCount.Size = new System.Drawing.Size(17, 20);
            this.labelAlbumCount.TabIndex = 6;
            this.labelAlbumCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "The number of albums: ";
            // 
            // buttonAdminCreate
            // 
            this.buttonAdminCreate.Location = new System.Drawing.Point(14, 55);
            this.buttonAdminCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdminCreate.Name = "buttonAdminCreate";
            this.buttonAdminCreate.Size = new System.Drawing.Size(173, 31);
            this.buttonAdminCreate.TabIndex = 5;
            this.buttonAdminCreate.Text = "Create a new Album...";
            this.buttonAdminCreate.UseVisualStyleBackColor = true;
            this.buttonAdminCreate.Click += new System.EventHandler(this.buttonAdminCreate_Click);
            // 
            // buttonAdminSearch
            // 
            this.buttonAdminSearch.Location = new System.Drawing.Point(682, 16);
            this.buttonAdminSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdminSearch.Name = "buttonAdminSearch";
            this.buttonAdminSearch.Size = new System.Drawing.Size(106, 31);
            this.buttonAdminSearch.TabIndex = 4;
            this.buttonAdminSearch.Text = "Search";
            this.buttonAdminSearch.UseVisualStyleBackColor = true;
            this.buttonAdminSearch.Click += new System.EventHandler(this.buttonAdminSearch_Click);
            // 
            // textBoxAdminSearch
            // 
            this.textBoxAdminSearch.Location = new System.Drawing.Point(507, 16);
            this.textBoxAdminSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAdminSearch.Name = "textBoxAdminSearch";
            this.textBoxAdminSearch.Size = new System.Drawing.Size(167, 27);
            this.textBoxAdminSearch.TabIndex = 3;
            // 
            // comboBoxAdminSearch
            // 
            this.comboBoxAdminSearch.FormattingEnabled = true;
            this.comboBoxAdminSearch.Location = new System.Drawing.Point(193, 16);
            this.comboBoxAdminSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAdminSearch.Name = "comboBoxAdminSearch";
            this.comboBoxAdminSearch.Size = new System.Drawing.Size(207, 28);
            this.comboBoxAdminSearch.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genre:";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelShopping);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelShopping.ResumeLayout(false);
            this.panelShopping.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem shoppingToolStripMenuItem;
        private ToolStripMenuItem cartToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem albumsToolStripMenuItem;
        private Panel panelShopping;
        private Button buttonNext;
        private Button buttonPrevious;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private ComboBox comboBoxSearch;
        private Label label2;
        private Label label1;
        private AlbumItem albumItem3;
        private AlbumItem albumItem2;
        private AlbumItem albumItem1;
        private Panel panelAdmin;
        private DataGridView dataGridView1;
        private Label labelAlbumCount;
        private Label label5;
        private Button buttonAdminCreate;
        private Button buttonAdminSearch;
        private TextBox textBoxAdminSearch;
        private ComboBox comboBoxAdminSearch;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn ArtistId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn AlbumUrl;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}