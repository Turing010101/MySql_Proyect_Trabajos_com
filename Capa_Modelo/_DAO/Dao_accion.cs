using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_accion : Dao_crud<Vo_accion>
    {
        DataTable SEARCH(Vo_accion accion);
    }
}
