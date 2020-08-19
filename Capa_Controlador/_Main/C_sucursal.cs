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
    class C_sucursal
    {
        Vo_sucursal e_sucursal = new Vo_sucursal();

        Dao_sucursal pxy_sucursal = (Pxy_sucursal)Fty_fabrica.Fabricar(new Pxy_sucursal());

        C_message c_message;

        Capa_Vista.frm_office frm;

        C_sucursal_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();

        public C_sucursal()
        {
            frm = new Capa_Vista.frm_office();
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
                if ((C_logeo.permisos[i, 0] == 10))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableOffice.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_sucursal_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableOffice.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableOffice.Layout += new LayoutEventHandler(dtgTablePeople_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableOffice.CellMouseEnter += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseEnter);
            frm.dtgTableOffice.CellMouseLeave += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseLeave);
            permisos();
        }

        private void read_sucursal(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_sucursal.READ();
            frm.dtgTableOffice.DataSource = dt;
            frm.dtgTableOffice.ClearSelection();
            e_sucursal.Clave = 0;
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
        private void frm_sucursal_Load(object sender, EventArgs e)
        {
           read_sucursal();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_sucursal_crud();
          
            using (frm_office_crud crud_sucursal = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_sucursal.btnAcept.Click += new EventHandler(read_sucursal);
                crud_sucursal.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTablePeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_sucursal.Clave = Convert.ToInt16(frm.dtgTableOffice.Rows[e.RowIndex].Cells["id"].Value.ToString());
            e_sucursal.Nombre = frm.dtgTableOffice.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
       
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_sucursal.Clave != 0)
            {
                e_sucursal.Operacion = "update";

                frm_crud = new C_sucursal_crud(e_sucursal);

                using (frm_office_crud crud_sucursal = frm_crud.formulario())
                {
                    crud_sucursal.btnAcept.Click += new EventHandler(read_sucursal);
                    crud_sucursal.ShowDialog();
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

            if (e_sucursal.Clave != 0)
            {
                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_sucursal.DELETE(e_sucursal))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_sucursal();
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
            frm.dtgTableOffice.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_sucursal.Expresion = frm.txtSearch.Text;

                frm.dtgTableOffice.DataSource = pxy_sucursal.SEARCH(e_sucursal);
                frm.dtgTableOffice.ClearSelection();
            }
            else
            {
                read_sucursal();
            }
        }
        private void dtgTablePeople_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableOffice.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTablePeople_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableOffice.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
