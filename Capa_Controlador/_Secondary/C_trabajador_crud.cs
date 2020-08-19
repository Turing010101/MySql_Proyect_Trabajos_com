using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._Visitor;
using Capa_Modelo._VO;
using Capa_Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_trabajador_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_trabajador vo_trabajador = new Vo_trabajador();
        C_validacion valida = new C_validacion();

        Dao_trabajador pxy_trabajador = (Pxy_trabajador)Fty_fabrica.Fabricar(new Pxy_trabajador());

        C_message c_message;
        C_persona_select frm_select_people;

        public static string rfc_trabajador;
        public static string nombre_trabajador;

        Capa_Vista.frm_woker_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

        string mensaje_sucursal = "--Elegir--";

        public C_trabajador_crud(Vo_trabajador trabajador = null)
        {
            frm = new Capa_Vista.frm_woker_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            vo_trabajador.Operacion = "insert";
            InitializeEvents();
            read_office();

            if (trabajador != null)
            {
                vo_trabajador.Clave = trabajador.Clave;
                vo_trabajador.Operacion = trabajador.Operacion;
                
                mensaje_sucursal = trabajador.Sucursal.ToString();
                rfc_trabajador = trabajador.Rfc;
                frm.txtTrabajador.Text = trabajador.Persona;
                frm.txtRating.Text = trabajador.Calificacion.ToString();
                frm.cmbEstado.Text = trabajador.Estado.ToString();
            }
        }
        public frm_woker_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_worker_crud_Load);
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);

            frm.txtRating.KeyPress += new KeyPressEventHandler(txtRating_KeyPress);
            frm.btnBuscarTrabjador.Click += new EventHandler(btnSelectPeople_Click);

            frm.cmbOffice.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbEstado.KeyDown += new KeyEventHandler(cmb_KeyDown);

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
        private void read_office()
        {
            frm.cmbOffice.DataSource = pxy_trabajador.LIST_OFFICE();
            frm.cmbOffice.DisplayMember = "nombre";
            frm.cmbOffice.ValueMember = "id";

        }
        private void cmb_KeyDown(object sender, KeyEventArgs e)
        {
            // ComboBox is readonly 
            e.SuppressKeyPress = true;
        }
        private void read_trabajador(object sender = null, EventArgs e = null)
        {
            frm.txtTrabajador.Text = nombre_trabajador;
        }
        private void btnSelectPeople_Click(object sender, EventArgs e)
        {
            frm_select_people = new C_persona_select();

            using (frm_people_select select_cliente = frm_select_people.getFormulario())
            {
                desenfoque_abrir_formulario();

                select_cliente.btnSelect.Click += new EventHandler(read_trabajador);
                select_cliente.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
        }
        private void txtRating_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumero(e, frm.txtRating, 10);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtRating.Focus();
            }
        }
        private void ptbClose_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapturea();
            SendMessage(frm.Handle, 0x112, 0xf012, 0);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (valida.CampoObligatorio(frm.pnlContent))
            {
                vo_trabajador.Persona = rfc_trabajador;
                vo_trabajador.Estado = frm.cmbEstado.SelectedItem.ToString();

                vo_trabajador.Sucursal = Convert.ToInt16(frm.cmbOffice.SelectedValue.ToString());
                vo_trabajador.Calificacion = Convert.ToInt16(frm.txtRating.Text);

                if (vo_trabajador.Operacion.Equals("update"))
                {
                    desenfoque_abrir_formulario();

                    if (pxy_trabajador.UPDATE(vo_trabajador))
                    {
                        c_message.message("Registro actualizado con exito", C_message.message_type.information);
                        frm.Close();
                    }
                    else
                    {
                        c_message.message("Se produjo un error al actualizar", C_message.message_type.error);
                    }
                    overlayForm.Dispose();
                }
                else if (vo_trabajador.Operacion.Equals("insert"))
                {
                    desenfoque_abrir_formulario();

                    if (pxy_trabajador.CREATE(vo_trabajador))
                    {
                        c_message.message("Registro guardado con exito ", C_message.message_type.information);
                        frm.Close();
                    }
                    else
                    {
                        c_message.message("Se produjo un error al guardar ", C_message.message_type.error);

                    }
                    overlayForm.Dispose();
                }
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("No deje campos vacios ", C_message.message_type.error);
                overlayForm.Dispose();
            }

        }
        private void frm_worker_crud_Load(object sender, EventArgs e)
        {
            frm.cmbOffice.Text = mensaje_sucursal;
        }
    }
}
