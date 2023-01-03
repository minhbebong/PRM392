namespace SE1626_Group6_A2.GUI
{
    partial class AlbumsGUI
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
            this.components = new System.ComponentModel.Container();
            this.plnShop = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.albumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.plnShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // plnShop
            // 
            this.plnShop.Controls.Add(this.dataGridView1);
            this.plnShop.Controls.Add(this.btnAdd);
            this.plnShop.Controls.Add(this.cbTitle);
            this.plnShop.Controls.Add(this.btnAll);
            this.plnShop.Controls.Add(this.btnSearch);
            this.plnShop.Controls.Add(this.Title);
            this.plnShop.Controls.Add(this.lbGenre);
            this.plnShop.Controls.Add(this.cbGenre);
            this.plnShop.Location = new System.Drawing.Point(12, 12);
            this.plnShop.Name = "plnShop";
            this.plnShop.Size = new System.Drawing.Size(1009, 685);
            this.plnShop.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumId,
            this.genreId,
            this.artistId,
            this.albumTitle,
            this.price,
            this.albumUrl,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.albumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(985, 559);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(SE1626_Group6_A2.Models.Album);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 29);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Create a new Album";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTitle
            // 
            this.cbTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(593, 15);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(258, 28);
            this.cbTitle.TabIndex = 10;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(387, 16);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(119, 29);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "All Products";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(857, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(549, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(38, 20);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(45, 21);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(51, 20);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "Genre:";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(114, 15);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(258, 28);
            this.cbGenre.TabIndex = 0;
            this.cbGenre.SelectedValueChanged += new System.EventHandler(this.cbGenre_SelectedValueChanged);
            // 
            // albumId
            // 
            this.albumId.DataPropertyName = "AlbumId";
            this.albumId.HeaderText = "AlbumId";
            this.albumId.MinimumWidth = 6;
            this.albumId.Name = "albumId";
            this.albumId.Width = 125;
            // 
            // genreId
            // 
            this.genreId.DataPropertyName = "GenreId";
            this.genreId.HeaderText = "GenreId";
            this.genreId.MinimumWidth = 6;
            this.genreId.Name = "genreId";
            this.genreId.Width = 125;
            // 
            // artistId
            // 
            this.artistId.DataPropertyName = "ArtistId";
            this.artistId.HeaderText = "ArtistId";
            this.artistId.MinimumWidth = 6;
            this.artistId.Name = "artistId";
            this.artistId.Width = 125;
            // 
            // albumTitle
            // 
            this.albumTitle.DataPropertyName = "Title";
            this.albumTitle.HeaderText = "Title";
            this.albumTitle.MinimumWidth = 6;
            this.albumTitle.Name = "albumTitle";
            this.albumTitle.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // albumUrl
            // 
            this.albumUrl.DataPropertyName = "AlbumUrl";
            this.albumUrl.HeaderText = "AlbumUrl";
            this.albumUrl.MinimumWidth = 6;
            this.albumUrl.Name = "albumUrl";
            this.albumUrl.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 90;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 90;
            // 
            // AlbumsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 702);
            this.Controls.Add(this.plnShop);
            this.Name = "AlbumsGUI";
            this.Text = "AlbumsGUI";
            this.plnShop.ResumeLayout(false);
            this.plnShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel plnShop;
        private Button btnAdd;
        private ComboBox cbTitle;
        private Button btnAll;
        private Button btnSearch;
        private Label Title;
        private Label lbGenre;
        private ComboBox cbGenre;
        private DataGridView dataGridView1;
        private BindingSource albumBindingSource;
        private DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn albumUrlDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn albumId;
        private DataGridViewTextBoxColumn genreId;
        private DataGridViewTextBoxColumn artistId;
        private DataGridViewTextBoxColumn albumTitle;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn albumUrl;
    }
}