using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using Bai6.Services;

namespace Bai6
{
    public partial class MainForm : Form
    {
        private EmailService _service;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Email và mật khẩu không được để trống!");
                    return;
                }

                _service = new EmailService(email, password);

                using (var imap = _service.ConnectImap())
                {
                    imap.Disconnect(true);
                }

                loginPanel.Visible = false;

                topBar.Visible = true;
                listViewEmails.Visible = true;
                txtFrom.Visible = true;
                txtSubject.Visible = true;
                txtBody.Visible = true;

                LoadEmailList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        
        private void LoadEmailList()
        {
            try
            {
                if (_service == null) return;

                listViewEmails.Items.Clear();

                using (var imap = _service.ConnectImap())
                {
                    var inbox = imap.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    int total = inbox.Count;
                    int count = Math.Min(20, total);

                    for (int i = total - 1; i >= total - count; i--)
                    {
                        var msg = inbox.GetMessage(i);

                        var item = new ListViewItem(msg.From.ToString());
                        item.SubItems.Add(msg.Subject);
                        item.SubItems.Add(msg.Date.LocalDateTime.ToString());
                        item.Tag = i;

                        listViewEmails.Items.Add(item);
                    }

                    imap.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading emails: " + ex.Message);
            }
        }

        private void ListViewEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmails.SelectedItems.Count == 0) return;

            int index = (int)listViewEmails.SelectedItems[0].Tag;

            using (var imap = _service.ConnectImap())
            {
                var inbox = imap.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                var msg = inbox.GetMessage(index);

                txtFrom.Text = msg.From.ToString();
                txtSubject.Text = msg.Subject;
                txtBody.Text = msg.TextBody;

                imap.Disconnect(true);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmailList();
        }

        private void BtnNewMail_Click(object sender, EventArgs e)
        {
            var sendForm = new SendMailForm(_service);
            sendForm.Show();
        }

        private void BtnReply_Click(object sender, EventArgs e)
        {
            var form = new SendMailForm(_service);
            form.SetReply(txtFrom.Text, txtSubject.Text);
            form.Show();
        }
    }
}
