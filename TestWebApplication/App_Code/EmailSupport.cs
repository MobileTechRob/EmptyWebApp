using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;


namespace TestWebApplication.App_Code
{
    public class EmailSupport
    {
        SmtpClient mailClient;
        MailMessage mailMessage;

        public EmailSupport()
        {
            // smtp-mail.outlook.com. SSL: true-explicit. Port: 587 (default) 
            mailClient = new SmtpClient();
            mailMessage = new MailMessage();
        }

        public bool SendATextMessage()
        {
            return true;
        }
    }
}