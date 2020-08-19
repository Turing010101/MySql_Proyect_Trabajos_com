using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_modulo : Dao_modulo
    {
        public M_modulo m_modulo;

        public bool CREATE(Vo_modulo modulo)
        {
            if (m_modulo == null)
            {
                m_modulo = new M_modulo();
                return m_modulo.CREATE(modulo);
            }
            else
            {
                return m_modulo.CREATE(modulo);
            }
        }

        public bool DELETE(Vo_modulo modulo)
        {
            if (m_modulo == null)
            {
                m_modulo = new M_modulo();
                return m_modulo.DELETE(modulo);
            }
            else
            {
                return m_modulo.DELETE(modulo);
            }
        }


        public DataTable READ()
        {
            if (m_modulo == null)
            {
                m_modulo = new M_modulo();
                return m_modulo.READ();
            }
            else
            {
                return m_modulo.READ();
            }
        }

        public DataTable SEARCH(Vo_modulo modulo)
        {
            if (m_modulo == null)
            {
                m_modulo = new M_modulo();
                return m_modulo.SEARCH(modulo);
            }
            else
            {
                return m_modulo.SEARCH(modulo);
            }
        }

        public bool UPDATE(Vo_modulo modulo)
        {
            if (m_modulo == null)
            {
                m_modulo = new M_modulo();
                return m_modulo.UPDATE(modulo);
            }
            else
            {
                return m_modulo.UPDATE(modulo);
            }
        }
    }
}
