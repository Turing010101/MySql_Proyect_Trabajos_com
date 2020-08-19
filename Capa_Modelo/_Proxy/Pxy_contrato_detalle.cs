using Capa_Modelo._DAO;
using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._Proxy
{
    public class Pxy_contrato_detalle : Dao_contrato_detalle
    {
        public M_contrato_detalle m_detalle;

        public bool CREATE(Vo_contrato_detalle contrato)
        {
            if (m_detalle == null)
            {
                m_detalle = new M_contrato_detalle();
                return m_detalle.CREATE(contrato);
            }
            else
            {
                return m_detalle.CREATE(contrato);
            }
        }
        public bool DELETE(Vo_contrato_detalle contrato)
        {
            if (m_detalle == null)
            {
                m_detalle = new M_contrato_detalle();
                return m_detalle.DELETE(contrato);
            }
            else
            {
                return m_detalle.DELETE(contrato);
            }
        }
        public DataTable READ()
        {
            if (m_detalle == null)
            {
                m_detalle = new M_contrato_detalle();
                return m_detalle.READ();
            }
            else
            {
                return m_detalle.READ();
            }
        }
        public double SELECT_SUBTOTAL(Vo_contrato_detalle contrato)
        {
            if (m_detalle == null)
            {
                m_detalle = new M_contrato_detalle();
                return m_detalle.SELECT_SUBTOTAL(contrato);
            }
            else
            {
                return m_detalle.SELECT_SUBTOTAL(contrato);
            }
        }
        public DataTable SEARCH(Vo_contrato_detalle contrato)
        {
            if (m_detalle == null)
            {
                m_detalle = new M_contrato_detalle();
                return m_detalle.SEARCH(contrato);
            }
            else
            {
                return m_detalle.SEARCH(contrato);
            }
        }
        public DataTable READ_FACTURA(Vo_contrato_detalle contrato)
        {
            if (m_detalle == null)
            {
                m_detalle = new M_contrato_detalle();
                return m_detalle.READ_FACTURA(contrato);
            }
            else
            {
                return m_detalle.READ_FACTURA(contrato);
            }
        }
        public DataSet REPORT(Vo_contrato_detalle contrato)
        {
            if (m_detalle == null)
            {
                m_detalle = new M_contrato_detalle();
                return m_detalle.REPORT(contrato);
            }
            else
            {
                return m_detalle.REPORT(contrato);
            }
        }
        public bool UPDATE(Vo_contrato_detalle contrato)
        {
            if (m_detalle == null)
            {
                m_detalle = new M_contrato_detalle();
                return m_detalle.UPDATE(contrato);
            }
            else
            {
                return m_detalle.UPDATE(contrato);
            }
        }
    }
}
