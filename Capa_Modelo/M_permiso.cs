using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_permiso : Dao_permiso
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;
        int[,] permiso;

        public M_permiso()
        {
            cnSql = cnn.conexion();
        }


        public int[,] FIND(int rol)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_readPermiso", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rol", rol);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                int f = dt.Rows.Count;
                int c = 2;

                permiso = new int[f,c];

                for(int i=0; i<f; i++)
                {
                    for (int j=0;j<c; j++)
                    {
                        permiso[i,j]= Convert.ToInt16(dt.Rows[i][j]);
                    }
                }

                return permiso;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnSql.Close();
                return null;
            }
            finally
            {
                cnSql.Close();
            }

        }
    }
}
