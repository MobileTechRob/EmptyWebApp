using System;
using System.Net.Mail;

namespace UtilityClasses
{
    public class EmailSupport
    {
        SmtpClient mailClient;
        
        public EmailSupport()
        {
            // smtp-mail.outlook.com. SSL: true-explicit. Port: 587 (default) 
            mailClient = new SmtpClient("smtp.sendgrid.net");            
        }

        public bool SendATextMessage(string fromAddress, string password, string toAddress, string subject, string msg,ref string errorTest)
        {
            bool mailSent = false;

            mailClient.UseDefaultCredentials = false;
            mailClient.Credentials = new System.Net.NetworkCredential();
            mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            mailClient.EnableSsl = true;
                           
            try
            {
                mailClient.Send(fromAddress, toAddress, subject, msg);                
                mailSent = true;
            }
            catch (Exception ex)
            {
                errorTest = ex.InnerException.ToString();
                ex.GetHashCode();
            }
            
            return mailSent;
        }
    }
}
