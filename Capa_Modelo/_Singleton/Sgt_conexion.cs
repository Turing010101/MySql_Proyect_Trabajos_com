using MySql.Data.MySqlClient;
using System.Configuration;

namespace Capa_Modelo._Singleton
{
    class Sgt_conexion
    {
        public static Sgt_conexion instancia;

        private Sgt_conexion()
        {

        }
        public static Sgt_conexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sgt_conexion();
            }
            return instancia;
        }
        public MySqlConnection conexion()
        {
            return new MySqlConnection (ConfigurationManager.ConnectionStrings["connection_sql"].ConnectionString);
        }
    }
}
