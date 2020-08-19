using Capa_Modelo._VO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Capa_Modelo._Visitor
{
    public class Vst_persona : Vst_validator<Vo_persona>
    {

        public bool IsValid(Vo_persona persona)
        {
            return BrokenRules(persona).Count() > 0;
        }
        public IEnumerable<string> BrokenRules(Vo_persona persona)
        {
            if (persona.Visible)
            {
                if (!Regex.IsMatch(persona.Usuario, @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$"))
                    yield return "Error : Usuario debil. ";

                if (!Regex.IsMatch(persona.Contrasena, @"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{10,20}$"))
                    yield return "Error : Contrseña debil. ";
            }

            if (!Regex.IsMatch(persona.Rfc, "^[A-Z,Ñ,&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?$"))
                yield return "Error RFC: formato incorrecto. ";

            if (!Regex.IsMatch(persona.Correo_electronico, @"\A(\w+\.?\w*\@\w+\.)(com)\Z"))
                yield return "Error Gmail: formato incorrecto. ";

            if (!Regex.IsMatch(persona.Telefono_personal, @"^[2-9]{2}[0-9]{8}$"))
                yield return "Error teléfono personal: formato incorrecto. ";

            if (!Regex.IsMatch(persona.Telefono_periente, @"^[2-9]{2}[0-9]{8}$"))
                yield return "Error teléfono pariente: formato incorrecto. ";

            if (!Regex.IsMatch(persona.Codigo_postal, @"^[0-9]{5}$"))
                yield return "Error código postal: formato incorrecto. ";
                 
            yield break;
        }
    }
}
