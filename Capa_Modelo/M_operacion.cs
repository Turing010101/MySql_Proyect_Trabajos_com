using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;

namespace Capa_Modelo
{
    public class M_operacion : Dao_operacion
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_operacion()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readOperation", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LIST_MODULE()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readModule", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LIST_ACTION()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readAction", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SEARCH(Vo_operacion operacion)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchOperation",cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", operacion.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_operacion operacion)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createOperation", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@modulo", operacion.Modulo);
                cmd.Parameters.AddWithValue("@accion", operacion.Accion);
                if (cnSql.State == ConnectionState.Open) cnSql.Close();
                cnSql.Open();
                if (cmd.ExecuteNonQuery()>0)
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
        public bool UPDATE(Vo_operacion operacion)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateOperation", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",operacion.Clave);
                cmd.Parameters.AddWithValue("@modulo", operacion.Modulo);
                cmd.Parameters.AddWithValue("@accion", operacion.Accion);
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
                MessageBox.Show("Ocurrio un error", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Error);
                cnSql.Close();
                return false;
            }
            finally
            {
                cnSql.Close();
            }

        }
        public bool DELETE(Vo_operacion operacion)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteOperation", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",operacion.Clave);
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
