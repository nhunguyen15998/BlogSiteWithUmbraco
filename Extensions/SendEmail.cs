using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;

namespace BlogSiteWithUmbraco.Extensions
{
    public static class SendEmail
    {
        public static void SendSync(string toEmail, string subject, string body)
        {
            try
            {
                var senderEmail = new MailAddress(ConfigurationManager.AppSettings["EmailSender"]);
                var senderEmailPassword = ConfigurationManager.AppSettings["EmailSenderPassword"];

                var smtp = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential(senderEmail.Address, senderEmailPassword)
                };
                var message = new MailMessage(senderEmail.Address, toEmail)
                {
                    Subject = subject,
                    Body = body, 
                    IsBodyHtml = true
                };

                smtp.Send(message);
               
            }
            catch (Exception ex)
            {

            }
        }
    }
}