namespace Q2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbRoomTitle = new System.Windows.Forms.ComboBox();
            this.cbFeeType = new System.Windows.Forms.ComboBox();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbFeeType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbRoomTitle
            // 
            this.cbRoomTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRoomTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRoomTitle.FormattingEnabled = true;
            this.cbRoomTitle.Location = new System.Drawing.Point(179, 100);
            this.cbRoomTitle.Name = "cbRoomTitle";
            this.cbRoomTitle.Size = new System.Drawing.Size(227, 28);
            this.cbRoomTitle.TabIndex = 1;
            this.cbRoomTitle.TextChanged += new System.EventHandler(this.cbRoomTitle_TextChanged);
            // 
            // cbFeeType
            // 
            this.cbFeeType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFeeType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFeeType.FormattingEnabled = true;
            this.cbFeeType.Location = new System.Drawing.Point(179, 153);
            this.cbFeeType.Name = "cbFeeType";
            this.cbFeeType.Size = new System.Drawing.Size(227, 28);
            this.cbFeeType.TabIndex = 2;
            this.cbFeeType.TextChanged += new System.EventHandler(this.cbFeeType_TextChanged);
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(71, 103);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(49, 20);
            this.lbRoom.TabIndex = 3;
            this.lbRoom.Text = "Room";
            // 
            // lbFeeType
            // 
            this.lbFeeType.AutoSize = true;
            this.lbFeeType.Location = new System.Drawing.Point(71, 156);
            this.lbFeeType.Name = "lbFeeType";
            this.lbFeeType.Size = new System.Drawing.Size(65, 20);
            this.lbFeeType.TabIndex = 4;
            this.lbFeeType.Text = "Fee type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "List fee of room";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFeeType);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.cbFeeType);
            this.Controls.Add(this.cbRoomTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbRoomTitle;
        private System.Windows.Forms.ComboBox cbFeeType;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbFeeType;
        private System.Windows.Forms.Label label3;
    }
}
