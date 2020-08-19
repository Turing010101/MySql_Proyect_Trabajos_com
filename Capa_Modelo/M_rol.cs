using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_rol:Dao_rol
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_rol()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readRole", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SEARCH(Vo_rol rol)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchRole", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", rol.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_rol rol)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createRole", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
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
        public bool UPDATE(Vo_rol rol)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateRole", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", rol.Clave);
                cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
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
        public bool DELETE(Vo_rol rol)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteRole", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", rol.Clave);
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
