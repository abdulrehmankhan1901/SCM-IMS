using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1089_1105_1116_IMS.Forms
{
    public partial class StockOptions : Form
    {
        public StockOptions()
        {
            InitializeComponent();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            string transactionID = txtNewTransactionID.Text; float totprice = float.Parse(txtNewTotPrice.Text); char status = char.Parse(cmbStatus.SelectedItem.ToString());
            Classes.Transaction tran = new Classes.Transaction(transactionID, totprice, status);
            Classes.Transaction.AddTransaction(tran);
        }

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            string transactionID = txtEditTransactionID.Text; float totprice = float.Parse(txtEditTotPrice.Text); char status = char.Parse(cmbEditStatus.SelectedItem.ToString());
            Classes.Transaction tran = new Classes.Transaction(transactionID, totprice, status);
            Classes.Transaction.EditTransaction(tran);
        }

        private void btnViewAllTransactions_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Transaction.GetData();
            grdTransactions.DataSource = ds.Tables["T_Transaction"];
        }

        private void btnSearchTransaction_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Transaction.SearchTransaction(txtSearchUsername.Text);
            grdTransactions.DataSource = ds.Tables["T_Transaction"];
        }

        private void btnTotalSold_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Transaction.TotalSold();
            grdTransactions.DataSource = ds.Tables["T_Transaction"];
        }

        private void btnTotalReturn_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Transaction.TotalReturn();
            grdTransactions.DataSource = ds.Tables["T_Transaction"];
        }

        private void btnSOExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
