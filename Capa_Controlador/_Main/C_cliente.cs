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
    class C_cliente
    {
        Vo_cliente e_cliente = new Vo_cliente();

        Dao_cliente pxy_cliente = (Pxy_cliente)Fty_fabrica.Fabricar(new Pxy_cliente());

        C_message c_message;

        Capa_Vista.frm_client frm;

        C_cliente_crud frm_crud;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();


        public C_cliente()
        {
            frm = new Capa_Vista.frm_client();
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
                if ((C_logeo.permisos[i, 0] == 6))
                {
                    switch (C_logeo.permisos[i, 1])
                    {
                        case 1:
                            frm.btnAdd.Enabled = true;
                            break;
                        case 2:
                            frm.dtgTableClient.Enabled = true;
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
            frm.dtgTableClient.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.dtgTableClient.Layout += new LayoutEventHandler(dtgTablePeople_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTableClient.CellMouseEnter += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseEnter);
            frm.dtgTableClient.CellMouseLeave += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseLeave);
            permisos();
        }

        private void read_persona(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_cliente.READ();
            frm.dtgTableClient.DataSource = dt;
            frm.dtgTableClient.ClearSelection();
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
        private void frm_people_Load(object sender, EventArgs e)
        {
            read_persona();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_cliente_crud();
          
            using (frm_client_crud crud_cliente = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_cliente.btnAcept.Click += new EventHandler(read_persona);
                crud_cliente.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTablePeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_cliente.Clave = Convert.ToInt16(frm.dtgTableClient.Rows[e.RowIndex].Cells["id_cliente"].Value.ToString());
            e_cliente.Rfc_persona = frm.dtgTableClient.Rows[e.RowIndex].Cells["cliente"].Value.ToString();
            e_cliente.Rating = Convert.ToInt16(frm.dtgTableClient.Rows[e.RowIndex].Cells["rating"].Value.ToString());

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_cliente.Clave != 0)
            {
                e_cliente.Operacion = "update";

                frm_crud = new C_cliente_crud(e_cliente);

                using (frm_client_crud crud_cliente = frm_crud.formulario())
                {
                    crud_cliente.btnAcept.Click += new EventHandler(read_persona);
                    crud_cliente.ShowDialog();
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

            if (e_cliente.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_cliente.DELETE(e_cliente))
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
            frm.dtgTableClient.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_cliente.Expresion = frm.txtSearch.Text;

                frm.dtgTableClient.DataSource = pxy_cliente.SEARCH(e_cliente);
                frm.dtgTableClient.ClearSelection();
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
                frm.dtgTableClient.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTablePeople_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableClient.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
