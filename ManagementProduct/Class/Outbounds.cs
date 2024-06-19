using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementProduct.Class
{
    internal class Outbounds
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Outbounds()
        {
            InitializeDB();
        }

        private void InitializeDB()
        {
            server = "localhost"; // Ganti dengan alamat server MySQL Anda
            database = "management_product"; // Ganti dengan nama database Anda
            uid = "root"; // Ganti dengan nama pengguna MySQL Anda
            password = ""; // Ganti dengan kata sandi MySQL Anda
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool CreateOutbound(string product_id, string customer_id, string quantity, string date)
        {
            string query = "INSERT INTO outbounds (product_id, customer_id, quantity, date) VALUES (@product_id, @customer_id, @quantity, @date)";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.Parameters.AddWithValue("@customer_id", customer_id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@date", date);

                int rowsAffected = cmd.ExecuteNonQuery();

                UpdateProductStock(product_id, quantity);

                CloseConnection();

                return rowsAffected > 0;
            }

            return false;
        }

        private void UpdateProductStock(string product_id, string quantity)
        {
            // Get current stock
            int currentStock = GetCurrentStock(product_id);

            // Calculate new stock
            int newStock = currentStock - Convert.ToInt32(quantity);

            // Update stock in products table
            string updateQuery = "UPDATE products SET stock = @stock WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
            cmd.Parameters.AddWithValue("@stock", newStock);
            cmd.Parameters.AddWithValue("@id", product_id);

            cmd.ExecuteNonQuery();
        }

        private int GetCurrentStock(string product_id)
        {
            int currentStock = 0;

            string query = "SELECT stock FROM products WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", product_id);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                currentStock = Convert.ToInt32(dataReader["stock"]);
            }

            dataReader.Close();

            return currentStock;
        }

        public List<string> GetCustomers()
        {
            List<string> customers = new List<string>();

            string query = "SELECT name FROM customer";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    customers.Add(dataReader["name"].ToString());
                }

                dataReader.Close();
                CloseConnection();
            }

            return customers;
        }

        public List<string> GetProducts()
        {
            List<string> products = new List<string>();

            string query = "SELECT name FROM products";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    products.Add(dataReader["name"].ToString());
                }

                dataReader.Close();
                CloseConnection();
            }

            return products;
        }

        public int GetCustomerIdByName(string customerName)
        {
            int customerId = -1;

            string query = "SELECT id FROM customer WHERE name = @name";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", customerName);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    customerId = Convert.ToInt32(dataReader["id"]);
                }

                dataReader.Close();
                CloseConnection();
            }

            return customerId;
        }

        public int GetProductIdByName(string productName)
        {
            int productId = -1;

            string query = "SELECT id FROM products WHERE name = @name";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", productName);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    productId = Convert.ToInt32(dataReader["id"]);
                }

                dataReader.Close();
                CloseConnection();
            }

            return productId;
        }
        public string GetCustomerNameById(int customerId)
        {
            string customerName = "";

            string query = "SELECT name FROM customer WHERE id = @id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", customerId);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    customerName = dataReader["name"].ToString();
                }

                dataReader.Close();
                CloseConnection();
            }

            return customerName;
        }

        public string GetProductNameById(int productId)
        {
            string productName = "";

            string query = "SELECT name FROM products WHERE id = @id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", productId);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    productName = dataReader["name"].ToString();
                }

                dataReader.Close();
                CloseConnection();
            }

            return productName;
        }
        public DataTable GetOutbounds()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT o.id, p.name AS product_name, s.name AS customer_name, o.quantity, o.date " +
   "FROM outbounds o " +
   "JOIN customer s ON o.customer_id = s.id " +  // Tambahkan spasi setelah 's.id'
   "JOIN products p ON o.product_id = p.id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                CloseConnection();
            }

            return dataTable;
        }

        public DataRow GetOutboundById(int outboundId)
        {
            string query = "SELECT product_id, customer_id, quantity, date FROM outbounds WHERE id = @id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", outboundId);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CloseConnection();
                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0];
                    }
                }
            }
            return null;
        }

        public bool UpdateOutbound(int outboundId, string product_id, string customer_id, string quantity, string date)
        {
            DataRow currentOutbound = GetOutboundById(outboundId);
            if (currentOutbound == null)
            {
                Console.WriteLine("Outbound with id {0} not found.", outboundId);
                return false;
            }

            string currentQuantity = currentOutbound["quantity"].ToString();
            string currentProductId = currentOutbound["product_id"].ToString();

            string query = "UPDATE outbounds SET product_id = @product_id, customer_id = @customer_id, quantity = @quantity, date = @date WHERE id = @id";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@product_id", product_id);
                    cmd.Parameters.AddWithValue("@customer_id", customer_id);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@id", outboundId);
                    cmd.ExecuteNonQuery();

                    // Calculate difference in quantity
                    int newQuantity = Convert.ToInt32(quantity);
                    int oldQuantity = Convert.ToInt32(currentQuantity);
                    int quantityDifference = newQuantity - oldQuantity;

                    // Update stock in products table
                    UpdateProductStock(currentProductId, quantityDifference.ToString());

                    CloseConnection();
                    return true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    CloseConnection();
                    return false;
                }
            }
            return false;
        }

        public bool DeleteOutbound(int outboundId)
        {
            string query = "DELETE FROM outbounds WHERE id = @id";

            if (OpenConnection())
            {
                try
                {
                    // Retrieve product_id and quantity before deletion
                    string getProductQuery = "SELECT product_id, quantity FROM outbounds WHERE id = @id";
                    MySqlCommand getProductCmd = new MySqlCommand(getProductQuery, connection);
                    getProductCmd.Parameters.AddWithValue("@id", outboundId);

                    string product_id = "";
                    string quantity = "";

                    using (MySqlDataReader dataReader = getProductCmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            product_id = dataReader["product_id"].ToString();
                            quantity = dataReader["quantity"].ToString();
                        }
                    }

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", outboundId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Increase product stock
                        IncreaseProductStock(product_id, quantity);
                    }

                    CloseConnection();

                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    CloseConnection();
                    return false;
                }
            }

            return false;
        }

        private void IncreaseProductStock(string product_id, string quantity)
        {
            // Get current stock
            int currentStock = GetCurrentStock(product_id);

            // Calculate new stock
            int newStock = currentStock + Convert.ToInt32(quantity);

            // Update stock in products table
            string updateQuery = "UPDATE products SET stock = @stock WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
            cmd.Parameters.AddWithValue("@stock", newStock);
            cmd.Parameters.AddWithValue("@id", product_id);

            cmd.ExecuteNonQuery();
        }
    }
}
