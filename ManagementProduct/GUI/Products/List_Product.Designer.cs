//namespace ManagementProduct.GUI.Products
//{
//    partial class List_Product
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
//            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
//            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
//            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
//            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
//            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
//            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
//            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
//            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
//            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
//            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
//            btnAdd = new Guna.UI2.WinForms.Guna2Button();
//            label2 = new Label();
//            label1 = new Label();
//            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
//            dgvNo = new DataGridViewTextBoxColumn();
//            dgvid = new DataGridViewTextBoxColumn();
//            dgvName = new DataGridViewTextBoxColumn();
//            dgvCategory = new DataGridViewTextBoxColumn();
//            dgvDescription = new DataGridViewTextBoxColumn();
//            dgvStock = new DataGridViewTextBoxColumn();
//            dgvPrice = new DataGridViewTextBoxColumn();
//            dgvEdit = new DataGridViewImageColumn();
//            dgvDel = new DataGridViewImageColumn();
//            guna2Panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
//            SuspendLayout();
//            // 
//            // guna2Panel1
//            // 
//            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
//            guna2Panel1.Controls.Add(txtSearch);
//            guna2Panel1.Controls.Add(btnAdd);
//            guna2Panel1.Controls.Add(label2);
//            guna2Panel1.Controls.Add(label1);
//            guna2Panel1.CustomizableEdges = customizableEdges5;
//            guna2Panel1.Location = new Point(0, 1);
//            guna2Panel1.Name = "guna2Panel1";
//            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
//            guna2Panel1.Size = new Size(923, 150);
//            guna2Panel1.TabIndex = 2;
//            // 
//            // txtSearch
//            // 
//            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            txtSearch.AutoRoundedCorners = true;
//            txtSearch.BorderRadius = 33;
//            txtSearch.CustomizableEdges = customizableEdges1;
//            txtSearch.DefaultText = "";
//            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
//            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
//            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
//            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
//            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
//            txtSearch.Font = new Font("Segoe UI", 9F);
//            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
//            txtSearch.IconLeft = Properties.Resources.search;
//            txtSearch.IconLeftOffset = new Point(20, 0);
//            txtSearch.IconLeftSize = new Size(30, 30);
//            txtSearch.Location = new Point(1293, 79);
//            txtSearch.Margin = new Padding(4, 5, 4, 5);
//            txtSearch.Name = "txtSearch";
//            txtSearch.PasswordChar = '\0';
//            txtSearch.PlaceholderText = "Search Here";
//            txtSearch.SelectedText = "";
//            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
//            txtSearch.Size = new Size(395, 68);
//            txtSearch.TabIndex = 3;
//            txtSearch.TextOffset = new Point(5, 0);
//            // 
//            // btnAdd
//            // 
//            btnAdd.Animated = true;
//            btnAdd.AutoRoundedCorners = true;
//            btnAdd.BorderRadius = 33;
//            btnAdd.CustomizableEdges = customizableEdges3;
//            btnAdd.DisabledState.BorderColor = Color.DarkGray;
//            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
//            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
//            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
//            btnAdd.FillColor = Color.FromArgb(95, 61, 204);
//            btnAdd.Font = new Font("Segoe UI", 9F);
//            btnAdd.ForeColor = Color.White;
//            btnAdd.Image = Properties.Resources.add;
//            btnAdd.ImageSize = new Size(30, 30);
//            btnAdd.Location = new Point(57, 79);
//            btnAdd.Name = "btnAdd";
//            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
//            btnAdd.Size = new Size(206, 68);
//            btnAdd.TabIndex = 2;
//            btnAdd.Text = "Add New";
//            btnAdd.Click += buttonAdd;
//            // 
//            // label2
//            // 
//            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            label2.AutoSize = true;
//            label2.Location = new Point(1293, 29);
//            label2.Name = "label2";
//            label2.Size = new Size(64, 25);
//            label2.TabIndex = 1;
//            label2.Text = "Search";
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label1.Location = new Point(57, 21);
//            label1.Name = "label1";
//            label1.Size = new Size(206, 38);
//            label1.TabIndex = 0;
//            label1.Text = "Sample Header";
//            // 
//            // guna2DataGridView1
//            // 
//            guna2DataGridView1.AllowUserToAddRows = false;
//            guna2DataGridView1.AllowUserToDeleteRows = false;
//            dataGridViewCellStyle1.BackColor = Color.White;
//            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
//            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
//            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
//            guna2DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
//            guna2DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
//            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle2.BackColor = Color.FromArgb(95, 61, 204);
//            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            dataGridViewCellStyle2.ForeColor = Color.White;
//            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
//            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
//            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
//            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
//            guna2DataGridView1.ColumnHeadersHeight = 50;
//            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
//            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvNo, dgvid, dgvName, dgvCategory, dgvDescription, dgvStock, dgvPrice, dgvEdit, dgvDel });
//            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle3.BackColor = Color.White;
//            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
//            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
//            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
//            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
//            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
//            guna2DataGridView1.GridColor = Color.Black;
//            guna2DataGridView1.Location = new Point(57, 193);
//            guna2DataGridView1.Name = "guna2DataGridView1";
//            guna2DataGridView1.ReadOnly = true;
//            guna2DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
//            guna2DataGridView1.RowHeadersVisible = false;
//            guna2DataGridView1.RowHeadersWidth = 62;
//            guna2DataGridView1.RowTemplate.Height = 50;
//            guna2DataGridView1.Size = new Size(750, 366);
//            guna2DataGridView1.TabIndex = 3;
//            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
//            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
//            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
//            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
//            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
//            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
//            guna2DataGridView1.ThemeStyle.GridColor = Color.Black;
//            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
//            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
//            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
//            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
//            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50;
//            guna2DataGridView1.ThemeStyle.ReadOnly = true;
//            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
//            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleVertical;
//            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
//            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 50;
//            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
//            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
//            // 
//            // dgvNo
//            // 
//            dgvNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
//            dgvNo.FillWeight = 70F;
//            dgvNo.HeaderText = "No";
//            dgvNo.MinimumWidth = 70;
//            dgvNo.Name = "dgvNo";
//            dgvNo.ReadOnly = true;
//            dgvNo.Width = 70;
//            // 
//            // dgvid
//            // 
//            dgvid.HeaderText = "id";
//            dgvid.MinimumWidth = 8;
//            dgvid.Name = "dgvid";
//            dgvid.ReadOnly = true;
//            dgvid.Visible = false;
//            // 
//            // dgvName
//            // 
//            dgvName.HeaderText = "Name";
//            dgvName.MinimumWidth = 8;
//            dgvName.Name = "dgvName";
//            dgvName.ReadOnly = true;
//            // 
//            // dgvCategory
//            // 
//            dgvCategory.HeaderText = "Category";
//            dgvCategory.MinimumWidth = 8;
//            dgvCategory.Name = "dgvCategory";
//            dgvCategory.ReadOnly = true;
//            // 
//            // dgvDescription
//            // 
//            dgvDescription.HeaderText = "Description";
//            dgvDescription.MinimumWidth = 8;
//            dgvDescription.Name = "dgvDescription";
//            dgvDescription.ReadOnly = true;
//            // 
//            // dgvStock
//            // 
//            dgvStock.HeaderText = "Stock";
//            dgvStock.MinimumWidth = 8;
//            dgvStock.Name = "dgvStock";
//            dgvStock.ReadOnly = true;
//            // 
//            // dgvPrice
//            // 
//            dgvPrice.HeaderText = "Price";
//            dgvPrice.MinimumWidth = 8;
//            dgvPrice.Name = "dgvPrice";
//            dgvPrice.ReadOnly = true;
//            // 
//            // dgvEdit
//            // 
//            dgvEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
//            dgvEdit.FillWeight = 50F;
//            dgvEdit.HeaderText = "";
//            dgvEdit.Image = Properties.Resources.edit;
//            dgvEdit.MinimumWidth = 50;
//            dgvEdit.Name = "dgvEdit";
//            dgvEdit.ReadOnly = true;
//            dgvEdit.Width = 50;
//            // 
//            // dgvDel
//            // 
//            dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
//            dgvDel.FillWeight = 50F;
//            dgvDel.HeaderText = "";
//            dgvDel.Image = Properties.Resources.delete;
//            dgvDel.MinimumWidth = 50;
//            dgvDel.Name = "dgvDel";
//            dgvDel.ReadOnly = true;
//            dgvDel.Width = 50;
//            // 
//            // List_Product
//            // 
//            AutoScaleDimensions = new SizeF(10F, 25F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(924, 728);
//            Controls.Add(guna2Panel1);
//            Controls.Add(guna2DataGridView1);
//            FormBorderStyle = FormBorderStyle.None;
//            Name = "List_Product";
//            Text = "List_Product";
//            guna2Panel1.ResumeLayout(false);
//            guna2Panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
//            ResumeLayout(false);
//        }

//        #endregion

//        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
//        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
//        public Guna.UI2.WinForms.Guna2Button btnAdd;
//        public Label label2;
//        public Label label1;
//        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
//        private DataGridViewTextBoxColumn dgvNo;
//        private DataGridViewTextBoxColumn dgvid;
//        private DataGridViewTextBoxColumn dgvName;
//        private DataGridViewTextBoxColumn dgvCategory;
//        private DataGridViewTextBoxColumn dgvDescription;
//        private DataGridViewTextBoxColumn dgvStock;
//        private DataGridViewTextBoxColumn dgvPrice;
//        private DataGridViewImageColumn dgvEdit;
//        private DataGridViewImageColumn dgvDel;
//    }
//}