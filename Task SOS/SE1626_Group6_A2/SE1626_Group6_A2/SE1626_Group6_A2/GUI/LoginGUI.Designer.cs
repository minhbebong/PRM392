namespace SE1626_Group6_A2.GUI
{
    partial class LoginGUI
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.lbForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(139, 91);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(82, 20);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "User Name";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(151, 138);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(70, 20);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Password";
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(240, 88);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(204, 27);
            this.txbUser.TabIndex = 1;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(240, 138);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(204, 27);
            this.txbPass.TabIndex = 2;
            // 
            // lbForgotPass
            // 
            this.lbForgotPass.AutoSize = true;
            this.lbForgotPass.LinkColor = System.Drawing.Color.Black;
            this.lbForgotPass.Location = new System.Drawing.Point(326, 178);
            this.lbForgotPass.Name = "lbForgotPass";
            this.lbForgotPass.Size = new System.Drawing.Size(118, 20);
            this.lbForgotPass.TabIndex = 3;
            this.lbForgotPass.TabStop = true;
            this.lbForgotPass.Text = "Forgot Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(240, 237);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 404);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbForgotPass);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "LoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginGUI";
            this.Load += new System.EventHandler(this.LoginGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbUser;
        private Label lbPass;
        private TextBox txbUser;
        private TextBox txbPass;
        private LinkLabel lbForgotPass;
        private Button btnLogin;
        private Button btnCancel;
    }
}