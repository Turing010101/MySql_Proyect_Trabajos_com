using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_trabajador : Dao_trabajador
    {
        public M_trabajador m_trabajador;

        public bool CREATE(Vo_trabajador trabajador)
        {
            if (m_trabajador == null)
            {
                m_trabajador = new M_trabajador();
                return m_trabajador.CREATE(trabajador);
            }
            else
            {
                return m_trabajador.CREATE(trabajador);
            }
        }

        public bool DELETE(Vo_trabajador trabajador)
        {
            if (m_trabajador == null)
            {
                m_trabajador = new M_trabajador();
                return m_trabajador.DELETE(trabajador);
            }
            else
            {
                return m_trabajador.DELETE(trabajador);
            }
        }
        public DataTable LIST_PEOPLE()
        {
            if (m_trabajador == null)
            {
                m_trabajador = new M_trabajador();
                return m_trabajador.LIST_PEOPLE();
            }
            else
            {
                return m_trabajador.LIST_PEOPLE();
            }
        }
        public DataTable LIST_OFFICE()
        {
            if (m_trabajador == null)
            {
                m_trabajador = new M_trabajador();
                return m_trabajador.LIST_OFFICE();
            }
            else
            {
                return m_trabajador.LIST_OFFICE();
            }
        }

        public DataTable READ()
        {
            if (m_trabajador == null)
            {
                m_trabajador = new M_trabajador();
                return m_trabajador.READ();
            }
            else
            {
                return m_trabajador.READ();
            }
        }

        public DataTable SEARCH(Vo_trabajador trabajador)
        {
            if (m_trabajador == null)
            {
                m_trabajador = new M_trabajador();
                return m_trabajador.SEARCH(trabajador);
            }
            else
            {
                return m_trabajador.SEARCH(trabajador);
            }
        }

        public bool UPDATE(Vo_trabajador trabajador)
        {
            if (m_trabajador == null)
            {
                m_trabajador = new M_trabajador();
                return m_trabajador.UPDATE(trabajador);
            }
            else
            {
                return m_trabajador.UPDATE(trabajador);
            }
        }
    }
}
