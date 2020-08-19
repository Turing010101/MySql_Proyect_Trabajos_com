using Capa_Modelo._DAO;
using Capa_Modelo._VO;

namespace Capa_Modelo._Proxy
{
    public class Pxy_recuperar:Dao_recuperar
    {
        public M_recuperar m_recuperar;

        public Vo_gmail SEARCH(Vo_recuperar recuperar)
        {
            if (m_recuperar == null)
            {
                m_recuperar = new M_recuperar();
                return m_recuperar.SEARCH(recuperar);
            }
            else
            {
                return m_recuperar.SEARCH(recuperar);
            }
        }
    }
}
