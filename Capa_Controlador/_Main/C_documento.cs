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
    class C_documento
    {
        Vo_documento e_documento = new Vo_documento();

        Dao_documento pxy_documento = (Pxy_documento)Fty_fabrica.Fabricar(new Pxy_documento());

        C_message c_message;

        Capa_Vista.frm_document frm;

        C_documento_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();

        public C_documento()
        {
            frm = new Capa_Vista.frm_document();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            InitializeEvents();
        }
        public Form getFormulario()
        {
            return frm;
        }
        private void permisos()
        {
            int f = C_logeo.permisos.GetLength(0);

            for (int i = 0; i < f; i++)
            {
                if ((C_logeo.permisos[i, 0] == 4))
                {
                        switch (C_logeo.permisos[i, 1])
                        {
                            case 1:
                                frm.btnAdd.Enabled = true;
                                break;
                            case 2:
                                 frm.dtgTableDocument.Enabled = true;
                                 break;
                            case 3:
                                frm.btnUpdate.Enabled = true;
                                break;
                            case 4:
                                frm.btnDelete.Enabled = true;
                                break;
                        default:
                                break;
                        }
                }
            }
        }
        private void InitializeEvents()
        {
           
            frm.Load += new EventHandler(frm_document_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableDocument.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableDocument.Layout += new LayoutEventHandler(dtgTablePeople_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableDocument.CellMouseEnter += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseEnter);
            frm.dtgTableDocument.CellMouseLeave += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseLeave);
            permisos();
        }

        private void read_documento(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_documento.READ();
            frm.dtgTableDocument.DataSource = dt;
            frm.dtgTableDocument.ClearSelection();
            e_documento.Clave = 0;
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
        private void frm_document_Load(object sender, EventArgs e)
        {
            read_documento();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_documento_crud();
          
            using (frm_document_crud crud_document = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_document.btnAcept.Click += new EventHandler(read_documento);
                crud_document.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTablePeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_documento.Clave = Convert.ToInt16(frm.dtgTableDocument.Rows[e.RowIndex].Cells["clave"].Value.ToString());
            e_documento.Rfc_trabajdor = frm.dtgTableDocument.Rows[e.RowIndex].Cells["rfc_trabajador"].Value.ToString();
            e_documento.Credencial = frm.dtgTableDocument.Rows[e.RowIndex].Cells["credencial"].Value.ToString();
            e_documento.Certificado = frm.dtgTableDocument.Rows[e.RowIndex].Cells["certificado"].Value.ToString();
            e_documento.Comprobante_domicilio = frm.dtgTableDocument.Rows[e.RowIndex].Cells["comprobante_domicilio"].Value.ToString();
            e_documento.Nombre_trabajador = frm.dtgTableDocument.Rows[e.RowIndex].Cells["nombre_trabajador"].Value.ToString();
            e_documento.Observaciones = frm.dtgTableDocument.Rows[e.RowIndex].Cells["observacion"].Value.ToString();
            e_documento.Estado = frm.dtgTableDocument.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            e_documento.Fecha_evaluacion = frm.dtgTableDocument.Rows[e.RowIndex].Cells["fecha_evaluacion"].Value.ToString();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_documento.Clave != 0)
            {
                e_documento.Operacion = "update";

                frm_crud = new C_documento_crud(e_documento);

                using (frm_document_crud crud_document = frm_crud.formulario())
                {
                    crud_document.btnAcept.Click += new EventHandler(read_documento);
                    crud_document.ShowDialog();
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();

            if (e_documento.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_documento.DELETE(e_documento))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_documento();
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTablePeople_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableDocument.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_documento.Expresion = frm.txtSearch.Text;

                frm.dtgTableDocument.DataSource = pxy_documento.SEARCH(e_documento);
                frm.dtgTableDocument.ClearSelection();
            }
            else
            {
                read_documento();
            }
        }
        private void dtgTablePeople_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableDocument.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTablePeople_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableDocument.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
