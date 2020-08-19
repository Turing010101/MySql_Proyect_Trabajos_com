using System.Collections.Generic;
using Capa_Modelo._Visitor;

namespace Capa_Modelo._VO
{
    public class Vo_modificar: Vst_validatable<Vo_modificar>
    {
        string usuario_email;
        string codigo;
        string contrasena;
        string confirmar;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Confirmar { get => confirmar; set => confirmar = value; }
        public string Usuario_email { get => usuario_email; set => usuario_email = value; }

        public bool validate(Vst_validator<Vo_modificar> validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            return validator.IsValid(this);
        }
    }
}
