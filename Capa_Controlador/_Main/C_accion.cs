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
    class C_accion
    {
        Vo_accion e_accion = new Vo_accion();

        Dao_accion pxy_accion = (Pxy_accion)Fty_fabrica.Fabricar(new Pxy_accion());

        C_message c_message;

        Capa_Vista.frm_action frm;

        C_accion_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;
      
        DialogResult resultado = new DialogResult();

        public C_accion()
        {
            frm = new Capa_Vista.frm_action();
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
                if ((C_logeo.permisos[i, 0] == 13))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableAction.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_modulo_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableAction.CellClick += new DataGridViewCellEventHandler(dtgTableAction_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableAction.Layout += new LayoutEventHandler(dtgTableAction_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableAction.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableAction_CellMouseEnter);
            frm.dtgTableAction.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableAction_CellMouseLeave);
            permisos();
        }

        private void read_modulo(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_accion.READ();
            frm.dtgTableAction.DataSource = dt;
            frm.dtgTableAction.ClearSelection();
            e_accion.Clave = 0;
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
        private void frm_modulo_Load(object sender, EventArgs e)
        {
           read_modulo();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_accion_crud();
          
            using (frm_accion_crud crud_accion = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_accion.btnAcept.Click += new EventHandler(read_modulo);
                crud_accion.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTableAction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_accion.Clave = Convert.ToInt16(frm.dtgTableAction.Rows[e.RowIndex].Cells["id"].Value.ToString());
            e_accion.Nombre = frm.dtgTableAction.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
       
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_accion.Clave != 0)
            {
                e_accion.Operacion = "update";

                frm_crud = new C_accion_crud(e_accion);

                using (frm_accion_crud crud_accion = frm_crud.formulario())
                {
                    crud_accion.btnAcept.Click += new EventHandler(read_modulo);
                    crud_accion.ShowDialog();
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

            if (e_accion.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_accion.DELETE(e_accion))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_modulo();
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTableAction_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableAction.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_accion.Expresion = frm.txtSearch.Text;

                frm.dtgTableAction.DataSource = pxy_accion.SEARCH(e_accion);
                frm.dtgTableAction.ClearSelection();
            }
            else
            {
                read_modulo();
            }
        }
        private void dtgTableAction_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableAction.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableAction_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableAction.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
