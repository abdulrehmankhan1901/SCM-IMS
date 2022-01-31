using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace _1089_1105_1116_IMS.Classes
{
    class User
    {
        private string username;
        private string password;
        private string role;

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Role { get { return role; } set { role = value; } }

        public User()
        {

        }
        
        public User(string user, string pass, string role)
        {
            this.username = user;
            this.password = pass;
            this.role = role;
        }

        

        public void GenerateReport(DataGridView dg)
        {
            try
            {
                TextWriter txt = new StreamWriter(@"D:\University\BSSE 5\SCM - Inventory Management System\1089_1105_1116_IMS\Report.txt");
                int rows = dg.Rows.Count;
                for(int i=0; i<rows - 1; i++)
                {
                    txt.WriteLine(dg.Rows[i].Cells[0].Value.ToString() + "\t" + dg.Rows[i].Cells[1].Value.ToString() + "\t" + dg.Rows[i].Cells[2].Value.ToString());
                }
                txt.Close();
                MessageBox.Show("Saved");
            }
            catch (Exception)
            {
                MessageBox.Show("File path Error");
            }
        }

        public static SqlConnection GetConnection()
        {
            string connection = "Data Source = DESKTOP-2CIG64U\\SQLEXPRESS; Initial Catalog = IMS; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Connection");
            }
            return conn;
        }

        public static DataSet GetData()
        {
            string qry = "SELECT * FROM T_User;";
            SqlConnection conn = GetConnection();
            SqlCommand comm = new SqlCommand(qry, conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_User");
            return ds;
        }

        public static void AddUser(User s)
        {
            string qry = "INSERT INTO T_User VALUES(@Username, @Password, @Role);";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Username", s.username);
            command.Parameters.AddWithValue("@Password", s.password);
            command.Parameters.AddWithValue("@Role", s.role);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Add Record");
            }
        }

        public static void DeleteUser(string username)
        {
            string qry = "DELETE FROM T_User WHERE Username = @Username;";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Username", username);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Deletion");
            }
        }

        public static void EditUser(User s)
        {
            string qry = "UPDATE T_User SET Password=@Password, Role=@Role WHERE Username = @Username";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Username", s.username);
            command.Parameters.AddWithValue("@Password", s.password);
            command.Parameters.AddWithValue("@Role", s.role);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Record Editting");
            }
        }

        public static DataSet SearchUser(string username)
        {
            string qry = "SELECT* FROM T_User WHERE Username = '" + username + "';";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_User");
            return ds;
        }

        public static bool Login(string username, string pass, string role)
        {
            string qry = "SELECT* FROM T_User WHERE Username = '"+username+"' AND Password = '"+pass+"' AND Role = '"+role+"';";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_User");
            if(ds.Tables[0].Rows.Count == 0) { return false; }
            else { return true; }
        }

    }
}
