using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_servicio : Dao_servicio
    {
        public M_servicio m_servicio;

        public bool CREATE(Vo_servicio servicio)
        {
            if (m_servicio == null)
            {
                m_servicio = new M_servicio();
                return m_servicio.CREATE(servicio);
            }
            else
            {
                return m_servicio.CREATE(servicio);
            }
        }

        public bool DELETE(Vo_servicio servicio)
        {
            if (m_servicio == null)
            {
                m_servicio = new M_servicio();
                return m_servicio.DELETE(servicio);
            }
            else
            {
                return m_servicio.DELETE(servicio);
            }
        }
        public DataTable READ()
        {
            if (m_servicio == null)
            {
                m_servicio = new M_servicio();
                return m_servicio.READ();
            }
            else
            {
                return m_servicio.READ();
            }
        }

        public DataTable SEARCH(Vo_servicio servicio)
        {
            if (m_servicio == null)
            {
                m_servicio = new M_servicio();
                return m_servicio.SEARCH(servicio);
            }
            else
            {
                return m_servicio.SEARCH(servicio);
            }
        }

        public bool UPDATE(Vo_servicio servicio)
        {
            if (m_servicio == null)
            {
                m_servicio = new M_servicio();
                return m_servicio.UPDATE(servicio);
            }
            else
            {
                return m_servicio.UPDATE(servicio);
            }
        }
    }
}
