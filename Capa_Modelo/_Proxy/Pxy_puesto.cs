using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_puesto : Dao_puesto
    {
        public M_puesto m_puesto;

        public bool CREATE(Vo_puesto puesto)
        {
            if (m_puesto == null)
            {
                m_puesto = new M_puesto();
                return m_puesto.CREATE(puesto);
            }
            else
            {
                return m_puesto.CREATE(puesto);
            }
        }

        public bool DELETE(Vo_puesto puesto)
        {
            if (m_puesto == null)
            {
                m_puesto = new M_puesto();
                return m_puesto.DELETE(puesto);
            }
            else
            {
                return m_puesto.DELETE(puesto);
            }
        }


        public DataTable READ()
        {
            if (m_puesto == null)
            {
                m_puesto = new M_puesto();
                return m_puesto.READ();
            }
            else
            {
                return m_puesto.READ();
            }
        }

        public DataTable SEARCH(Vo_puesto puesto)
        {
            if (m_puesto == null)
            {
                m_puesto = new M_puesto();
                return m_puesto.SEARCH(puesto);
            }
            else
            {
                return m_puesto.SEARCH(puesto);
            }
        }

        public bool UPDATE(Vo_puesto puesto)
        {
            if (m_puesto == null)
            {
                m_puesto = new M_puesto();
                return m_puesto.UPDATE(puesto);
            }
            else
            {
                return m_puesto.UPDATE(puesto);
            }
        }
    }
}
