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
using ManagementProduct.Class;

namespace ManagementProduct.GUI
{
    public partial class Form_Edit_User : Form
    {
        private int userId;
        private Users users;

        public event EventHandler UserUpdated;

        public Form_Edit_User(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            users = new Users();
            LoadUserData();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUserData()
        {
            DataRow user = users.GetUserById(userId);
            if (user != null)
            {
                txtUsername.Text = user["username"].ToString();
                txtEmail.Text = user["email"].ToString();
                txtPhone.Text = user["phone"].ToString();
                txtPassword.Text = user["password"].ToString();
                if (user["image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])user["image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        txtPic.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void buttonUpdate(object sender, EventArgs e)
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

            bool success = users.UpdateUser(userId, usernameValue, passwordValue, emailValue, phoneValue, imageValue);
            if (success)
            {
                MessageBox.Show("Data updated successfully.");
                UserUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }
        }

        private void buttonBrowseImage(object sender, EventArgs e)
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
