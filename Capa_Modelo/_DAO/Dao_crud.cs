using System.Data;

namespace Capa_Modelo._DAO
{
    public interface Dao_crud<T>
    {
        DataTable READ();
        bool CREATE(T objeto);
        bool UPDATE(T objeto);
        bool DELETE(T objeto);
    }
}
