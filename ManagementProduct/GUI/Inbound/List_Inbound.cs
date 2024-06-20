using Guna.UI2.WinForms;
using ManagementProduct.Class;
using ManagementProduct.GUI.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementProduct.GUI.Inbound
{
    public partial class List_Inbound : Form
    {
        private Inbounds inbounds;

        public List_Inbound(bool isDarkModeEnabled)
        {
            InitializeComponent();
            inbounds = new Inbounds(); 
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = inbounds.GetInbounds(); 

            guna2DataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                guna2DataGridView1.Rows.Add(i++, row["id"], row["product_name"], row["supplier_name"], row["quantity"], row["date"]);
            }

        }

        private void buttonAdd(object sender, EventArgs e)
        {
            Form_Add_Inbound formAddInbound = new Form_Add_Inbound
            {
                Owner = this
            };
            formAddInbound.ShowDialog();
        }

        private void buttonActions(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Jika kolom edit yang diklik
                if (e.ColumnIndex == guna2DataGridView1.Columns["dgvEdit"].Index)
                {
                    int inboundId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    Form_Edit_Inbound formEditInbound = new Form_Edit_Inbound(inboundId);
                    formEditInbound.InboundUpdated += (s, ev) => LoadData();
                    formEditInbound.ShowDialog();
                }
                // Jika kolom delete yang diklik
                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
                {
                    int inboundId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (inbounds.DeleteInbound(inboundId))
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
