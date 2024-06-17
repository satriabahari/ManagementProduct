using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ManagementProduct.Class;
using MySql.Data.MySqlClient;


namespace ManagementProduct.GUI
{
    public partial class List_User : Form
    {
        private Users users;

        public List_User(bool isDarkModeEnabled)
        {
            InitializeComponent();
            LoadData();
            buttonDarkMode(isDarkModeEnabled);
        }

        public void LoadData()
        {
            Users users = new Users(); // Inisialisasi objek Users
            DataTable dataTable = users.GetUsers(); // Ambil data pengguna dari database

            guna2DataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                guna2DataGridView1.Rows.Add(i++, row["id"], row["username"], row["email"], row["phone"], row["password"]);
            }
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            Form_Add_User formAddUsers = new Form_Add_User
            {
                Owner = this
            };
            formAddUsers.ShowDialog();
        }

        public void buttonDarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                // Terapkan warna-warna untuk mode gelap
                this.BackColor = Color.FromArgb(45, 45, 48); // Warna latar belakang gelap
                this.ForeColor = Color.White; // Warna teks putih
            }
            else
            {
                // Terapkan warna-warna untuk mode normal
                this.BackColor = SystemColors.Control; // Warna latar belakang default
                this.ForeColor = SystemColors.ControlText; // Warna teks default
            }
        }

        private void buttonActions(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Jika kolom edit yang diklik
                if (e.ColumnIndex == guna2DataGridView1.Columns["dgvEdit"].Index)
                {
                    int userId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    Form_Edit_User formEditUsers = new Form_Edit_User(userId);
                    formEditUsers.UserUpdated += (s, ev) => LoadData();
                    formEditUsers.ShowDialog();
                }
                // Jika kolom delete yang diklik
                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
                {
                    int userId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (users.DeleteUser(userId))
                        {
                            MessageBox.Show("User deleted successfully.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while deleting the user.");
                        }
                    }
                }
            }
        }
    }
}
