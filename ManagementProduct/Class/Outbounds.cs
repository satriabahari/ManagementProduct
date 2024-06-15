﻿using MySql.Data.MySqlClient;
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

                CloseConnection();

                return rowsAffected > 0;
            }

            return false;
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


        public DataTable GetOutbounds()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT i.id, i.product_id, s.name AS customer_name, i.quantity, i.date " +
               "FROM outbounds i " +
               "JOIN customer s ON i.customer_id = s.id";

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
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", outboundId);
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