using Guna.UI2.WinForms.Suite;
using Guna.UI2.WinForms;

namespace ManagementProduct.GUI
{
    partial class Form_Register
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
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            CustomizableEdges customizableEdges7 = new CustomizableEdges();
            CustomizableEdges customizableEdges8 = new CustomizableEdges();
            CustomizableEdges customizableEdges9 = new CustomizableEdges();
            CustomizableEdges customizableEdges10 = new CustomizableEdges();
            CustomizableEdges customizableEdges11 = new CustomizableEdges();
            CustomizableEdges customizableEdges12 = new CustomizableEdges();
            CustomizableEdges customizableEdges13 = new CustomizableEdges();
            CustomizableEdges customizableEdges14 = new CustomizableEdges();
            CustomizableEdges customizableEdges15 = new CustomizableEdges();
            CustomizableEdges customizableEdges16 = new CustomizableEdges();
            CustomizableEdges customizableEdges17 = new CustomizableEdges();
            guna2PictureBox1 = new Guna2PictureBox();
            label1 = new Label();
            txtUsername = new Guna2TextBox();
            btnRegister = new Guna2Button();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new Guna2TextBox();
            guna2vSeparator1 = new Guna2VSeparator();
            label5 = new Label();
            txtEmail = new Guna2TextBox();
            btnBrowse = new Guna2Button();
            txtPic = new Guna2CirclePictureBox();
            btnClose = new Guna2Button();
            label4 = new Label();
            txtPhone = new Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPic).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.pos;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(21, 107);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(320, 528);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(619, 30);
            label1.Name = "label1";
            label1.Size = new Size(192, 45);
            label1.TabIndex = 5;
            label1.Text = "Create User";
            // 
            // txtUsername
            // 
            txtUsername.AutoRoundedCorners = true;
            txtUsername.BorderRadius = 21;
            txtUsername.CustomizableEdges = customizableEdges3;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9.75F);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(407, 370);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsername.Size = new Size(300, 45);
            txtUsername.TabIndex = 0;
            txtUsername.TextOffset = new Point(15, 0);
            // 
            // btnRegister
            // 
            btnRegister.Animated = true;
            btnRegister.AutoRoundedCorners = true;
            btnRegister.BorderRadius = 26;
            btnRegister.CustomizableEdges = customizableEdges5;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.FromArgb(34, 211, 238);
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(416, 559);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnRegister.Size = new Size(174, 55);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(407, 335);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(407, 435);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.AutoRoundedCorners = true;
            txtPassword.BorderRadius = 21;
            txtPassword.CustomizableEdges = customizableEdges7;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9.75F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(407, 470);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.Size = new Size(300, 45);
            txtPassword.TabIndex = 1;
            txtPassword.TextOffset = new Point(15, 0);
            txtPassword.UseSystemPasswordChar = true;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(360, 90);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(10, 550);
            guna2vSeparator1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(743, 335);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.AutoRoundedCorners = true;
            txtEmail.BorderRadius = 21;
            txtEmail.CustomizableEdges = customizableEdges9;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(743, 370);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Enter your username";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtEmail.Size = new Size(300, 45);
            txtEmail.TabIndex = 8;
            txtEmail.TextOffset = new Point(15, 0);
            // 
            // btnBrowse
            // 
            btnBrowse.AutoRoundedCorners = true;
            btnBrowse.BorderRadius = 33;
            btnBrowse.CustomizableEdges = customizableEdges11;
            btnBrowse.DisabledState.BorderColor = Color.DarkGray;
            btnBrowse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBrowse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBrowse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBrowse.FillColor = Color.FromArgb(34, 211, 238);
            btnBrowse.Font = new Font("Segoe UI", 9F);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(647, 243);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnBrowse.Size = new Size(133, 68);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Browse";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtPic
            // 
            txtPic.Image = Properties.Resources.users;
            txtPic.ImageRotate = 0F;
            txtPic.Location = new Point(644, 90);
            txtPic.Name = "txtPic";
            txtPic.ShadowDecoration.CustomizableEdges = customizableEdges13;
            txtPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtPic.Size = new Size(136, 132);
            txtPic.SizeMode = PictureBoxSizeMode.Zoom;
            txtPic.TabIndex = 13;
            txtPic.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Animated = true;
            btnClose.AutoRoundedCorners = true;
            btnClose.BorderRadius = 26;
            btnClose.CustomizableEdges = customizableEdges14;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Crimson;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(619, 559);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges15;
            btnClose.Size = new Size(174, 55);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(743, 435);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 16;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.AutoRoundedCorners = true;
            txtPhone.BorderRadius = 21;
            txtPhone.CustomizableEdges = customizableEdges16;
            txtPhone.DefaultText = "";
            txtPhone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPhone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPhone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPhone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhone.Font = new Font("Segoe UI", 9.75F);
            txtPhone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhone.Location = new Point(743, 470);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '\0';
            txtPhone.PlaceholderText = "Enter your username";
            txtPhone.SelectedText = "";
            txtPhone.ShadowDecoration.CustomizableEdges = customizableEdges17;
            txtPhone.Size = new Size(300, 45);
            txtPhone.TabIndex = 15;
            txtPhone.TextOffset = new Point(15, 0);
            // 
            // Form_Register
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(239, 243, 248);
            ClientSize = new Size(1075, 734);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(btnClose);
            Controls.Add(btnBrowse);
            Controls.Add(txtPic);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(guna2vSeparator1);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(guna2PictureBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(71, 69, 94);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Register";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Label label5;
        private Guna2TextBox txtEmail;
        private Guna2Button btnBrowse;
        private Guna2CirclePictureBox txtPic;
        private Guna2Button btnClose;
        private Label label4;
        private Guna2TextBox txtPhone;
    }
}