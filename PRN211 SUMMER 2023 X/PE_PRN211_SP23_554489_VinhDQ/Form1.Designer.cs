﻿namespace PE_PRN211_SP23_554489_VinhDQ
{
    partial class btnLogin
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
            label1 = new Label();
            txtusername = new TextBox();
            label2 = new Label();
            txtpass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 79);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(176, 79);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(237, 27);
            txtusername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 168);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(177, 162);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(237, 27);
            txtpass.TabIndex = 3;
            txtpass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(240, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(label2);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Name = "btnLogin";
            Text = "Flogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtusername;
        private Label label2;
        private TextBox txtpass;
        private Button button1;
    }
}