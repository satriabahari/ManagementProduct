using Guna.UI2.WinForms;
using ManagementProduct.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementProduct.GUI.Products
{
    public partial class List_Product : Form
    {
        private Barangs products;

        public List_Product(bool isDarkModeEnabled)
        {
            InitializeComponent();
            LoadData();
            products = new Barangs();
            buttonDarkMode(isDarkModeEnabled);
        }

        public void LoadData()
        {
            Barangs products = new Barangs(); // Inisialisasi objek Products
            DataTable dataTable = products.GetProducts(); // Ambil data produk dari database

            guna2DataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                guna2DataGridView1.Rows.Add(i++, row["id"], row["name"], row["category_name"], row["description"], row["stock"], row["price"]);
            }
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            Form_Add_Product formAddProducts = new Form_Add_Product
            {
                Owner = this
            };
            formAddProducts.ShowDialog();
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
                    int productId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    Form_Edit_Product formEditProducts = new Form_Edit_Product(productId);
                    formEditProducts.ProductUpdated += (s, ev) => LoadData();
                    formEditProducts.ShowDialog();
                }
                // Jika kolom delete yang diklik
                else if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index)
                {
                    int productId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (products.DeleteProduct(productId))
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

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna2Panel();
            txtSearch = new Guna2TextBox();
            btnAdd = new Guna2Button();
            label2 = new Label();
            label1 = new Label();
            guna2DataGridView1 = new Guna2DataGridView();
            dgvNo = new DataGridViewTextBoxColumn();
            dgvid = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvCategory = new DataGridViewTextBoxColumn();
            dgvDescription = new DataGridViewTextBoxColumn();
            dgvStock = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            guna2Panel1.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.Controls.Add(txtSearch);
            guna2Panel1.Controls.Add(btnAdd);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(10, 61);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(1024, 150);
            guna2Panel1.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 33;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = Properties.Resources.search;
            txtSearch.IconLeftOffset = new Point(20, 0);
            txtSearch.IconLeftSize = new Size(30, 30);
            txtSearch.Location = new Point(2941, 79);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(395, 68);
            txtSearch.TabIndex = 3;
            txtSearch.TextOffset = new Point(5, 0);
            // 
            // btnAdd
            // 
            btnAdd.Animated = true;
            btnAdd.AutoRoundedCorners = true;
            btnAdd.BorderRadius = 33;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(34, 211, 238);
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.ImageSize = new Size(30, 30);
            btnAdd.Location = new Point(57, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(206, 68);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add New";
            btnAdd.Click += buttonAdd;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(2941, 29);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 21);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 0;
            label1.Text = "Sample Header";
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            guna2DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            guna2DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 211, 238);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 50;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvNo, dgvid, dgvName, dgvCategory, dgvDescription, dgvStock, dgvPrice, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.Black;
            guna2DataGridView1.Location = new Point(67, 241);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 62;
            guna2DataGridView1.RowTemplate.Height = 50;
            guna2DataGridView1.Size = new Size(919, 423);
            guna2DataGridView1.TabIndex = 7;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.Black;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 50;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellClick += buttonActions;
            // 
            // dgvNo
            // 
            dgvNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNo.FillWeight = 70F;
            dgvNo.HeaderText = "No";
            dgvNo.MinimumWidth = 70;
            dgvNo.Name = "dgvNo";
            dgvNo.ReadOnly = true;
            dgvNo.Width = 70;
            // 
            // dgvid
            // 
            dgvid.HeaderText = "id";
            dgvid.MinimumWidth = 8;
            dgvid.Name = "dgvid";
            dgvid.ReadOnly = true;
            dgvid.Visible = false;
            // 
            // dgvName
            // 
            dgvName.HeaderText = "Name";
            dgvName.MinimumWidth = 8;
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            // 
            // dgvCategory
            // 
            dgvCategory.HeaderText = "Category";
            dgvCategory.MinimumWidth = 8;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            // 
            // dgvDescription
            // 
            dgvDescription.HeaderText = "Description";
            dgvDescription.MinimumWidth = 8;
            dgvDescription.Name = "dgvDescription";
            dgvDescription.ReadOnly = true;
            // 
            // dgvStock
            // 
            dgvStock.HeaderText = "Stock";
            dgvStock.MinimumWidth = 8;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            // 
            // dgvPrice
            // 
            dgvPrice.HeaderText = "Price";
            dgvPrice.MinimumWidth = 8;
            dgvPrice.Name = "dgvPrice";
            dgvPrice.ReadOnly = true;
            // 
            // dgvEdit
            // 
            dgvEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEdit.FillWeight = 50F;
            dgvEdit.HeaderText = "";
            dgvEdit.Image = Properties.Resources.edit;
            dgvEdit.MinimumWidth = 50;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.ReadOnly = true;
            dgvEdit.Width = 50;
            // 
            // dgvDel
            // 
            dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDel.FillWeight = 50F;
            dgvDel.HeaderText = "";
            dgvDel.Image = Properties.Resources.delete;
            dgvDel.MinimumWidth = 50;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.Width = 50;
            // 
            // List_Product
            // 
            ClientSize = new Size(1044, 724);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2DataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "List_Product";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        public Guna2Panel guna2Panel1;
        public Guna2TextBox txtSearch;
        public Guna2Button btnAdd;
        public Label label2;
        public Label label1;
        public Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn dgvNo;
        private DataGridViewTextBoxColumn dgvid;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvCategory;
        private DataGridViewTextBoxColumn dgvDescription;
        private DataGridViewTextBoxColumn dgvStock;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}
