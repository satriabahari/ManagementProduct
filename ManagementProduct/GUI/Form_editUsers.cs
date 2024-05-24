using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementProduct.GUI
{
    public partial class Form_editUsers : Form
    {
        private int userId;
        private string connectionString = "server=localhost;user=root;password=;database=management_product;";

        public event EventHandler UserUpdated;

        public Form_editUsers(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUserData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUserData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT username, email, phone, password, image FROM users WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text = reader["username"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtPhone.Text = reader["phone"].ToString();
                            txtPassword.Text = reader["password"].ToString();
                            if (reader["image"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["image"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    txtPic.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string usernameValue = txtUsername.Text;
            string passwordValue = txtPassword.Text;
            string emailValue = txtEmail.Text;
            string phoneValue = txtPhone.Text;
            byte[] imageValue = ConvertImageToByteArray(txtPic.Image);

            if (string.IsNullOrEmpty(usernameValue) || string.IsNullOrEmpty(passwordValue) || string.IsNullOrEmpty(emailValue) || string.IsNullOrEmpty(phoneValue))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE users SET username = @username, password = @password, email = @email, phone = @phone, image = @image WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@username", usernameValue);
                    cmd.Parameters.AddWithValue("@password", passwordValue);
                    cmd.Parameters.AddWithValue("@email", emailValue);
                    cmd.Parameters.AddWithValue("@phone", phoneValue);
                    cmd.Parameters.AddWithValue("@image", imageValue);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data updated successfully.");
                UserUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Mendapatkan path file gambar yang dipilih
                        string selectedImagePath = openFileDialog.FileName;

                        // Menampilkan gambar yang dipilih pada PictureBox
                        txtPic.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not open file. Details: " + ex.Message);
                    }
                }
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
