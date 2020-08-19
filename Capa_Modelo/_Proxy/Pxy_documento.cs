using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_documento : Dao_documento
    {
        public M_documento m_documento;

        public bool CREATE(Vo_documento documento)
        {
            if (m_documento == null)
            {
                m_documento = new M_documento();
                return m_documento.CREATE(documento);
            }
            else
            {
                return m_documento.CREATE(documento);
            }
        }

        public bool DELETE(Vo_documento documento)
        {
            if (m_documento == null)
            {
                m_documento = new M_documento();
                return m_documento.DELETE(documento);
            }
            else
            {
                return m_documento.DELETE(documento);
            }
        }

        public DataTable READ()
        {
            if (m_documento == null)
            {
                m_documento = new M_documento();
                return m_documento.READ();
            }
            else
            {
                return m_documento.READ();
            }
        }

        public DataTable SEARCH(Vo_documento documento)
        {
            if (m_documento == null)
            {
                m_documento = new M_documento();
                return m_documento.SEARCH(documento);
            }
            else
            {
                return m_documento.SEARCH(documento);
            }
        }

        public bool UPDATE(Vo_documento documento)
        {
            if (m_documento == null)
            {
                m_documento = new M_documento();
                return m_documento.UPDATE(documento);
            }
            else
            {
                return m_documento.UPDATE(documento);
            }
        }
    }
}
