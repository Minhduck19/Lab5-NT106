using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
    using MailKit.Net.Pop3;
    using MailKit;
namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMailListView();
        }

        private void InitMailListView()
        {
            listMail.View = View.Details;
            listMail.Columns.Add("From", 200);
            listMail.Columns.Add("Subject", 250);
            listMail.Columns.Add("Date", 200);

            cntMail.Text = "0";
            cntRecent.Text = "0";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ShowError("Vui lòng nhập đầy đủ Email & App Password.");
                return;
            }

            ToggleLogin(false);

            try
            {
                LoadMailWithPOP(email, password);
                ShowSuccess("Đăng nhập và tải mail hoàn tất.");
            }
            catch (Exception ex)
            {
                ShowError("Lỗi kết nối POP3.\n" + ex.Message);
            }
            finally
            {
                ToggleLogin(true);
            }
        }

        private void LoadMailWithPOP(string email, string password)
        {
            using (var client = new Pop3Client())
            {
                // Kết nối POP3 Gmail
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(email, password);

                int totalMessages = client.Count;
                cntMail.Text = totalMessages.ToString();

                // POP3 không hỗ trợ NotSeen, nên recent = 0
                cntRecent.Text = "0";

                listMail.Items.Clear();

                int fetchLimit = Math.Min(totalMessages, 20);

                // Lấy thư từ mới nhất
                for (int i = totalMessages - 1; i >= totalMessages - fetchLimit; i--)
                {
                    var msg = client.GetMessage(i);

                    var item = new ListViewItem(new string[]
                    {
                        msg.From.ToString(),
                        msg.Subject ?? "(No Subject)",
                        msg.Date.DateTime.ToString("dd/MM/yyyy HH:mm")
                    });

                    listMail.Items.Add(item);
                }

                client.Disconnect(true);
            }
        }

        private void ToggleLogin(bool isEnabled)
        {
            btnLogin.Enabled = isEnabled;
            btnLogin.Text = isEnabled ? "Login" : "Loading...";
        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccess(string msg)
        {
            MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
