using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_accion : Dao_accion
    {
        public M_accion m_accion;

        public bool CREATE(Vo_accion accion)
        {
            if (m_accion == null)
            {
                m_accion = new M_accion();
                return m_accion.CREATE(accion);
            }
            else
            {
                return m_accion.CREATE(accion);
            }
        }

        public bool DELETE(Vo_accion accion)
        {
            if (m_accion == null)
            {
                m_accion = new M_accion();
                return m_accion.DELETE(accion);
            }
            else
            {
                return m_accion.DELETE(accion);
            }
        }
        public DataTable READ()
        {
            if (m_accion == null)
            {
                m_accion = new M_accion();
                return m_accion.READ();
            }
            else
            {
                return m_accion.READ();
            }
        }

        public DataTable SEARCH(Vo_accion accion)
        {
            if (m_accion == null)
            {
                m_accion = new M_accion();
                return m_accion.SEARCH(accion);
            }
            else
            {
                return m_accion.SEARCH(accion);
            }
        }

        public bool UPDATE(Vo_accion accion)
        {
            if (m_accion == null)
            {
                m_accion = new M_accion();
                return m_accion.UPDATE(accion);
            }
            else
            {
                return m_accion.UPDATE(accion);
            }
        }
    }
}
