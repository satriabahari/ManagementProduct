using ManagementProduct.Class;
using ManagementProduct.GUI.Category;
using ManagementProduct.GUI.Customer;
using ManagementProduct.GUI.Supplier;
using ManagementProduct.GUI.Inbound;
using ManagementProduct.GUI.Outbound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementProduct.GUI.Products;
using ManagementProduct.GUI.Home;

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

            //UpdateDarkModeButton();

            btnMax.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form_CRUDCategory
            List_Category crudCategoryForm = new List_Category(darkModeEnabled);

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
            List_User crudUsersForm = new List_User(darkModeEnabled);



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

        //private void EnableDarkMode()
        //{
        //    // Mengatur warna latar belakang form
        //    this.BackColor = Color.FromArgb(45, 45, 48);

        //    // Mengatur warna teks
        //    this.ForeColor = Color.White;

        //    // Mengatur warna latar belakang panel-panel
        //    guna2Panel1.FillColor = Color.FromArgb(35, 35, 38);
        //    guna2Panel2.FillColor = Color.FromArgb(35, 35, 38);
        //    guna2Panel3.FillColor = Color.FromArgb(35, 35, 38);
        //    btnDarkMode.BackColor = Color.FromArgb(35, 35, 38);
        //    // Mengubah status mode menjadi gelap
        //    darkModeEnabled = true;

        //    UpdateDarkModeButton();

        //    DarkModeChanged?.Invoke(this, EventArgs.Empty);
        //}

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
            //btnDarkMode.BackColor = Color.FromArgb(239, 243, 248);
            guna2Panel3.FillColor = Color.FromArgb(95, 61, 204);

            // Mengubah status mode menjadi normal
            darkModeEnabled = false;

            //UpdateDarkModeButton();

            DarkModeChanged?.Invoke(this, EventArgs.Empty);
        }

        //private void ToggleDarkMode()
        //{
        //    if (darkModeEnabled)
        //    {
        //        DisableDarkMode();
        //    }
        //    else
        //    {
        //        EnableDarkMode();
        //    }

        //    // Perbarui Form_crudUsers jika sedang ditampilkan
        //    if (guna2Panel2.Controls.Count > 0 && guna2Panel2.Controls[0] is List_User)
        //    {
        //        ((List_User)guna2Panel2.Controls[0]).buttonDarkMode(darkModeEnabled);
        //    }
        //}

        //private void UpdateDarkModeButton()
        //{
        //    if (darkModeEnabled)
        //    {
        //        btnDarkMode.Image = Properties.Resources.bulan;
        //        btnDarkMode.FillColor = Color.Black;
        //    }
        //    else
        //    {
        //        btnDarkMode.Image = Properties.Resources.light;
        //        btnDarkMode.FillColor = Color.WhiteSmoke;
        //    }
        //}

        //private void btnDarkMode_Click(object sender, EventArgs e)
        //{
        //    ToggleDarkMode(); // Panggil fungsi untuk mengubah mode
        //}

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form_CRUDCategory
            //List_Product crudProductForm = new List_Product(darkModeEnabled);

            // Mengatur properti TopLevel dan BorderStyle
            //crudProductForm.TopLevel = false;
            //crudProductForm.FormBorderStyle = FormBorderStyle.None;
            //crudProductForm.Dock = DockStyle.Fill;
            //guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            //guna2Panel2.Controls.Add(crudProductForm);

            // Tampilkan Form_CRUDCategory
            // crudProductForm.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            List_Inbound crudInboundForm = new List_Inbound(darkModeEnabled);

            // Mengatur properti TopLevel dan BorderStyle
            crudInboundForm.TopLevel = false;
            crudInboundForm.FormBorderStyle = FormBorderStyle.None;
            crudInboundForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            guna2Panel2.Controls.Add(crudInboundForm);

            // Tampilkan Form_CRUDCategory
            crudInboundForm.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            List_Outbound crudOutboundForm = new List_Outbound(darkModeEnabled);

            // Mengatur properti TopLevel dan BorderStyle
            crudOutboundForm.TopLevel = false;
            crudOutboundForm.FormBorderStyle = FormBorderStyle.None;
            crudOutboundForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            guna2Panel2.Controls.Add(crudOutboundForm);

            // Tampilkan Form_CRUDCategory
            crudOutboundForm.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form_CRUDCategory
            List_Customer crudCustomersForm = new List_Customer(darkModeEnabled);



            // Mengatur properti TopLevel dan BorderStyle
            crudCustomersForm.TopLevel = false;
            crudCustomersForm.FormBorderStyle = FormBorderStyle.None;
            crudCustomersForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            guna2Panel2.Controls.Add(crudCustomersForm);

            // Tampilkan Form_CRUDCategory
            crudCustomersForm.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form_CRUDCategory
            List_Supplier crudSuppliersForm = new List_Supplier(darkModeEnabled);



            // Mengatur properti TopLevel dan BorderStyle
            crudSuppliersForm.TopLevel = false;
            crudSuppliersForm.FormBorderStyle = FormBorderStyle.None;
            crudSuppliersForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            guna2Panel2.Controls.Add(crudSuppliersForm);

            // Tampilkan Form_CRUDCategory
            crudSuppliersForm.Show();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            // Membuat instance dari Form_CRUDCategory
            List_Product crudProductsForm = new List_Product(darkModeEnabled);



            // Mengatur properti TopLevel dan BorderStyle
            crudProductsForm.TopLevel = false;
            crudProductsForm.FormBorderStyle = FormBorderStyle.None;
            crudProductsForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            guna2Panel2.Controls.Add(crudProductsForm);

            // Tampilkan Form_CRUDCategory
            crudProductsForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_Home homeForm = new Form_Home();
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();

            // Tetapkan parent ke guna2Panel2
            guna2Panel2.Controls.Add(homeForm);

            // Tampilkan Form_CRUDCategory
            homeForm.Show();
        }
    }
}
