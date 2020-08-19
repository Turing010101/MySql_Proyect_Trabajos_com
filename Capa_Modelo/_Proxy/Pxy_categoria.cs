using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_categoria: Dao_categoria
    {
        public M_categoria m_categoria;

        public bool CREATE(Vo_categoria categoria)
        {
            if (m_categoria == null)
            {
                m_categoria = new M_categoria();
                return m_categoria.CREATE(categoria);
            }
            else
            {
                return m_categoria.CREATE(categoria);
            }
        }

        public bool DELETE(Vo_categoria categoria)
        {
            if (m_categoria == null)
            {
                m_categoria = new M_categoria();
                return m_categoria.DELETE(categoria);
            }
            else
            {
                return m_categoria.DELETE(categoria);
            }
        }


        public DataTable READ()
        {
            if (m_categoria == null)
            {
                m_categoria = new M_categoria();
                return m_categoria.READ();
            }
            else
            {
                return m_categoria.READ();
            }
        }

        public DataTable SEARCH(Vo_categoria categoria)
        {
            if (m_categoria == null)
            {
                m_categoria = new M_categoria();
                return m_categoria.SEARCH(categoria);
            }
            else
            {
                return m_categoria.SEARCH(categoria);
            }
        }

        public bool UPDATE(Vo_categoria categoria)
        {
            if (m_categoria == null)
            {
                m_categoria = new M_categoria();
                return m_categoria.UPDATE(categoria);
            }
            else
            {
                return m_categoria.UPDATE(categoria);
            }
        }
    }
}
