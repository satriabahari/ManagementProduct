﻿using MySql.Data.MySqlClient;
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

                CloseConnection();

                return rowsAffected > 0;
            }

            return false;
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


        public DataTable GetInbounds()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT i.id, i.product_id, s.name AS supplier_name, i.quantity, i.date " +
               "FROM inbounds i " +
               "JOIN supplier s ON i.supplier_id = s.id";

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

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", inboundId);
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

        public static implicit operator Inbounds(Outbounds v)
        {
            throw new NotImplementedException();
        }
    }
}
