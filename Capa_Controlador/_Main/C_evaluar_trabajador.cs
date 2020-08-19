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
    class C_evaluar_trabajador
    {
        Vo_evaluar_trabajador e_evaluar = new Vo_evaluar_trabajador();

        Dao_evaluar_trabajador pxy_evaluar = (Pxy_evaluar_trabajador)Fty_fabrica.Fabricar(new Pxy_evaluar_trabajador());

        C_message c_message;

        Capa_Vista.frm_evaluate_worker frm;

        C_evaluar_trabajador_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();


        public C_evaluar_trabajador()
        {
            frm = new Capa_Vista.frm_evaluate_worker();
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
                if ((C_logeo.permisos[i, 0] == 16))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableEvaluateWorker.Enabled = true;
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
           
            frm.Load += new EventHandler(frm_evaluate_worker_Load);
            frm.btnAdd.Click += new EventHandler(btnAdd_Click);
            frm.dtgTableEvaluateWorker.CellClick += new DataGridViewCellEventHandler(dtgTableEvaluateWorker_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableEvaluateWorker.Layout += new LayoutEventHandler(dtgTableEvaluateWorker_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableEvaluateWorker.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableEvaluateWorker_CellMouseEnter);
            frm.dtgTableEvaluateWorker.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableEvaluateWorker_CellMouseLeave);
            permisos();
        }

        private void read_evaluate_worker(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_evaluar.READ();
            frm.dtgTableEvaluateWorker.DataSource = dt;
            frm.dtgTableEvaluateWorker.ClearSelection();
            e_evaluar.Clave = 0;
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
        private void frm_evaluate_worker_Load(object sender, EventArgs e)
        {
            read_evaluate_worker();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_evaluar_trabajador_crud();
          
            using (frm_evaluate_worker_crud crud_evaluate = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_evaluate.btnAcept.Click += new EventHandler(read_evaluate_worker);
                crud_evaluate.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTableEvaluateWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_evaluar.Clave = Convert.ToInt16(frm.dtgTableEvaluateWorker.Rows[e.RowIndex].Cells["clave"].Value.ToString());
            e_evaluar.Trabajador = frm.dtgTableEvaluateWorker.Rows[e.RowIndex].Cells["nombre_trabajador"].Value.ToString();
            e_evaluar.Documento = Convert.ToInt16(frm.dtgTableEvaluateWorker.Rows[e.RowIndex].Cells["id_requerimiento"].Value.ToString());
            e_evaluar.Observaciones = frm.dtgTableEvaluateWorker.Rows[e.RowIndex].Cells["observaciones"].Value.ToString();
            e_evaluar.Estado = frm.dtgTableEvaluateWorker.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_evaluar.Clave != 0)
            {
                e_evaluar.Operacion = "update";

                frm_crud = new C_evaluar_trabajador_crud(e_evaluar);

                using (frm_evaluate_worker_crud crud_assing = frm_crud.formulario())
                {
                    crud_assing.btnAcept.Click += new EventHandler(read_evaluate_worker);
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

            if (e_evaluar.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_evaluar.DELETE(e_evaluar))
                    {
                        c_message.message("Error al eliminar", C_message.message_type.error);
                    }
                    read_evaluate_worker();
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTableEvaluateWorker_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableEvaluateWorker.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_evaluar.Expresion = frm.txtSearch.Text;

                frm.dtgTableEvaluateWorker.DataSource = pxy_evaluar.SEARCH(e_evaluar);
                frm.dtgTableEvaluateWorker.ClearSelection();
            }
            else
            {
                read_evaluate_worker();
            }
        }
        private void dtgTableEvaluateWorker_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableEvaluateWorker.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableEvaluateWorker_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableEvaluateWorker.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
