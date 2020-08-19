using Capa_Modelo._VO;
using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_cliente : Dao_crud<Vo_cliente>
    {
        DataTable LIST_PEOPLE();
        DataTable SEARCH(Vo_cliente cliente);
    }
}
