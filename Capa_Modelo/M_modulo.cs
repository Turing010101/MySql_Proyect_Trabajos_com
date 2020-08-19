using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_modulo : Dao_modulo
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_modulo()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readModule", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SEARCH(Vo_modulo modulo)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchModule", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", modulo.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_modulo modulo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createModule", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", modulo.Nombre);
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
        public bool UPDATE(Vo_modulo modulo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateModule", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", modulo.Clave);
                cmd.Parameters.AddWithValue("@nombre", modulo.Nombre);
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
        public bool DELETE(Vo_modulo modulo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteModule", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", modulo.Clave);
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
