using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_evaluar_trabajador : Dao_evaluar_trabajador
    {
        public M_evaluar_trabajador m_evaluar_trabajador;

        public bool CREATE(Vo_evaluar_trabajador evaluar)
        {
            if (m_evaluar_trabajador == null)
            {
                m_evaluar_trabajador = new M_evaluar_trabajador();
                return m_evaluar_trabajador.CREATE(evaluar);
            }
            else
            {
                return m_evaluar_trabajador.CREATE(evaluar);
            }
        }

        public bool DELETE(Vo_evaluar_trabajador evaluar)
        {
            if (m_evaluar_trabajador == null)
            {
                m_evaluar_trabajador = new M_evaluar_trabajador();
                return m_evaluar_trabajador.DELETE(evaluar);
            }
            else
            {
                return m_evaluar_trabajador.DELETE(evaluar);
            }
        }
        public DataTable LIST_DOCUMENT()
        {
            if (m_evaluar_trabajador == null)
            {
                m_evaluar_trabajador = new M_evaluar_trabajador();
                return m_evaluar_trabajador.LIST_DOCUMENT();
            }
            else
            {
                return m_evaluar_trabajador.LIST_DOCUMENT();
            }
        }
        public DataTable READ()
        {
            if (m_evaluar_trabajador == null)
            {
                m_evaluar_trabajador = new M_evaluar_trabajador();
                return m_evaluar_trabajador.READ();
            }
            else
            {
                return m_evaluar_trabajador.READ();
            }
        }
        public DataTable SEARCH(Vo_evaluar_trabajador evaluar)
        {
            if (m_evaluar_trabajador == null)
            {
                m_evaluar_trabajador = new M_evaluar_trabajador();
                return m_evaluar_trabajador.SEARCH(evaluar);
            }
            else
            {
                return m_evaluar_trabajador.SEARCH(evaluar);
            }
        }
        public bool UPDATE(Vo_evaluar_trabajador evaluar)
        {
            if (m_evaluar_trabajador == null)
            {
                m_evaluar_trabajador = new M_evaluar_trabajador();
                return m_evaluar_trabajador.UPDATE(evaluar);
            }
            else
            {
                return m_evaluar_trabajador.UPDATE(evaluar);
            }
        }
    }
}
