namespace _1089_1105_1116_IMS.Forms
{
    partial class ManagePerson
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
            this.cmbEditType = new System.Windows.Forms.ComboBox();
            this.cmbNewType = new System.Windows.Forms.ComboBox();
            this.grdPerson = new System.Windows.Forms.DataGridView();
            this.btnViewAllCustomer = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.btnDelPerson = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtEditPersonID = new System.Windows.Forms.TextBox();
            this.txtNewPersonID = new System.Windows.Forms.TextBox();
            this.txtEditTelephone = new System.Windows.Forms.TextBox();
            this.txtNewTelephone = new System.Windows.Forms.TextBox();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.txtSearchPerson = new System.Windows.Forms.TextBox();
            this.txtDelPersonID = new System.Windows.Forms.TextBox();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.txtNewFirstName = new System.Windows.Forms.TextBox();
            this.lblViewPeople = new System.Windows.Forms.Label();
            this.lblDelPerson = new System.Windows.Forms.Label();
            this.lblEditPersonID = new System.Windows.Forms.Label();
            this.lblNewPersonID = new System.Windows.Forms.Label();
            this.lblSearchPerson = new System.Windows.Forms.Label();
            this.lblEditType = new System.Windows.Forms.Label();
            this.lblNewType = new System.Windows.Forms.Label();
            this.lblEditTelephone = new System.Windows.Forms.Label();
            this.lblNewTelephone = new System.Windows.Forms.Label();
            this.lblEditAddress = new System.Windows.Forms.Label();
            this.lblNewAddress = new System.Windows.Forms.Label();
            this.lblDelPersonID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.lblEditPerson = new System.Windows.Forms.Label();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.lblAddPerson = new System.Windows.Forms.Label();
            this.lblNewFirstName = new System.Windows.Forms.Label();
            this.btnPerExit = new System.Windows.Forms.Button();
            this.btnViewAllSuppliers = new System.Windows.Forms.Button();
            this.lblDelType = new System.Windows.Forms.Label();
            this.cmbDelPerson = new System.Windows.Forms.ComboBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.lblSearchType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEditType
            // 
            this.cmbEditType.FormattingEnabled = true;
            this.cmbEditType.Items.AddRange(new object[] {
            "Customer",
            "Supplier"});
            this.cmbEditType.Location = new System.Drawing.Point(344, 173);
            this.cmbEditType.Name = "cmbEditType";
            this.cmbEditType.Size = new System.Drawing.Size(160, 21);
            this.cmbEditType.TabIndex = 127;
            this.cmbEditType.Tag = "cmbEditType";
            // 
            // cmbNewType
            // 
            this.cmbNewType.FormattingEnabled = true;
            this.cmbNewType.Items.AddRange(new object[] {
            "Customer",
            "Supplier"});
            this.cmbNewType.Location = new System.Drawing.Point(77, 147);
            this.cmbNewType.Name = "cmbNewType";
            this.cmbNewType.Size = new System.Drawing.Size(160, 21);
            this.cmbNewType.TabIndex = 126;
            this.cmbNewType.Tag = "cmbNewType";
            // 
            // grdPerson
            // 
            this.grdPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerson.Location = new System.Drawing.Point(19, 383);
            this.grdPerson.Name = "grdPerson";
            this.grdPerson.Size = new System.Drawing.Size(756, 189);
            this.grdPerson.TabIndex = 125;
            this.grdPerson.Tag = "grdPerson";
            // 
            // btnViewAllCustomer
            // 
            this.btnViewAllCustomer.Location = new System.Drawing.Point(615, 336);
            this.btnViewAllCustomer.Name = "btnViewAllCustomer";
            this.btnViewAllCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllCustomer.TabIndex = 124;
            this.btnViewAllCustomer.Tag = "btnViewAllCustomer";
            this.btnViewAllCustomer.Text = "Customers";
            this.btnViewAllCustomer.UseVisualStyleBackColor = true;
            this.btnViewAllCustomer.Click += new System.EventHandler(this.btnViewAllCustomer_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(532, 336);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPerson.TabIndex = 123;
            this.btnSearchPerson.Tag = "btnSearchPerson";
            this.btnSearchPerson.Text = "Search";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // btnDelPerson
            // 
            this.btnDelPerson.Location = new System.Drawing.Point(700, 167);
            this.btnDelPerson.Name = "btnDelPerson";
            this.btnDelPerson.Size = new System.Drawing.Size(75, 23);
            this.btnDelPerson.TabIndex = 122;
            this.btnDelPerson.Tag = "btnDelPerson";
            this.btnDelPerson.Text = "Delete";
            this.btnDelPerson.UseVisualStyleBackColor = true;
            this.btnDelPerson.Click += new System.EventHandler(this.btnDelPerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(359, 236);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(75, 23);
            this.btnEditPerson.TabIndex = 121;
            this.btnEditPerson.Tag = "btnEditPerson";
            this.btnEditPerson.Text = "Edit";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(80, 236);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 120;
            this.btnAddPerson.Tag = "btnAddPerson";
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // txtEditPersonID
            // 
            this.txtEditPersonID.Location = new System.Drawing.Point(397, 44);
            this.txtEditPersonID.Name = "txtEditPersonID";
            this.txtEditPersonID.Size = new System.Drawing.Size(107, 20);
            this.txtEditPersonID.TabIndex = 117;
            this.txtEditPersonID.Tag = "txtEditPersonID";
            // 
            // txtNewPersonID
            // 
            this.txtNewPersonID.Location = new System.Drawing.Point(130, 174);
            this.txtNewPersonID.Name = "txtNewPersonID";
            this.txtNewPersonID.Size = new System.Drawing.Size(107, 20);
            this.txtNewPersonID.TabIndex = 118;
            this.txtNewPersonID.Tag = "txtNewPersonID";
            // 
            // txtEditTelephone
            // 
            this.txtEditTelephone.Location = new System.Drawing.Point(344, 148);
            this.txtEditTelephone.Name = "txtEditTelephone";
            this.txtEditTelephone.Size = new System.Drawing.Size(160, 20);
            this.txtEditTelephone.TabIndex = 116;
            this.txtEditTelephone.Tag = "txtEditTelephone";
            // 
            // txtNewTelephone
            // 
            this.txtNewTelephone.Location = new System.Drawing.Point(77, 122);
            this.txtNewTelephone.Name = "txtNewTelephone";
            this.txtNewTelephone.Size = new System.Drawing.Size(160, 20);
            this.txtNewTelephone.TabIndex = 115;
            this.txtNewTelephone.Tag = "txtNewTelephone";
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Location = new System.Drawing.Point(344, 122);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(160, 20);
            this.txtEditAddress.TabIndex = 114;
            this.txtEditAddress.Tag = "txtEditAddress";
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(77, 96);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(160, 20);
            this.txtNewAddress.TabIndex = 113;
            this.txtNewAddress.Tag = "txtNewAddress";
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Location = new System.Drawing.Point(344, 96);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(160, 20);
            this.txtEditLastName.TabIndex = 112;
            this.txtEditLastName.Tag = "txtEditLastName";
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Location = new System.Drawing.Point(77, 70);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(160, 20);
            this.txtNewLastName.TabIndex = 111;
            this.txtNewLastName.Tag = "txtNewLastName";
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Location = new System.Drawing.Point(180, 333);
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Size = new System.Drawing.Size(107, 20);
            this.txtSearchPerson.TabIndex = 110;
            this.txtSearchPerson.Tag = "txtSearchPerson";
            // 
            // txtDelPersonID
            // 
            this.txtDelPersonID.Location = new System.Drawing.Point(665, 44);
            this.txtDelPersonID.Name = "txtDelPersonID";
            this.txtDelPersonID.Size = new System.Drawing.Size(110, 20);
            this.txtDelPersonID.TabIndex = 119;
            this.txtDelPersonID.Tag = "txtDelPersonID";
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Location = new System.Drawing.Point(344, 70);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtEditFirstName.TabIndex = 109;
            this.txtEditFirstName.Tag = "txtEditFirstName";
            // 
            // txtNewFirstName
            // 
            this.txtNewFirstName.Location = new System.Drawing.Point(77, 44);
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtNewFirstName.TabIndex = 108;
            this.txtNewFirstName.Tag = "txtNewFirstName";
            // 
            // lblViewPeople
            // 
            this.lblViewPeople.AutoSize = true;
            this.lblViewPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPeople.Location = new System.Drawing.Point(327, 286);
            this.lblViewPeople.Name = "lblViewPeople";
            this.lblViewPeople.Size = new System.Drawing.Size(107, 20);
            this.lblViewPeople.TabIndex = 105;
            this.lblViewPeople.Tag = "lblViewPeople";
            this.lblViewPeople.Text = "View People";
            // 
            // lblDelPerson
            // 
            this.lblDelPerson.AutoSize = true;
            this.lblDelPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelPerson.Location = new System.Drawing.Point(611, 12);
            this.lblDelPerson.Name = "lblDelPerson";
            this.lblDelPerson.Size = new System.Drawing.Size(123, 20);
            this.lblDelPerson.TabIndex = 104;
            this.lblDelPerson.Tag = "lblDelPerson";
            this.lblDelPerson.Text = "Delete Person";
            // 
            // lblEditPersonID
            // 
            this.lblEditPersonID.AutoSize = true;
            this.lblEditPersonID.Location = new System.Drawing.Point(283, 47);
            this.lblEditPersonID.Name = "lblEditPersonID";
            this.lblEditPersonID.Size = new System.Drawing.Size(108, 13);
            this.lblEditPersonID.TabIndex = 101;
            this.lblEditPersonID.Tag = "lblEditPersonID";
            this.lblEditPersonID.Text = "Customer/Supplier ID";
            // 
            // lblNewPersonID
            // 
            this.lblNewPersonID.AutoSize = true;
            this.lblNewPersonID.Location = new System.Drawing.Point(16, 177);
            this.lblNewPersonID.Name = "lblNewPersonID";
            this.lblNewPersonID.Size = new System.Drawing.Size(108, 13);
            this.lblNewPersonID.TabIndex = 100;
            this.lblNewPersonID.Tag = "lblNewPersonID";
            this.lblNewPersonID.Text = "Customer/Supplier ID";
            // 
            // lblSearchPerson
            // 
            this.lblSearchPerson.AutoSize = true;
            this.lblSearchPerson.Location = new System.Drawing.Point(66, 336);
            this.lblSearchPerson.Name = "lblSearchPerson";
            this.lblSearchPerson.Size = new System.Drawing.Size(108, 13);
            this.lblSearchPerson.TabIndex = 103;
            this.lblSearchPerson.Tag = "lblSearchPerson";
            this.lblSearchPerson.Text = "Customer/Supplier ID";
            // 
            // lblEditType
            // 
            this.lblEditType.AutoSize = true;
            this.lblEditType.Location = new System.Drawing.Point(283, 177);
            this.lblEditType.Name = "lblEditType";
            this.lblEditType.Size = new System.Drawing.Size(31, 13);
            this.lblEditType.TabIndex = 99;
            this.lblEditType.Tag = "lblEditType";
            this.lblEditType.Text = "Type";
            // 
            // lblNewType
            // 
            this.lblNewType.AutoSize = true;
            this.lblNewType.Location = new System.Drawing.Point(16, 151);
            this.lblNewType.Name = "lblNewType";
            this.lblNewType.Size = new System.Drawing.Size(31, 13);
            this.lblNewType.TabIndex = 98;
            this.lblNewType.Tag = "lblNewType";
            this.lblNewType.Text = "Type";
            // 
            // lblEditTelephone
            // 
            this.lblEditTelephone.AutoSize = true;
            this.lblEditTelephone.Location = new System.Drawing.Point(283, 151);
            this.lblEditTelephone.Name = "lblEditTelephone";
            this.lblEditTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblEditTelephone.TabIndex = 97;
            this.lblEditTelephone.Tag = "lblEditTelephone";
            this.lblEditTelephone.Text = "Telephone";
            // 
            // lblNewTelephone
            // 
            this.lblNewTelephone.AutoSize = true;
            this.lblNewTelephone.Location = new System.Drawing.Point(16, 125);
            this.lblNewTelephone.Name = "lblNewTelephone";
            this.lblNewTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblNewTelephone.TabIndex = 96;
            this.lblNewTelephone.Tag = "lblNewTelephone";
            this.lblNewTelephone.Text = "Telephone";
            // 
            // lblEditAddress
            // 
            this.lblEditAddress.AutoSize = true;
            this.lblEditAddress.Location = new System.Drawing.Point(283, 125);
            this.lblEditAddress.Name = "lblEditAddress";
            this.lblEditAddress.Size = new System.Drawing.Size(45, 13);
            this.lblEditAddress.TabIndex = 94;
            this.lblEditAddress.Tag = "lblEditAddress";
            this.lblEditAddress.Text = "Address";
            // 
            // lblNewAddress
            // 
            this.lblNewAddress.AutoSize = true;
            this.lblNewAddress.Location = new System.Drawing.Point(16, 99);
            this.lblNewAddress.Name = "lblNewAddress";
            this.lblNewAddress.Size = new System.Drawing.Size(45, 13);
            this.lblNewAddress.TabIndex = 95;
            this.lblNewAddress.Tag = "lblNewAddress";
            this.lblNewAddress.Text = "Address";
            // 
            // lblDelPersonID
            // 
            this.lblDelPersonID.AutoSize = true;
            this.lblDelPersonID.Location = new System.Drawing.Point(554, 47);
            this.lblDelPersonID.Name = "lblDelPersonID";
            this.lblDelPersonID.Size = new System.Drawing.Size(108, 13);
            this.lblDelPersonID.TabIndex = 102;
            this.lblDelPersonID.Tag = "lblDelPersonID";
            this.lblDelPersonID.Text = "Customer/Supplier ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 93;
            this.label3.Tag = "lblNewLastName";
            this.label3.Text = "Last Name";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Location = new System.Drawing.Point(16, 73);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(58, 13);
            this.lblNewLastName.TabIndex = 92;
            this.lblNewLastName.Tag = "lblNewLastName";
            this.lblNewLastName.Text = "Last Name";
            // 
            // lblEditPerson
            // 
            this.lblEditPerson.AutoSize = true;
            this.lblEditPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPerson.Location = new System.Drawing.Point(355, 12);
            this.lblEditPerson.Name = "lblEditPerson";
            this.lblEditPerson.Size = new System.Drawing.Size(102, 20);
            this.lblEditPerson.TabIndex = 106;
            this.lblEditPerson.Tag = "lblEditPerson";
            this.lblEditPerson.Text = "Edit Person";
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Location = new System.Drawing.Point(283, 73);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblEditFirstName.TabIndex = 91;
            this.lblEditFirstName.Tag = "lblEditFirstName";
            this.lblEditFirstName.Text = "First Name";
            // 
            // lblAddPerson
            // 
            this.lblAddPerson.AutoSize = true;
            this.lblAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPerson.Location = new System.Drawing.Point(76, 12);
            this.lblAddPerson.Name = "lblAddPerson";
            this.lblAddPerson.Size = new System.Drawing.Size(102, 20);
            this.lblAddPerson.TabIndex = 107;
            this.lblAddPerson.Tag = "lblAddPerson";
            this.lblAddPerson.Text = "Add Person";
            // 
            // lblNewFirstName
            // 
            this.lblNewFirstName.AutoSize = true;
            this.lblNewFirstName.Location = new System.Drawing.Point(16, 47);
            this.lblNewFirstName.Name = "lblNewFirstName";
            this.lblNewFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblNewFirstName.TabIndex = 90;
            this.lblNewFirstName.Tag = "lblNewFirstName";
            this.lblNewFirstName.Text = "First Name";
            // 
            // btnPerExit
            // 
            this.btnPerExit.Location = new System.Drawing.Point(806, 545);
            this.btnPerExit.Name = "btnPerExit";
            this.btnPerExit.Size = new System.Drawing.Size(75, 23);
            this.btnPerExit.TabIndex = 128;
            this.btnPerExit.Tag = "btnPerExit";
            this.btnPerExit.Text = "Exit";
            this.btnPerExit.UseVisualStyleBackColor = true;
            this.btnPerExit.Click += new System.EventHandler(this.btnPerExit_Click);
            // 
            // btnViewAllSuppliers
            // 
            this.btnViewAllSuppliers.Location = new System.Drawing.Point(696, 337);
            this.btnViewAllSuppliers.Name = "btnViewAllSuppliers";
            this.btnViewAllSuppliers.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllSuppliers.TabIndex = 129;
            this.btnViewAllSuppliers.Tag = "btnViewAllSuppliers";
            this.btnViewAllSuppliers.Text = "Suppliers";
            this.btnViewAllSuppliers.UseVisualStyleBackColor = true;
            this.btnViewAllSuppliers.Click += new System.EventHandler(this.btnViewAllSuppliers_Click);
            // 
            // lblDelType
            // 
            this.lblDelType.AutoSize = true;
            this.lblDelType.Location = new System.Drawing.Point(554, 73);
            this.lblDelType.Name = "lblDelType";
            this.lblDelType.Size = new System.Drawing.Size(31, 13);
            this.lblDelType.TabIndex = 130;
            this.lblDelType.Tag = "lblDelType";
            this.lblDelType.Text = "Type";
            // 
            // cmbDelPerson
            // 
            this.cmbDelPerson.FormattingEnabled = true;
            this.cmbDelPerson.Items.AddRange(new object[] {
            "Customer",
            "Supplier"});
            this.cmbDelPerson.Location = new System.Drawing.Point(592, 68);
            this.cmbDelPerson.Name = "cmbDelPerson";
            this.cmbDelPerson.Size = new System.Drawing.Size(183, 21);
            this.cmbDelPerson.TabIndex = 131;
            this.cmbDelPerson.Tag = "cmbDelPerson";
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Customer",
            "Supplier"});
            this.cmbSearchType.Location = new System.Drawing.Point(383, 332);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchType.TabIndex = 132;
            this.cmbSearchType.Tag = "cmbSearchType";
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(328, 335);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(31, 13);
            this.lblSearchType.TabIndex = 133;
            this.lblSearchType.Tag = "lblSearchType";
            this.lblSearchType.Text = "Type";
            // 
            // ManagePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 580);
            this.Controls.Add(this.lblSearchType);
            this.Controls.Add(this.cmbSearchType);
            this.Controls.Add(this.cmbDelPerson);
            this.Controls.Add(this.lblDelType);
            this.Controls.Add(this.btnViewAllSuppliers);
            this.Controls.Add(this.btnPerExit);
            this.Controls.Add(this.cmbEditType);
            this.Controls.Add(this.cmbNewType);
            this.Controls.Add(this.grdPerson);
            this.Controls.Add(this.btnViewAllCustomer);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnDelPerson);
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txtEditPersonID);
            this.Controls.Add(this.txtNewPersonID);
            this.Controls.Add(this.txtEditTelephone);
            this.Controls.Add(this.txtNewTelephone);
            this.Controls.Add(this.txtEditAddress);
            this.Controls.Add(this.txtNewAddress);
            this.Controls.Add(this.txtEditLastName);
            this.Controls.Add(this.txtNewLastName);
            this.Controls.Add(this.txtSearchPerson);
            this.Controls.Add(this.txtDelPersonID);
            this.Controls.Add(this.txtEditFirstName);
            this.Controls.Add(this.txtNewFirstName);
            this.Controls.Add(this.lblViewPeople);
            this.Controls.Add(this.lblDelPerson);
            this.Controls.Add(this.lblEditPersonID);
            this.Controls.Add(this.lblNewPersonID);
            this.Controls.Add(this.lblSearchPerson);
            this.Controls.Add(this.lblEditType);
            this.Controls.Add(this.lblNewType);
            this.Controls.Add(this.lblEditTelephone);
            this.Controls.Add(this.lblNewTelephone);
            this.Controls.Add(this.lblEditAddress);
            this.Controls.Add(this.lblNewAddress);
            this.Controls.Add(this.lblDelPersonID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNewLastName);
            this.Controls.Add(this.lblEditPerson);
            this.Controls.Add(this.lblEditFirstName);
            this.Controls.Add(this.lblAddPerson);
            this.Controls.Add(this.lblNewFirstName);
            this.Name = "ManagePerson";
            this.Text = "ManagePerson";
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEditType;
        private System.Windows.Forms.ComboBox cmbNewType;
        private System.Windows.Forms.DataGridView grdPerson;
        private System.Windows.Forms.Button btnViewAllCustomer;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Button btnDelPerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtEditPersonID;
        private System.Windows.Forms.TextBox txtNewPersonID;
        private System.Windows.Forms.TextBox txtEditTelephone;
        private System.Windows.Forms.TextBox txtNewTelephone;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.TextBox txtNewLastName;
        private System.Windows.Forms.TextBox txtSearchPerson;
        private System.Windows.Forms.TextBox txtDelPersonID;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.TextBox txtNewFirstName;
        private System.Windows.Forms.Label lblViewPeople;
        private System.Windows.Forms.Label lblDelPerson;
        private System.Windows.Forms.Label lblEditPersonID;
        private System.Windows.Forms.Label lblNewPersonID;
        private System.Windows.Forms.Label lblSearchPerson;
        private System.Windows.Forms.Label lblEditType;
        private System.Windows.Forms.Label lblNewType;
        private System.Windows.Forms.Label lblEditTelephone;
        private System.Windows.Forms.Label lblNewTelephone;
        private System.Windows.Forms.Label lblEditAddress;
        private System.Windows.Forms.Label lblNewAddress;
        private System.Windows.Forms.Label lblDelPersonID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNewLastName;
        private System.Windows.Forms.Label lblEditPerson;
        private System.Windows.Forms.Label lblEditFirstName;
        private System.Windows.Forms.Label lblAddPerson;
        private System.Windows.Forms.Label lblNewFirstName;
        private System.Windows.Forms.Button btnPerExit;
        private System.Windows.Forms.Button btnViewAllSuppliers;
        private System.Windows.Forms.Label lblDelType;
        private System.Windows.Forms.ComboBox cmbDelPerson;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Label lblSearchType;
    }
}