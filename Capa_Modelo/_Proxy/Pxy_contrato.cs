using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_contrato : Dao_contrato
    {
        public M_contrato m_contrato;

        public bool CREATE(Vo_contrato contrato)
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.CREATE(contrato);
            }
            else
            {
                return m_contrato.CREATE(contrato);
            }
        }
        public bool DELETE(Vo_contrato contrato)
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.DELETE(contrato);
            }
            else
            {
                return m_contrato.DELETE(contrato);
            }
        }
        public DataSet REPORT(Vo_contrato contrato)
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.REPORT(contrato);
            }
            else
            {
                return m_contrato.REPORT(contrato);
            }
        }
        public int SELECT_HIGHER()
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.SELECT_HIGHER();
            }
            else
            {
                return m_contrato.SELECT_HIGHER();
            }
        }
        public DataTable LIST_COMMISSION()
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.LIST_COMMISSION();
            }
            else
            {
                return m_contrato.LIST_COMMISSION();
            }
        }
        public DataTable LIST_PAY()
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.LIST_PAY();
            }
            else
            {
                return m_contrato.LIST_PAY();
            }
        }
        public DataTable READ()
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.READ();
            }
            else
            {
                return m_contrato.READ();
            }
        }

        public DataTable SEARCH(Vo_contrato contrato)
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.SEARCH(contrato);
            }
            else
            {
                return m_contrato.SEARCH(contrato);
            }
        }

        public bool UPDATE(Vo_contrato contrato)
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.UPDATE(contrato);
            }
            else
            {
                return m_contrato.UPDATE(contrato);
            }
        }
        public bool PAY_CONTRACT(Vo_contrato contrato)
        {
            if (m_contrato == null)
            {
                m_contrato = new M_contrato();
                return m_contrato.PAY_CONTRACT(contrato);
            }
            else
            {
                return m_contrato.PAY_CONTRACT(contrato);
            }
        }
    }
}
