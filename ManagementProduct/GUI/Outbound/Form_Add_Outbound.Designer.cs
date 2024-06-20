using Guna.UI2.WinForms;

namespace ManagementProduct.GUI.Outbound
{
    partial class Form_Add_Outbound
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            guna2Panel1 = new Guna2Panel();
            label1 = new Label();
            guna2Panel2 = new Guna2Panel();
            buttonCancel = new Guna2Button();
            buttonSave = new Guna2Button();
            inputDate = new Guna2TextBox();
            label5 = new Label();
            inputCustomer = new Guna2ComboBox();
            label3 = new Label();
            inputQuantity = new Guna2TextBox();
            label4 = new Label();
            inputProduct = new Guna2ComboBox();
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
            guna2Panel1.FillColor = Color.FromArgb(34, 211, 238);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(943, 150);
            guna2Panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 54);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 0;
            label1.Text = "Outbound ";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(buttonCancel);
            guna2Panel2.Controls.Add(buttonSave);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.FillColor = Color.Gainsboro;
            guna2Panel2.Location = new Point(0, 461);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(943, 150);
            guna2Panel2.TabIndex = 22;
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
            buttonSave.FillColor = Color.FromArgb(34, 211, 238);
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
            // inputDate
            // 
            inputDate.AutoRoundedCorners = true;
            inputDate.BorderRadius = 28;
            inputDate.CustomizableEdges = customizableEdges9;
            inputDate.DefaultText = "";
            inputDate.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputDate.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputDate.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputDate.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputDate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputDate.Font = new Font("Segoe UI", 9F);
            inputDate.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputDate.Location = new Point(416, 332);
            inputDate.Margin = new Padding(4, 5, 4, 5);
            inputDate.Name = "inputDate";
            inputDate.PasswordChar = '\0';
            inputDate.PlaceholderText = "";
            inputDate.SelectedText = "";
            inputDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            inputDate.Size = new Size(324, 59);
            inputDate.TabIndex = 26;
            inputDate.TextOffset = new Point(10, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 299);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 31;
            label5.Text = "Date";
            // 
            // inputCustomer
            // 
            inputCustomer.AutoRoundedCorners = true;
            inputCustomer.BackColor = Color.Transparent;
            inputCustomer.BorderRadius = 29;
            inputCustomer.CustomizableEdges = customizableEdges11;
            inputCustomer.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputCustomer.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputCustomer.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputCustomer.DrawMode = DrawMode.OwnerDrawFixed;
            inputCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            inputCustomer.FocusedColor = Color.FromArgb(94, 148, 255);
            inputCustomer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputCustomer.Font = new Font("Segoe UI", 9F);
            inputCustomer.ForeColor = Color.FromArgb(68, 88, 112);
            inputCustomer.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputCustomer.ItemHeight = 55;
            inputCustomer.Location = new Point(416, 203);
            inputCustomer.Margin = new Padding(4, 5, 4, 5);
            inputCustomer.Name = "inputCustomer";
            inputCustomer.ShadowDecoration.CustomizableEdges = customizableEdges12;
            inputCustomer.Size = new Size(324, 61);
            inputCustomer.TabIndex = 16;
            inputCustomer.TextOffset = new Point(10, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 170);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 29;
            label3.Text = "Customer";
            // 
            // inputQuantity
            // 
            inputQuantity.AutoRoundedCorners = true;
            inputQuantity.BorderRadius = 28;
            inputQuantity.CustomizableEdges = customizableEdges11;
            inputQuantity.DefaultText = "";
            inputQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputQuantity.Font = new Font("Segoe UI", 9F);
            inputQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputQuantity.Location = new Point(53, 332);
            inputQuantity.Margin = new Padding(4, 5, 4, 5);
            inputQuantity.Name = "inputQuantity";
            inputQuantity.PasswordChar = '\0';
            inputQuantity.PlaceholderText = "";
            inputQuantity.SelectedText = "";
            inputQuantity.ShadowDecoration.CustomizableEdges = customizableEdges12;
            inputQuantity.Size = new Size(324, 59);
            inputQuantity.TabIndex = 25;
            inputQuantity.TextOffset = new Point(10, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 299);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 30;
            label4.Text = "Quantity";
            // 
            // inputProduct
            // 
            inputProduct.AutoRoundedCorners = true;
            inputProduct.BackColor = Color.Transparent;
            inputProduct.BorderRadius = 29;
            inputProduct.CustomizableEdges = customizableEdges11;
            inputProduct.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputProduct.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputProduct.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputProduct.DrawMode = DrawMode.OwnerDrawFixed;
            inputProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            inputProduct.FocusedColor = Color.FromArgb(94, 148, 255);
            inputProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputProduct.Font = new Font("Segoe UI", 9F);
            inputProduct.ForeColor = Color.FromArgb(68, 88, 112);
            inputProduct.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputProduct.ItemHeight = 55;
            inputProduct.Location = new Point(53, 213);
            inputProduct.Margin = new Padding(4, 5, 4, 5);
            inputProduct.Name = "inputProduct";
            inputProduct.ShadowDecoration.CustomizableEdges = customizableEdges12;
            inputProduct.Size = new Size(324, 61);
            inputProduct.TabIndex = 16;
            inputProduct.TextOffset = new Point(10, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 170);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 28;
            label2.Text = "Product";
            // 
            // Form_Add_Outbound
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 611);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel2);
            Controls.Add(inputDate);
            Controls.Add(label5);
            Controls.Add(inputCustomer);
            Controls.Add(label3);
            Controls.Add(inputQuantity);
            Controls.Add(label4);
            Controls.Add(inputProduct);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Add_Outbound";
            Text = "Form_Add_Outbound";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2TextBox inputDate;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox inputCustomer;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox inputQuantity;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox inputProduct;
        private Label label2;
    }
}