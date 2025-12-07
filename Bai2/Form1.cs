using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(700, 600);
            listMail.View = View.Details;
            listMail.Columns.Add("From", 200);
            listMail.Columns.Add("Subject", 250);
            listMail.Columns.Add("Date", 200);

            cntMail.Text = "0";
            cntRecent.Text = "0";
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            if (name == "" || password == "")
            {
                MessageBox.Show("Vui long nhap day du ten va mat khau tai khoan", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "Loading...";
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(name, password);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    // Đếm mail
                    cntMail.Text = inbox.Count.ToString();
                    // Đếm mail gần đây (chưa đọc)
                    var recent = inbox.Search(SearchQuery.NotSeen);
                    cntRecent.Text = recent.Count.ToString();
                    // Clear list
                    listMail.Items.Clear();
                    // Lấy 20 mail gần nhất
                    int fetchLimit = Math.Min(inbox.Count, 20);
                    for (int i = inbox.Count - 1; i >= inbox.Count - fetchLimit; i--)
                    {
                        var msg = inbox.GetMessage(i);

                        ListViewItem item = new ListViewItem(new string[]
                        {
                            msg.From.ToString(),
                            msg.Subject,
                            msg.Date.DateTime.ToString("dd/MM/yyyy HH:mm")
                        });

                        listMail.Items.Add(item);
                    }

                    client.Disconnect(true);
                }

                btnLogin.Text = "Login";
                btnLogin.Enabled = true;

                MessageBox.Show("Dang nhap va tai mail haon tat",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                btnLogin.Text = "Login";
                btnLogin.Enabled = true;

                MessageBox.Show("Loi ket noi",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
