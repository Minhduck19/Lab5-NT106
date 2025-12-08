using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace Bai6
{
    partial class SendMailForm
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
        private Guna2HtmlLabel lblTo;
        private Guna2TextBox txtTo;
        private Guna2HtmlLabel lblSubject;
        private Guna2TextBox txtSubject;
        private Guna2HtmlLabel lblBody;
        private Guna2TextBox txtBody;
        private Guna2Button btnAttach;
        private Guna2HtmlLabel lblAttachment;
        private Guna2Button btnSend;

        private void InitializeComponent()
        {
            // Form settings
            this.Text = "Send Email";
            this.Size = new Size(650, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // lblTo
            lblTo = new Guna2HtmlLabel();
            lblTo.Text = "To:";
            lblTo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTo.Location = new Point(30, 30);
            lblTo.AutoSize = true;

            // txtTo
            txtTo = new Guna2TextBox();
            txtTo.PlaceholderText = "Receiver Email";
            txtTo.BorderRadius = 8;
            txtTo.Location = new Point(120, 25);
            txtTo.Size = new Size(480, 40);

            // lblSubject
            lblSubject = new Guna2HtmlLabel();
            lblSubject.Text = "Subject:";
            lblSubject.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblSubject.Location = new Point(30, 85);
            lblSubject.AutoSize = true;

            // txtSubject
            txtSubject = new Guna2TextBox();
            txtSubject.PlaceholderText = "Email Subject";
            txtSubject.BorderRadius = 8;
            txtSubject.Location = new Point(120, 80);
            txtSubject.Size = new Size(480, 40);

            // lblBody
            lblBody = new Guna2HtmlLabel();
            lblBody.Text = "Message:";
            lblBody.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblBody.Location = new Point(30, 140);
            lblBody.AutoSize = true;

            // txtBody
            txtBody = new Guna2TextBox();
            txtBody.Multiline = true;
            txtBody.BorderRadius = 10;
            txtBody.Location = new Point(120, 135);
            txtBody.Size = new Size(480, 300);

            // btnAttach
            btnAttach = new Guna2Button();
            btnAttach.Text = "Attach File";
            btnAttach.BorderRadius = 8;
            btnAttach.Location = new Point(120, 450);
            btnAttach.Size = new Size(130, 40);
            btnAttach.FillColor = Color.FromArgb(50, 130, 255);
            btnAttach.Click += new System.EventHandler(this.btnAttach_Click);

            // lblAttachment
            lblAttachment = new Guna2HtmlLabel();
            lblAttachment.Text = "No file selected";
            lblAttachment.Location = new Point(265, 460);
            lblAttachment.ForeColor = Color.Gray;
            lblAttachment.AutoSize = true;

            // btnSend
            btnSend = new Guna2Button();
            btnSend.Text = "Send";
            btnSend.BorderRadius = 10;
            btnSend.Size = new Size(180, 45);
            btnSend.Location = new Point(420, 500);
            btnSend.FillColor = Color.FromArgb(30, 90, 200);
            btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // Add controls to form
            this.Controls.Add(lblTo);
            this.Controls.Add(txtTo);
            this.Controls.Add(lblSubject);
            this.Controls.Add(txtSubject);
            this.Controls.Add(lblBody);
            this.Controls.Add(txtBody);
            this.Controls.Add(btnAttach);
            this.Controls.Add(lblAttachment);
            this.Controls.Add(btnSend);
        }
        #endregion
    }
}