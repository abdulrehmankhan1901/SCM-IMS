using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1089_1105_1116_IMS.Classes
{
    class Transaction
    {
        private string tID;
        private float tot;
        private char stat;

        public Transaction(string t, float tot, char s)
        {
            this.tID = t;
            this.tot = tot;
            this.stat = s;
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
            string qry = "SELECT * FROM T_Transaction;";
            SqlConnection conn = GetConnection();
            SqlCommand comm = new SqlCommand(qry, conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Transaction");
            return ds;
        }

        public static void AddTransaction(Transaction s)
        {
            string qry = "INSERT INTO T_Transaction VALUES(@TransactionID, @TotalPrice, @Status)";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@TransactionID", s.tID);
            command.Parameters.AddWithValue("@TotalPrice", s.tot);
            command.Parameters.AddWithValue("@Status", s.stat);
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


        public static void EditTransaction(Transaction s)
        {
            string qry = "UPDATE T_Transaction SET TotalPrice=@TotalPrice, Status=@Status WHERE TransactionID = @TransactionID";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@TransactionID", s.tID);
            command.Parameters.AddWithValue("@TotalPrice", s.tot);
            command.Parameters.AddWithValue("@Status", s.stat);
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

        public static DataSet SearchTransaction(string tID)
        {
            string qry = "SELECT* FROM T_Transaction WHERE TransactionID = '" + tID + "';";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Transaction");
            return ds;
        }

        public static DataSet TotalSold()
        {
            string qry = "SELECT* FROM T_Transaction WHERE Status = 'S';";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Transaction");
            return ds;
        }

        public static DataSet TotalReturn()
        {
            string qry = "SELECT* FROM T_Transaction WHERE Status = 'R';";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Transaction");
            return ds;
        }

    }
}
