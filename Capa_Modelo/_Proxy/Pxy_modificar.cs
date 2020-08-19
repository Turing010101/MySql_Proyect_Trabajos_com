using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_modificar : Dao_modificar
    {
        public M_modificar m_modificar;

        public bool UPDATE(Vo_modificar modificar)
        {
            if (m_modificar == null)
            {
                m_modificar = new M_modificar();
                return m_modificar.UPDATE(modificar);
            }
            else
            {
                return m_modificar.UPDATE(modificar);
            }
        }
    }
}
