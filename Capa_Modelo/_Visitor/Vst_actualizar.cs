using Capa_Modelo._VO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Capa_Modelo._Visitor
{
    public class Vst_actualizar : Vst_validator<Vo_actualizar>
    {

        public bool IsValid(Vo_actualizar update)
        {
            return BrokenRules(update).Count() > 0;
        }
        public IEnumerable<string> BrokenRules(Vo_actualizar modificar)
        {

            if (!Regex.IsMatch(modificar.Contrasena_nueva, @"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{10,20}$"))
                yield return "Error : Contrseña debil. ";

            if (!Regex.IsMatch(modificar.Confirmar, @"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{10,20}$"))
                yield return "Error : Confirmación debil. ";
               
            yield break;
        }
    }
}
