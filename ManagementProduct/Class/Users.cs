using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManagementProduct.Class
{
    internal class Users
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Users()
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

        public bool AuthenticateUser(string username, string password)
        {
            string query = $"SELECT * FROM users WHERE username='{username}' AND password='{password}'";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                bool authenticated = dataReader.Read();

                dataReader.Close();
                CloseConnection();

                return authenticated;
            }

            return false;
        }

        public List<string> GetUsernames()
        {
            List<string> usernames = new List<string>();

            string query = "SELECT username FROM users";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string username = dataReader["username"].ToString();
                    usernames.Add(username);
                }

                dataReader.Close();
                CloseConnection();
            }

            return usernames;
        }
    }
}
