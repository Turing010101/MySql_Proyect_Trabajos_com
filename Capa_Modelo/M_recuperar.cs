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
    public class M_recuperar : Dao_recuperar
    {
        Random rdm = new Random();
        Vo_gmail datos_gmail = new Vo_gmail();
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;
     

        public M_recuperar()
        {
            cnSql = cnn.conexion();
        }

        private string getCode()
        {
            string codigo = "";
            for (int i = 0; i < 6; i++)
            {
                codigo+=rdm.Next(0, 9);
            }
            return codigo;
        }

        public Vo_gmail SEARCH(Vo_recuperar recuperar)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_readRecover", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@valor", recuperar.Valor);
                if (cnSql.State == ConnectionState.Open) cnSql.Close();
                cnSql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()==true)
                {
                    string code = getCode();
                    datos_gmail.Subject = "Trabajos.com Support";
                    datos_gmail.Body = "Hola, " + reader.GetString(3)+" "+ reader.GetString(4)+" "+reader.GetString(5) + ":\n\nRecibimos una solicitud para restablecer tu contraseña de Trabajos.com.\n" + "Ingrese el siguiente código para restablecer la contraseña:\n" + code+ "\n";
                    datos_gmail.Code = code;
                    datos_gmail.RecipientMail = new List<string> { reader.GetString(9) };
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
    }
}
