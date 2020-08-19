using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;

namespace Capa_Modelo
{
    public class M_empleado:Dao_empleado
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_empleado()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readEmployee", cnSql);
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
        public DataTable LIST_POST()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readPost", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LIST_OFFICE()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readOffice", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LIST_TURN()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readTurn", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SEARCH(Vo_empleado empleado)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchEmployee",cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", empleado.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_empleado empleado)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createEmployee", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@persona", empleado.Rfc_persona);
                cmd.Parameters.AddWithValue("@jefe", empleado.Rfc_jefe);
                cmd.Parameters.AddWithValue("@puesto", empleado.Puesto);
                cmd.Parameters.AddWithValue("@sucursal", empleado.Sucursal);
                cmd.Parameters.AddWithValue("@turno", empleado.Turno);
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
        public bool UPDATE(Vo_empleado empleado)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateEmployee", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",empleado.Clave);
                cmd.Parameters.AddWithValue("@persona", empleado.Rfc_persona);
                cmd.Parameters.AddWithValue("@jefe", empleado.Rfc_jefe);
                cmd.Parameters.AddWithValue("@puesto", empleado.Puesto);
                cmd.Parameters.AddWithValue("@sucursal", empleado.Sucursal);
                cmd.Parameters.AddWithValue("@turno", empleado.Turno);
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
        public bool DELETE(Vo_empleado empleado)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteEmployee", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",empleado.Clave);
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
