namespace ManagementProduct.GUI.Category
{
    partial class Form_Edit_Category
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            buttonSave = new Guna.UI2.WinForms.Guna2Button();
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
            guna2Panel1.FillColor = Color.FromArgb(34, 211, 238);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1152, 150);
            guna2Panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 54);
            label1.Name = "label1";
            label1.Size = new Size(225, 38);
            label1.TabIndex = 0;
            label1.Text = "Category Update";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(buttonCancel);
            guna2Panel2.Controls.Add(buttonSave);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.FillColor = Color.Gainsboro;
            guna2Panel2.Location = new Point(0, 506);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(1152, 150);
            guna2Panel2.TabIndex = 11;
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
            buttonSave.Click += buttonUpdate;
            // 
            // inputName
            // 
            inputName.AutoRoundedCorners = true;
            inputName.BorderRadius = 28;
            inputName.CustomizableEdges = customizableEdges9;
            inputName.DefaultText = "";
            inputName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputName.Font = new Font("Segoe UI", 9F);
            inputName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputName.Location = new Point(52, 215);
            inputName.Margin = new Padding(4, 5, 4, 5);
            inputName.Name = "inputName";
            inputName.PasswordChar = '\0';
            inputName.PlaceholderText = "";
            inputName.SelectedText = "";
            inputName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            inputName.Size = new Size(324, 59);
            inputName.TabIndex = 12;
            inputName.TextOffset = new Point(10, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 182);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // Form_Edit_Category
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 656);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel2);
            Controls.Add(inputName);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Edit_Category";
            Text = "Form_Edit_Category";
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
        public Guna.UI2.WinForms.Guna2TextBox inputName;
        private Label label2;
    }
}