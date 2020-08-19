using Capa_Modelo._Visitor;
using System;
using System.Collections.Generic;

namespace Capa_Modelo._VO
{
    public class Vo_asignar_categoria 
    {
        int clave;
        object trabajador;
        object categoria;
        string estado;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public object Trabajador { get => trabajador; set => trabajador = value; }
        public object Categoria { get => categoria; set => categoria = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
    }
}
