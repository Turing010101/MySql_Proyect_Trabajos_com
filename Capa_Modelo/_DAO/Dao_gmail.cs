using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_gmail
    {
        void INITIALIZE_SMTP_CLIENT();
        bool SEND_MAIL(Vo_gmail gmail);
    }
}
