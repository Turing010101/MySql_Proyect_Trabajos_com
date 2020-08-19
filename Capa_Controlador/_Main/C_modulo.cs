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
    class C_modulo
    {
        Vo_modulo e_modulo = new Vo_modulo();

        Dao_modulo pxy_modulo = (Pxy_modulo)Fty_fabrica.Fabricar(new Pxy_modulo());

        C_message c_message;

        Capa_Vista.frm_module frm;

        C_modulo_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;
      
        DialogResult resultado = new DialogResult();

        public C_modulo()
        {
            frm = new Capa_Vista.frm_module();
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
                if ((C_logeo.permisos[i, 0] == 12))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableModule.Enabled = true;
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
            frm.dtgTableModule.CellClick += new DataGridViewCellEventHandler(dtgTableModule_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableModule.Layout += new LayoutEventHandler(dtgTableModule_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableModule.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableModule_CellMouseEnter);
            frm.dtgTableModule.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableModule_CellMouseLeave);
            permisos();
        }

        private void read_modulo(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_modulo.READ();
            frm.dtgTableModule.DataSource = dt;
            frm.dtgTableModule.ClearSelection();
            e_modulo.Clave = 0;
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
           frm_crud = new C_modulo_crud();
          
            using (frm_modulo_crud crud_modulo = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_modulo.btnAcept.Click += new EventHandler(read_modulo);
                crud_modulo.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTableModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_modulo.Clave = Convert.ToInt16(frm.dtgTableModule.Rows[e.RowIndex].Cells["id"].Value.ToString());
            e_modulo.Nombre = frm.dtgTableModule.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
       
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_modulo.Clave != 0)
            {
                e_modulo.Operacion = "update";

                frm_crud = new C_modulo_crud(e_modulo);

                using (frm_modulo_crud crud_modulo = frm_crud.formulario())
                {
                    crud_modulo.btnAcept.Click += new EventHandler(read_modulo);
                    crud_modulo.ShowDialog();
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

            if (e_modulo.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_modulo.DELETE(e_modulo))
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
        private void dtgTableModule_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableModule.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_modulo.Expresion = frm.txtSearch.Text;

                frm.dtgTableModule.DataSource = pxy_modulo.SEARCH(e_modulo);
                frm.dtgTableModule.ClearSelection();
            }
            else
            {
                read_modulo();
            }
        }
        private void dtgTableModule_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableModule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableModule_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableModule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
