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
    public partial class Form_Register : Form
    {
        private Users users;
        public Form_Register()
        {
            InitializeComponent();
            users = new Users();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Form_Login loginForm = new Form_Login();
            loginForm.Show();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            byte[] image = ConvertImageToByteArray(txtPic.Image);


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            bool success = users.CreateUser(username, password, email, phone, image);

            if (success)
            {
                MessageBox.Show("User registration successful. Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create an instance of Form_Login and show it
                Form_Login loginForm = new Form_Login();
                loginForm.Show();

                // Close the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("User registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
