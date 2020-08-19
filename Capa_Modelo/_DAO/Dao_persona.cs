using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_persona:Dao_crud<Vo_persona>
    {
        DataTable LIST_ROLE();
        DataTable SEARCH(Vo_persona persona);
        bool ESTABLISH(Vo_persona persona);
    }
}
