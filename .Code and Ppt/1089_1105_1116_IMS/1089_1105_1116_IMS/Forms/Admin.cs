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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            Forms.ManageUsers popup = new Forms.ManageUsers();
            popup.Show();
        }

        private void btnManageRecords_Click(object sender, EventArgs e)
        {
            Forms.ManageItems popup = new Forms.ManageItems();
            popup.Show();
        }

        private void btnStockOpts_Click(object sender, EventArgs e)
        {
            Forms.StockOptions popup = new Forms.StockOptions();
            popup.Show();
        }

        private void btnGenRep_Click(object sender, EventArgs e)
        {
            Forms.GenerateReport popup = new GenerateReport();
            popup.Show();
        }

        private void btnManagePerson_Click(object sender, EventArgs e)
        {
            Forms.ManagePerson popup = new Forms.ManagePerson();
            popup.Show();
        }
    }
}
