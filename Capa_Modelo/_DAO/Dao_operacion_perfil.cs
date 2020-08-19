using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_operacion_perfil : Dao_crud<Vo_operacion_perfil>
    {
        DataTable LIST_ROLE();
        DataTable LIST_OPERATION();
        DataTable SEARCH(Vo_operacion_perfil operacion);
    }
}
