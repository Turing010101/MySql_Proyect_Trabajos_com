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
    class C_servicio_select
    {
        Vo_servicio e_servicio = new Vo_servicio();

        Dao_servicio pxy_servicio = (Pxy_servicio)Fty_fabrica.Fabricar(new Pxy_servicio());

        C_message c_message;

        Capa_Vista.frm_servicio_select frm;

        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();


        public C_servicio_select()
        {
            frm = new Capa_Vista.frm_servicio_select();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            InitializeEvents();
        }
        public frm_servicio_select getFormulario()
        {
            return frm;
        }

        private void InitializeEvents()
        {
           
            frm.Load += new EventHandler(frm_people_Load);
            frm.btnSelect.Click += new EventHandler(btnSelect_Click);
            frm.dtgTableServiceS.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.dtgTableServiceS.Layout += new LayoutEventHandler(dtgTableService_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableServiceS.CellMouseEnter += new DataGridViewCellEventHandler(dtgService_CellMouseEnter);
            frm.dtgTableServiceS.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableService_CellMouseLeave);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);

        }

        private void read_client(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_servicio.READ();
            frm.dtgTableServiceS.DataSource = dt;
            frm.dtgTableServiceS.ClearSelection();
            e_servicio.Clave = 0;
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

        private void ptbClose_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        private void frm_people_Load(object sender, EventArgs e)
        {
            read_client();
        }
        private void dtgTablePeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_servicio.Clave = Convert.ToInt16(frm.dtgTableServiceS.Rows[e.RowIndex].Cells["clave_servicio"].Value.ToString());

            C_factura.nombre_servicio = frm.dtgTableServiceS.Rows[e.RowIndex].Cells["servicio_nombre"].Value.ToString();
            C_factura.descripcion_serivico = frm.dtgTableServiceS.Rows[e.RowIndex].Cells["servicio_descripcion"].Value.ToString();
            C_factura.precio_servicio = frm.dtgTableServiceS.Rows[e.RowIndex].Cells["servicio_costo"].Value.ToString();
            C_factura.clave_servicio = e_servicio.Clave;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (e_servicio.Clave != 0)
            {
                frm.Close();
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
                overlayForm.Dispose();
            }
        }
       
        private void dtgTableService_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableServiceS.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_servicio.Expresion = frm.txtSearch.Text;

                frm.dtgTableServiceS.DataSource = pxy_servicio.SEARCH(e_servicio);
                frm.dtgTableServiceS.ClearSelection();
            }
            else
            {
                read_client();
            }
        }
        private void dtgService_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableServiceS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableService_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableServiceS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
