namespace Assignment1
{
    partial class CarDetailGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarID = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxPetname = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CarID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Petname:";
            // 
            // textBoxCarID
            // 
            this.textBoxCarID.Location = new System.Drawing.Point(138, 70);
            this.textBoxCarID.Name = "textBoxCarID";
            this.textBoxCarID.ReadOnly = true;
            this.textBoxCarID.Size = new System.Drawing.Size(168, 23);
            this.textBoxCarID.TabIndex = 4;
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(138, 118);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.ReadOnly = true;
            this.textBoxMake.Size = new System.Drawing.Size(168, 23);
            this.textBoxMake.TabIndex = 4;
            // 
            // textBoxPetname
            // 
            this.textBoxPetname.Location = new System.Drawing.Point(416, 118);
            this.textBoxPetname.Name = "textBoxPetname";
            this.textBoxPetname.ReadOnly = true;
            this.textBoxPetname.Size = new System.Drawing.Size(168, 23);
            this.textBoxPetname.TabIndex = 4;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(416, 70);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.ReadOnly = true;
            this.textBoxColor.Size = new System.Drawing.Size(168, 23);
            this.textBoxColor.TabIndex = 4;
            this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Location = new System.Drawing.Point(604, 70);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(45, 23);
            this.panelColor.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(335, 226);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CarDetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxPetname);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.textBoxCarID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CarDetailGUI";
            this.Text = "CarDetailGUI";
            this.Load += new System.EventHandler(this.CarDetailGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxCarID;
        private TextBox textBoxMake;
        private TextBox textBoxPetname;
        private TextBox textBoxColor;
        private Panel panelColor;
        private Button buttonBack;
    }
}