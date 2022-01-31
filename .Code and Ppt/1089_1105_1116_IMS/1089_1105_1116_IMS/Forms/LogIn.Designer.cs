namespace _1089_1105_1116_IMS.Forms
{
    partial class LogIn
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(100, 192);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Tag = "btnLogin";
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 57);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Tag = "lblUser";
            this.lblUser.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(73, 54);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(185, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.Tag = "txtUser";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(12, 100);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Tag = "lblPass";
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(73, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(185, 20);
            this.txtPass.TabIndex = 4;
            this.txtPass.Tag = "txtPass";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(120, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Tag = "lblLogin";
            this.lblLogin.Text = "LogIn";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(12, 141);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 3;
            this.lblRole.Tag = "lblRole";
            this.lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbRole.Location = new System.Drawing.Point(73, 138);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(185, 21);
            this.cmbRole.TabIndex = 6;
            this.cmbRole.Tag = "cmbRole";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 248);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogin);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}