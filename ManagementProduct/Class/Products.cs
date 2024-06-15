//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ManagementProduct.Class
//{
//    internal class Products
//    {

//        private MySqlConnection connection;
//        private string server;
//        private string database;
//        private string uid;
//        private string password;

//        private void InitializeDB()
//        {
//            server = "localhost";
//            database = "management_product";
//            uid = "root";
//            password = "";
//            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

//            connection = new MySqlConnection(connectionString);
//        }

//        public Products()
//        {
//            InitializeDB();
//        }

//        public bool OpenConnection()
//        {
//            try
//            {
//                connection.Open();
//                return true;
//            }
//            catch (MySqlException ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//                return false;
//            }
//        }

//        public bool CloseConnection()
//        {
//            try
//            {
//                connection.Close();
//                return true;
//            }
//            catch (MySqlException ex)
//            {
//                // Handle exception
//                Console.WriteLine("Error: " + ex.Message);
//                return false;
//            }
//        }

//        public DataTable GetProducts()
//        {
//            DataTable dataTable = new DataTable();

//            string query = "SELECT * FROM products";

//            if (OpenConnection())
//            {
//                MySqlCommand cmd = new MySqlCommand(query, connection);
//                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
//                adapter.Fill(dataTable);

//                CloseConnection();
//            }

//            return dataTable;
//        }

//        public DataRow GetProductById(int productId)
//        {
//            string query = "SELECT name FROM products WHERE id = @id";

//            if (OpenConnection())
//            {
//                MySqlCommand cmd = new MySqlCommand(query, connection);
//                cmd.Parameters.AddWithValue("@id", productId);

//                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
//                {
//                    DataTable dt = new DataTable();
//                    adapter.Fill(dt);
//                    CloseConnection();
//                    if (dt.Rows.Count > 0)
//                    {
//                        return dt.Rows[0];
//                    }
//                }
//            }
//            return null;
//        }

//        public DataRow GetProductByName(string name)
//        {
//            string query = "SELECT * FROM products WHERE name = @name";

//            if (OpenConnection())
//            {
//                MySqlCommand cmd = new MySqlCommand(query, connection);
//                cmd.Parameters.AddWithValue("@name", name);

//                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
//                {
//                    DataTable dt = new DataTable();
//                    adapter.Fill(dt);
//                    CloseConnection();
//                    if (dt.Rows.Count > 0)
//                    {
//                        return dt.Rows[0];
//                    }
//                }
//            }
//            return null;
//        }

//        public bool CreateProduct(string name, int category_id, string description, int stock, int price)
//        {
//            string query = "INSERT INTO products (name, category_id, description, stock, price) VALUES (@name,  @category_id, @description, @stock, @price)";

//            if (OpenConnection())
//            {
//                MySqlCommand cmd = new MySqlCommand(query, connection);
//                cmd.Parameters.AddWithValue("@name", name);
//                cmd.Parameters.AddWithValue("@category_id", category_id);
//                cmd.Parameters.AddWithValue("@description", description);
//                cmd.Parameters.AddWithValue("@stock", stock);
//                cmd.Parameters.AddWithValue("@price", price);

//                int rowsAffected = cmd.ExecuteNonQuery();

//                CloseConnection();

//                return rowsAffected > 0;
//            }

//            return false;
//        }

//        public bool UpdateProduct(string name, int category_id, string description, int stock, int price)
//        {
//            string query = "UPDATE products SET name = @name, category_id = @category_id, description = @description, stock = @stock, price = @price WHERE id = @id";

//            if (OpenConnection())
//            {
//                try
//                {
//                    MySqlCommand cmd = new MySqlCommand(query, connection);
//                    cmd.Parameters.AddWithValue("@name", name);
//                    cmd.Parameters.AddWithValue("@category_id", category_id);
//                    cmd.Parameters.AddWithValue("@description", description);
//                    cmd.Parameters.AddWithValue("@stock", stock);
//                    cmd.Parameters.AddWithValue("@price", price);
//                    cmd.ExecuteNonQuery();
//                    CloseConnection();
//                    return true;
//                }
//                catch (MySqlException ex)
//                {
//                    Console.WriteLine("Error: " + ex.Message);
//                    CloseConnection();
//                    return false;
//                }
//            }
//            return false;
//        }

//        public bool DeleteProduct(int productId)
//        {
//            string query = "DELETE FROM products WHERE id = @id";

//            if (OpenConnection())
//            {
//                try
//                {
//                    MySqlCommand cmd = new MySqlCommand(query, connection);
//                    cmd.Parameters.AddWithValue("@id", productId);
//                    int rowsAffected = cmd.ExecuteNonQuery();
//                    CloseConnection();

//                    // Jika ada baris yang terpengaruh, penghapusan berhasil
//                    return rowsAffected > 0;
//                }
//                catch (MySqlException ex)
//                {
//                    Console.WriteLine("Error: " + ex.Message);
//                    CloseConnection();
//                    return false;
//                }
//            }

//            return false;


//        }

//    }
//}
