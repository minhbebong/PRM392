namespace SE1626_Group6_A2.GUI
{
    partial class CartGUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.recordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIdDataGridViewTextBoxColumn,
            this.cardId,
            this.albumID,
            this.count,
            this.dataCreate,
            this.albumDataGridViewTextBoxColumn,
            this.Detail,
            this.Add,
            this.Remove});
            this.dataGridView1.DataSource = this.cartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(843, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataSource = typeof(SE1626_Group6_A2.Models.Cart);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(23, 9);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(82, 22);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Price";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(96, 317);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.ReadOnly = true;
            this.txbPrice.Size = new System.Drawing.Size(110, 23);
            this.txbPrice.TabIndex = 3;
            // 
            // recordIdDataGridViewTextBoxColumn
            // 
            this.recordIdDataGridViewTextBoxColumn.DataPropertyName = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.HeaderText = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordIdDataGridViewTextBoxColumn.Name = "recordIdDataGridViewTextBoxColumn";
            this.recordIdDataGridViewTextBoxColumn.Visible = false;
            this.recordIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // cardId
            // 
            this.cardId.DataPropertyName = "CartId";
            this.cardId.HeaderText = "CartId";
            this.cardId.MinimumWidth = 6;
            this.cardId.Name = "cardId";
            this.cardId.Visible = false;
            this.cardId.Width = 125;
            // 
            // albumID
            // 
            this.albumID.DataPropertyName = "AlbumId";
            this.albumID.HeaderText = "AlbumId";
            this.albumID.MinimumWidth = 6;
            this.albumID.Name = "albumID";
            this.albumID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.albumID.Width = 125;
            // 
            // count
            // 
            this.count.DataPropertyName = "Count";
            this.count.HeaderText = "Count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.count.Width = 125;
            // 
            // dataCreate
            // 
            this.dataCreate.DataPropertyName = "DateCreated";
            this.dataCreate.HeaderText = "DateCreated";
            this.dataCreate.MinimumWidth = 6;
            this.dataCreate.Name = "dataCreate";
            this.dataCreate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataCreate.Width = 175;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.Visible = false;
            this.albumDataGridViewTextBoxColumn.Width = 125;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detail.Text = "View Detail";
            this.Detail.UseColumnTextForButtonValue = true;
            this.Detail.Width = 125;
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Text = "Add to cart";
            this.Add.UseColumnTextForButtonValue = true;
            this.Add.Width = 127;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove from cart";
            this.Remove.UseColumnTextForButtonValue = true;
            this.Remove.Width = 138;
            // 
            // CartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 379);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource cartBindingSource;
        private Button btnCheckout;
        private Label label1;
        private TextBox txbPrice;
        private DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardId;
        private DataGridViewTextBoxColumn albumID;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn dataCreate;
        private DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Detail;
        private DataGridViewButtonColumn Add;
        private DataGridViewButtonColumn Remove;
    }
}