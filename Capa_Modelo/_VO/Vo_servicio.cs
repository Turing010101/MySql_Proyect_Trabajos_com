namespace Capa_Modelo._VO
{
    public class Vo_servicio
    {
        int clave;
        string nombre;
        string descripcion;
        float costo;
        int categoria;
        string operacion;
        string expresion;

        public int Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Costo { get => costo; set => costo = value; }
        public int Categoria { get => categoria; set => categoria = value; }
    }
}
