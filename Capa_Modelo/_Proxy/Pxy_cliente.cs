using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_cliente : Dao_cliente
    {
        public M_cliente m_cliente;

        public bool CREATE(Vo_cliente cliente)
        {
            if (m_cliente == null)
            {
                m_cliente = new M_cliente();
                return m_cliente.CREATE(cliente);
            }
            else
            {
                return m_cliente.CREATE(cliente);
            }
        }

        public bool DELETE(Vo_cliente cliente)
        {
            if (m_cliente == null)
            {
                m_cliente = new M_cliente();
                return m_cliente.DELETE(cliente);
            }
            else
            {
                return m_cliente.DELETE(cliente);
            }
        }
        public DataTable LIST_PEOPLE()
        {
            if (m_cliente == null)
            {
                m_cliente = new M_cliente();
                return m_cliente.LIST_PEOPLE();
            }
            else
            {
                return m_cliente.LIST_PEOPLE();
            }
        }
        public DataTable READ()
        {
            if (m_cliente == null)
            {
                m_cliente = new M_cliente();
                return m_cliente.READ();
            }
            else
            {
                return m_cliente.READ();
            }
        }

        public DataTable SEARCH(Vo_cliente cliente)
        {
            if (m_cliente == null)
            {
                m_cliente = new M_cliente();
                return m_cliente.SEARCH(cliente);
            }
            else
            {
                return m_cliente.SEARCH(cliente);
            }
        }

        public bool UPDATE(Vo_cliente cliente)
        {
            if (m_cliente == null)
            {
                m_cliente = new M_cliente();
                return m_cliente.UPDATE(cliente);
            }
            else
            {
                return m_cliente.UPDATE(cliente);
            }
        }
    }
}
