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
    class C_jefe_select
    {
        Vo_persona e_persona = new Vo_persona();

        Dao_persona pxy_persona = (Pxy_persona)Fty_fabrica.Fabricar(new Pxy_persona());

        C_message c_message;

        Capa_Vista.frm_boss_select frm;

        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

        public C_jefe_select()
        {
            frm = new Capa_Vista.frm_boss_select();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            InitializeEvents();
        }
        public frm_boss_select getFormulario()
        {
            return frm;
        }

        private void InitializeEvents()
        {
           
            frm.Load += new EventHandler(frm_people_Load);
            frm.btnSelect.Click += new EventHandler(btnSelect_Click);
            frm.dtgTableBossS.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.dtgTableBossS.Layout += new LayoutEventHandler(dtgTableClient_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableBossS.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableClient_CellMouseEnter);
            frm.dtgTableBossS.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableClient_CellMouseLeave);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);

        }

        private void read_client(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_persona.READ();
            frm.dtgTableBossS.DataSource = dt;
            frm.dtgTableBossS.ClearSelection();
            e_persona.Clave = 0;
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
            e_persona.Clave = Convert.ToUInt16(frm.dtgTableBossS.Rows[e.RowIndex].Cells["clave"].Value.ToString());
            e_persona.Rfc = frm.dtgTableBossS.Rows[e.RowIndex].Cells["rfc"].Value.ToString();

            C_empleado_crud.nombre_jefe = frm.dtgTableBossS.Rows[e.RowIndex].Cells["nombre"].Value.ToString() + " " + frm.dtgTableBossS.Rows[e.RowIndex].Cells["apellido_paterno"].Value.ToString() + " " + frm.dtgTableBossS.Rows[e.RowIndex].Cells["apellido_materno"].Value.ToString();
            C_empleado_crud.rfc_jefe = e_persona.Rfc.ToString();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (e_persona.Clave != 0)
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
            frm.dtgTableBossS.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_persona.Expresion = frm.txtSearch.Text;

                frm.dtgTableBossS.DataSource = pxy_persona.SEARCH(e_persona);
                frm.dtgTableBossS.ClearSelection();
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
                frm.dtgTableBossS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableClient_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableBossS.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
