using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_actualizar : Dao_actualizar
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_actualizar()
        {
            cnSql = cnn.conexion();
        }

        public bool UPDATE(Vo_actualizar actualizar)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updatePassword", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clave", actualizar.Clave);
                cmd.Parameters.AddWithValue("@contrasena_actual", actualizar.Contrasena_actual);
                cmd.Parameters.AddWithValue("@contrasena_nueva", actualizar.Contrasena_nueva);
                if (cnSql.State == ConnectionState.Open) cnSql.Close();
                cnSql.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnSql.Close();
                return false;
            }
            finally
            {
                cnSql.Close();
            }

        }
    }
}
