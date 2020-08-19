using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_evaluar_trabajador : Dao_crud<Vo_evaluar_trabajador>
    {
        DataTable LIST_DOCUMENT();
        DataTable SEARCH(Vo_evaluar_trabajador evaluar);
    }
}
