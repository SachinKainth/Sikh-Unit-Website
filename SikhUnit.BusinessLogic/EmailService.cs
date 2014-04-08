using System.Net.Mail;
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
                contact.EmailAddress,
                SiteConfiguration.ContactUsToEmailAddress,
                contact.Subject,
                contact.Message);
            mail.ReplyToList.Add(new MailAddress(contact.EmailAddress));

            var client = new SmtpClient();
 
            client.Send(mail);
        }
    }
}