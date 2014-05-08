using System;
using System.Net.Mail;
using System.Reflection.Emit;
using SikhUnit.Configuration;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.BusinessLogic
{
    public class EmailService : IEmailService
    {
        public void Send(Contact contact)
        {
            var mail = new MailMessage(
                SiteConfiguration.ContactUsToEmailAddress,
                SiteConfiguration.ContactUsToEmailAddress,
                SiteConfiguration.EmailSubject,
                SenderDetails(contact));
  
            var client = new SmtpClient();
 
            client.Send(mail);
        }

        public string SenderDetails(Contact contact)
        {
            return
                "Sender name:" + Environment.NewLine + contact.Name + Environment.NewLine + Environment.NewLine +
                "Sender email address:" + Environment.NewLine + contact.EmailAddress + Environment.NewLine + Environment.NewLine +
                "Subject:" + Environment.NewLine + contact.Subject + Environment.NewLine + Environment.NewLine +
                "Message:" + Environment.NewLine + contact.Message + Environment.NewLine;
        }
    }
}