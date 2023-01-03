namespace SE1626_Group6_A2.GUI
{
    partial class ShoppingGUI
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
            this.plnShop = new System.Windows.Forms.Panel();
            this.flplShop = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.plnShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // plnShop
            // 
            this.plnShop.Controls.Add(this.flplShop);
            this.plnShop.Controls.Add(this.cbTitle);
            this.plnShop.Controls.Add(this.btnAll);
            this.plnShop.Controls.Add(this.btnNext);
            this.plnShop.Controls.Add(this.btnPrev);
            this.plnShop.Controls.Add(this.btnSearch);
            this.plnShop.Controls.Add(this.Title);
            this.plnShop.Controls.Add(this.lbGenre);
            this.plnShop.Controls.Add(this.cbGenre);
            this.plnShop.Location = new System.Drawing.Point(21, 12);
            this.plnShop.Name = "plnShop";
            this.plnShop.Size = new System.Drawing.Size(992, 667);
            this.plnShop.TabIndex = 2;
            // 
            // flplShop
            // 
            this.flplShop.Location = new System.Drawing.Point(25, 84);
            this.flplShop.Name = "flplShop";
            this.flplShop.Size = new System.Drawing.Size(951, 511);
            this.flplShop.TabIndex = 11;
            // 
            // cbTitle
            // 
            this.cbTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(568, 15);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(258, 28);
            this.cbTitle.TabIndex = 10;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(375, 15);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(119, 29);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "All Products";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(145, 632);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(25, 632);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(832, 15);
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
            this.Title.Location = new System.Drawing.Point(524, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(38, 20);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(54, 20);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(51, 20);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "Genre:";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(111, 16);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(258, 28);
            this.cbGenre.TabIndex = 0;
            this.cbGenre.SelectedValueChanged += new System.EventHandler(this.cbGenre_SelectedValueChanged);
            // 
            // ShoppingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 685);
            this.Controls.Add(this.plnShop);
            this.Name = "ShoppingGUI";
            this.Text = "ShoppingGUI";
            this.Load += new System.EventHandler(this.ShoppingGUI_Load);
            this.plnShop.ResumeLayout(false);
            this.plnShop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel plnShop;
        private ComboBox cbTitle;
        private Button btnAll;
        private Button btnNext;
        private Button btnPrev;
        private Button btnSearch;
        private Label Title;
        private Label lbGenre;
        private ComboBox cbGenre;
        private FlowLayoutPanel flplShop;
    }
}