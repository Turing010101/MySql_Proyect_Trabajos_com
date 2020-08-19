using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_rol:Dao_crud<Vo_rol>
    {
        DataTable SEARCH(Vo_rol rol);
    }
}
