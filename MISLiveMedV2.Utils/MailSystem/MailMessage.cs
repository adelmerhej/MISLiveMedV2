using System;
using System.Net.Mail;

namespace MISLiveMed.Utils.MailSystem
{
    public class NoReplyMailMessage
    {
        public void SendEmail(NoReplyMailModel model)
        {
            if (model ==null)
            {
                throw new Exception("Error in creating message notification Please try again or contact your system administrator.");
                return;
            }

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(model.MailFrom, model.MailDisplayNameFrom);
            msg.To.Add(new MailAddress(model.MailTo, model.MailDisplayNameTo));
            msg.Subject = model.MailSubject;
            msg.Body = model.MailBody;
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(model.MailUserName, model.MailPassword);
            client.Port = model.MailOutgoingPort; // You can use Port 25 if 587 is blocked (mine is!)
            client.Host = model.MailHost;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = false;
            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
