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
    class Item
    {
        private string id;
        private string name;
        private string desc;
        private float price;
        private string type;
        private int quantity;
        private string supplier;

        public Item(string i, string n, string d, float p, string t, int q, string s)
        {
            this.id = i;
            this.name = n;
            this.desc = d;
            this.price = p;
            this.type = t;
            this.quantity = q;
            this.supplier = s;
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
            string qry = "SELECT * FROM Item_T;";
            SqlConnection conn = GetConnection();
            SqlCommand comm = new SqlCommand(qry, conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Item_T");
            return ds;
        }

        public static void AddItem(Item s)
        {
            string qry = "INSERT INTO Item_T VALUES(@ItemID, @Name, @Description, @Price, @Type, @Quantity, @Supplier)";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ItemID", s.id);
            command.Parameters.AddWithValue("@Name", s.name);
            command.Parameters.AddWithValue("@Description", s.desc);
            command.Parameters.AddWithValue("@Price", s.price);
            command.Parameters.AddWithValue("@Type", s.type);
            command.Parameters.AddWithValue("@Quantity", s.quantity);
            command.Parameters.AddWithValue("@Supplier", s.supplier);
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

        public static void DeleteItem(string ItemID)
        {
            string qry = "DELETE FROM Item_T WHERE ItemID = @ItemID;";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ItemID", ItemID);
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

        public static void EditItem(Item s)
        {
            string qry = "UPDATE Item_T SET Name=@Name, Description=@Description, Price=@Price, Type=@Type, Quantity=@Quantity, Supplier=@Supplier WHERE ItemID = @ItemID";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ItemID", s.id);
            command.Parameters.AddWithValue("@Name", s.name);
            command.Parameters.AddWithValue("@Description", s.desc);
            command.Parameters.AddWithValue("@Price", s.price);
            command.Parameters.AddWithValue("@Type", s.type);
            command.Parameters.AddWithValue("@Quantity", s.quantity);
            command.Parameters.AddWithValue("@Supplier", s.supplier);
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

        public static DataSet SearchItem(string sID)
        {
            string qry = "SELECT* FROM Item_T WHERE ItemID = '" + sID + "';";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Item_T");
            return ds;
        }

    }
}
