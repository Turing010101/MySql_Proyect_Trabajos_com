using Capa_Modelo._Visitor;
using System;
using System.Collections.Generic;

namespace Capa_Modelo._VO
{
    public class Vo_empleado
    {
        int clave;
        string rfc_persona;
        string rfc_jefe;
        object puesto;
        object turno;
        object sucursal;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public string Rfc_persona { get => rfc_persona; set => rfc_persona = value; }
        public string Rfc_jefe { get => rfc_jefe; set => rfc_jefe = value; }
        public object Puesto { get => puesto; set => puesto = value; }
        public object Turno { get => turno; set => turno = value; }
        public object Sucursal { get => sucursal; set => sucursal = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }

    }
}
