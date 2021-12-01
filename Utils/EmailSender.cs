using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PhysicLeaner.Utils
{
    public class EmailSender
    {
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("wwelize0317@gmail.com", "FIT5032 Assignment");
            var to = new EmailAddress(toEmail, "csuu0008@student.monash.edu");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }
    }
}