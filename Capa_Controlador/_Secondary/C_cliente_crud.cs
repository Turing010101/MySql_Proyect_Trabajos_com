using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._Visitor;
using Capa_Modelo._VO;
using Capa_Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_cliente_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_cliente vo_cliente = new Vo_cliente();
        C_validacion valida = new C_validacion();

        Dao_cliente pxy_cliente = (Pxy_cliente)Fty_fabrica.Fabricar(new Pxy_cliente());
    
        C_message c_message;

        Capa_Vista.frm_client_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

        string mensaje_persona = "--Elegir--";

        public C_cliente_crud(Vo_cliente cliente = null)
        {
            frm = new Capa_Vista.frm_client_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            vo_cliente.Operacion = "insert";
            InitializeEvents();
            read_people();

            if (cliente != null)
            {
                vo_cliente.Clave = cliente.Clave;
                vo_cliente.Operacion = cliente.Operacion;

                mensaje_persona = cliente.Rfc_persona;
                frm.txtRating.Text = cliente.Rating.ToString();
            }
        }
        public frm_client_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_people_crud_Load);
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);

            frm.txtRating.KeyPress += new KeyPressEventHandler(txtRating_KeyPress);
            frm.cmbPeople.KeyDown += new KeyEventHandler(cmb_KeyDown);

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
        private void read_people()
        {
            frm.cmbPeople.DataSource = pxy_cliente.LIST_PEOPLE();
            frm.cmbPeople.DisplayMember = "nombre";
            frm.cmbPeople.ValueMember = "rfc";

        }
        private void txtRating_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumero(e, frm.txtRating, 10);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtRating.Focus();
            }
        }
        private void cmb_KeyDown(object sender, KeyEventArgs e)
        {
            // ComboBox is readonly 
            e.SuppressKeyPress = true;
        }
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
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
                vo_cliente.Rfc_persona = frm.cmbPeople.SelectedValue.ToString();
                vo_cliente.Rating = Convert.ToInt16(frm.txtRating.Text);

                    if (vo_cliente.Operacion.Equals("update"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_cliente.UPDATE(vo_cliente))
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
                    else if (vo_cliente.Operacion.Equals("insert"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_cliente.CREATE(vo_cliente))
                        {
                            c_message.message("Registro guardado con exito", C_message.message_type.information);
                            frm.Close();
                        }
                        else
                        {
                            c_message.message("Se produjo un error al guardar", C_message.message_type.error);

                        }
                        overlayForm.Dispose();
                    }
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("No deje campos vacios", C_message.message_type.error);
                overlayForm.Dispose();
            }

        }
        private void frm_people_crud_Load(object sender, EventArgs e)
        {
            frm.cmbPeople.Text = mensaje_persona;
        }

    }
}
