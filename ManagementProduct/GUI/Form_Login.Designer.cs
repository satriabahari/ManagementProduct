using Guna.UI2.WinForms.Suite;
using Guna.UI2.WinForms;

namespace ManagementProduct.GUI
{
    partial class Form_Login
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
            guna2PictureBox1 = new Guna2PictureBox();
            label1 = new Label();
            txtUser = new Guna2TextBox();
            btnLogin = new Guna2Button();
            label2 = new Label();
            label3 = new Label();
            txtPass = new Guna2TextBox();
            guna2CirclePictureBox1 = new Guna2CirclePictureBox();
            guna2vSeparator1 = new Guna2VSeparator();
            linkRegister = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.pos;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(20, 50);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(320, 350);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 83);
            label1.Name = "label1";
            label1.Size = new Size(238, 45);
            label1.TabIndex = 5;
            label1.Text = "Welcome Back";
            // 
            // txtUser
            // 
            txtUser.AutoRoundedCorners = true;
            txtUser.BorderRadius = 21;
            txtUser.CustomizableEdges = customizableEdges3;
            txtUser.DefaultText = "";
            txtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Font = new Font("Segoe UI", 9.75F);
            txtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Location = new Point(400, 175);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.PlaceholderText = "Enter your username";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUser.Size = new Size(300, 45);
            txtUser.TabIndex = 0;
            txtUser.TextOffset = new Point(15, 0);
            // 
            // btnLogin
            // 
            btnLogin.Animated = true;
            btnLogin.AutoRoundedCorners = true;
            btnLogin.BorderRadius = 26;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(34, 211, 238);
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(400, 345);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(300, 55);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(400, 140);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(400, 240);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // txtPass
            // 
            txtPass.AutoRoundedCorners = true;
            txtPass.BorderRadius = 21;
            txtPass.CustomizableEdges = customizableEdges7;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Segoe UI", 9.75F);
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Location = new Point(400, 275);
            txtPass.Margin = new Padding(4, 5, 4, 5);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.PlaceholderText = "Enter your password";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPass.Size = new Size(300, 45);
            txtPass.TabIndex = 1;
            txtPass.TextOffset = new Point(15, 0);
            txtPass.UseSystemPasswordChar = true;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = Properties.Resources.user;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(520, 20);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(60, 60);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 7;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(360, 50);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(10, 350);
            guna2vSeparator1.TabIndex = 6;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            linkRegister.ForeColor = Color.Blue;
            linkRegister.Location = new Point(400, 400);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(334, 28);
            linkRegister.TabIndex = 6;
            linkRegister.Text = "Don't have an account? Register here";
            linkRegister.Click += linkRegister_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(239, 243, 248);
            ClientSize = new Size(800, 450);
            Controls.Add(guna2vSeparator1);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(guna2PictureBox1);
            Controls.Add(linkRegister);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(71, 69, 94);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Login";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Label linkRegister;
    }
}