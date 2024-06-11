using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementProduct.Class
{
    internal class Customers
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Customers()
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

        

        

        public bool CreateCustomers(string name, string address, string email, string phone)
        {
            string query = "INSERT INTO customer (name, address, email, phone) VALUES (@name, @address, @email, @phone)";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);

                int rowsAffected = cmd.ExecuteNonQuery();

                CloseConnection();

                return rowsAffected > 0;
            }

            return false;
        }

        public DataTable GetCustomers()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT id, name, email, phone, address FROM customer";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                CloseConnection();
            }

            return dataTable;
        }

        public DataRow GetCustomersById(int customersId)
        {
            string query = "SELECT name, email, phone, address FROM customer WHERE id = @id";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", customersId);

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

        public DataRow GetUserByName(string name)
        {
            string query = "SELECT * FROM customer WHERE name = @name";

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
        public bool UpdateCustomers(int customersId, string name, string address, string email, string phone)
        {
            string query = "UPDATE customer SET name = @name, address = @address, email = @email, phone = @phone WHERE id = @id";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@id", customersId);
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

        public bool DeleteCustomers(int customersId)
        {
            string query = "DELETE FROM customer WHERE id = @id";

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", customersId);
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
