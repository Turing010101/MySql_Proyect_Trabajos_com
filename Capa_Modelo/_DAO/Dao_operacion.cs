using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_operacion : Dao_crud<Vo_operacion>
    {
        DataTable LIST_MODULE();
        DataTable LIST_ACTION();
        DataTable SEARCH(Vo_operacion operacion);
    }
}
