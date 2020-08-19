using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_operacion : Dao_operacion
    {
        public M_operacion m_operacion;

        public bool CREATE(Vo_operacion operacion)
        {
            if (m_operacion == null)
            {
                m_operacion = new M_operacion();
                return m_operacion.CREATE(operacion);
            }
            else
            {
                return m_operacion.CREATE(operacion);
            }
        }

        public bool DELETE(Vo_operacion operacion)
        {
            if (m_operacion == null)
            {
                m_operacion = new M_operacion();
                return m_operacion.DELETE(operacion);
            }
            else
            {
                return m_operacion.DELETE(operacion);
            }
        }
        public DataTable LIST_MODULE()
        {
            if (m_operacion == null)
            {
                m_operacion = new M_operacion();
                return m_operacion.LIST_MODULE();
            }
            else
            {
                return m_operacion.LIST_MODULE();
            }
        }
        public DataTable LIST_ACTION()
        {
            if (m_operacion == null)
            {
                m_operacion = new M_operacion();
                return m_operacion.LIST_ACTION();
            }
            else
            {
                return m_operacion.LIST_ACTION();
            }
        }
        public DataTable READ()
        {
            if (m_operacion == null)
            {
                m_operacion = new M_operacion();
                return m_operacion.READ();
            }
            else
            {
                return m_operacion.READ();
            }
        }
        public DataTable SEARCH(Vo_operacion operacion)
        {
            if (m_operacion == null)
            {
                m_operacion = new M_operacion();
                return m_operacion.SEARCH(operacion);
            }
            else
            {
                return m_operacion.SEARCH(operacion);
            }
        }
        public bool UPDATE(Vo_operacion operacion)
        {
            if (m_operacion == null)
            {
                m_operacion = new M_operacion();
                return m_operacion.UPDATE(operacion);
            }
            else
            {
                return m_operacion.UPDATE(operacion);
            }
        }
    }
}
