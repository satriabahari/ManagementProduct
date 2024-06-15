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
    public partial class Form_Login : Form
    {
        private Users userManager;
        public Form_Login()
        {
            InitializeComponent();
            userManager = new Users();
        }
        public string LoggedInUsername { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (userManager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                LoggedInUsername = username;

                // Lanjutkan ke form lain
                Main formMain = new Main();
                formMain.LoggedInUsername = LoggedInUsername;
                formMain.Show();
                this.Hide(); // Sembunyikan form login
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            // Buat instance Form_Register
            Form_Register formRegister = new Form_Register();

            // Menampilkan form register
            formRegister.Show();

            // Menutup form login
            this.Hide();
        }

    }
}
