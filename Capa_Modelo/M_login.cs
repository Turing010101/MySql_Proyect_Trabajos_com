using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_login : Dao_login
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;
        int[] clave = new int[2] {0,0};

        public M_login()
        {
            cnSql = cnn.conexion();
        }
        
        public int[] SEARCH(Vo_login login)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_readLogin", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", login.Usuario);
                cmd.Parameters.AddWithValue("@contrasena", login.Contrasena);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
            
                if (dt.Rows.Count==1)
                {
                    clave[0] = Convert.ToInt16(dt.Rows[0]["int_id_persona"]);
                    clave[1] = Convert.ToInt16(dt.Rows[0]["pf_rol"]);

                    return clave;
                }
                else
                {
                    return clave;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return clave;
            }

        }
    }
}
