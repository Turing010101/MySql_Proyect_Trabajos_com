using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_puesto : Dao_puesto
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_puesto()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readPost", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SEARCH(Vo_puesto puesto)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchCategory", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", puesto.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_puesto puesto)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createPost", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", puesto.Nombre);
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
        public bool UPDATE(Vo_puesto puesto)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updatePost", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", puesto.Clave);
                cmd.Parameters.AddWithValue("@nombre", puesto.Nombre);
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
        public bool DELETE(Vo_puesto puesto)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deletePost", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", puesto.Clave);
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
