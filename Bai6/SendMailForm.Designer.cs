using Guna.UI2.WinForms;
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
        private Guna2GradientPanel header;
        private Guna2TextBox txtTo;
        private Guna2TextBox txtSubject;
        private Guna2TextBox txtBody;
        private Guna2Button btnAttach;
        private Guna2Button btnSend;
        private Guna2HtmlLabel lblAttachment;


        private void InitializeComponent()
        {
            this.header = new Guna2GradientPanel();
            this.txtTo = new Guna2TextBox();
            this.txtSubject = new Guna2TextBox();
            this.txtBody = new Guna2TextBox();
            this.btnAttach = new Guna2Button();
            this.btnSend = new Guna2Button();
            this.lblAttachment = new Guna2HtmlLabel();


            this.SuspendLayout();


            // Header
            header.Dock = DockStyle.Top;
            header.Height = 55;
            header.FillColor = System.Drawing.Color.FromArgb(58, 141, 255);
            header.FillColor2 = System.Drawing.Color.FromArgb(108, 200, 255);


            // txtTo
            txtTo.PlaceholderText = "To";
            txtTo.BorderRadius = 10;
            txtTo.Location = new System.Drawing.Point(20, 70);
            txtTo.Size = new System.Drawing.Size(450, 40);


            // txtSubject
            txtSubject.PlaceholderText = "Subject";
            txtSubject.BorderRadius = 10;
            txtSubject.Location = new System.Drawing.Point(20, 120);
            txtSubject.Size = new System.Drawing.Size(450, 40);


            // txtBody
            txtBody.Multiline = true;
            txtBody.BorderRadius = 12;
            txtBody.Location = new System.Drawing.Point(20, 175);
            txtBody.Size = new System.Drawing.Size(450, 330);


            // btnAttach
            btnAttach.Text = "Attach";
            btnAttach.BorderRadius = 8;
            btnAttach.Location = new System.Drawing.Point(20, 520);
            btnAttach.Size = new System.Drawing.Size(100, 40);
            btnAttach.Click += new System.EventHandler(this.btnAttach_Click);


            // lblAttachment
            lblAttachment.Text = "No file chosen";
            lblAttachment.Location = new System.Drawing.Point(130, 530);
            lblAttachment.AutoSize = true;
            lblAttachment.ForeColor = System.Drawing.Color.FromArgb(30, 60, 120);


            // btnSend
            btnSend.Text = "Send";
            btnSend.BorderRadius = 8;
            btnSend.FillColor = System.Drawing.Color.FromArgb(0, 90, 200);
            btnSend.Location = new System.Drawing.Point(370, 520);
            btnSend.Size = new System.Drawing.Size(100, 40);
            btnSend.Click += new System.EventHandler(this.btnSend_Click);


            // Form
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(header);
            this.Controls.Add(txtTo);
            this.Controls.Add(txtSubject);
            this.Controls.Add(txtBody);
            this.PerformLayout();
        }
        #endregion
    }
}