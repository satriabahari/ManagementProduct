using ManagementProduct.Class;
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
    public partial class Main : Form
    {
        public event EventHandler DarkModeChanged;

        private bool darkModeEnabled = false;
        public string LoggedInUsername { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Users userManager = new Users();
            DataRow userData = userManager.GetUserByUsername(LoggedInUsername);

            if (userData != null)
            {
                // Tetapkan gambar pengguna
                if (userData["image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])userData["image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        txtPic.Image = Image.FromStream(ms);
                        txtPic.SizeMode = PictureBoxSizeMode.Zoom; // Mengatur SizeMode agar gambar tidak terpotong
                    }
                }

                // Tetapkan nama pengguna
                lblUser.Text = userData["username"].ToString();
            }
            else
            {
                MessageBox.Show("User data not found.");
            }

            UpdateDarkModeButton();

            btnMax.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form_CRUDCategory
            Form_crudCategory crudCategoryForm = new Form_crudCategory();

            // Mengatur properti TopLevel dan BorderStyle
            crudCategoryForm.TopLevel = false;
            crudCategoryForm.FormBorderStyle = FormBorderStyle.None;
            crudCategoryForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            guna2Panel2.Controls.Add(crudCategoryForm);

            // Tampilkan Form_CRUDCategory
            crudCategoryForm.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form_CRUDCategory
            Form_crudUsers crudUsersForm = new Form_crudUsers(darkModeEnabled);

            

            // Mengatur properti TopLevel dan BorderStyle
            crudUsersForm.TopLevel = false;
            crudUsersForm.FormBorderStyle = FormBorderStyle.None;
            crudUsersForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            guna2Panel2.Controls.Add(crudUsersForm);

            // Tampilkan Form_CRUDCategory
            crudUsersForm.Show();
        }

        private void EnableDarkMode()
        {
            // Mengatur warna latar belakang form
            this.BackColor = Color.FromArgb(45, 45, 48);

            // Mengatur warna teks
            this.ForeColor = Color.White;

            // Mengatur warna latar belakang panel-panel
            guna2Panel1.FillColor = Color.FromArgb(35, 35, 38);
            guna2Panel2.FillColor = Color.FromArgb(35, 35, 38);
            guna2Panel3.FillColor = Color.FromArgb(35, 35, 38);
            btnDarkMode.BackColor = Color.FromArgb(35, 35, 38);
            // Mengubah status mode menjadi gelap
            darkModeEnabled = true;

            UpdateDarkModeButton();

            DarkModeChanged?.Invoke(this, EventArgs.Empty);
        }

        // Fungsi untuk mengembalikan tema aplikasi ke mode normal
        private void DisableDarkMode()
        {
            // Mengatur warna latar belakang form
            this.BackColor = Color.FromArgb(239, 243, 248);

            // Mengatur warna teks
            this.ForeColor = Color.FromArgb(71, 69, 94);

            // Mengatur warna latar belakang panel-panel
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel2.FillColor = Color.Transparent;
            btnDarkMode.BackColor = Color.FromArgb(239, 243, 248);
            guna2Panel3.FillColor = Color.FromArgb(95, 61, 204);

            // Mengubah status mode menjadi normal
            darkModeEnabled = false;

            UpdateDarkModeButton();

            DarkModeChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ToggleDarkMode()
        {
            if (darkModeEnabled)
            {
                DisableDarkMode();
            }
            else
            {
                EnableDarkMode();
            }

            // Perbarui Form_crudUsers jika sedang ditampilkan
            if (guna2Panel2.Controls.Count > 0 && guna2Panel2.Controls[0] is Form_crudUsers)
            {
                ((Form_crudUsers)guna2Panel2.Controls[0]).ApplyDarkMode(darkModeEnabled);
            }
        }

        private void UpdateDarkModeButton()
        {
            if (darkModeEnabled)
            {
                btnDarkMode.Image = Properties.Resources.bulan;
                btnDarkMode.FillColor = Color.Black;
            }
            else
            {
                btnDarkMode.Image = Properties.Resources.light;
                btnDarkMode.FillColor = Color.WhiteSmoke;
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            ToggleDarkMode(); // Panggil fungsi untuk mengubah mode
        }
    }
}
