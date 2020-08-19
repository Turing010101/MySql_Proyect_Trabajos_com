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
    class C_cliente_select
    {
        Vo_cliente e_cliente = new Vo_cliente();

        Dao_cliente pxy_cliente = (Pxy_cliente)Fty_fabrica.Fabricar(new Pxy_cliente());

        C_message c_message;

        Capa_Vista.frm_client_select frm;

        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();


        public C_cliente_select()
        {
            frm = new Capa_Vista.frm_client_select();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            InitializeEvents();
        }
        public frm_client_select getFormulario()
        {
            return frm;
        }

        private void InitializeEvents()
        {
           
            frm.Load += new EventHandler(frm_people_Load);
            frm.btnSelect.Click += new EventHandler(btnSelect_Click);
            frm.dtgTableClientS.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.dtgTableClientS.Layout += new LayoutEventHandler(dtgTableClient_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableClientS.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableClient_CellMouseEnter);
            frm.dtgTableClientS.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableClient_CellMouseLeave);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);

        }

        private void read_client(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_cliente.READ();
            frm.dtgTableClientS.DataSource = dt;
            frm.dtgTableClientS.ClearSelection();
            e_cliente.Clave = 0;
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
            e_cliente.Clave = Convert.ToInt16(frm.dtgTableClientS.Rows[e.RowIndex].Cells["id_cliente"].Value.ToString());

            C_factura.nombre_cliente = frm.dtgTableClientS.Rows[e.RowIndex].Cells["nombre"].Value.ToString() + " " + frm.dtgTableClientS.Rows[e.RowIndex].Cells["apellido_paterno"].Value.ToString() + " " + frm.dtgTableClientS.Rows[e.RowIndex].Cells["apellido_materno"].Value.ToString();
            C_factura.clave_cliente = e_cliente.Clave;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (e_cliente.Clave != 0)
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
       
        private void dtgTableClient_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableClientS.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_cliente.Expresion = frm.txtSearch.Text;

                frm.dtgTableClientS.DataSource = pxy_cliente.SEARCH(e_cliente);
                frm.dtgTableClientS.ClearSelection();
            }
            else
            {
                read_client();
            }
        }
        private void dtgTableClient_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableClientS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableClient_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableClientS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
