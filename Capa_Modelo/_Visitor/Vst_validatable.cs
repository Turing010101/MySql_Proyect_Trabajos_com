using System.Collections.Generic;

namespace Capa_Modelo._Visitor
{
    interface Vst_validatable<T>
    {
        bool validate(Vst_validator<T> validator, out IEnumerable<string> brokenRules);
    }
}
