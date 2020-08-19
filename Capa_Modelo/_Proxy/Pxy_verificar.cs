using Capa_Modelo._DAO;
using Capa_Modelo._VO;

namespace Capa_Modelo._Proxy
{
    public class Pxy_verificar : Dao_verificar
    {
        public M_verificar m_verificar;

        public bool FIND(Vo_verificar verificar)
        {
            if (m_verificar == null)
            {
                m_verificar = new M_verificar();
                return m_verificar.FIND(verificar);
            }
            else
            {
                return m_verificar.FIND(verificar);
            }
        }
        public Vo_gmail E_MAIL(Vo_verificar verificar)
        {
            if (m_verificar == null)
            {
                m_verificar = new M_verificar();
                return m_verificar.E_MAIL(verificar);
            }
            else
            {
                return m_verificar.E_MAIL(verificar);
            }
        }
        public Vo_perfil PERFIL(Vo_verificar verificar)
        {
            if (m_verificar == null)
            {
                m_verificar = new M_verificar();
                return m_verificar.PERFIL(verificar);
            }
            else
            {
                return m_verificar.PERFIL(verificar);
            }
        }
    }
}
