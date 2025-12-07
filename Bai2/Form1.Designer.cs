using Guna.UI2.WinForms;

namespace Bai2
{
    partial class Form1
    {
        private Guna.UI2.WinForms.Guna2BorderlessForm borderRadius;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2AnimateWindow animate;
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
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.headerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.listMail = new System.Windows.Forms.ListView();
            this.countMail = new System.Windows.Forms.Label();
            this.cntMail = new System.Windows.Forms.Label();
            this.cntRecent = new System.Windows.Forms.Label();
            this.countRecent = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 12;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(290, 113);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Tên ứng dụng";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(585, 51);
            this.txtName.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(61, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.BorderRadius = 15;
            this.btnLogin.ShadowDecoration.Depth = 8;
            this.btnLogin.ShadowDecoration.Enabled = true;
            this.btnLogin.Size = new System.Drawing.Size(166, 55);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.guna2HtmlLabel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.RoyalBlue;
            this.headerPanel.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(915, 95);
            this.headerPanel.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(900, 63);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Sending & Receiving Email in C# (IMAP)";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 12;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(290, 189);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(585, 51);
            this.txtPassword.TabIndex = 7;
            // 
            // listMail
            // 
            this.listMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMail.HideSelection = false;
            this.listMail.Location = new System.Drawing.Point(40, 317);
            this.listMail.Name = "listMail";
            this.listMail.Size = new System.Drawing.Size(835, 351);
            this.listMail.TabIndex = 8;
            this.listMail.UseCompatibleStateImageBehavior = false;
            // 
            // countMail
            // 
            this.countMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countMail.Location = new System.Drawing.Point(93, 261);
            this.countMail.Name = "countMail";
            this.countMail.Size = new System.Drawing.Size(59, 27);
            this.countMail.TabIndex = 9;
            this.countMail.Text = "Total:";
            // 
            // cntMail
            // 
            this.cntMail.AutoSize = true;
            this.cntMail.Location = new System.Drawing.Point(158, 263);
            this.cntMail.Name = "cntMail";
            this.cntMail.Size = new System.Drawing.Size(0, 16);
            this.cntMail.TabIndex = 33;
            // 
            // cntRecent
            // 
            this.cntRecent.AutoSize = true;
            this.cntRecent.Location = new System.Drawing.Point(336, 263);
            this.cntRecent.Name = "cntRecent";
            this.cntRecent.Size = new System.Drawing.Size(0, 16);
            this.cntRecent.TabIndex = 35;
            // 
            // countRecent
            // 
            this.countRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countRecent.Location = new System.Drawing.Point(246, 261);
            this.countRecent.Name = "countRecent";
            this.countRecent.Size = new System.Drawing.Size(75, 29);
            this.countRecent.TabIndex = 34;
            this.countRecent.Text = "Recent:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 700);
            this.Controls.Add(this.cntRecent);
            this.Controls.Add(this.countRecent);
            this.Controls.Add(this.cntMail);
            this.Controls.Add(this.countMail);
            this.Controls.Add(this.listMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Send Email";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2GradientPanel headerPanel;
        private System.Windows.Forms.ListView listMail;
        private Guna2TextBox txtPassword;
        private System.Windows.Forms.Label cntMail;
        private System.Windows.Forms.Label countMail;
        private System.Windows.Forms.Label cntRecent;
        private System.Windows.Forms.Label countRecent;

        #endregion

        private Guna2HtmlLabel guna2HtmlLabel1;
    }
}

