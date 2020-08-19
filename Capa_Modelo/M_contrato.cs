using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_contrato : Dao_contrato
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_contrato()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readContract", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SEARCH(Vo_contrato contrato)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchContract", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", contrato.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LIST_COMMISSION()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readCommision", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LIST_PAY()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readPay", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int SELECT_HIGHER()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_readHegher", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    return Convert.ToInt16(dt.Rows[0]["id"]); ;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public DataSet REPORT(Vo_contrato contrato)
        {
            MySqlCommand cmd = new MySqlCommand("sp_readContractReport", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@clave", contrato.Clave);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            da.Fill(dts);
            return dts;
        }
        public bool CREATE(Vo_contrato contrato)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createContract", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_contrato", contrato.Fecha_contrato);
                cmd.Parameters.AddWithValue("@cliente", contrato.Cliente);
                cmd.Parameters.AddWithValue("@modo_pago", contrato.Modo_pago);

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
        public bool UPDATE(Vo_contrato contrato)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateContract", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", contrato.Clave);
                cmd.Parameters.AddWithValue("@fecha_contrato", contrato.Fecha_contrato);
                cmd.Parameters.AddWithValue("@cliente", contrato.Cliente);
                cmd.Parameters.AddWithValue("@modo_pago", contrato.Modo_pago);
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
        public bool PAY_CONTRACT(Vo_contrato contrato)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_payContract", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", contrato.Clave);
                cmd.Parameters.AddWithValue("@total", contrato.Total);
                cmd.Parameters.AddWithValue("@comision", contrato.Comision);
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
        public bool DELETE(Vo_contrato contrato)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteContract", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", contrato.Clave);
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
