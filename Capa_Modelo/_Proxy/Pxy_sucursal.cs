using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_sucursal : Dao_sucursal
    {
        public M_sucursal m_sucrsal;

        public bool CREATE(Vo_sucursal sucursal)
        {
            if (m_sucrsal == null)
            {
                m_sucrsal = new M_sucursal();
                return m_sucrsal.CREATE(sucursal);
            }
            else
            {
                return m_sucrsal.CREATE(sucursal);
            }
        }

        public bool DELETE(Vo_sucursal sucursal)
        {
            if (m_sucrsal == null)
            {
                m_sucrsal = new M_sucursal();
                return m_sucrsal.DELETE(sucursal);
            }
            else
            {
                return m_sucrsal.DELETE(sucursal);
            }
        }


        public DataTable READ()
        {
            if (m_sucrsal == null)
            {
                m_sucrsal = new M_sucursal();
                return m_sucrsal.READ();
            }
            else
            {
                return m_sucrsal.READ();
            }
        }

        public DataTable SEARCH(Vo_sucursal sucursal)
        {
            if (m_sucrsal == null)
            {
                m_sucrsal = new M_sucursal();
                return m_sucrsal.SEARCH(sucursal);
            }
            else
            {
                return m_sucrsal.SEARCH(sucursal);
            }
        }

        public bool UPDATE(Vo_sucursal sucursal)
        {
            if (m_sucrsal == null)
            {
                m_sucrsal = new M_sucursal();
                return m_sucrsal.UPDATE(sucursal);
            }
            else
            {
                return m_sucrsal.UPDATE(sucursal);
            }
        }
    }
}
