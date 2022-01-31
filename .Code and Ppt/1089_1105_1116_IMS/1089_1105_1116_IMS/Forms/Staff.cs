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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnStaffExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Item.SearchItem(txtSearchUsername.Text);
            grdItem.DataSource = ds.Tables["Item_T"];
        }

        private void btnViewAllItems_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Item.GetData();
            grdItem.DataSource = ds.Tables["Item_T"];
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString() == "Supplier")
            {
                DataSet ds = Classes.Person.Supplier.SearchSupplier(txtSearchPerson.Text);
                grdPerson.DataSource = ds.Tables["Supplier_T"];
            }
            else
            {
                DataSet ds = Classes.Person.Customer.SearchCustomer(txtSearchPerson.Text);
                grdPerson.DataSource = ds.Tables["Customer_T"];
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            string transID = txtNewTransactionID.Text; float tot = float.Parse(txtNewTotPrice.Text);
            char stat = char.Parse(cmbStatus.SelectedItem.ToString());
            Classes.Transaction t = new Classes.Transaction(transID, tot, stat);
            Classes.Transaction.AddTransaction(t);
        }

        private void btnSearchTransaction_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Transaction.SearchTransaction(textBox1.Text);
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

        private void btnViewAllPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedItem.ToString() == "Supplier")
                {
                    DataSet ds = Classes.Person.Supplier.GetData();
                    grdPerson.DataSource = ds.Tables["Supplier_T"];
                }
                else
                {
                    DataSet ds = Classes.Person.Customer.GetData();
                    grdPerson.DataSource = ds.Tables["Customer_T"];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a role");
            }
        }

        private void GenerateReportS_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.User.SearchUser(txtAdminUsername.Text);
            dataGridView1.DataSource = ds.Tables["T_User"];
            if(ds.Tables[0].Rows.Count == 0 || dataGridView1.Rows[0].Cells[2].Value.ToString() != "Admin")
            {
                MessageBox.Show("Enter a valid Admin Username");
            }
            else
            {
                Forms.GenerateReport popup = new GenerateReport();
                popup.Show();
            }
        }
    }
}
