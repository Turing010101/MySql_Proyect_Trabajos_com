using Capa_Modelo._Visitor;
using System;
using System.Collections.Generic;

namespace Capa_Modelo._VO
{
    public class Vo_evaluar_trabajador
    {
        int clave;
        string trabajador;
        int documento;
        string estado;
        string observaciones;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int Documento { get => documento; set => documento = value; }
        public string Trabajador { get => trabajador; set => trabajador = value; }
    }
}
