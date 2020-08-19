using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
   public interface Dao_servicio : Dao_crud<Vo_servicio>
    {
        DataTable SEARCH(Vo_servicio servicio);
    }
}
