using ManagementProduct.Class;
using ManagementProduct.GUI.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementProduct.GUI.Supplier
{
    public partial class List_Supplier : Form
    {
        private Suppliers Suppliers;

        public List_Supplier(bool isDarkModeEnabled)
        {
            InitializeComponent();
            LoadData();
            Suppliers = new Suppliers();
            buttonDarkMode(isDarkModeEnabled);
        }

        public void LoadData()
        {
            Suppliers suppliers = new Suppliers(); // Inisialisasi objek Customers
            DataTable dataTable = suppliers.GetSuppliers(); // Ambil data customer dari database

            guna2DataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                guna2DataGridView1.Rows.Add(i++, row["id"], row["name"], row["email"], row["phone"], row["address"]);
            }
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            Form_Add_Supplier formAddSuppliers = new Form_Add_Supplier
            {
                Owner = this
            };
            formAddSuppliers.ShowDialog();
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
                    int suppliersId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    Form_Edit_Supplier formEditSuppliers = new Form_Edit_Supplier(suppliersId);
                    formEditSuppliers.SuppliersUpdated += (s, ev) => LoadData();
                    formEditSuppliers.ShowDialog();
                }
                // Jika kolom delete yang diklik
                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
                {
                    int suppliersId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (Suppliers.DeleteSuppliers(suppliersId))
                        {
                            MessageBox.Show("Supplier deleted successfully.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while deleting the supplier.");
                        }
                    }
                }
            }
        }
    }
}
