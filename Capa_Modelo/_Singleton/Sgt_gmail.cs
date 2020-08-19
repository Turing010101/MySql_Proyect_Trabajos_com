using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Capa_Modelo._Singleton
{
    class Sgt_gmail
    {
        public static Sgt_gmail instancia;

        private Sgt_gmail()
        {

        }
        public static Sgt_gmail getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sgt_gmail();
            }
            return instancia;
        }
        public SmtpClient stmp_client()
        {
            return new SmtpClient();
        }
    }
}
