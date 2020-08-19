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
    class C_document_select
    {
        Vo_documento e_documento = new Vo_documento();

        Dao_documento pxy_documento = (Pxy_documento)Fty_fabrica.Fabricar(new Pxy_documento());

        C_message c_message;

        Capa_Vista.frm_document_select frm;

        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();


        public C_document_select()
        {
            frm = new Capa_Vista.frm_document_select();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            InitializeEvents();
        }
        public frm_document_select getFormulario()
        {
            return frm;
        }

        private void InitializeEvents()
        {
           
            frm.Load += new EventHandler(frm_people_Load);
            frm.btnSelect.Click += new EventHandler(btnSelect_Click);
            frm.dtgTableDocumentS.CellClick += new DataGridViewCellEventHandler(dtgTableDocument_CellClick);
            frm.dtgTableDocumentS.Layout += new LayoutEventHandler(dtgTableDocument_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableDocumentS.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableDocument_CellMouseEnter);
            frm.dtgTableDocumentS.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableDocument_CellMouseLeave);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);

        }

        private void read_document(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_documento.READ();
            frm.dtgTableDocumentS.DataSource = dt;
            frm.dtgTableDocumentS.ClearSelection();
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

        private void ptbClose_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        private void frm_people_Load(object sender, EventArgs e)
        {
            read_document();
        }
        private void dtgTableDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_documento.Clave = Convert.ToUInt16(frm.dtgTableDocumentS.Rows[e.RowIndex].Cells["clave"].Value.ToString());

            C_evaluar_trabajador_crud.nombre_trabajador = frm.dtgTableDocumentS.Rows[e.RowIndex].Cells["nombre_trabajador"].Value.ToString();
            C_evaluar_trabajador_crud.id_documento = e_documento.Clave;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (e_documento.Clave != 0)
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
       
        private void dtgTableDocument_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableDocumentS.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_documento.Expresion = frm.txtSearch.Text;

                frm.dtgTableDocumentS.DataSource = pxy_documento.SEARCH(e_documento);
                frm.dtgTableDocumentS.ClearSelection();
            }
            else
            {
                read_document();
            }
        }
        private void dtgTableDocument_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableDocumentS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableDocument_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableDocumentS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
