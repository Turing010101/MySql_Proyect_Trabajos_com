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
    class C_puesto
    {
        Vo_puesto e_puesto = new Vo_puesto();

        Dao_puesto pxy_puesto = (Pxy_puesto)Fty_fabrica.Fabricar(new Pxy_puesto());

        C_message c_message;

        Capa_Vista.frm_post frm;

        C_puesto_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();

        public C_puesto()
        {
            frm = new Capa_Vista.frm_post();
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
                if ((C_logeo.permisos[i, 0] == 8))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTablePost.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_categoria_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTablePost.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTablePost.Layout += new LayoutEventHandler(dtgTablePeople_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTablePost.CellMouseEnter += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseEnter);
            frm.dtgTablePost.CellMouseLeave += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseLeave);
            permisos();
        }

        private void read_puesto(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_puesto.READ();
            frm.dtgTablePost.DataSource = dt;
            frm.dtgTablePost.ClearSelection();
            e_puesto.Clave = 0;
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
        private void frm_categoria_Load(object sender, EventArgs e)
        {
           read_puesto();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_puesto_crud();
          
            using (frm_post_crud crud_puesto = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_puesto.btnAcept.Click += new EventHandler(read_puesto);
                crud_puesto.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTablePeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_puesto.Clave = Convert.ToInt16(frm.dtgTablePost.Rows[e.RowIndex].Cells["id"].Value.ToString());
            e_puesto.Nombre = frm.dtgTablePost.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
       
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_puesto.Clave != 0)
            {
                e_puesto.Operacion = "update";

                frm_crud = new C_puesto_crud(e_puesto);

                using (frm_post_crud crud_puesto = frm_crud.formulario())
                {
                    crud_puesto.btnAcept.Click += new EventHandler(read_puesto);
                    crud_puesto.ShowDialog();
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

            if (e_puesto.Clave != 0)
            {
                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_puesto.DELETE(e_puesto))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_puesto();
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
            frm.dtgTablePost.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_puesto.Expresion = frm.txtSearch.Text;

                frm.dtgTablePost.DataSource = pxy_puesto.SEARCH(e_puesto);
                frm.dtgTablePost.ClearSelection();
            }
            else
            {
                read_puesto();
            }
        }
        private void dtgTablePeople_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTablePost.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTablePeople_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTablePost.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
