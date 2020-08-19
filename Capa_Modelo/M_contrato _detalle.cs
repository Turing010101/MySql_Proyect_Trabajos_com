using Capa_Modelo._DAO;
using Capa_Modelo._Singleton;
using Capa_Modelo._VO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class M_contrato_detalle : Dao_contrato_detalle
    {
        Sgt_conexion cnn = Sgt_conexion.getInstancia();
        MySqlConnection cnSql;

        public M_contrato_detalle()
        {
            cnSql = cnn.conexion();
        }

        public DataTable READ()
        {
            MySqlCommand cmd = new MySqlCommand("sp_readBill", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SEARCH(Vo_contrato_detalle detalle)
        {
            MySqlCommand cmd = new MySqlCommand("sp_searchBill", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@termino", detalle.Expresion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataSet REPORT(Vo_contrato_detalle detalle)
        {
            MySqlCommand cmd = new MySqlCommand("sp_readBill", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@no_contrato", detalle.Clave_contrato);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            da.Fill(dts);
            return dts;
        }
        public DataTable READ_FACTURA(Vo_contrato_detalle detalle)
        {
            MySqlCommand cmd = new MySqlCommand("sp_readBill", cnSql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@no_contrato", detalle.Clave_contrato);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public double SELECT_SUBTOTAL(Vo_contrato_detalle detalle)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_readSubTotal", cnSql);
                cmd.Parameters.AddWithValue("@no_contrato", detalle.Clave_contrato);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    return Convert.ToInt16(dt.Rows[0]["subtotal"]); ;
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
        public bool CREATE(Vo_contrato_detalle detalle)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_createBill", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@contrato", detalle.Clave_contrato);
                cmd.Parameters.AddWithValue("@servicio", detalle.Servicio);
                cmd.Parameters.AddWithValue("@precio", detalle.Precio);
                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);

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
        public bool UPDATE(Vo_contrato_detalle detalle)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_updateBill", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", detalle.Clave_detalle);
                cmd.Parameters.AddWithValue("@contrato", detalle.Clave_contrato);
                cmd.Parameters.AddWithValue("@servicio", detalle.Servicio);
                cmd.Parameters.AddWithValue("@precio", detalle.Precio);
                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);

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
        public bool DELETE(Vo_contrato_detalle detalle)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleteBill", cnSql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", detalle.Clave_detalle);
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
