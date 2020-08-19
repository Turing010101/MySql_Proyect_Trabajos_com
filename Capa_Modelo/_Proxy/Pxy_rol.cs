using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_rol:Dao_rol
    {
        public M_rol m_rol;

        public bool CREATE(Vo_rol rol)
        {
            if (m_rol == null)
            {
                m_rol = new M_rol();
                return m_rol.CREATE(rol);
            }
            else
            {
                return m_rol.CREATE(rol);
            }
        }

        public bool DELETE(Vo_rol rol)
        {
            if (m_rol == null)
            {
                m_rol = new M_rol();
                return m_rol.DELETE(rol);
            }
            else
            {
                return m_rol.DELETE(rol);
            }
        }


        public DataTable READ()
        {
            if (m_rol == null)
            {
                m_rol = new M_rol();
                return m_rol.READ();
            }
            else
            {
                return m_rol.READ();
            }
        }

        public DataTable SEARCH(Vo_rol rol)
        {
            if (m_rol == null)
            {
                m_rol = new M_rol();
                return m_rol.SEARCH(rol);
            }
            else
            {
                return m_rol.SEARCH(rol);
            }
        }

        public bool UPDATE(Vo_rol rol)
        {
            if (m_rol == null)
            {
                m_rol = new M_rol();
                return m_rol.UPDATE(rol);
            }
            else
            {
                return m_rol.UPDATE(rol);
            }
        }
    }
}
