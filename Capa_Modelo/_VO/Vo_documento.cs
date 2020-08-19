using Capa_Modelo._Visitor;
using System;
using System.Collections.Generic;

namespace Capa_Modelo._VO
{
    public class Vo_documento
    {
        int clave;
        string credencial;
        string certificado;
        string comprobante_domicilio;
        string estado;
        string observaciones;
        string fecha_evaluacion;
        string rfc_trabajdor;
        string nombre_trabajador;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public string Credencial { get => credencial; set => credencial = value; }
        public string Certificado { get => certificado; set => certificado = value; }
        public string Comprobante_domicilio { get => comprobante_domicilio; set => comprobante_domicilio = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Fecha_evaluacion { get => fecha_evaluacion; set => fecha_evaluacion = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public string Rfc_trabajdor { get => rfc_trabajdor; set => rfc_trabajdor = value; }
        public string Nombre_trabajador { get => nombre_trabajador; set => nombre_trabajador = value; }
    }
}
