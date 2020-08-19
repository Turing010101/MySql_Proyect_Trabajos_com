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
    class C_rol
    {
        Vo_rol e_rol = new Vo_rol();

        Dao_rol pxy_rol = (Pxy_rol)Fty_fabrica.Fabricar(new Pxy_rol());

        C_message c_message;

        Capa_Vista.frm_role frm;

        C_rol_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();

        public C_rol()
        {
            frm = new Capa_Vista.frm_role();
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
                if ((C_logeo.permisos[i, 0] == 7))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableRole.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_rol_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableRole.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableRole.Layout += new LayoutEventHandler(dtgTablePeople_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableRole.CellMouseEnter += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseEnter);
            frm.dtgTableRole.CellMouseLeave += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseLeave);
            permisos();
        }

        private void read_rol(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_rol.READ();
            frm.dtgTableRole.DataSource = dt;
            frm.dtgTableRole.ClearSelection();
            e_rol.Clave = 0;
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
        private void frm_rol_Load(object sender, EventArgs e)
        {
           read_rol();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_rol_crud();
          
            using (frm_role_crud crud_rol = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_rol.btnAcept.Click += new EventHandler(read_rol);
                crud_rol.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTablePeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_rol.Clave = Convert.ToInt16(frm.dtgTableRole.Rows[e.RowIndex].Cells["id"].Value.ToString());
            e_rol.Nombre = frm.dtgTableRole.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
       
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_rol.Clave != 0)
            {
                e_rol.Operacion = "update";

                frm_crud = new C_rol_crud(e_rol);

                using (frm_role_crud crud_rol = frm_crud.formulario())
                {
                    crud_rol.btnAcept.Click += new EventHandler(read_rol);
                    crud_rol.ShowDialog();
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

            if (e_rol.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_rol.DELETE(e_rol))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_rol();
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
            frm.dtgTableRole.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_rol.Expresion = frm.txtSearch.Text;

                frm.dtgTableRole.DataSource = pxy_rol.SEARCH(e_rol);
                frm.dtgTableRole.ClearSelection();
            }
            else
            {
                read_rol();
            }
        }
        private void dtgTablePeople_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableRole.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTablePeople_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableRole.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
