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

namespace ManagementProduct.GUI.Customer
{
    public partial class List_Customer : Form
    {
        private Customers Customers;

        public List_Customer(bool isDarkModeEnabled)
        {
            InitializeComponent();
            LoadData();
            Customers = new Customers();
            buttonDarkMode(isDarkModeEnabled);
        }

        public void LoadData()
        {
            Customers customers = new Customers(); // Inisialisasi objek Customers
            DataTable dataTable = customers.GetCustomers(); // Ambil data customer dari database

            guna2DataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                guna2DataGridView1.Rows.Add(i++, row["id"], row["name"], row["email"], row["phone"], row["address"]);
            }
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            Form_Add_Customer formAddCustomers = new Form_Add_Customer
            {
                Owner = this
            };
            formAddCustomers.ShowDialog();
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
                    int customersId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    Form_Edit_Customer formEditCustomers = new Form_Edit_Customer(customersId);
                    formEditCustomers.CustomersUpdated += (s, ev) => LoadData();
                    formEditCustomers.ShowDialog();
                }
                // Jika kolom delete yang diklik
                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
                {
                    int customersId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (Customers.DeleteCustomers(customersId))
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
