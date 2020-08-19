using System;
using System.Drawing;
using System.Data;
using Capa_Vista;
using System.Windows.Forms;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._VO;
using Capa_Modelo._DAO;
using System.IO;

namespace Capa_Controlador
{
    class C_trabajador
    {
        Vo_trabajador e_trabajador = new Vo_trabajador();

        Dao_trabajador pxy_trabajador = (Pxy_trabajador)Fty_fabrica.Fabricar(new Pxy_trabajador());

        C_message c_message;

        Capa_Vista.frm_woker frm;

        C_trabajador_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();
      
        public C_trabajador()
        {
            frm = new Capa_Vista.frm_woker();
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
                if ((C_logeo.permisos[i, 0] == 3))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableWorker.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_worker_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableWorker.CellClick += new DataGridViewCellEventHandler(dtgTableWorker_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableWorker.Layout += new LayoutEventHandler(dtgTableWorker_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableWorker.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableWorker_CellMouseEnter);
            frm.dtgTableWorker.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableWorker_CellMouseLeave);
            permisos();
        }

        private void read_trabajador(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_trabajador.READ();
            frm.dtgTableWorker.DataSource = dt;
            frm.dtgTableWorker.ClearSelection();
            e_trabajador.Clave = 0;
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
        private void frm_worker_Load(object sender, EventArgs e)
        {
            read_trabajador();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_trabajador_crud();
          
            using (frm_woker_crud crud_trabajador = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_trabajador.btnAcept.Click += new EventHandler(read_trabajador);
                crud_trabajador.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTableWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_trabajador.Clave = Convert.ToInt16(frm.dtgTableWorker.Rows[e.RowIndex].Cells["id_trabajador"].Value.ToString());
            e_trabajador.Rfc = frm.dtgTableWorker.Rows[e.RowIndex].Cells["rfc"].Value.ToString();
            e_trabajador.Persona = frm.dtgTableWorker.Rows[e.RowIndex].Cells["nombre"].Value.ToString() + " " + frm.dtgTableWorker.Rows[e.RowIndex].Cells["apellido_paterno"].Value.ToString() + " " + frm.dtgTableWorker.Rows[e.RowIndex].Cells["apellido_materno"].Value.ToString();
            e_trabajador.Sucursal = frm.dtgTableWorker.Rows[e.RowIndex].Cells["sucursal"].Value.ToString();
            e_trabajador.Estado = frm.dtgTableWorker.Rows[e.RowIndex].Cells["estado_trabajador"].Value.ToString();
            e_trabajador.Calificacion = Convert.ToInt16(frm.dtgTableWorker.Rows[e.RowIndex].Cells["calificacion"].Value.ToString());

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_trabajador.Clave != 0)
            {
                e_trabajador.Operacion = "update";

                frm_crud = new C_trabajador_crud(e_trabajador);

                using (frm_woker_crud crud_trabajador = frm_crud.formulario())
                {
                    crud_trabajador.btnAcept.Click += new EventHandler(read_trabajador);
                    crud_trabajador.ShowDialog();
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

            if (e_trabajador.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!(pxy_trabajador.DELETE(e_trabajador)))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }

                    read_trabajador();
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTableWorker_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableWorker.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_trabajador.Expresion = frm.txtSearch.Text;

                frm.dtgTableWorker.DataSource = pxy_trabajador.SEARCH(e_trabajador);
                frm.dtgTableWorker.ClearSelection();
            }
            else
            {
                read_trabajador();
            }
        }
        private void dtgTableWorker_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableWorker.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableWorker_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableWorker.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
