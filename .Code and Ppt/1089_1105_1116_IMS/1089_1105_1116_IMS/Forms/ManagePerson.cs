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
    public partial class ManagePerson : Form
    {
        public ManagePerson()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string fn = txtNewFirstName.Text; string ln = txtNewLastName.Text; string ad = txtNewAddress.Text;
            string tel = txtNewTelephone.Text; string id = txtNewPersonID.Text; string ty = cmbNewType.SelectedItem.ToString();
            if(cmbNewType.SelectedItem.ToString() == "Supplier")
            {
                Classes.Person.Supplier s = new Classes.Person.Supplier(fn, ln, ad, tel, ty, id);
                Classes.Person.Supplier.AddSupplier(s);
            }
            else
            {
                Classes.Person.Customer c = new Classes.Person.Customer(fn, ln, ad, tel, ty, id);
                Classes.Person.Customer.AddCustomer(c);
            }
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            string fn = txtEditFirstName.Text; string ln = txtEditLastName.Text; string ad = txtEditAddress.Text;
            string tel = txtEditTelephone.Text; string id = txtEditPersonID.Text; string ty = cmbEditType.SelectedItem.ToString();
            if (cmbEditType.SelectedItem.ToString() == "Supplier")
            {
                Classes.Person.Supplier s = new Classes.Person.Supplier(fn, ln, ad, tel, ty, id);
                Classes.Person.Supplier.EditSupplier(s);
            }
            else
            {
                Classes.Person.Customer c = new Classes.Person.Customer(fn, ln, ad, tel, ty, id);
                Classes.Person.Customer.EditCustomer(c);
            }
        }

        private void btnDelPerson_Click(object sender, EventArgs e)
        {
            if(cmbDelPerson.SelectedItem.ToString() == "Supplier")
            {
                Classes.Person.Supplier.DeleteSupplier(txtDelPersonID.Text);
            }
            else
            {
                Classes.Person.Customer.DeleteCustomer(txtDelPersonID.Text);
            }
        }

        private void btnViewAllCustomer_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Person.Customer.GetData();
            grdPerson.DataSource = ds.Tables["Customer_T"];
        }

        private void btnViewAllSuppliers_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.Person.Supplier.GetData();
            grdPerson.DataSource = ds.Tables["Supplier_T"];
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if(cmbSearchType.SelectedItem.ToString() == "Supplier")
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

        private void btnPerExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
