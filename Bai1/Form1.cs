using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            txtFrom.Text = "tdruucc20056@gmail.com";
            txtPassword.Text = "xrep oxeb tdqf aody";
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            if (txtTo == null || string.IsNullOrWhiteSpace(txtTo.Text))
            {
                MessageBox.Show("Vui lòng nhập Email người nhận!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFrom.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập Email gửi và Mật khẩu ứng dụng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSend.Enabled = false;
            btnSend.Text = "SENDING...";
            btnSend.BackColor = Color.Gray;
            lblStatus.Text = "Đang kết nối tới máy chủ SMTP...";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(txtFrom.Text.Trim());

                string[] emails = txtTo.Text.Split(',');
                foreach (var email in emails)
                {
                    if (!string.IsNullOrWhiteSpace(email))
                        mail.To.Add(email.Trim());
                }

                mail.Subject = txtSubject.Text.Trim();
                mail.Body = rtbBody.Text;
                mail.IsBodyHtml = false; 

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587; 
                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential(txtFrom.Text.Trim(), txtPassword.Text.Trim());

                await smtp.SendMailAsync(mail);

                MessageBox.Show("Gửi mail thành công!", "Ông Trùm Winforms", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = "Gửi xong lúc: " + DateTime.Now.ToString("HH:mm:ss");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi mail:\n" + ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Gửi thất bại.";
            }
            finally
            {
                btnSend.Enabled = true;
                btnSend.Text = "SEND EMAIL";
                btnSend.BackColor = Color.FromArgb(0, 123, 255);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}