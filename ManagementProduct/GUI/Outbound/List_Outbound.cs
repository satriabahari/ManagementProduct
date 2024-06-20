using Guna.UI2.WinForms;
using ManagementProduct.Class;
using ManagementProduct.GUI.Inbound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementProduct.GUI.Outbound
{
    public partial class List_Outbound : Form
    {
        private Outbounds outbounds;

        public List_Outbound(bool isDarkModeEnabled)
        {
            InitializeComponent();
            LoadData();
            outbounds = new Outbounds();
            buttonDarkMode(isDarkModeEnabled);
        }

        internal void LoadData()
        {
            Outbounds outbounds = new Outbounds(); // Inisialisasi objek Users
            DataTable dataTable = outbounds.GetOutbounds(); // Ambil data pengguna dari database

            guna2DataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                guna2DataGridView1.Rows.Add(i++, row["id"], row["product_name"], row["customer_name"], row["quantity"], row["date"]);
            }
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            Form_Add_Outbound formAddOutbound = new Form_Add_Outbound
            {
                Owner = this
            };
            formAddOutbound.ShowDialog();
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
                    int outboundId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    Form_Edit_Outbound formEditOutbound = new Form_Edit_Outbound(outboundId);
                    formEditOutbound.OutboundUpdated += (s, ev) => LoadData();
                    formEditOutbound.ShowDialog();
                }
                // Jika kolom delete yang diklik
                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
                {
                    int outboundId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (outbounds.DeleteOutbound(outboundId))
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
