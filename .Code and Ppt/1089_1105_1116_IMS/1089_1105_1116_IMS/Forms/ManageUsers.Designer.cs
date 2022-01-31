namespace _1089_1105_1116_IMS.Forms
{
    partial class ManageUsers
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
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblEditUsername = new System.Windows.Forms.Label();
            this.lblEditUser = new System.Windows.Forms.Label();
            this.lblEditPass = new System.Windows.Forms.Label();
            this.txtEditUsername = new System.Windows.Forms.TextBox();
            this.lblEditRole = new System.Windows.Forms.Label();
            this.txtEditPass = new System.Windows.Forms.TextBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.cmbEditRole = new System.Windows.Forms.ComboBox();
            this.lblDelUsername = new System.Windows.Forms.Label();
            this.lblDelUser = new System.Windows.Forms.Label();
            this.txtDelUsername = new System.Windows.Forms.TextBox();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.lblSearchUsername = new System.Windows.Forms.Label();
            this.lblViewUsers = new System.Windows.Forms.Label();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnViewAllUsers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMUserExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Location = new System.Drawing.Point(12, 55);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(55, 13);
            this.lblNewUsername.TabIndex = 0;
            this.lblNewUsername.Tag = "lblNewUsername";
            this.lblNewUsername.Text = "Username";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(73, 52);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(160, 20);
            this.txtNewUsername.TabIndex = 1;
            this.txtNewUsername.Tag = "txtNewUsername";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(69, 20);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(84, 20);
            this.lblAddUser.TabIndex = 0;
            this.lblAddUser.Tag = "lblAddUser";
            this.lblAddUser.Text = "Add User";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(12, 81);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(53, 13);
            this.lblNewPass.TabIndex = 0;
            this.lblNewPass.Tag = "lblNewPass";
            this.lblNewPass.Text = "Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(73, 78);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(160, 20);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Tag = "txtNewPass";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(73, 143);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Tag = "btnAddUser";
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(12, 107);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Tag = "lblRole";
            this.lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbRole.Location = new System.Drawing.Point(73, 107);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(160, 21);
            this.cmbRole.TabIndex = 3;
            this.cmbRole.Tag = "cmbRole";
            // 
            // lblEditUsername
            // 
            this.lblEditUsername.AutoSize = true;
            this.lblEditUsername.Location = new System.Drawing.Point(299, 55);
            this.lblEditUsername.Name = "lblEditUsername";
            this.lblEditUsername.Size = new System.Drawing.Size(55, 13);
            this.lblEditUsername.TabIndex = 0;
            this.lblEditUsername.Tag = "lblEditUsername";
            this.lblEditUsername.Text = "Username";
            // 
            // lblEditUser
            // 
            this.lblEditUser.AutoSize = true;
            this.lblEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUser.Location = new System.Drawing.Point(356, 20);
            this.lblEditUser.Name = "lblEditUser";
            this.lblEditUser.Size = new System.Drawing.Size(84, 20);
            this.lblEditUser.TabIndex = 0;
            this.lblEditUser.Tag = "lblEditUser";
            this.lblEditUser.Text = "Edit User";
            // 
            // lblEditPass
            // 
            this.lblEditPass.AutoSize = true;
            this.lblEditPass.Location = new System.Drawing.Point(299, 81);
            this.lblEditPass.Name = "lblEditPass";
            this.lblEditPass.Size = new System.Drawing.Size(53, 13);
            this.lblEditPass.TabIndex = 0;
            this.lblEditPass.Tag = "lblEditPass";
            this.lblEditPass.Text = "Password";
            // 
            // txtEditUsername
            // 
            this.txtEditUsername.Location = new System.Drawing.Point(360, 52);
            this.txtEditUsername.Name = "txtEditUsername";
            this.txtEditUsername.Size = new System.Drawing.Size(160, 20);
            this.txtEditUsername.TabIndex = 1;
            this.txtEditUsername.Tag = "txtEditUsername";
            // 
            // lblEditRole
            // 
            this.lblEditRole.AutoSize = true;
            this.lblEditRole.Location = new System.Drawing.Point(299, 107);
            this.lblEditRole.Name = "lblEditRole";
            this.lblEditRole.Size = new System.Drawing.Size(29, 13);
            this.lblEditRole.TabIndex = 0;
            this.lblEditRole.Tag = "lblEditRole";
            this.lblEditRole.Text = "Role";
            // 
            // txtEditPass
            // 
            this.txtEditPass.Location = new System.Drawing.Point(360, 78);
            this.txtEditPass.Name = "txtEditPass";
            this.txtEditPass.Size = new System.Drawing.Size(160, 20);
            this.txtEditPass.TabIndex = 1;
            this.txtEditPass.Tag = "txtEditPass";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(360, 143);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Tag = "btnEditUser";
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // cmbEditRole
            // 
            this.cmbEditRole.FormattingEnabled = true;
            this.cmbEditRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbEditRole.Location = new System.Drawing.Point(360, 107);
            this.cmbEditRole.Name = "cmbEditRole";
            this.cmbEditRole.Size = new System.Drawing.Size(160, 21);
            this.cmbEditRole.TabIndex = 3;
            this.cmbEditRole.Tag = "cmbEditRole";
            // 
            // lblDelUsername
            // 
            this.lblDelUsername.AutoSize = true;
            this.lblDelUsername.Location = new System.Drawing.Point(563, 55);
            this.lblDelUsername.Name = "lblDelUsername";
            this.lblDelUsername.Size = new System.Drawing.Size(55, 13);
            this.lblDelUsername.TabIndex = 0;
            this.lblDelUsername.Tag = "lblDelUsername";
            this.lblDelUsername.Text = "Username";
            // 
            // lblDelUser
            // 
            this.lblDelUser.AutoSize = true;
            this.lblDelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelUser.Location = new System.Drawing.Point(620, 20);
            this.lblDelUser.Name = "lblDelUser";
            this.lblDelUser.Size = new System.Drawing.Size(105, 20);
            this.lblDelUser.TabIndex = 0;
            this.lblDelUser.Tag = "lblDelUser";
            this.lblDelUser.Text = "Delete User";
            // 
            // txtDelUsername
            // 
            this.txtDelUsername.Location = new System.Drawing.Point(624, 52);
            this.txtDelUsername.Name = "txtDelUsername";
            this.txtDelUsername.Size = new System.Drawing.Size(160, 20);
            this.txtDelUsername.TabIndex = 1;
            this.txtDelUsername.Tag = "txtDelUsername";
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(650, 97);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(75, 23);
            this.btnDelUser.TabIndex = 2;
            this.btnDelUser.Tag = "btnDelUser";
            this.btnDelUser.Text = "Delete";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // lblSearchUsername
            // 
            this.lblSearchUsername.AutoSize = true;
            this.lblSearchUsername.Location = new System.Drawing.Point(12, 229);
            this.lblSearchUsername.Name = "lblSearchUsername";
            this.lblSearchUsername.Size = new System.Drawing.Size(55, 13);
            this.lblSearchUsername.TabIndex = 0;
            this.lblSearchUsername.Tag = "lblSearchUsername";
            this.lblSearchUsername.Text = "Username";
            // 
            // lblViewUsers
            // 
            this.lblViewUsers.AutoSize = true;
            this.lblViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewUsers.Location = new System.Drawing.Point(335, 191);
            this.lblViewUsers.Name = "lblViewUsers";
            this.lblViewUsers.Size = new System.Drawing.Size(99, 20);
            this.lblViewUsers.TabIndex = 0;
            this.lblViewUsers.Tag = "lblViewUsers";
            this.lblViewUsers.Text = "View Users";
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.Location = new System.Drawing.Point(73, 226);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(160, 20);
            this.txtSearchUsername.TabIndex = 1;
            this.txtSearchUsername.Tag = "txtSearchUsername";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(277, 223);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Tag = "btnSearchUser";
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnViewAllUsers
            // 
            this.btnViewAllUsers.Location = new System.Drawing.Point(360, 223);
            this.btnViewAllUsers.Name = "btnViewAllUsers";
            this.btnViewAllUsers.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllUsers.TabIndex = 2;
            this.btnViewAllUsers.Tag = "btnViewAllUsers";
            this.btnViewAllUsers.Text = "View All";
            this.btnViewAllUsers.UseVisualStyleBackColor = true;
            this.btnViewAllUsers.Click += new System.EventHandler(this.btnViewAllUsers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnMUserExit
            // 
            this.btnMUserExit.Location = new System.Drawing.Point(713, 415);
            this.btnMUserExit.Name = "btnMUserExit";
            this.btnMUserExit.Size = new System.Drawing.Size(75, 23);
            this.btnMUserExit.TabIndex = 5;
            this.btnMUserExit.Tag = "btnMUserExit";
            this.btnMUserExit.Text = "Exit";
            this.btnMUserExit.UseVisualStyleBackColor = true;
            this.btnMUserExit.Click += new System.EventHandler(this.btnMUserExit_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMUserExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbEditRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnViewAllUsers);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtEditPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblEditRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtSearchUsername);
            this.Controls.Add(this.txtDelUsername);
            this.Controls.Add(this.txtEditUsername);
            this.Controls.Add(this.lblEditPass);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.lblViewUsers);
            this.Controls.Add(this.lblDelUser);
            this.Controls.Add(this.lblSearchUsername);
            this.Controls.Add(this.lblEditUser);
            this.Controls.Add(this.lblDelUsername);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblEditUsername);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.lblNewUsername);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblEditUsername;
        private System.Windows.Forms.Label lblEditUser;
        private System.Windows.Forms.Label lblEditPass;
        private System.Windows.Forms.TextBox txtEditUsername;
        private System.Windows.Forms.Label lblEditRole;
        private System.Windows.Forms.TextBox txtEditPass;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.ComboBox cmbEditRole;
        private System.Windows.Forms.Label lblDelUsername;
        private System.Windows.Forms.Label lblDelUser;
        private System.Windows.Forms.TextBox txtDelUsername;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Label lblSearchUsername;
        private System.Windows.Forms.Label lblViewUsers;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnViewAllUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMUserExit;
    }
}