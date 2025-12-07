namespace Bai3
{
    partial class Form1
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

        private Guna.UI2.WinForms.Guna2GradientPanel headerPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.ListView listMail;
        private System.Windows.Forms.Label countMail;
        private System.Windows.Forms.Label cntMail;
        private System.Windows.Forms.Label countRecent;
        private System.Windows.Forms.Label cntRecent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;

        private void InitializeComponent()
        {
            this.headerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.listMail = new System.Windows.Forms.ListView();
            this.countMail = new System.Windows.Forms.Label();
            this.cntMail = new System.Windows.Forms.Label();
            this.countRecent = new System.Windows.Forms.Label();
            this.cntRecent = new System.Windows.Forms.Label();

            this.headerPanel.SuspendLayout();
            this.SuspendLayout();

            // HEADER PANEL
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.RoyalBlue;
            this.headerPanel.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.headerPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.headerPanel.Size = new System.Drawing.Size(950, 95);
            this.headerPanel.Controls.Add(this.lblTitle);

            // TITLE
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Sending & Receiving Email in C# (POP3)";
            this.lblTitle.Location = new System.Drawing.Point(20, 25);

            // TXT EMAIL
            this.txtName.BorderRadius = 12;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.PlaceholderText = "Email";
            this.txtName.Location = new System.Drawing.Point(280, 120);
            this.txtName.Size = new System.Drawing.Size(600, 50);

            // TXT PASSWORD
            this.txtPassword.BorderRadius = 12;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.PlaceholderText = "App Password";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Location = new System.Drawing.Point(280, 190);
            this.txtPassword.Size = new System.Drawing.Size(600, 50);

            // LOGIN BUTTON
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(60, 150);
            this.btnLogin.Size = new System.Drawing.Size(180, 60);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // LIST MAIL
            this.listMail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listMail.Location = new System.Drawing.Point(40, 330);
            this.listMail.Size = new System.Drawing.Size(840, 350);
            this.listMail.HideSelection = false;
            this.listMail.UseCompatibleStateImageBehavior = false;

            // TOTAL LABEL
            this.countMail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.countMail.Location = new System.Drawing.Point(90, 270);
            this.countMail.Text = "Total:";

            this.cntMail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cntMail.Location = new System.Drawing.Point(150, 270);
            this.cntMail.Text = "0";

            // RECENT LABEL
            this.countRecent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.countRecent.Location = new System.Drawing.Point(250, 270);
            this.countRecent.Text = "Recent:";

            this.cntRecent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cntRecent.Location = new System.Drawing.Point(325, 270);
            this.cntRecent.Text = "0";

            // FORM PROPERTIES
            this.ClientSize = new System.Drawing.Size(950, 720);
            this.BackColor = System.Drawing.Color.White;

            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.countMail);
            this.Controls.Add(this.cntMail);
            this.Controls.Add(this.countRecent);
            this.Controls.Add(this.cntRecent);
            this.Controls.Add(this.listMail);

            this.Text = "Email Reader - POP3";

            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

