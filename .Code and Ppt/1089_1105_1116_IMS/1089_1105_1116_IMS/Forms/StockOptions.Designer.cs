namespace _1089_1105_1116_IMS.Forms
{
    partial class StockOptions
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
            this.grdTransactions = new System.Windows.Forms.DataGridView();
            this.cmbEditStatus = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnViewAllTransactions = new System.Windows.Forms.Button();
            this.btnSearchTransaction = new System.Windows.Forms.Button();
            this.btnEditTransaction = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.txtEditTotPrice = new System.Windows.Forms.TextBox();
            this.txtNewTotPrice = new System.Windows.Forms.TextBox();
            this.lblEditStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.txtEditTransactionID = new System.Windows.Forms.TextBox();
            this.lblEditTotPrice = new System.Windows.Forms.Label();
            this.txtNewTransactionID = new System.Windows.Forms.TextBox();
            this.lblViewTransactions = new System.Windows.Forms.Label();
            this.lblSearchTransactionID = new System.Windows.Forms.Label();
            this.lblEditTransaction = new System.Windows.Forms.Label();
            this.lblNewTotPrice = new System.Windows.Forms.Label();
            this.lblEditTransactionID = new System.Windows.Forms.Label();
            this.lblAddTransaction = new System.Windows.Forms.Label();
            this.lblNewTransactionID = new System.Windows.Forms.Label();
            this.btnTotalSold = new System.Windows.Forms.Button();
            this.btnTotalReturn = new System.Windows.Forms.Button();
            this.btnSOExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTransactions
            // 
            this.grdTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransactions.Location = new System.Drawing.Point(68, 288);
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.Size = new System.Drawing.Size(545, 150);
            this.grdTransactions.TabIndex = 26;
            this.grdTransactions.Tag = "grdTransactions";
            // 
            // cmbEditStatus
            // 
            this.cmbEditStatus.FormattingEnabled = true;
            this.cmbEditStatus.Items.AddRange(new object[] {
            "R",
            "S"});
            this.cmbEditStatus.Location = new System.Drawing.Point(355, 110);
            this.cmbEditStatus.Name = "cmbEditStatus";
            this.cmbEditStatus.Size = new System.Drawing.Size(160, 21);
            this.cmbEditStatus.TabIndex = 25;
            this.cmbEditStatus.Tag = "cmbEditStatus";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "R",
            "S"});
            this.cmbStatus.Location = new System.Drawing.Point(68, 114);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 21);
            this.cmbStatus.TabIndex = 24;
            this.cmbStatus.Tag = "cmbStatus";
            // 
            // btnViewAllTransactions
            // 
            this.btnViewAllTransactions.Location = new System.Drawing.Point(355, 241);
            this.btnViewAllTransactions.Name = "btnViewAllTransactions";
            this.btnViewAllTransactions.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllTransactions.TabIndex = 23;
            this.btnViewAllTransactions.Tag = "btnViewAllTransactions";
            this.btnViewAllTransactions.Text = "View All";
            this.btnViewAllTransactions.UseVisualStyleBackColor = true;
            this.btnViewAllTransactions.Click += new System.EventHandler(this.btnViewAllTransactions_Click);
            // 
            // btnSearchTransaction
            // 
            this.btnSearchTransaction.Location = new System.Drawing.Point(272, 241);
            this.btnSearchTransaction.Name = "btnSearchTransaction";
            this.btnSearchTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTransaction.TabIndex = 22;
            this.btnSearchTransaction.Tag = "btnSearchTransaction";
            this.btnSearchTransaction.Text = "Search";
            this.btnSearchTransaction.UseVisualStyleBackColor = true;
            this.btnSearchTransaction.Click += new System.EventHandler(this.btnSearchTransaction_Click);
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.Location = new System.Drawing.Point(355, 146);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnEditTransaction.TabIndex = 21;
            this.btnEditTransaction.Tag = "btnEditTransaction";
            this.btnEditTransaction.Text = "Edit";
            this.btnEditTransaction.UseVisualStyleBackColor = true;
            this.btnEditTransaction.Click += new System.EventHandler(this.btnEditTransaction_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(68, 150);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransaction.TabIndex = 20;
            this.btnAddTransaction.Tag = "btnAddTransaction";
            this.btnAddTransaction.Text = "Add";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // txtEditTotPrice
            // 
            this.txtEditTotPrice.Location = new System.Drawing.Point(355, 81);
            this.txtEditTotPrice.Name = "txtEditTotPrice";
            this.txtEditTotPrice.Size = new System.Drawing.Size(160, 20);
            this.txtEditTotPrice.TabIndex = 15;
            this.txtEditTotPrice.Tag = "txtEditTotPrice";
            // 
            // txtNewTotPrice
            // 
            this.txtNewTotPrice.Location = new System.Drawing.Point(68, 85);
            this.txtNewTotPrice.Name = "txtNewTotPrice";
            this.txtNewTotPrice.Size = new System.Drawing.Size(160, 20);
            this.txtNewTotPrice.TabIndex = 19;
            this.txtNewTotPrice.Tag = "txtNewTotPrice";
            // 
            // lblEditStatus
            // 
            this.lblEditStatus.AutoSize = true;
            this.lblEditStatus.Location = new System.Drawing.Point(294, 110);
            this.lblEditStatus.Name = "lblEditStatus";
            this.lblEditStatus.Size = new System.Drawing.Size(37, 13);
            this.lblEditStatus.TabIndex = 13;
            this.lblEditStatus.Tag = "lblEditStatus";
            this.lblEditStatus.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 114);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Tag = "lblStatus";
            this.lblStatus.Text = "Status";
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.Location = new System.Drawing.Point(90, 244);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(138, 20);
            this.txtSearchUsername.TabIndex = 16;
            this.txtSearchUsername.Tag = "txtSearchUsername";
            // 
            // txtEditTransactionID
            // 
            this.txtEditTransactionID.Location = new System.Drawing.Point(377, 55);
            this.txtEditTransactionID.Name = "txtEditTransactionID";
            this.txtEditTransactionID.Size = new System.Drawing.Size(138, 20);
            this.txtEditTransactionID.TabIndex = 17;
            this.txtEditTransactionID.Tag = "txtEditTransactionID";
            // 
            // lblEditTotPrice
            // 
            this.lblEditTotPrice.AutoSize = true;
            this.lblEditTotPrice.Location = new System.Drawing.Point(294, 84);
            this.lblEditTotPrice.Name = "lblEditTotPrice";
            this.lblEditTotPrice.Size = new System.Drawing.Size(58, 13);
            this.lblEditTotPrice.TabIndex = 11;
            this.lblEditTotPrice.Tag = "lblEditTotPrice";
            this.lblEditTotPrice.Text = "Total Price";
            // 
            // txtNewTransactionID
            // 
            this.txtNewTransactionID.Location = new System.Drawing.Point(90, 59);
            this.txtNewTransactionID.Name = "txtNewTransactionID";
            this.txtNewTransactionID.Size = new System.Drawing.Size(138, 20);
            this.txtNewTransactionID.TabIndex = 18;
            this.txtNewTransactionID.Tag = "txtNewTransactionID";
            // 
            // lblViewTransactions
            // 
            this.lblViewTransactions.AutoSize = true;
            this.lblViewTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewTransactions.Location = new System.Drawing.Point(330, 209);
            this.lblViewTransactions.Name = "lblViewTransactions";
            this.lblViewTransactions.Size = new System.Drawing.Size(155, 20);
            this.lblViewTransactions.TabIndex = 10;
            this.lblViewTransactions.Tag = "lblViewTransactions";
            this.lblViewTransactions.Text = "View Transactions";
            // 
            // lblSearchTransactionID
            // 
            this.lblSearchTransactionID.AutoSize = true;
            this.lblSearchTransactionID.Location = new System.Drawing.Point(7, 247);
            this.lblSearchTransactionID.Name = "lblSearchTransactionID";
            this.lblSearchTransactionID.Size = new System.Drawing.Size(77, 13);
            this.lblSearchTransactionID.TabIndex = 9;
            this.lblSearchTransactionID.Tag = "lblSearchTransactionID";
            this.lblSearchTransactionID.Text = "Transaction ID";
            // 
            // lblEditTransaction
            // 
            this.lblEditTransaction.AutoSize = true;
            this.lblEditTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTransaction.Location = new System.Drawing.Point(351, 23);
            this.lblEditTransaction.Name = "lblEditTransaction";
            this.lblEditTransaction.Size = new System.Drawing.Size(140, 20);
            this.lblEditTransaction.TabIndex = 8;
            this.lblEditTransaction.Tag = "lblEditTransaction";
            this.lblEditTransaction.Text = "Edit Transaction";
            // 
            // lblNewTotPrice
            // 
            this.lblNewTotPrice.AutoSize = true;
            this.lblNewTotPrice.Location = new System.Drawing.Point(7, 88);
            this.lblNewTotPrice.Name = "lblNewTotPrice";
            this.lblNewTotPrice.Size = new System.Drawing.Size(58, 13);
            this.lblNewTotPrice.TabIndex = 7;
            this.lblNewTotPrice.Tag = "lblNewTotPrice";
            this.lblNewTotPrice.Text = "Total Price";
            // 
            // lblEditTransactionID
            // 
            this.lblEditTransactionID.AutoSize = true;
            this.lblEditTransactionID.Location = new System.Drawing.Point(294, 58);
            this.lblEditTransactionID.Name = "lblEditTransactionID";
            this.lblEditTransactionID.Size = new System.Drawing.Size(77, 13);
            this.lblEditTransactionID.TabIndex = 6;
            this.lblEditTransactionID.Tag = "lblEditTransactionID";
            this.lblEditTransactionID.Text = "Transaction ID";
            // 
            // lblAddTransaction
            // 
            this.lblAddTransaction.AutoSize = true;
            this.lblAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTransaction.Location = new System.Drawing.Point(64, 27);
            this.lblAddTransaction.Name = "lblAddTransaction";
            this.lblAddTransaction.Size = new System.Drawing.Size(140, 20);
            this.lblAddTransaction.TabIndex = 12;
            this.lblAddTransaction.Tag = "lblAddTransaction";
            this.lblAddTransaction.Text = "Add Transaction";
            // 
            // lblNewTransactionID
            // 
            this.lblNewTransactionID.AutoSize = true;
            this.lblNewTransactionID.Location = new System.Drawing.Point(7, 62);
            this.lblNewTransactionID.Name = "lblNewTransactionID";
            this.lblNewTransactionID.Size = new System.Drawing.Size(77, 13);
            this.lblNewTransactionID.TabIndex = 14;
            this.lblNewTransactionID.Tag = "lblNewTransactionID";
            this.lblNewTransactionID.Text = "Transaction ID";
            // 
            // btnTotalSold
            // 
            this.btnTotalSold.Location = new System.Drawing.Point(440, 241);
            this.btnTotalSold.Name = "btnTotalSold";
            this.btnTotalSold.Size = new System.Drawing.Size(75, 23);
            this.btnTotalSold.TabIndex = 27;
            this.btnTotalSold.Tag = "btnTotalSold";
            this.btnTotalSold.Text = "Total Sold";
            this.btnTotalSold.UseVisualStyleBackColor = true;
            this.btnTotalSold.Click += new System.EventHandler(this.btnTotalSold_Click);
            // 
            // btnTotalReturn
            // 
            this.btnTotalReturn.Location = new System.Drawing.Point(521, 241);
            this.btnTotalReturn.Name = "btnTotalReturn";
            this.btnTotalReturn.Size = new System.Drawing.Size(75, 23);
            this.btnTotalReturn.TabIndex = 27;
            this.btnTotalReturn.Tag = "btnTotalReturn";
            this.btnTotalReturn.Text = "Total Return";
            this.btnTotalReturn.UseVisualStyleBackColor = true;
            this.btnTotalReturn.Click += new System.EventHandler(this.btnTotalReturn_Click);
            // 
            // btnSOExit
            // 
            this.btnSOExit.Location = new System.Drawing.Point(713, 415);
            this.btnSOExit.Name = "btnSOExit";
            this.btnSOExit.Size = new System.Drawing.Size(75, 23);
            this.btnSOExit.TabIndex = 28;
            this.btnSOExit.Tag = "btnSOExit";
            this.btnSOExit.Text = "Exit";
            this.btnSOExit.UseVisualStyleBackColor = true;
            this.btnSOExit.Click += new System.EventHandler(this.btnSOExit_Click);
            // 
            // StockOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSOExit);
            this.Controls.Add(this.btnTotalReturn);
            this.Controls.Add(this.btnTotalSold);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.cmbEditStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnViewAllTransactions);
            this.Controls.Add(this.btnSearchTransaction);
            this.Controls.Add(this.btnEditTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.txtEditTotPrice);
            this.Controls.Add(this.txtNewTotPrice);
            this.Controls.Add(this.lblEditStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtSearchUsername);
            this.Controls.Add(this.txtEditTransactionID);
            this.Controls.Add(this.lblEditTotPrice);
            this.Controls.Add(this.txtNewTransactionID);
            this.Controls.Add(this.lblViewTransactions);
            this.Controls.Add(this.lblSearchTransactionID);
            this.Controls.Add(this.lblEditTransaction);
            this.Controls.Add(this.lblNewTotPrice);
            this.Controls.Add(this.lblEditTransactionID);
            this.Controls.Add(this.lblAddTransaction);
            this.Controls.Add(this.lblNewTransactionID);
            this.Name = "StockOptions";
            this.Text = "StockOptions";
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTransactions;
        private System.Windows.Forms.ComboBox cmbEditStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnViewAllTransactions;
        private System.Windows.Forms.Button btnSearchTransaction;
        private System.Windows.Forms.Button btnEditTransaction;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.TextBox txtEditTotPrice;
        private System.Windows.Forms.TextBox txtNewTotPrice;
        private System.Windows.Forms.Label lblEditStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.TextBox txtEditTransactionID;
        private System.Windows.Forms.Label lblEditTotPrice;
        private System.Windows.Forms.TextBox txtNewTransactionID;
        private System.Windows.Forms.Label lblViewTransactions;
        private System.Windows.Forms.Label lblSearchTransactionID;
        private System.Windows.Forms.Label lblEditTransaction;
        private System.Windows.Forms.Label lblNewTotPrice;
        private System.Windows.Forms.Label lblEditTransactionID;
        private System.Windows.Forms.Label lblAddTransaction;
        private System.Windows.Forms.Label lblNewTransactionID;
        private System.Windows.Forms.Button btnTotalSold;
        private System.Windows.Forms.Button btnTotalReturn;
        private System.Windows.Forms.Button btnSOExit;
    }
}