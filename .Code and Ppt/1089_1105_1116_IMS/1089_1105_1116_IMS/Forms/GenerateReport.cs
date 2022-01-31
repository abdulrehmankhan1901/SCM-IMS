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
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {
            Classes.User u = new Classes.User();
            DataSet ds = Classes.Transaction.GetData();
            dataGridView1.DataSource = ds.Tables["T_Transaction"];
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            Classes.User u = new Classes.User();
            u.GenerateReport(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
