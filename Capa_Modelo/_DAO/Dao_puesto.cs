using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_puesto : Dao_crud<Vo_puesto>
    {
        DataTable SEARCH(Vo_puesto puesto);
    }
}
