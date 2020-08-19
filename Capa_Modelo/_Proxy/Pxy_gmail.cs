using Capa_Modelo._DAO;
using Capa_Modelo._VO;

namespace Capa_Modelo._Proxy
{
    public class Pxy_gmail:Dao_gmail
    {
        public M_gmail m_gmail;

        public void INITIALIZE_SMTP_CLIENT()
        {
            if (m_gmail == null)
            {
                m_gmail = new M_gmail();
                m_gmail.INITIALIZE_SMTP_CLIENT();
            }
            else
            {
                m_gmail.INITIALIZE_SMTP_CLIENT();
            }
        }

        public bool SEND_MAIL(Vo_gmail gmail)
        {
            if (m_gmail == null)
            {
                m_gmail = new M_gmail();
                return m_gmail.SEND_MAIL(gmail);
            }
            else
            {
               return m_gmail.SEND_MAIL(gmail);
            }
        }
    }
}
