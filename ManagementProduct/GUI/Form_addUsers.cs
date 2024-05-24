using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManagementProduct.GUI
{
    public partial class Form_addUsers : Form
    {
        public Form_addUsers()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string server = "localhost"; // Ganti dengan server MySQL Anda
            string database = "management_product"; // Ganti dengan nama database Anda
            string username = "root"; // Ganti dengan username MySQL Anda
            string password = ""; // Ganti dengan password MySQL Anda

            string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";

            // Ambil nilai dari TextBox dan PictureBox
            string usernameValue = txtUsername.Text;
            string passwordValue = txtPassword.Text;
            string emailValue = txtEmail.Text;
            string phoneValue = txtPhone.Text;
            byte[] imageValue = ConvertImageToByteArray(txtPic.Image); // Konversi gambar ke byte array jika perlu

            // Cek apakah ada data yang kosong
            if (string.IsNullOrEmpty(usernameValue) || string.IsNullOrEmpty(passwordValue) || string.IsNullOrEmpty(emailValue) || string.IsNullOrEmpty(phoneValue) || imageValue == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Simpan data ke dalam tabel users
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO users (username, password, email, phone, image) VALUES (@username, @password, @email, @phone, @image)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@username", usernameValue);
                    cmd.Parameters.AddWithValue("@password", passwordValue);
                    cmd.Parameters.AddWithValue("@email", emailValue);
                    cmd.Parameters.AddWithValue("@phone", phoneValue);
                    cmd.Parameters.AddWithValue("@image", imageValue);
                    cmd.ExecuteNonQuery();
                }

                // Tampilkan pesan sukses jika data berhasil disimpan
                MessageBox.Show("Data saved successfully.");

                if (Owner is Form_crudUsers crudForm)
                {
                    crudForm.LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
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
