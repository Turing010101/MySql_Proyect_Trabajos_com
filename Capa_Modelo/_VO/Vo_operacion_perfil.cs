using Capa_Modelo._Visitor;
using System;
using System.Collections.Generic;

namespace Capa_Modelo._VO
{
    public class Vo_operacion_perfil
    {
        int clave;
        object rol;
        object accion;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public object Rol { get => rol; set => rol = value; }
        public object Accion { get => accion; set => accion = value; }
    }
}
