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
    class C_categoria
    {
        Vo_categoria e_categoria = new Vo_categoria();

        Dao_categoria pxy_categoria = (Pxy_categoria)Fty_fabrica.Fabricar(new Pxy_categoria());

        C_message c_message;

        Capa_Vista.frm_category frm;

        C_categoria_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;
      
        DialogResult resultado = new DialogResult();

        public C_categoria()
        {
            frm = new Capa_Vista.frm_category();
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
                if ((C_logeo.permisos[i, 0] == 5))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableCategory.Enabled = true;
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
            frm.dtgTableCategory.CellClick += new DataGridViewCellEventHandler(dtgTableCategory_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableCategory.Layout += new LayoutEventHandler(dtgTableCategory_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableCategory.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableCategory_CellMouseEnter);
            frm.dtgTableCategory.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableCategory_CellMouseLeave);
            permisos();
        }

        private void read_categoria(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_categoria.READ();
            frm.dtgTableCategory.DataSource = dt;
            frm.dtgTableCategory.ClearSelection();
            e_categoria.Clave = 0;
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
           read_categoria();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_categoria_crud();
          
            using (frm_category_crud crud_categoria = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_categoria.btnAcept.Click += new EventHandler(read_categoria);
                crud_categoria.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTableCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_categoria.Clave = Convert.ToInt16(frm.dtgTableCategory.Rows[e.RowIndex].Cells["id"].Value.ToString());
            e_categoria.Nombre = frm.dtgTableCategory.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
       
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_categoria.Clave != 0)
            {
                e_categoria.Operacion = "update";

                frm_crud = new C_categoria_crud(e_categoria);

                using (frm_category_crud crud_categoria = frm_crud.formulario())
                {
                    crud_categoria.btnAcept.Click += new EventHandler(read_categoria);
                    crud_categoria.ShowDialog();
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

            if (e_categoria.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_categoria.DELETE(e_categoria))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_categoria();
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTableCategory_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableCategory.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_categoria.Expresion = frm.txtSearch.Text;

                frm.dtgTableCategory.DataSource = pxy_categoria.SEARCH(e_categoria);
                frm.dtgTableCategory.ClearSelection();
            }
            else
            {
                read_categoria();
            }
        }
        private void dtgTableCategory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableCategory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableCategory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableCategory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
