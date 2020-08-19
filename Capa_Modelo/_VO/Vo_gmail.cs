using System.Collections.Generic;
using System.Net.Mail;

namespace Capa_Modelo._VO
{
    public class Vo_gmail
    {
        string subject;
        string body;
        string code;
        List<string> recipientMail;

        public string Subject { get => subject; set => subject = value; }
        public string Body { get => body; set => body = value; }
        public List<string> RecipientMail { get => recipientMail; set => recipientMail = value; }
        public string Code { get => code; set => code = value; }
    }
}
