using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_categoria:Dao_crud<Vo_categoria>
    {
        DataTable SEARCH(Vo_categoria categoria);
    }
}
