using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_empleado : Dao_empleado
    {
        public M_empleado m_empleado;

        public bool CREATE(Vo_empleado empleado)
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.CREATE(empleado);
            }
            else
            {
                return m_empleado.CREATE(empleado);
            }
        }

        public bool DELETE(Vo_empleado empleado)
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.DELETE(empleado);
            }
            else
            {
                return m_empleado.DELETE(empleado);
            }
        }
        public DataTable LIST_PEOPLE()
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.LIST_PEOPLE();
            }
            else
            {
                return m_empleado.LIST_PEOPLE();
            }
        }
        public DataTable LIST_OFFICE()
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.LIST_OFFICE();
            }
            else
            {
                return m_empleado.LIST_OFFICE();
            }
        }
        public DataTable LIST_POST()
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.LIST_POST();
            }
            else
            {
                return m_empleado.LIST_POST();
            }
        }
        public DataTable LIST_TURN()
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.LIST_TURN();
            }
            else
            {
                return m_empleado.LIST_TURN();
            }
        }

        public DataTable READ()
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.READ();
            }
            else
            {
                return m_empleado.READ();
            }
        }

        public DataTable SEARCH(Vo_empleado empleado)
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.SEARCH(empleado);
            }
            else
            {
                return m_empleado.SEARCH(empleado);
            }
        }

        public bool UPDATE(Vo_empleado empleado)
        {
            if (m_empleado == null)
            {
                m_empleado = new M_empleado();
                return m_empleado.UPDATE(empleado);
            }
            else
            {
                return m_empleado.UPDATE(empleado);
            }
        }
    }
}
