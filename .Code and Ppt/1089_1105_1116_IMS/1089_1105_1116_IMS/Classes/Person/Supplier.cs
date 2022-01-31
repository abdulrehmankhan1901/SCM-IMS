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
    class Supplier : Person
    {
        private string sID;

        public Supplier(string f, string l, string a, string tel, string t, string id):base(f,l,a,tel,t)
        {
            this.sID = id;
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
            string qry = "SELECT * FROM Supplier_T;";
            SqlConnection conn = GetConnection();
            SqlCommand comm = new SqlCommand(qry,conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Supplier_T");
            return ds;
        }

        public static void AddSupplier(Supplier s)
        {
            string qry = "INSERT INTO Supplier_T VALUES(@SupplierID, @FirstName, @LastName, @Address, @Telephone)";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@SupplierID", s.sID);
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

        public static void DeleteSupplier(string SupplierID)
        {
            string qry = "DELETE FROM Supplier_T WHERE SupplierID = @SupplierID;";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
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

        public static void EditSupplier(Supplier s)
        {
            string qry = "UPDATE Supplier_T SET FirstName=@FirstName, LastName=@LastName, Address=@Address, Telephone=@Telephone WHERE SupplierID = @SupplierID";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@SupplierID", s.sID);
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

        public static DataSet SearchSupplier(string sID)
        {
            string qry = "SELECT* FROM Supplier_T WHERE SupplierID = '" + sID + "';";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Supplier_T");
            return ds;
        }

    }
}
