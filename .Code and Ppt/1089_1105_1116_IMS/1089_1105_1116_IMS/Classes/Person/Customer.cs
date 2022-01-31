using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1089_1105_1116_IMS.Classes.Person
{
    class Customer : Person
    {
        private string cID;

        public Customer(string f, string l, string a, string tel, string t, string cID) : base(f,l,a,tel,t)
        {
            this.cID = cID;
        }

        public static SqlConnection GetConnection()
        {
            string connection = @"Data Source = DESKTOP-2CIG64U\SQLEXPRESS; Initial Catalog = IMS; Integrated Security = true;";
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
            string qry = "SELECT * FROM Customer_T;";
            SqlConnection conn = GetConnection();
            SqlCommand comm = new SqlCommand(qry, conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Customer_T");
            return ds;
        }

        public static void AddCustomer(Customer s)
        {
            string qry = "INSERT INTO Customer_T VALUES(@CustomerID, @FirstName, @LastName, @Address, @Telephone)";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@CustomerID", s.cID);
            command.Parameters.AddWithValue("@FirstName", s.FirstName);
            command.Parameters.AddWithValue("@LastName", s.LastName);
            command.Parameters.AddWithValue("@Address", s.Address);
            command.Parameters.AddWithValue("@Telephone", s.Telephone);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Record Creation");
            }
        }

        public static void DeleteCustomer(string CustomerID)
        {
            string qry = "DELETE FROM Customer_T WHERE CustomerID = @CustomerID;";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        public static void EditCustomer(Customer s)
        {
            string qry = "UPDATE Customer_T SET FirstName=@FirstName, LastName=@LastName, Address=@Address, Telephone=@Telephone WHERE CustomerID = @SupplierID";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@SupplierID", s.cID);
            command.Parameters.AddWithValue("@FirstName", s.FirstName);
            command.Parameters.AddWithValue("@LastName", s.LastName);
            command.Parameters.AddWithValue("@Address", s.Address);
            command.Parameters.AddWithValue("@Telephone", s.Telephone);
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

        public static DataSet SearchCustomer(string cID)
        {
            string qry = "SELECT* FROM Customer_T WHERE CustomerID = '" + cID + "';";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Customer_T");
            return ds;
        }

    }
}
