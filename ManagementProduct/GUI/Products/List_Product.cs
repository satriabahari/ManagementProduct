//using ManagementProduct.Class;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ManagementProduct.GUI.Products
//{
//    public partial class List_Product : Form
//    {
//        private Products products;

//        public List_Product(bool isDarkModeEnabled)
//        {
//            InitializeComponent();
//            LoadData();
//            products = new Products();
//            buttonDarkMode(isDarkModeEnabled);
//        }

//        public void LoadData()
//        {
//            Products products = new Products(); // Inisialisasi objek Users
//            DataTable dataTable = products.GetProducts(); // Ambil data pengguna dari database

//            guna2DataGridView1.Rows.Clear();
//            int i = 1;
//            foreach (DataRow row in dataTable.Rows)
//            {
//                guna2DataGridView1.Rows.Add(i++, row["id"], row["name"], row["category"], row["description"], row["stock"], row["price"]);
//            }
//        }

//        private void buttonAdd(object sender, EventArgs e)
//        {
//            Form_Add_Product formAddProducts = new Form_Add_Product
//            {
//                Owner = this
//            };
//            formAddProducts.ShowDialog();
//        }

//        public void buttonDarkMode(bool isDarkMode)
//        {
//            if (isDarkMode)
//            {
//                // Terapkan warna-warna untuk mode gelap
//                this.BackColor = Color.FromArgb(45, 45, 48); // Warna latar belakang gelap
//                this.ForeColor = Color.White; // Warna teks putih
//            }
//            else
//            {
//                // Terapkan warna-warna untuk mode normal
//                this.BackColor = SystemColors.Control; // Warna latar belakang default
//                this.ForeColor = SystemColors.ControlText; // Warna teks default
//            }
//        }

//        private void buttonActions(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {
//                // Jika kolom edit yang diklik
//                if (e.ColumnIndex == guna2DataGridView1.Columns["dgvEdit"].Index)
//                {
//                    int productId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
//                    Form_Edit_Product formEditProducts = new Form_Edit_Product(productId);
//                    formEditProducts.ProductUpdated += (s, ev) => LoadData();
//                    formEditProducts.ShowDialog();
//                }
//                // Jika kolom delete yang diklik
//                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
//                {
//                    int productId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
//                    if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
//                    {
//                        if (products.DeleteProduct(productId))
//                        {
//                            MessageBox.Show("User deleted successfully.");
//                            LoadData();
//                        }
//                        else
//                        {
//                            MessageBox.Show("An error occurred while deleting the user.");
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
