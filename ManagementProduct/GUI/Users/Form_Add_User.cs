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
using ManagementProduct.Class;

namespace ManagementProduct.GUI
{
    public partial class Form_Add_User : Form
    {
        private Users users;
        public Form_Add_User()
        {
            InitializeComponent();
            users = new Users();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
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
                        inputPicture.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not open file. Details: " + ex.Message);
                    }
                }
            }
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Text;
            string email = inputEmail.Text;
            string phone = inputPhone.Text;
            byte[] image = ConvertImageToByteArray(inputPicture.Image);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            bool success = users.CreateUser(username, password, email, phone, image);

            if (success)
            {
                MessageBox.Show("User data has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is List_User crudForm)
                {
                    crudForm.LoadData();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("User data was not successfully added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
