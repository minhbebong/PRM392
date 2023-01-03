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
            this.txtCarid = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPetname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bgcolor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car ID:";
            // 
            // txtCarid
            // 
            this.txtCarid.Location = new System.Drawing.Point(90, 84);
            this.txtCarid.Name = "txtCarid";
            this.txtCarid.ReadOnly = true;
            this.txtCarid.Size = new System.Drawing.Size(100, 23);
            this.txtCarid.TabIndex = 1;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(90, 184);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(100, 23);
            this.txtMake.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Make:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(379, 87);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(100, 23);
            this.txtColor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color:";
            // 
            // txtPetname
            // 
            this.txtPetname.Location = new System.Drawing.Point(379, 187);
            this.txtPetname.Name = "txtPetname";
            this.txtPetname.ReadOnly = true;
            this.txtPetname.Size = new System.Drawing.Size(100, 23);
            this.txtPetname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Petname:";
            // 
            // bgcolor
            // 
            this.bgcolor.Location = new System.Drawing.Point(517, 87);
            this.bgcolor.Name = "bgcolor";
            this.bgcolor.Size = new System.Drawing.Size(48, 23);
            this.bgcolor.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(258, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CarDetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 367);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bgcolor);
            this.Controls.Add(this.txtPetname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CarDetailGUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CarDetailGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCarid;
        private TextBox txtMake;
        private Label label2;
        private TextBox txtColor;
        private Label label3;
        private TextBox txtPetname;
        private Label label4;
        private TextBox bgcolor;
        private Button button1;
    }
}