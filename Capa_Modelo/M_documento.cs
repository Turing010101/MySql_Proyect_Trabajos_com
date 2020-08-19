using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;

namespace Capa_Modelo
{
    public class M_documento: Dao_documento
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_documento()
        {
            cnSql = cnn.conexion();
        }
        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readDocument", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SEARCH(Vo_documento documento)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchDocument", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", documento.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CREATE(Vo_documento documento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createDocument", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@credencial", documento.Credencial);
                cmd.Parameters.AddWithValue("@certificado", documento.Certificado);
                cmd.Parameters.AddWithValue("@comprobante_domicilio", documento.Comprobante_domicilio);
                cmd.Parameters.AddWithValue("@estado", documento.Estado);
                cmd.Parameters.AddWithValue("@observacion", documento.Observaciones);
                cmd.Parameters.AddWithValue("@rfc", documento.Rfc_trabajdor);
                cmd.Parameters.AddWithValue("@nombre trabajador", documento.Nombre_trabajador);
                cmd.Parameters.AddWithValue("@fecha_evaluacion", documento.Fecha_evaluacion);
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
        public bool UPDATE(Vo_documento documento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateDocument", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",documento.Clave);
                cmd.Parameters.AddWithValue("@estado", documento.Estado);
                cmd.Parameters.AddWithValue("@observacion", documento.Observaciones);
                cmd.Parameters.AddWithValue("@fecha", documento.Fecha_evaluacion);
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
        public bool DELETE(Vo_documento documento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteDocument", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",documento.Clave);
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
