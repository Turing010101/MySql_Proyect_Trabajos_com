using Capa_Modelo._Visitor;
using System;
using System.Collections.Generic;

namespace Capa_Modelo._VO
{
    public class Vo_cliente
    {
        int clave;
        string rfc_persona;
        int rating;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public string Rfc_persona { get => rfc_persona; set => rfc_persona = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
    }
}
