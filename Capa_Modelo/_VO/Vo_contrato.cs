using System;

namespace Capa_Modelo._VO
{
    public class Vo_contrato
    {
        int clave;
        DateTime fecha_contrato;
        int cliente;
        int modo_pago;
        string estado;
        double total;
        double comision;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public DateTime Fecha_contrato { get => fecha_contrato; set => fecha_contrato = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public int Modo_pago { get => modo_pago; set => modo_pago = value; }
        public double Total { get => total; set => total = value; }
        public double Comision { get => comision; set => comision = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
