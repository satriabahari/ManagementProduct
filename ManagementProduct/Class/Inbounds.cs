using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementProduct.Class
{
    internal class Inbounds
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Inbounds()
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
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool CreateInbound(string product_id, string supplier_id, string quantity, string date)
        {
            string query = "INSERT INTO inbounds (product_id, supplier_id, quantity, date) VALUES (@product_id, @supplier_id, @quantity, @date)";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
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
            int newStock = currentStock + Convert.ToInt32(quantity);

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

        public List<string> GetSuppliers()
        {
            List<string> suppliers = new List<string>();

            string query = "SELECT name FROM supplier";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    suppliers.Add(dataReader["name"].ToString());
                }

                dataReader.Close();
                CloseConnection();
            }

            return suppliers;
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

        public int GetSupplierIdByName(string supplierName)
        {
            int supplierId = -1;

            string query = "SELECT id FROM supplier WHERE name = @name";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", supplierName);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    supplierId = Convert.ToInt32(dataReader["id"]);
                }

                dataReader.Close();
                CloseConnection();
            }

            return supplierId;
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

        public string GetSupplierNameById(int supplierId)
        {
            string supplierName = "";

            string query = "SELECT name FROM supplier WHERE id = @id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", supplierId);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    supplierName = dataReader["name"].ToString();
                }

                dataReader.Close();
                CloseConnection();
            }

            return supplierName;
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


        public DataTable GetInbounds()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT i.id, p.name AS product_name, s.name AS supplier_name, i.quantity, i.date " +
   "FROM inbounds i " +
   "JOIN supplier s ON i.supplier_id = s.id " +  // Tambahkan spasi setelah 's.id'
   "JOIN products p ON i.product_id = p.id";


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

        public DataRow GetInboundById(int inboundId)
        {
            string query = "SELECT product_id, supplier_id, quantity, date FROM inbounds WHERE id = @id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", inboundId);

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

        public bool UpdateInbound(int inboundId, string product_id, string supplier_id, string quantity, string date)
        {
            // Get current inbound data
            DataRow currentInbound = GetInboundById(inboundId);
            if (currentInbound == null)
            {
                Console.WriteLine("Inbound with id {0} not found.", inboundId);
                return false;
            }

            string currentQuantity = currentInbound["quantity"].ToString();
            string currentProductId = currentInbound["product_id"].ToString();

            string query = "UPDATE inbounds SET product_id = @product_id, supplier_id = @supplier_id, quantity = @quantity, date = @date WHERE id = @id";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@product_id", product_id);
                    cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@id", inboundId);
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

        public bool DeleteInbound(int inboundId)
        {
            string query = "DELETE FROM inbounds WHERE id = @id";

            if (OpenConnection()) // Buka koneksi sebelum menggunakan
            {
                try
                {
                    // Retrieve product_id and quantity before deletion
                    string getProductQuery = "SELECT product_id, quantity FROM inbounds WHERE id = @id";
                    MySqlCommand getProductCmd = new MySqlCommand(getProductQuery, connection);
                    getProductCmd.Parameters.AddWithValue("@id", inboundId);

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
                    cmd.Parameters.AddWithValue("@id", inboundId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Reduce stock in products table
                        ReduceProductStock(product_id, quantity);
                    }

                    CloseConnection(); // Tutup koneksi setelah selesai menggunakan

                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    CloseConnection(); // Tutup koneksi jika terjadi kesalahan
                    return false;
                }
            }

            return false;
        }

        private void ReduceProductStock(string product_id, string quantity)
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

        public static implicit operator Inbounds(Outbounds v)
        {
            throw new NotImplementedException();
        }
    }
}
