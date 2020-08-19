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
    class C_empleado
    {
        Vo_empleado e_empleado = new Vo_empleado();

        Dao_empleado pxy_empleado = (Pxy_empleado)Fty_fabrica.Fabricar(new Pxy_empleado());

        C_message c_message;

        Capa_Vista.frm_employee frm;

        C_empleado_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();


        public C_empleado()
        {
            frm = new Capa_Vista.frm_employee();
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
                if ((C_logeo.permisos[i, 0] == 2))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableEmployee.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_people_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableEmployee.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableEmployee.Layout += new LayoutEventHandler(dtgTablePeople_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableEmployee.CellMouseEnter += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseEnter);
            frm.dtgTableEmployee.CellMouseLeave += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseLeave);
            permisos();
        }

        private void read_persona(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_empleado.READ();
            frm.dtgTableEmployee.DataSource = dt;
            frm.dtgTableEmployee.ClearSelection();
            e_empleado.Clave = 0;
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
        private void frm_people_Load(object sender, EventArgs e)
        {
            read_persona();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_empleado_crud();
          
            using (frm_employee_crud crud_empleado = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_empleado.btnAcept.Click += new EventHandler(read_persona);
                crud_empleado.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTablePeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_empleado.Clave = Convert.ToInt16(frm.dtgTableEmployee.Rows[e.RowIndex].Cells["id_empleado"].Value.ToString());
            e_empleado.Rfc_persona = frm.dtgTableEmployee.Rows[e.RowIndex].Cells["empleado"].Value.ToString();
            e_empleado.Rfc_jefe = frm.dtgTableEmployee.Rows[e.RowIndex].Cells["jefe"].Value.ToString();
            e_empleado.Puesto = frm.dtgTableEmployee.Rows[e.RowIndex].Cells["puesto"].Value.ToString();
            e_empleado.Sucursal = frm.dtgTableEmployee.Rows[e.RowIndex].Cells["sucursal"].Value.ToString();
            e_empleado.Turno = frm.dtgTableEmployee.Rows[e.RowIndex].Cells["turno"].Value.ToString();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_empleado.Clave != 0)
            {
                e_empleado.Operacion = "update";

                frm_crud = new C_empleado_crud(e_empleado);

                using (frm_employee_crud crud_empleado = frm_crud.formulario())
                {
                    crud_empleado.btnAcept.Click += new EventHandler(read_persona);
                    crud_empleado.ShowDialog();
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

            if (e_empleado.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_empleado.DELETE(e_empleado))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_persona();
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
            frm.dtgTableEmployee.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_empleado.Expresion = frm.txtSearch.Text;

                frm.dtgTableEmployee.DataSource = pxy_empleado.SEARCH(e_empleado);
                frm.dtgTableEmployee.ClearSelection();
            }
            else
            {
                read_persona();
            }
        }
        private void dtgTablePeople_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableEmployee.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTablePeople_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableEmployee.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
