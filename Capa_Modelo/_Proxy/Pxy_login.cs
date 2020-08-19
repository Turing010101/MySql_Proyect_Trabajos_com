using Capa_Modelo._DAO;
using Capa_Modelo._VO;

namespace Capa_Modelo._Proxy
{
    public class Pxy_login:Dao_login
    {
        public M_login m_login;

        public int[] SEARCH(Vo_login login)
        {
            if (m_login == null)
            {
                m_login = new M_login();
                return m_login.SEARCH(login);
            }
            else
            {
                return m_login.SEARCH(login);
            }
        }
    }
}
