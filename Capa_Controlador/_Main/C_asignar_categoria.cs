using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._VO;
using Capa_Vista;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_asignar_categoria
    {
        Vo_asignar_categoria e_asignar = new Vo_asignar_categoria();

        Dao_asignar_categoria pxy_asignar = (Pxy_asignar_categoria)Fty_fabrica.Fabricar(new Pxy_asignar_categoria());

        C_message c_message;

        Capa_Vista.frm_assign_category frm;

        C_asignar_categoria_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();


        public C_asignar_categoria()
        {
            frm = new Capa_Vista.frm_assign_category();
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
                if ((C_logeo.permisos[i, 0] == 9))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableAssignCategory.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_assign_category_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableAssignCategory.CellClick += new DataGridViewCellEventHandler(dtgTableAssignCategory_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableAssignCategory.Layout += new LayoutEventHandler(dtgTableAssignCategory_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableAssignCategory.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableAssignCategory_CellMouseEnter);
            frm.dtgTableAssignCategory.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableAssignCategory_CellMouseLeave);
            permisos();
        }

        private void read_assign_category(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_asignar.READ();
            frm.dtgTableAssignCategory.DataSource = dt;
            frm.dtgTableAssignCategory.ClearSelection();
            e_asignar.Clave = 0;
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
        private void frm_assign_category_Load(object sender, EventArgs e)
        {
            read_assign_category();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_asignar_categoria_crud();
          
            using (frm_assign_category_crud crud_assing = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_assing.btnAcept.Click += new EventHandler(read_assign_category);
                crud_assing.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTableAssignCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_asignar.Clave = Convert.ToInt16(frm.dtgTableAssignCategory.Rows[e.RowIndex].Cells["clave"].Value.ToString());
            e_asignar.Trabajador = frm.dtgTableAssignCategory.Rows[e.RowIndex].Cells["trabajador"].Value.ToString();
            e_asignar.Categoria = frm.dtgTableAssignCategory.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
            e_asignar.Estado = frm.dtgTableAssignCategory.Rows[e.RowIndex].Cells["estado"].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_asignar.Clave != 0)
            {
                e_asignar.Operacion = "update";

                frm_crud = new C_asignar_categoria_crud(e_asignar);

                using (frm_assign_category_crud crud_assing = frm_crud.formulario())
                {
                    crud_assing.btnAcept.Click += new EventHandler(read_assign_category);
                    crud_assing.ShowDialog();
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

            if (e_asignar.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_asignar.DELETE(e_asignar))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_assign_category();
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTableAssignCategory_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableAssignCategory.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_asignar.Expresion = frm.txtSearch.Text;

                frm.dtgTableAssignCategory.DataSource = pxy_asignar.SEARCH(e_asignar);
                frm.dtgTableAssignCategory.ClearSelection();
            }
            else
            {
                read_assign_category();
            }
        }
        private void dtgTableAssignCategory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableAssignCategory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableAssignCategory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableAssignCategory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
