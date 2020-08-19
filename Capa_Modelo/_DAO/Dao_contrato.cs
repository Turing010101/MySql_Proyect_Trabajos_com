using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_contrato : Dao_crud<Vo_contrato>
    {
        DataTable SEARCH(Vo_contrato contrato);
        DataTable LIST_COMMISSION();
        DataTable LIST_PAY();
        int SELECT_HIGHER();
        bool PAY_CONTRACT(Vo_contrato contrato);
        DataSet REPORT(Vo_contrato contrato);
    }
}
