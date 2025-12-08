using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit;
using MailKit.Security;
using MimeKit;

namespace Bai6.Services
{
    public class EmailService
    {
        public string Email { get; }
        public string Password { get; }

        public EmailService(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public ImapClient ConnectImap()
        {
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
            client.Authenticate(Email, Password);
            return client;
        }

        public MailKit.Net.Smtp.SmtpClient ConnectSmtp()
        {
            var client = new MailKit.Net.Smtp.SmtpClient();
            client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
            client.Authenticate(Email, Password);
            return client;
        }
    }
}
