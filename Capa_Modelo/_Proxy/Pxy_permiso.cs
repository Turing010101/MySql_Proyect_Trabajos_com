using Capa_Modelo._DAO;
using Capa_Modelo._VO;

namespace Capa_Modelo._Proxy
{
    public class Pxy_permiso: Dao_permiso
    {
        public M_permiso m_permiso;

        public int[,] FIND(int rol)
        {
            if (m_permiso == null)
            {
                m_permiso = new M_permiso();
                return m_permiso.FIND(rol);
            }
            else
            {
                return m_permiso.FIND(rol);
            }
        }
    }
}
