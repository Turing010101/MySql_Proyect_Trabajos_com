using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_gmail : Dao_gmail
    {
        Sgt_gmail mail = Sgt_gmail.getInstancia();
        SmtpClient smtpClient;
        string senderMail;
        string password;
        string host;
        int port;
        bool ssl;

        public M_gmail()
        {
            senderMail = "jorge019912@gmail.com";
            password = "tesla_369";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
        }

        public void INITIALIZE_SMTP_CLIENT()
        {
            smtpClient = mail.stmp_client();
            smtpClient.Credentials = new NetworkCredential(senderMail,password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public bool SEND_MAIL(Vo_gmail gmail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in gmail.RecipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = gmail.Subject;
                mailMessage.Body = gmail.Body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);//Enviar mensaje
                return true;
            }
            catch (Exception ex) { return false; }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }

        }
    }
}
