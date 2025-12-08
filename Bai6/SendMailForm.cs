using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
using Bai6.Services;

namespace Bai6
{
    public partial class SendMailForm : Form
    {
        private readonly EmailService _service;
        private string _attachmentPath = "";

        public SendMailForm(EmailService service)
        {
            _service = service;
            InitializeComponent();
        }

        public void SetReply(string to, string subject)
        {
            txtTo.Text = to;
            txtSubject.Text = "Re: " + subject;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _attachmentPath = dialog.FileName;
                lblAttachment.Text = dialog.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", _service.Email));
                message.To.Add(new MailboxAddress("", txtTo.Text));
                message.Subject = txtSubject.Text;

                var builder = new BodyBuilder();
                builder.TextBody = txtBody.Text;

                if (!string.IsNullOrEmpty(_attachmentPath))
                    builder.Attachments.Add(_attachmentPath);

                message.Body = builder.ToMessageBody();

                using (var smtp = _service.ConnectSmtp())
                {
                    smtp.Send(message);
                    smtp.Disconnect(true);
                }

                MessageBox.Show("Email sent successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sending failed: " + ex.Message);
            }
        }
    }
}
