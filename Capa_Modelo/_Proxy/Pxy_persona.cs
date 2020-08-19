using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_persona : Dao_persona
    {
        public M_persona m_persona;

        public bool CREATE(Vo_persona persona)
        {
            if (m_persona == null)
            {
                m_persona = new M_persona();
                return m_persona.CREATE(persona);
            }
            else
            {
                return m_persona.CREATE(persona);
            }
        }

        public bool DELETE(Vo_persona persona)
        {
            if (m_persona == null)
            {
                m_persona = new M_persona();
                return m_persona.DELETE(persona);
            }
            else
            {
                return m_persona.DELETE(persona);
            }
        }

        public DataTable LIST_ROLE()
        {
            if (m_persona == null)
            {
                m_persona = new M_persona();
                return m_persona.LIST_ROLE();
            }
            else
            {
                return m_persona.LIST_ROLE();
            }
        }

        public DataTable READ()
        {
            if (m_persona == null)
            {
                m_persona = new M_persona();
                return m_persona.READ();
            }
            else
            {
                return m_persona.READ();
            }
        }

        public DataTable SEARCH(Vo_persona persona)
        {
            if (m_persona == null)
            {
                m_persona = new M_persona();
                return m_persona.SEARCH(persona);
            }
            else
            {
                return m_persona.SEARCH(persona);
            }
        }

        public bool UPDATE(Vo_persona persona)
        {
            if (m_persona == null)
            {
                m_persona = new M_persona();
                return m_persona.UPDATE(persona);
            }
            else
            {
                return m_persona.UPDATE(persona);
            }
        }
        public bool ESTABLISH(Vo_persona persona)
        {
            if (m_persona == null)
            {
                m_persona = new M_persona();
                return m_persona.ESTABLISH(persona);
            }
            else
            {
                return m_persona.ESTABLISH(persona);
            }
        }
    }
}
