using System;
using System.Net;
using System.Net.Mail;

namespace EModernHouse.Application.Extensions
{
    public static class EmailSender
    {
        public static void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                const string fromEmail = "info@yazdstar.com";
                var message = new MailMessage
                {
                    From = new MailAddress(fromEmail),
                    To = { toEmail },
                    Subject = subject,
                    Body = body,
                    DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                };
                using (SmtpClient smtpClient = new SmtpClient("https://sadaf.mrsservers.com:8443"))
                {
                    smtpClient.Credentials = new NetworkCredential("info@yazdstar.com", "xHvi342^");
                    smtpClient.Port = 25;
                    smtpClient.EnableSsl = false;
                    smtpClient.Send(message);
                }

            }
            catch (Exception excep)
            {
                //ignore it or you can retry .
            }
        }
    }
}