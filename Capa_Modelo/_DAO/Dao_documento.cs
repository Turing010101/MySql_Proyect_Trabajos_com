using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_documento : Dao_crud<Vo_documento>
    {
        DataTable SEARCH(Vo_documento documento);
    }
}
