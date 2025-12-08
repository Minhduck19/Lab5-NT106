using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace Bai6
{
    partial class MainForm
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

        #region 
        private Guna2Panel loginPanel;
        private Guna2TextBox txtEmail;
        private Guna2TextBox txtPassword;
        private Guna2Button btnLogin;
        private Guna2HtmlLabel lblTitle;

        private Guna2GradientPanel topBar;
        private Guna2Button BtnRefresh;
        private Guna2Button BtnNewMail;
        private Guna2Button BtnReply;

        private ListView listViewEmails;
        private ColumnHeader colFrom;
        private ColumnHeader colSubject;
        private ColumnHeader colDate;

        private Guna2TextBox txtFrom;
        private Guna2TextBox txtSubject;
        private Guna2TextBox txtBody;

        private void InitializeComponent()
        {
            // ====================== LOGIN PANEL ======================
            loginPanel = new Guna2Panel();
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.FillColor = Color.FromArgb(50, 130, 255);

            lblTitle = new Guna2HtmlLabel();
            lblTitle.Text = "Email Client Login";
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(140, 40);

            txtEmail = new Guna2TextBox();
            txtEmail.PlaceholderText = "Email";
            txtEmail.BorderRadius = 10;
            txtEmail.Size = new Size(330, 45);
            txtEmail.Location = new Point(85, 120);

            txtPassword = new Guna2TextBox();
            txtPassword.PlaceholderText = "App Password";
            txtPassword.PasswordChar = '*';
            txtPassword.BorderRadius = 10;
            txtPassword.Size = new Size(330, 45);
            txtPassword.Location = new Point(85, 180);

            btnLogin = new Guna2Button();
            btnLogin.Text = "Login";
            btnLogin.FillColor = Color.FromArgb(30, 90, 200);
            btnLogin.BorderRadius = 10;
            btnLogin.Size = new Size(330, 50);
            btnLogin.Location = new Point(85, 250);
            btnLogin.Click += BtnLogin_Click;

            loginPanel.Controls.Add(lblTitle);
            loginPanel.Controls.Add(txtEmail);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(btnLogin);

            // ====================== TOP BAR ======================
            topBar = new Guna2GradientPanel();
            topBar.Dock = DockStyle.Top;
            topBar.Height = 55;
            topBar.FillColor = Color.FromArgb(58, 141, 255);
            topBar.FillColor2 = Color.FromArgb(108, 200, 255);
            topBar.Visible = false;

            BtnRefresh = new Guna2Button();
            BtnRefresh.Text = "Refresh";
            BtnRefresh.Size = new Size(100, 36);
            BtnRefresh.BorderRadius = 8;
            BtnRefresh.Location = new Point(20, 10);
            BtnRefresh.Click += BtnRefresh_Click;

            BtnNewMail = new Guna2Button();
            BtnNewMail.Text = "New Mail";
            BtnNewMail.Size = new Size(100, 36);
            BtnNewMail.BorderRadius = 8;
            BtnNewMail.Location = new Point(130, 10);
            BtnNewMail.Click += BtnNewMail_Click;

            BtnReply = new Guna2Button();
            BtnReply.Text = "Reply";
            BtnReply.Size = new Size(100, 36);
            BtnReply.BorderRadius = 8;
            BtnReply.Location = new Point(240, 10);
            BtnReply.Click += BtnReply_Click;

            topBar.Controls.Add(BtnRefresh);
            topBar.Controls.Add(BtnNewMail);
            topBar.Controls.Add(BtnReply);

            // ====================== EMAIL LIST ======================
            listViewEmails = new ListView();
            listViewEmails.View = View.Details;
            listViewEmails.FullRowSelect = true;
            listViewEmails.GridLines = true;
            listViewEmails.Location = new Point(10, 70);
            listViewEmails.Size = new Size(450, 520);
            listViewEmails.Visible = false;
            listViewEmails.HideSelection = false;
            listViewEmails.SelectedIndexChanged += ListViewEmails_SelectedIndexChanged;

            colFrom = new ColumnHeader() { Text = "From", Width = 150 };
            colSubject = new ColumnHeader() { Text = "Subject", Width = 200 };
            colDate = new ColumnHeader() { Text = "Date", Width = 100 };

            listViewEmails.Columns.AddRange(new ColumnHeader[] {
                colFrom, colSubject, colDate
            });

            // ====================== MAIL VIEWER ======================
            txtFrom = new Guna2TextBox();
            txtFrom.PlaceholderText = "From";
            txtFrom.BorderRadius = 8;
            txtFrom.Location = new Point(470, 70);
            txtFrom.Size = new Size(400, 35);
            txtFrom.ReadOnly = true;
            txtFrom.Visible = false;

            txtSubject = new Guna2TextBox();
            txtSubject.PlaceholderText = "Subject";
            txtSubject.BorderRadius = 8;
            txtSubject.Location = new Point(470, 120);
            txtSubject.Size = new Size(400, 35);
            txtSubject.ReadOnly = true;
            txtSubject.Visible = false;

            txtBody = new Guna2TextBox();
            txtBody.Multiline = true;
            txtBody.BorderRadius = 12;
            txtBody.Location = new Point(470, 170);
            txtBody.Size = new Size(400, 420);
            txtBody.ReadOnly = true;
            txtBody.Visible = false;

            // ====================== FORM SETTINGS ======================
            this.ClientSize = new Size(900, 600);
            this.Text = "Email Client";
            this.StartPosition = FormStartPosition.CenterScreen;

            // ====================== ADD CONTROLS ======================
            this.Controls.Add(loginPanel);
            this.Controls.Add(topBar);
            this.Controls.Add(listViewEmails);
            this.Controls.Add(txtFrom);
            this.Controls.Add(txtSubject);
            this.Controls.Add(txtBody);
        }
        #endregion
    }
}