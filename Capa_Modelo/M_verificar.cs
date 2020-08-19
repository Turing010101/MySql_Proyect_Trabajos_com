using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_verificar : Dao_verificar
    {

        Vo_gmail datos_gmail = new Vo_gmail();
        Vo_perfil datos_perfil = new Vo_perfil();
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;
        
        public M_verificar()
        {
            cnSql = cnn.conexion();
        }
        public bool FIND(Vo_verificar verificar)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_readCheck", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clave", verificar.Clave);
                cmd.Parameters.AddWithValue("@fecha", verificar.Fecha_modificar);
                if (cnSql.State == ConnectionState.Open) cnSql.Close();
                cnSql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
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
                MessageBox.Show(ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public Vo_gmail E_MAIL(Vo_verificar verificar)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_readEmail", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", verificar.Clave);
                if (cnSql.State == ConnectionState.Open) cnSql.Close();
                cnSql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    datos_gmail.Subject = "Trabajos.com Support";
                    datos_gmail.Body = "Hola, " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + ":\n\nRecibimos una solicitud para notificarle que usted ha iniciado sesión en el sistema.";
                    datos_gmail.RecipientMail = new List<string> { reader.GetString(8) };
                    return datos_gmail;
                }
                else
                {
                    return null;
                }
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

        public Vo_perfil PERFIL(Vo_verificar verificar)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_readPerfil", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", verificar.Clave);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    datos_perfil.Rol = dt.Rows[0]["rol"].ToString();
                    datos_perfil.Nombre = dt.Rows[0]["nombre"].ToString();

                    if (dt.Rows[0]["foto"] != DBNull.Value)
                    {
                        datos_perfil.Imagen = (byte[])dt.Rows[0]["foto"];
                    }
                    else
                    {
                        datos_perfil.Imagen = null;
                    }

                    return datos_perfil;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
