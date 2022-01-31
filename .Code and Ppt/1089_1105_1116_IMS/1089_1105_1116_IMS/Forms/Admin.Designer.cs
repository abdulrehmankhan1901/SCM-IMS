namespace _1089_1105_1116_IMS.Forms
{
    partial class Admin
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageItems = new System.Windows.Forms.Button();
            this.btnStockOpts = new System.Windows.Forms.Button();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnManagePerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(33, 18);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(108, 20);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Tag = "lblAdmin";
            this.lblAdmin.Text = "Admin Menu";
            // 
            // btnManageUser
            // 
            this.btnManageUser.Location = new System.Drawing.Point(37, 53);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(104, 23);
            this.btnManageUser.TabIndex = 1;
            this.btnManageUser.Tag = "btnManageUser";
            this.btnManageUser.Text = "Manage Users";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnManageItems
            // 
            this.btnManageItems.Location = new System.Drawing.Point(37, 101);
            this.btnManageItems.Name = "btnManageItems";
            this.btnManageItems.Size = new System.Drawing.Size(104, 23);
            this.btnManageItems.TabIndex = 2;
            this.btnManageItems.Tag = "btnManageItems";
            this.btnManageItems.Text = "Manage Items";
            this.btnManageItems.UseVisualStyleBackColor = true;
            this.btnManageItems.Click += new System.EventHandler(this.btnManageRecords_Click);
            // 
            // btnStockOpts
            // 
            this.btnStockOpts.Location = new System.Drawing.Point(37, 196);
            this.btnStockOpts.Name = "btnStockOpts";
            this.btnStockOpts.Size = new System.Drawing.Size(104, 23);
            this.btnStockOpts.TabIndex = 3;
            this.btnStockOpts.Tag = "btnStockOpts";
            this.btnStockOpts.Text = "Stock Options";
            this.btnStockOpts.UseVisualStyleBackColor = true;
            this.btnStockOpts.Click += new System.EventHandler(this.btnStockOpts_Click);
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(37, 246);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(104, 23);
            this.btnGenRep.TabIndex = 4;
            this.btnGenRep.Tag = "btnGenRep";
            this.btnGenRep.Text = "Generate Report";
            this.btnGenRep.UseVisualStyleBackColor = true;
            this.btnGenRep.Click += new System.EventHandler(this.btnGenRep_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(131, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Tag = "btnExit";
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnManagePerson
            // 
            this.btnManagePerson.Location = new System.Drawing.Point(37, 152);
            this.btnManagePerson.Name = "btnManagePerson";
            this.btnManagePerson.Size = new System.Drawing.Size(104, 23);
            this.btnManagePerson.TabIndex = 6;
            this.btnManagePerson.Tag = "btnManagePerson";
            this.btnManagePerson.Text = "Manage Person";
            this.btnManagePerson.UseVisualStyleBackColor = true;
            this.btnManagePerson.Click += new System.EventHandler(this.btnManagePerson_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 320);
            this.Controls.Add(this.btnManagePerson);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenRep);
            this.Controls.Add(this.btnStockOpts);
            this.Controls.Add(this.btnManageItems);
            this.Controls.Add(this.btnManageUser);
            this.Controls.Add(this.lblAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnManageItems;
        private System.Windows.Forms.Button btnStockOpts;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnManagePerson;
    }
}