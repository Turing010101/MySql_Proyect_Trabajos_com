using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_asignar_categoria : Dao_asignar_categoria
    {
        public M_asignar_categoria m_asignar_categoria;

        public bool CREATE(Vo_asignar_categoria asignar)
        {
            if (m_asignar_categoria == null)
            {
                m_asignar_categoria = new M_asignar_categoria();
                return m_asignar_categoria.CREATE(asignar);
            }
            else
            {
                return m_asignar_categoria.CREATE(asignar);
            }
        }

        public bool DELETE(Vo_asignar_categoria asignar)
        {
            if (m_asignar_categoria == null)
            {
                m_asignar_categoria = new M_asignar_categoria();
                return m_asignar_categoria.DELETE(asignar);
            }
            else
            {
                return m_asignar_categoria.DELETE(asignar);
            }
        }
        public DataTable LIST_WORKER()
        {
            if (m_asignar_categoria == null)
            {
                m_asignar_categoria = new M_asignar_categoria();
                return m_asignar_categoria.LIST_WORKER();
            }
            else
            {
                return m_asignar_categoria.LIST_WORKER();
            }
        }
        public DataTable LIST_CATEGORY()
        {
            if (m_asignar_categoria == null)
            {
                m_asignar_categoria = new M_asignar_categoria();
                return m_asignar_categoria.LIST_CATEGORY();
            }
            else
            {
                return m_asignar_categoria.LIST_CATEGORY();
            }
        }
        public DataTable READ()
        {
            if (m_asignar_categoria == null)
            {
                m_asignar_categoria = new M_asignar_categoria();
                return m_asignar_categoria.READ();
            }
            else
            {
                return m_asignar_categoria.READ();
            }
        }
        public DataTable SEARCH(Vo_asignar_categoria asignar)
        {
            if (m_asignar_categoria == null)
            {
                m_asignar_categoria = new M_asignar_categoria();
                return m_asignar_categoria.SEARCH(asignar);
            }
            else
            {
                return m_asignar_categoria.SEARCH(asignar);
            }
        }
        public bool UPDATE(Vo_asignar_categoria asignar)
        {
            if (m_asignar_categoria == null)
            {
                m_asignar_categoria = new M_asignar_categoria();
                return m_asignar_categoria.UPDATE(asignar);
            }
            else
            {
                return m_asignar_categoria.UPDATE(asignar);
            }
        }
    }
}
