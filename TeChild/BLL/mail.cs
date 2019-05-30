using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace BLL
{
    public class mail
    {
      public void sendmail(string mail)
        {
            var msg = new MailMessage("techild10@gmail.com", mail, "Welcome to the Techild", Convert.ToString("hello eti your password is:5s21cza3f"));
            msg.To.Add(mail);
            msg.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com", 587); //**if your from email address is "from@hotmail.com" then host should be "smtp.hotmail.com"**
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new NetworkCredential("techild10@gmail.com", "av13zi12");
            smtpClient.EnableSsl = true;
            smtpClient.Send(msg);
            Console.WriteLine("Email Sent Successfully");
        }
    }
}
