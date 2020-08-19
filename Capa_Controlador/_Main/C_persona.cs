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
    class C_persona
    {
        Vo_persona e_persona = new Vo_persona();

        Dao_persona pxy_persona = (Pxy_persona)Fty_fabrica.Fabricar(new Pxy_persona());

        C_message c_message;

        Capa_Vista.frm_people frm;

        C_persona_crud frm_crud;
        C_establecer_crud frm_establish;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

      
        DialogResult resultado = new DialogResult();

        public C_persona()
        {
            frm = new Capa_Vista.frm_people();
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
                if ((C_logeo.permisos[i, 0] == 1))
                {
                        switch (C_logeo.permisos[i, 1])
                        {
                            case 1:
                                frm.btnAdd.Enabled = true;
                                break;
                            case 2:
                                 frm.dtgTablePeople.Enabled = true;
                                 break;
                            case 3:
                                frm.btnUpdate.Enabled = true;
                                break;
                            case 4:
                                frm.btnDelete.Enabled = true;
                                break;
                            case 5:
                                 frm.btnEstablish.Enabled = true;
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
            frm.dtgTablePeople.CellClick += new DataGridViewCellEventHandler(dtgTablePeople_CellClick);
            frm.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frm.btnDelete.Click += new EventHandler(btnDelete_Click);
            frm.btnEstablish.Click += new EventHandler(btnEstablish_Click);
            frm.dtgTablePeople.Layout += new LayoutEventHandler(dtgTablePeople_Layout);
            frm.txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            frm.dtgTablePeople.CellMouseEnter += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseEnter);
            frm.dtgTablePeople.CellMouseLeave += new DataGridViewCellEventHandler(dtgTablePeople_CellMouseLeave);
            permisos();
        }

        private void read_persona(object sender = null, EventArgs e = null)
        {
            DataTable dt = pxy_persona.READ();
            frm.dtgTablePeople.DataSource = dt;
            frm.dtgTablePeople.ClearSelection();
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
        private void frm_people_Load(object sender, EventArgs e)
        {
            read_persona();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           frm_crud = new C_persona_crud();
          
            using (frm_people_crud crud_people = frm_crud.formulario())
            {
                desenfoque_abrir_formulario();

                crud_people.btnAcept.Click += new EventHandler(read_persona);
                crud_people.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTablePeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }
            e_persona.Clave = Convert.ToInt16(frm.dtgTablePeople.Rows[e.RowIndex].Cells["clave"].Value.ToString());
            e_persona.Rfc = frm.dtgTablePeople.Rows[e.RowIndex].Cells["rfc"].Value.ToString();
            e_persona.Nombre = frm.dtgTablePeople.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            e_persona.Apellido_paterno = frm.dtgTablePeople.Rows[e.RowIndex].Cells["apellido_paterno"].Value.ToString();
            e_persona.Apellido_materno = frm.dtgTablePeople.Rows[e.RowIndex].Cells["apellido_materno"].Value.ToString();
            e_persona.Sexo = Convert.ToChar(frm.dtgTablePeople.Rows[e.RowIndex].Cells["sexo"].Value.ToString());
            e_persona.Status = frm.dtgTablePeople.Rows[e.RowIndex].Cells["statu"].Value.ToString();
            e_persona.Telefono_personal = frm.dtgTablePeople.Rows[e.RowIndex].Cells["telefono_personal"].Value.ToString();
            e_persona.Telefono_periente = frm.dtgTablePeople.Rows[e.RowIndex].Cells["telefono_pariente"].Value.ToString();
            e_persona.Correo_electronico = frm.dtgTablePeople.Rows[e.RowIndex].Cells["correo_electronico"].Value.ToString();
            e_persona.Localidad = frm.dtgTablePeople.Rows[e.RowIndex].Cells["localidad"].Value.ToString();
            e_persona.Nombre_calle = frm.dtgTablePeople.Rows[e.RowIndex].Cells["nombre_calle"].Value.ToString();
            e_persona.Numero_calle = frm.dtgTablePeople.Rows[e.RowIndex].Cells["numero_calle"].Value.ToString();
            e_persona.Municipio = frm.dtgTablePeople.Rows[e.RowIndex].Cells["municipio"].Value.ToString();
            e_persona.Estado = frm.dtgTablePeople.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            e_persona.Codigo_postal = frm.dtgTablePeople.Rows[e.RowIndex].Cells["codigo_postal"].Value.ToString();
            e_persona.Fecha_registro = Convert.ToDateTime(frm.dtgTablePeople.Rows[e.RowIndex].Cells["fecha_registro"].Value.ToString());
            e_persona.Rol = frm.dtgTablePeople.Rows[e.RowIndex].Cells["rol"].Value.ToString();

            if (frm.dtgTablePeople.Rows[e.RowIndex].Cells["foto"].Value!=DBNull.Value) {
                e_persona.Fotografia = (byte[])frm.dtgTablePeople.Rows[e.RowIndex].Cells["foto"].Value;
            }
            else
            {
                e_persona.Fotografia = null;
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();
            if (e_persona.Clave != 0)
            {
                e_persona.Operacion = "update";
                e_persona.Visible = false;

                frm_crud = new C_persona_crud(e_persona);

                using (frm_people_crud crud_people = frm_crud.formulario())
                {
                    crud_people.btnAcept.Click += new EventHandler(read_persona);
                    crud_people.ShowDialog();
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

            if (e_persona.Clave != 0)
            {

                c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                resultado = message_box.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    if (!pxy_persona.DELETE(e_persona))
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
        private void btnEstablish_Click(object sender, EventArgs e)
        {
            frm_establish = new C_establecer_crud();

            using (frm_establish_crud crud_establish = frm_establish.formulario())
            {
                desenfoque_abrir_formulario();
                crud_establish.btnAcept.Click += new EventHandler(read_persona);
                crud_establish.ShowDialog();
                overlayForm.Dispose();
            }

        }
        private void dtgTablePeople_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTablePeople.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (frm.txtSearch.Text != "")
            {
                e_persona.Expresion = frm.txtSearch.Text;

                frm.dtgTablePeople.DataSource = pxy_persona.SEARCH(e_persona);
                frm.dtgTablePeople.ClearSelection();
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
                frm.dtgTablePeople.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTablePeople_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTablePeople.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
