using System.Collections.Generic;

namespace Capa_Modelo._Visitor
{
    public interface Vst_validator<T>
    {
            bool IsValid(T entity);
            IEnumerable<string> BrokenRules(T entity);
    }
}
