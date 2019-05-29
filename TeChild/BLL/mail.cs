using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text;
using System.Net;

namespace BLL
{
    public class mail
    {
        //public void send(/*string mailTo*/)
        //{
        //    try
        //    {
        //        SmtpClient client = new SmtpClient("smpt.gmail.com", 587);
        //        MailMessage message = new MailMessage();
        //        message.From = new MailAddress("234aviya@gmail.com");
        //        message.To.Add("e6739995@gmail.com");
        //        message.Body = "hello";
        //        message.Subject = "welcome to techild";
        //        client.UseDefaultCredentials = false;
        //        client.EnableSsl = true;
        //        client.Credentials = new System.Net.NetworkCredential("234aviya@gmail.com", "avm12105");
        //        client.Send(message);
        //        message = null;

        //        MessageBox.Show("sent");
        //    }
        //    catch (Exception s)
        //    {
        //        MessageBox.Show("Failed to send message");
        //    }
        //}



        // Command line argument must the the SMTP host.
        //public void sendmail()
        //{
        //    SmtpClient client = new SmtpClient();
        //    client.Port = 587;
        //    client.Host = "smtp.gmail.com";
        //    client.EnableSsl = true;
        //    client.Timeout = 10000;
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    client.UseDefaultCredentials = false;
        //    client.Credentials = new System.Net.NetworkCredential("234aviya@gmail.com", "avm12105");

        //    MailMessage mm = new MailMessage("234aviya@gmail.com", "e6739995@gmail.com", "test", "test");
        //    mm.BodyEncoding = UTF8Encoding.UTF8;
        //    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

        //    client.Send(mm);
        //}
      public void sendmail()
        {
            var msg = new MailMessage("e6739995@gmail.com", "234aviya@gmail.com", "Hello", Convert.ToString("hi"));
            msg.To.Add("e6739995@gmail.com");
            msg.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com", 587); //**if your from email address is "from@hotmail.com" then host should be "smtp.hotmail.com"**
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new NetworkCredential("e6739995@gmail.com", "e5999376550‏‏");
            smtpClient.EnableSsl = true;
            smtpClient.Send(msg);
            Console.WriteLine("Email Sent Successfully");
        }
    }
}
