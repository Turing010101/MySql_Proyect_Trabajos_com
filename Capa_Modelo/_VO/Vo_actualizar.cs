using System.Collections.Generic;
using Capa_Modelo._Visitor;

namespace Capa_Modelo._VO
{
    public class Vo_actualizar : Vst_validatable<Vo_actualizar>
    {

        int clave;
        string contrasena_actual;
        string contrasena_nueva;
        string confirmar;

        public int Clave { get => clave; set => clave = value; }
        public string Contrasena_actual { get => contrasena_actual; set => contrasena_actual = value; }
        public string Contrasena_nueva { get => contrasena_nueva; set => contrasena_nueva = value; }
        public string Confirmar { get => confirmar; set => confirmar = value; }

        public bool validate(Vst_validator<Vo_actualizar> validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            return validator.IsValid(this);
        }
    }
}
