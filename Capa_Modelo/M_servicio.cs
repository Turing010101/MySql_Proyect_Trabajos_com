using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_servicio : Dao_servicio
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_servicio()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readService", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SEARCH(Vo_servicio servicio)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchService", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", servicio.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_servicio servicio)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createService", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@servicio", servicio.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", servicio.Descripcion);
                cmd.Parameters.AddWithValue("@costo", servicio.Costo);
                cmd.Parameters.AddWithValue("@categoria", servicio.Categoria);
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
        public bool UPDATE(Vo_servicio servicio)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateService", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", servicio.Clave);
                cmd.Parameters.AddWithValue("@servicio", servicio.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", servicio.Descripcion);
                cmd.Parameters.AddWithValue("@costo", servicio.Costo);
                cmd.Parameters.AddWithValue("@categoria", servicio.Categoria);
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
        public bool DELETE(Vo_servicio servicio)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteService", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", servicio.Clave);
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
