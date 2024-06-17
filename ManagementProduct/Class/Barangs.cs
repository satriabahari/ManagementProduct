using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementProduct.Class
{
    internal class Barangs
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private void InitializeDB()
        {
            server = "localhost";
            database = "management_product";
            uid = "root";
            password = "";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public Barangs()
        {
            InitializeDB();
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
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public DataTable GetProducts()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT p.id, p.name, c.name AS category_name, p.description, p.price, p.stock  FROM products p JOIN categories c ON p.category_id = c.id";

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

        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();

            string query = "SELECT name FROM categories";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    categories.Add(dataReader["name"].ToString());
                }

                dataReader.Close();
                CloseConnection();
            }

            return categories;
        }

        public int GetCategoryIdByName(string categoryName)
        {
            int categoryId = -1;

            string query = "SELECT id FROM categories WHERE name = @name";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", categoryName);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    categoryId = Convert.ToInt32(dataReader["id"]);
                }

                dataReader.Close();
                CloseConnection();
            }

            return categoryId;
        }

        public string GetCategoryNameById(int categoryId)
        {
            string categoryName = "";

            string query = "SELECT name FROM categories WHERE id = @id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", categoryId);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    categoryName = dataReader["name"].ToString();
                }

                dataReader.Close();
                CloseConnection();
            }

            return categoryName;
        }

        public DataRow GetProductById(int productId)
        {
            string query = "SELECT name, category_id, description, stock, price FROM products WHERE id = @id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", productId);

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

        public DataRow GetProductByName(string name)
        {
            string query = "SELECT * FROM products WHERE name = @name";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);

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

        public bool CreateProduct(string name, string category_id, string description, string stock, string price)
        {
            string query = "INSERT INTO products (name, category_id, description, stock, price) VALUES (@name,  @category_id, @description, @stock, @price)";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category_id", category_id);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@price", price);

                int rowsAffected = cmd.ExecuteNonQuery();

                CloseConnection();

                return rowsAffected > 0;
            }

            return false;
        }

        public bool UpdateProduct(int productId, string name, string category_id, string description, string stock, string price)
        {
            string query = "UPDATE products SET name = @name, category_id = @category_id, description = @description, stock = @stock, price = @price WHERE id = @id";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@category_id", category_id);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
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

        public bool DeleteProduct(int productId)
        {
            string query = "DELETE FROM products WHERE id = @id";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", productId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    CloseConnection();

                    // Jika ada baris yang terpengaruh, penghapusan berhasil
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
    }
}
