using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_modulo : Dao_crud<Vo_modulo>
    {
        DataTable SEARCH(Vo_modulo modulo);
    }
}
