using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_trabajador : Dao_crud<Vo_trabajador>
    {
        DataTable LIST_OFFICE();
        DataTable LIST_PEOPLE();
        DataTable SEARCH(Vo_trabajador trabajador);
    }
}
