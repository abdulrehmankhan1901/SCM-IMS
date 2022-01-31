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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool show = false;
            Classes.User u = new Classes.User(txtUser.Text, txtPass.Text, cmbRole.SelectedItem.ToString());
            show = Classes.User.Login(u.Username, u.Password, u.Role);
            if (show == true)
            {
                if(u.Role == "Admin")
                {
                    Forms.Admin popup = new Forms.Admin();
                    popup.Show();
                }
                else
                {
                    Forms.Staff popup = new Forms.Staff();
                    popup.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid username and password");
            }
        }
    }
}
