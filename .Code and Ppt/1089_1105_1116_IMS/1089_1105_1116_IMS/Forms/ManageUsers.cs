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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text; string password = txtNewPass.Text; string role = cmbRole.SelectedItem.ToString();
            Classes.User user = new Classes.User(username,password,role);
            Classes.User.AddUser(user);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            Classes.User Euser = new Classes.User(txtEditUsername.Text, txtEditPass.Text, cmbEditRole.SelectedItem.ToString());
            Classes.User.EditUser(Euser);
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            Classes.User.DeleteUser(txtDelUsername.Text);
        }

        private void btnViewAllUsers_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.User.GetData();
            dataGridView1.DataSource = ds.Tables["T_User"];
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            DataSet ds = Classes.User.SearchUser(txtSearchUsername.Text);
            dataGridView1.DataSource = ds.Tables["T_User"];
        }

        private void btnMUserExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
