using System;
using System.Net.Mail;

namespace UtilityClasses
{
    public class EmailSupport
    {
        SmtpClient mailClient;
        MailMessage mailMessage;

        public EmailSupport()
        {
            // smtp-mail.outlook.com. SSL: true-explicit. Port: 587 (default) 
            mailClient = new SmtpClient("smtp-mail.outlook.com", 587);            
        }

        public bool SendATextMessage(string fromAddress, string password, string toAddress, string subject, string msg)
        {
            bool mailSent = false;

            mailClient.UseDefaultCredentials = false;
            mailClient.Credentials = new System.Net.NetworkCredential(fromAddress, password);
            mailClient.EnableSsl = true;
                           
            try
            {
                mailClient.Send(fromAddress, toAddress, subject, msg);
                mailSent = true;
            }
            catch (Exception ex)
            {
                ex.GetHashCode();
            }
            
            return mailSent;
        }
    }
}
