namespace Capa_Modelo._VO
{
    public class Vo_perfil
    {
        string rol;
        string nombre;
        byte[] imagen;

        public string Rol { get => rol; set => rol = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
