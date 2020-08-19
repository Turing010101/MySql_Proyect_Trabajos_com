using Capa_Modelo._Visitor;
using System;
using System.Collections.Generic;

namespace Capa_Modelo._VO
{
    public class Vo_trabajador
    {
        int clave;
        string persona;
        string rfc;
        object sucursal;
        string estado;
        int calificacion;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public string Persona { get => persona; set => persona = value; }
        public object Sucursal { get => sucursal; set => sucursal = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
        public string Rfc { get => rfc; set => rfc = value; }
    }
}

