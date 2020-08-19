using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_operacion_perfil : Dao_operacion_perfil
    {
        public M_operacion_perfil m_operacion_perfil;

        public bool CREATE(Vo_operacion_perfil operacion)
        {
            if (m_operacion_perfil == null)
            {
                m_operacion_perfil = new M_operacion_perfil();
                return m_operacion_perfil.CREATE(operacion);
            }
            else
            {
                return m_operacion_perfil.CREATE(operacion);
            }
        }

        public bool DELETE(Vo_operacion_perfil operacion)
        {
            if (m_operacion_perfil == null)
            {
                m_operacion_perfil = new M_operacion_perfil();
                return m_operacion_perfil.DELETE(operacion);
            }
            else
            {
                return m_operacion_perfil.DELETE(operacion);
            }
        }
        public DataTable LIST_ROLE()
        {
            if (m_operacion_perfil == null)
            {
                m_operacion_perfil = new M_operacion_perfil();
                return m_operacion_perfil.LIST_ROLE();
            }
            else
            {
                return m_operacion_perfil.LIST_ROLE();
            }
        }
        public DataTable LIST_OPERATION()
        {
            if (m_operacion_perfil == null)
            {
                m_operacion_perfil = new M_operacion_perfil();
                return m_operacion_perfil.LIST_OPERATION();
            }
            else
            {
                return m_operacion_perfil.LIST_OPERATION();
            }
        }
        public DataTable READ()
        {
            if (m_operacion_perfil == null)
            {
                m_operacion_perfil = new M_operacion_perfil();
                return m_operacion_perfil.READ();
            }
            else
            {
                return m_operacion_perfil.READ();
            }
        }
        public DataTable SEARCH(Vo_operacion_perfil operacion)
        {
            if (m_operacion_perfil == null)
            {
                m_operacion_perfil = new M_operacion_perfil();
                return m_operacion_perfil.SEARCH(operacion);
            }
            else
            {
                return m_operacion_perfil.SEARCH(operacion);
            }
        }
        public bool UPDATE(Vo_operacion_perfil operacion)
        {
            if (m_operacion_perfil == null)
            {
                m_operacion_perfil = new M_operacion_perfil();
                return m_operacion_perfil.UPDATE(operacion);
            }
            else
            {
                return m_operacion_perfil.UPDATE(operacion);
            }
        }
    }
}
