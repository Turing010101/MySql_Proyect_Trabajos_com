using System;

namespace Capa_Modelo._VO
{
    public class Vo_contrato_detalle
    {
        int clave_detalle;
        int clave_contrato;
        int servicio;
        double precio;
        float total;
        int cantidad;
        string operacion;
        string expresion;
        
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public int Servicio { get => servicio; set => servicio = value; }
        public double Precio { get => precio; set => precio = value; }
        public float Total { get => total; set => total = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Clave_detalle { get => clave_detalle; set => clave_detalle = value; }
        public int Clave_contrato { get => clave_contrato; set => clave_contrato = value; }
    }
}
