using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_sucursal : Dao_crud<Vo_sucursal>
    {
        DataTable SEARCH(Vo_sucursal sucursal);
    }
}
