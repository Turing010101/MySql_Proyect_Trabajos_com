using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_empleado : Dao_crud<Vo_empleado>
    {
        DataTable LIST_POST();
        DataTable LIST_OFFICE();
        DataTable LIST_TURN();
        DataTable LIST_PEOPLE();
        DataTable SEARCH(Vo_empleado empleado);
    }
}
