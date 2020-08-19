using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_actualizar : Dao_actualizar
    {
        public M_actualizar m_actualizar;

        public bool UPDATE(Vo_actualizar modificar)
        {
            if (m_actualizar == null)
            {
                m_actualizar = new M_actualizar();
                return m_actualizar.UPDATE(modificar);
            }
            else
            {
                return m_actualizar.UPDATE(modificar);
            }
        }
    }
}
