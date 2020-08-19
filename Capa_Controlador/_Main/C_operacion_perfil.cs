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
    class C_operacion_perfil
    {
        Vo_operacion_perfil e_operacion = new Vo_operacion_perfil();

        Dao_operacion_perfil pxy_operacion = (Pxy_operacion_perfil)Fty_fabrica.Fabricar(new Pxy_operacion_perfil());

        C_message c_message;

        Capa_Vista.frm_operation_perfil frm;

        C_operacion_perfil_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();


        public C_operacion_perfil()
        {
            frm = new Capa_Vista.frm_operation_perfil();
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
                if ((C_logeo.permisos[i, 0] == 15))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableActionPerfil.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_operaction_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableActionPerfil.CellClick += new DataGridViewCellEventHandler(dtgTableOperationPerfil_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableActionPerfil.Layout += new LayoutEventHandler(dtgTableOperationPerfil_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableActionPerfil.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableOperationPefil_CellMouseEnter);
            frm.dtgTableActionPerfil.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableOperationPerfil_CellMouseLeave);
            permisos();
        }

        private void read_operacion_perfil(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_operacion.READ();
            frm.dtgTableActionPerfil.DataSource = dt;
            frm.dtgTableActionPerfil.ClearSelection();
            e_operacion.Clave = 0;
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
        private void frm_operaction_Load(object sender, EventArgs e)
        {
            read_operacion_perfil();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_operacion_perfil_crud();
          
            using (frm_operation_perfil_crud crud_operacion = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_operacion.btnAcept.Click += new EventHandler(read_operacion_perfil);
                crud_operacion.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTableOperationPerfil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_operacion.Clave = Convert.ToInt16(frm.dtgTableActionPerfil.Rows[e.RowIndex].Cells["clave"].Value.ToString());
            e_operacion.Rol = frm.dtgTableActionPerfil.Rows[e.RowIndex].Cells["nombre_rol"].Value.ToString();
            e_operacion.Accion = frm.dtgTableActionPerfil.Rows[e.RowIndex].Cells["nombre_modulo"].Value.ToString() +" => "+ frm.dtgTableActionPerfil.Rows[e.RowIndex].Cells["nombre_accion"].Value.ToString();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_operacion.Clave != 0)
            {
                e_operacion.Operacion = "update";

                frm_crud = new C_operacion_perfil_crud(e_operacion);

                using (frm_operation_perfil_crud crud_operacion = frm_crud.formulario())
                {
                    crud_operacion.btnAcept.Click += new EventHandler(read_operacion_perfil);
                    crud_operacion.ShowDialog();
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

            if (e_operacion.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_operacion.DELETE(e_operacion))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_operacion_perfil();
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTableOperationPerfil_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableActionPerfil.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_operacion.Expresion = frm.txtSearch.Text;

                frm.dtgTableActionPerfil.DataSource = pxy_operacion.SEARCH(e_operacion);
                frm.dtgTableActionPerfil.ClearSelection();
            }
            else
            {
                read_operacion_perfil();
            }
        }
        private void dtgTableOperationPefil_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableActionPerfil.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableOperationPerfil_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableActionPerfil.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
