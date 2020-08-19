using Capa_Modelo._VO;
using System;

namespace Capa_Modelo._DAO
{
    public interface Dao_verificar
    {

        Vo_gmail E_MAIL(Vo_verificar verificar);
        Vo_perfil PERFIL(Vo_verificar verificar);
        bool FIND (Vo_verificar verificar);
    }
}
