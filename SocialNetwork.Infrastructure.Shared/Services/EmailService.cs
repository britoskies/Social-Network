using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using SocialNetwork.Core.Application.Dtos.Email;
using SocialNetwork.Core.Application.Interfaces.Services;
using SocialNetwork.Core.Domain.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Infrastructure.Shared.Services
{
    public class EmailService : IEmailService
    {
        public MailSettings _mailSettings { get; }

        public EmailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public async Task SendAsync(EmailRequest req)
        {
            try
            {
                // Email config
                MimeMessage email = new();
                email.Sender = MailboxAddress.Parse($"{_mailSettings.DisplayName} <{_mailSettings.EmailFrom}>");
                email.To.Add(MailboxAddress.Parse(req.To));
                email.Subject = req.Subject;

                // Adding content to body of email
                BodyBuilder body = new();
                body.HtmlBody = req.Body;
                email.Body = body.ToMessageBody();

                // Other email settings
                using SmtpClient smtp = new();
                smtp.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.SmtpUser, _mailSettings.SmtpPass);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
