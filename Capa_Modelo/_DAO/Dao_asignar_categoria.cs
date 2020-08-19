using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_asignar_categoria : Dao_crud<Vo_asignar_categoria>
    {
        DataTable LIST_WORKER();
        DataTable LIST_CATEGORY();
        DataTable SEARCH(Vo_asignar_categoria asignar);
    }
}
