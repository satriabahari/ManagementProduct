using ManagementProduct.Class;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementProduct.GUI.Category
{
    public partial class List_Category : Form
    {
        private Categories categories;

        public List_Category(bool isDarkModeEnabled)
        {
            InitializeComponent();
            LoadData();
            categories = new Categories();
            buttonDarkMode(isDarkModeEnabled);
        }

        internal void LoadData()
        {
            Categories categories = new Categories(); // Inisialisasi objek Users
            DataTable dataTable = categories.GetCategories(); // Ambil data pengguna dari database

            guna2DataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                guna2DataGridView1.Rows.Add(i++, row["id"], row["name"]);
            }
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            Form_Add_Category formAddCategory = new Form_Add_Category
            {
                Owner = this
            };
            formAddCategory.ShowDialog();
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
                    int categoryId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    Form_Edit_Category formEditCategory = new Form_Edit_Category(categoryId);
                    formEditCategory.CategoryUpdated += (s, ev) => LoadData();
                    formEditCategory.ShowDialog();
                }
                // Jika kolom delete yang diklik
                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
                {
                    int categoryId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (categories.DeleteCategory(categoryId))
                        {
                            MessageBox.Show("Category deleted successfully.");
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
