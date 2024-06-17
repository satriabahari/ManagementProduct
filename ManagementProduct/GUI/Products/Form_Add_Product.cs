﻿using ManagementProduct.Class;
using ManagementProduct.GUI.Supplier;
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
    public partial class Form_Add_Product : Form
    {
        private Barangs products;

        public Form_Add_Product()
        {
            InitializeComponent();
            products = new Barangs();
            LoadCategories();
        }

        private void LoadCategories()
        {
            List<string> categories = products.GetCategories();
            foreach (string category in categories)
            {
                inputCategory.Items.Add(category);
            }
        }

        private void buttonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            string name = inputName.Text;
            string category = inputCategory.Text;
            string description = inputDescription.Text;
            string stock = inputStock.Text;
            string price = inputPrice.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(price) )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            int categoryId = products.GetCategoryIdByName(category);
            if (categoryId == -1)
            {
                MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool success = products.CreateProduct(name, categoryId.ToString(), description, stock, price);

            if (success)
            {
                MessageBox.Show("Category data has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is List_Product crudForm)
                {
                    crudForm.LoadData();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Category data was not successfully added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox inputCategory;
        private Label label3;
        private Label label4;
        public Guna.UI2.WinForms.Guna2TextBox inputName;
        private Label label2;
        public Guna.UI2.WinForms.Guna2TextBox inputStock;
        public Guna.UI2.WinForms.Guna2TextBox inputDescription;
        private Label label6;
        public Guna.UI2.WinForms.Guna2TextBox inputPrice;
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            buttonSave = new Guna.UI2.WinForms.Guna2Button();
            inputStock = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            inputPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            inputCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            inputDescription = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            inputName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(95, 61, 204);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1124, 150);
            guna2Panel1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 54);
            label1.Name = "label1";
            label1.Size = new Size(120, 38);
            label1.TabIndex = 0;
            label1.Text = "Inbound";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(buttonCancel);
            guna2Panel2.Controls.Add(buttonSave);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.FillColor = Color.Gainsboro;
            guna2Panel2.Location = new Point(0, 411);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(1124, 150);
            guna2Panel2.TabIndex = 34;
            // 
            // buttonCancel
            // 
            buttonCancel.Animated = true;
            buttonCancel.AutoRoundedCorners = true;
            buttonCancel.BackColor = Color.Gainsboro;
            buttonCancel.BorderRadius = 33;
            buttonCancel.CustomizableEdges = customizableEdges3;
            buttonCancel.DisabledState.BorderColor = Color.DarkGray;
            buttonCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonCancel.FillColor = Color.Crimson;
            buttonCancel.Font = new Font("Segoe UI", 9F);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(223, 34);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buttonCancel.Size = new Size(154, 68);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonClose;
            // 
            // buttonSave
            // 
            buttonSave.Animated = true;
            buttonSave.AutoRoundedCorners = true;
            buttonSave.BackColor = Color.Gainsboro;
            buttonSave.BorderRadius = 33;
            buttonSave.CustomizableEdges = customizableEdges5;
            buttonSave.DisabledState.BorderColor = Color.DarkGray;
            buttonSave.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonSave.FillColor = Color.FromArgb(95, 61, 204);
            buttonSave.Font = new Font("Segoe UI", 9F);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(53, 34);
            buttonSave.Name = "buttonSave";
            buttonSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            buttonSave.Size = new Size(154, 68);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.Click += buttonAdd;
            // 
            // inputStock
            // 
            inputStock.AutoRoundedCorners = true;
            inputStock.BorderRadius = 28;
            inputStock.CustomizableEdges = customizableEdges9;
            inputStock.DefaultText = "";
            inputStock.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputStock.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputStock.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputStock.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputStock.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputStock.Font = new Font("Segoe UI", 9F);
            inputStock.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputStock.Location = new Point(775, 332);
            inputStock.Margin = new Padding(4, 5, 4, 5);
            inputStock.Name = "inputStock";
            inputStock.PasswordChar = '\0';
            inputStock.PlaceholderText = "";
            inputStock.SelectedText = "";
            inputStock.ShadowDecoration.CustomizableEdges = customizableEdges10;
            inputStock.Size = new Size(324, 59);
            inputStock.TabIndex = 44;
            inputStock.TextOffset = new Point(10, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(789, 299);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 45;
            label6.Text = "Stock";
            // 
            // inputPrice
            // 
            inputPrice.AutoRoundedCorners = true;
            inputPrice.BorderRadius = 28;
            inputPrice.CustomizableEdges = customizableEdges11;
            inputPrice.DefaultText = "";
            inputPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputPrice.Font = new Font("Segoe UI", 9F);
            inputPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputPrice.Location = new Point(416, 332);
            inputPrice.Margin = new Padding(4, 5, 4, 5);
            inputPrice.Name = "inputPrice";
            inputPrice.PasswordChar = '\0';
            inputPrice.PlaceholderText = "";
            inputPrice.SelectedText = "";
            inputPrice.ShadowDecoration.CustomizableEdges = customizableEdges12;
            inputPrice.Size = new Size(324, 59);
            inputPrice.TabIndex = 37;
            inputPrice.TextOffset = new Point(10, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 299);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 43;
            label5.Text = "Price";
            // 
            // inputCategory
            // 
            inputCategory.AutoRoundedCorners = true;
            inputCategory.BackColor = Color.Transparent;
            inputCategory.BorderRadius = 29;
            inputCategory.CustomizableEdges = customizableEdges13;
            inputCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputCategory.DrawMode = DrawMode.OwnerDrawFixed;
            inputCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            inputCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            inputCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputCategory.Font = new Font("Segoe UI", 9F);
            inputCategory.ForeColor = Color.FromArgb(68, 88, 112);
            inputCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputCategory.ItemHeight = 55;
            inputCategory.Location = new Point(416, 203);
            inputCategory.Margin = new Padding(4, 5, 4, 5);
            inputCategory.Name = "inputCategory";
            inputCategory.ShadowDecoration.CustomizableEdges = customizableEdges14;
            inputCategory.Size = new Size(324, 61);
            inputCategory.TabIndex = 38;
            inputCategory.TextOffset = new Point(10, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 170);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 41;
            label3.Text = "Category";
            // 
            // inputDescription
            // 
            inputDescription.AutoRoundedCorners = true;
            inputDescription.BorderRadius = 28;
            inputDescription.CustomizableEdges = customizableEdges13;
            inputDescription.DefaultText = "";
            inputDescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputDescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputDescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputDescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputDescription.Font = new Font("Segoe UI", 9F);
            inputDescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputDescription.Location = new Point(53, 332);
            inputDescription.Margin = new Padding(4, 5, 4, 5);
            inputDescription.Name = "inputDescription";
            inputDescription.PasswordChar = '\0';
            inputDescription.PlaceholderText = "";
            inputDescription.SelectedText = "";
            inputDescription.ShadowDecoration.CustomizableEdges = customizableEdges14;
            inputDescription.Size = new Size(324, 59);
            inputDescription.TabIndex = 36;
            inputDescription.TextOffset = new Point(10, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 299);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 42;
            label4.Text = "Description";
            // 
            // inputName
            // 
            inputName.AutoRoundedCorners = true;
            inputName.BorderRadius = 28;
            inputName.CustomizableEdges = customizableEdges15;
            inputName.DefaultText = "";
            inputName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputName.Font = new Font("Segoe UI", 9F);
            inputName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputName.Location = new Point(53, 203);
            inputName.Margin = new Padding(4, 5, 4, 5);
            inputName.Name = "inputName";
            inputName.PasswordChar = '\0';
            inputName.PlaceholderText = "";
            inputName.SelectedText = "";
            inputName.ShadowDecoration.CustomizableEdges = customizableEdges16;
            inputName.Size = new Size(324, 59);
            inputName.TabIndex = 35;
            inputName.TextOffset = new Point(10, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 170);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 40;
            label2.Text = "Name";
            // 
            // Form_Add_Product
            // 
            ClientSize = new Size(1124, 561);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel2);
            Controls.Add(inputStock);
            Controls.Add(label6);
            Controls.Add(inputPrice);
            Controls.Add(label5);
            Controls.Add(inputCategory);
            Controls.Add(label3);
            Controls.Add(inputDescription);
            Controls.Add(label4);
            Controls.Add(inputName);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Add_Product";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
