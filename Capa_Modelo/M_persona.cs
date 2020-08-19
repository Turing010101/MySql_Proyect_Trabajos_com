using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;

namespace Capa_Modelo
{
    public class M_persona:Dao_persona
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_persona()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readPeople", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LIST_ROLE()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readRole", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SEARCH(Vo_persona persona)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchPeople",cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", persona.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_persona persona)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createPeople", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rfc", persona.Rfc);
                cmd.Parameters.AddWithValue("@foto", persona.Fotografia);
                cmd.Parameters.AddWithValue("@nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("@apellido_paterno", persona.Apellido_paterno);
                cmd.Parameters.AddWithValue("@apellido_materno",persona.Apellido_materno);
                cmd.Parameters.AddWithValue("@sexo", persona.Sexo);
                cmd.Parameters.AddWithValue("@telefono_personal", persona.Telefono_personal);
                cmd.Parameters.AddWithValue("@telefono_pariente", persona.Telefono_periente);
                cmd.Parameters.AddWithValue("@correo_electronico", persona.Correo_electronico);
                cmd.Parameters.AddWithValue("@localidad", persona.Localidad);
                cmd.Parameters.AddWithValue("@nombre_calle", persona.Nombre_calle);
                cmd.Parameters.AddWithValue("@numero_calle", persona.Numero_calle);
                cmd.Parameters.AddWithValue("@municipio", persona.Municipio);
                cmd.Parameters.AddWithValue("@estado", persona.Estado);
                cmd.Parameters.AddWithValue("@codigo_postal", persona.Codigo_postal);
                cmd.Parameters.AddWithValue("@fecha_registro", persona.Fecha_registro);
                cmd.Parameters.AddWithValue("@usuario", persona.Usuario);
                cmd.Parameters.AddWithValue("@contrasena", persona.Contrasena);
                cmd.Parameters.AddWithValue("@estatus", persona.Status);
                cmd.Parameters.AddWithValue("@rol",persona.Rol);
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
        public bool UPDATE(Vo_persona persona)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updatePeople", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",persona.Clave);
                cmd.Parameters.AddWithValue("@rfc", persona.Rfc);
                cmd.Parameters.AddWithValue("@foto", persona.Fotografia);
                cmd.Parameters.AddWithValue("@nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("@apellido_paterno", persona.Apellido_paterno);
                cmd.Parameters.AddWithValue("@apellido_materno", persona.Apellido_materno);
                cmd.Parameters.AddWithValue("@sexo", persona.Sexo);
                cmd.Parameters.AddWithValue("@telefono_personal", persona.Telefono_personal);
                cmd.Parameters.AddWithValue("@telefono_pariente", persona.Telefono_periente);
                cmd.Parameters.AddWithValue("@correo_electronico", persona.Correo_electronico);
                cmd.Parameters.AddWithValue("@localidad", persona.Localidad);
                cmd.Parameters.AddWithValue("@nombre_calle", persona.Nombre_calle);
                cmd.Parameters.AddWithValue("@numero_calle", persona.Numero_calle);
                cmd.Parameters.AddWithValue("@municipio", persona.Municipio);
                cmd.Parameters.AddWithValue("@estado", persona.Estado);
                cmd.Parameters.AddWithValue("@codigo_postal", persona.Codigo_postal);
                cmd.Parameters.AddWithValue("@fecha_registro", persona.Fecha_registro);
                cmd.Parameters.AddWithValue("@estatus", persona.Status);
                cmd.Parameters.AddWithValue("@rol", persona.Rol);
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
        public bool ESTABLISH(Vo_persona persona)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateEstablish", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", persona.Fecha_contrasena);
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
        public bool DELETE(Vo_persona persona)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deletePeople", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",persona.Clave);
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
