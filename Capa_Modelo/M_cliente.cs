using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;

namespace Capa_Modelo
{
    public class M_cliente : Dao_cliente
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_cliente()
        {
            cnSql = cnn.conexion();
        }
        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readClient", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LIST_PEOPLE()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readPeopleList", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SEARCH(Vo_cliente cliente)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchClient",cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", cliente.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_cliente cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createClient", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@persona", cliente.Rfc_persona);
                cmd.Parameters.AddWithValue("@rating", cliente.Rating);
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
        public bool UPDATE(Vo_cliente cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateClient", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cliente.Clave);
                cmd.Parameters.AddWithValue("@persona", cliente.Rfc_persona);
                cmd.Parameters.AddWithValue("@rating", cliente.Rating);
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
        public bool DELETE(Vo_cliente cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteClient", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",cliente.Clave);
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
