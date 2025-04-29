using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
   public  class Utility
    {
        public static void Send(System.Net.Mail.MailMessage msg)
        {
            try
            {
                if (System.Net.ServicePointManager.ServerCertificateValidationCallback == null)
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationHandler;
                }

                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("administrator@razi-foundation.com", "Yekta@RaziFoundation232");
                client.Port = 25;
                client.Host = "mail.razi-foundation.com";
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Send(msg);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //public static void SendMail(Aspose.Email.Mail.MailMessage msg)
        //{
        //    System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationHandler;
        //    Aspose.Email.Exchange.IEWSClient client = Aspose.Email.Exchange.EWSClient.GetEWSClient("https://mail-01.razi-foundation.com/ews/exchange.asmx", "Reports", "RaziScience35741", "Razi-Foundation.com");

        //    client.Send(msg);
        //}

        //public static void SendMailInvoice(Aspose.Email.Mail.MailMessage msg)
        //{
        //    System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationHandler;
        //    Aspose.Email.Exchange.IEWSClient client = Aspose.Email.Exchange.EWSClient.GetEWSClient("https://mail-01.razi-foundation.com/ews/exchange.asmx", "Invoice", "RaziScience35741", "Razi-Foundation.com");

        //    client.Send(msg);
        //}

        //public static void SendMailMarketing(Aspose.Email.Mail.MailMessage msg)
        //{
        //    System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationHandler;
        //    Aspose.Email.Exchange.IEWSClient client = Aspose.Email.Exchange.EWSClient.GetEWSClient("https://mail-01.razi-foundation.com/ews/exchange.asmx", "marketing", "Razi789", "Razi-Foundation.com");

        //    client.Send(msg);
        //}

        //public static void SendFax(Aspose.Email.Mail.MailMessage msg)
        //{
        //    System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationHandler;
        //    Aspose.Email.Exchange.IEWSClient client = Aspose.Email.Exchange.EWSClient.GetEWSClient("https://mail-01.razi-foundation.com/ews/exchange.asmx", "LabFax", "RaziScience35741", "Razi-Foundation.com");

        //    client.Send(msg);
        //}


        private static bool RemoteCertificateValidationHandler(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
