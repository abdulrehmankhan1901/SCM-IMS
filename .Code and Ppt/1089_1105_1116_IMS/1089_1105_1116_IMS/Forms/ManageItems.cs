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
    public partial class ManageItems : Form
    {
        public ManageItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string id = txtNewItemId.Text; string name = txtNewItemName.Text; string desc = txtNewItemDesc.Text;
            float price = float.Parse(txtNewItemPrice.Text); string type = txtNewItemType.Text;
            int quantity = int.Parse(txtNewItemQuantity.Text);  string supplier = txtNewItemSupplier.Text;
            Classes.Item i = new Classes.Item(id, name, desc, price, type, quantity, supplier);
            Classes.Item.AddItem(i);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            string id = txtEditItemID.Text; string name = txtEditItemName.Text; string desc = txtEditItemDesc.Text;
            float price = float.Parse(txtEditItemPrice.Text); string type = txtEditItemType.Text;
            int quantity = int.Parse(txtEditItemQuantity.Text); string supplier = txtEditItemSupplier.Text;
            Classes.Item i = new Classes.Item(id, name, desc, price, type, quantity, supplier);
            Classes.Item.EditItem(i);
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            Classes.Item.DeleteItem(txtDelItemID.Text);
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

        private void btnItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
