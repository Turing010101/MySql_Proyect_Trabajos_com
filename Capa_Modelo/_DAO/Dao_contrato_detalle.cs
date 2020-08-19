using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_contrato_detalle : Dao_crud<Vo_contrato_detalle>
    {
        DataTable SEARCH(Vo_contrato_detalle factura);
        DataTable READ_FACTURA(Vo_contrato_detalle factura);
        double SELECT_SUBTOTAL(Vo_contrato_detalle factura);
        DataSet REPORT(Vo_contrato_detalle factura);
    }
}
