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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
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
            Form_crudUsers crudCategoryForm = new Form_crudUsers();

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
    }
}
