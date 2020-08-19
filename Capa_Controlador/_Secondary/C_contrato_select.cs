using System;
using System.Drawing;
using System.Data;
using Capa_Vista;
using System.Windows.Forms;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._VO;
using Capa_Modelo._DAO;

namespace Capa_Controlador
{
    class C_contrato_select
    {
        Vo_contrato e_contrato = new Vo_contrato();

        Dao_contrato pxy_contrato = (Pxy_contrato)Fty_fabrica.Fabricar(new Pxy_contrato());

        C_message c_message;

        Capa_Vista.frm_contrato_select frm;

        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

        DialogResult resultado = new DialogResult();

        public C_contrato_select()
        {
            frm = new Capa_Vista.frm_contrato_select();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            InitializeEvents();
        }
        public frm_contrato_select getFormulario()
        {
            return frm;
        }

        private void InitializeEvents()
        {
           
            frm.Load += new EventHandler(frm_contrato_Load);
            frm.btnSelect.Click += new EventHandler(btnSelect_Click);
            frm.btnEliminar.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableContratoS.CellClick += new DataGridViewCellEventHandler(dtgTableContrato_CellClick);
            frm.dtgTableContratoS.Layout += new LayoutEventHandler(dtgTableClient_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableContratoS.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableClient_CellMouseEnter);
            frm.dtgTableContratoS.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableClient_CellMouseLeave);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);

        }

        private void read_contrato(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_contrato.READ();
            frm.dtgTableContratoS.DataSource = dt;
            frm.dtgTableContratoS.ClearSelection();
            e_contrato.Clave = 0;
        }

        private void desenfoque_abrir_formulario()
        {
            overlayForm = new frm_blur();
            overlayForm.StartPosition = FormStartPosition.Manual;
            overlayForm.WindowState = FormWindowState.Maximized;
            overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            overlayForm.Opacity = .50d;
            overlayForm.BackColor = Color.Black;
            overlayForm.ShowInTaskbar = false;
            overlayForm.Show();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            frm.Close();
            e_contrato.Clave = 0;
        }

        private void frm_contrato_Load(object sender, EventArgs e)
        {
            read_contrato();
        }
        private void dtgTableContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_contrato.Clave = Convert.ToInt16(frm.dtgTableContratoS.Rows[e.RowIndex].Cells["id_contrato"].Value.ToString());
            e_contrato.Estado=frm.dtgTableContratoS.Rows[e.RowIndex].Cells["estado"].Value.ToString();

            C_factura.estado_contrato = e_contrato.Estado;
            C_factura.clave_contrato = e_contrato.Clave;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (e_contrato.Clave != 0)
            {
                frm.Close();
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
                overlayForm.Dispose();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();

            if (e_contrato.Clave != 0)
            {
                if (e_contrato.Estado == "Pendiente")
                {
                    c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                    resultado = message_box.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        if (!pxy_contrato.DELETE(e_contrato))
                        {
                            c_message.message("Contrato no culminada. ", C_message.message_type.warning);                         
                        }
                        else
                        {
                            C_factura.clave_contrato = 0;
                        }
                        read_contrato();
                    }
                }
                else
                {
                    c_message.message("La factura ha sido pagado.", C_message.message_type.warning);
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTableClient_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableContratoS.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_contrato.Expresion = frm.txtSearch.Text;

                frm.dtgTableContratoS.DataSource = pxy_contrato.SEARCH(e_contrato);
                frm.dtgTableContratoS.ClearSelection();
            }
            else
            {
                read_contrato();
            }
        }
        private void dtgTableClient_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableContratoS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableClient_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableContratoS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
