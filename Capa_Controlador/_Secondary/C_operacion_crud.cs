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
    class C_operacion_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_operacion vo_operacion = new Vo_operacion();
        C_validacion valida = new C_validacion();

        Dao_operacion pxy_operacion = (Pxy_operacion)Fty_fabrica.Fabricar(new Pxy_operacion());
    
        C_message c_message;

        Capa_Vista.frm_operation_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

        string mensaje_modulo = "--Elegir--";
        string mensaje_accion = "--Elegir--";

        public C_operacion_crud(Vo_operacion operacion = null)
        {
            frm = new Capa_Vista.frm_operation_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            vo_operacion.Operacion = "insert";
            InitializeEvents();
            read_modulo();
            read_accion();

            if (operacion != null)
            {
                vo_operacion.Clave = operacion.Clave;
                vo_operacion.Operacion = operacion.Operacion;

                mensaje_modulo = operacion.Modulo.ToString();
                mensaje_accion = operacion.Accion.ToString();
            }
        }
        public frm_operation_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_operation_crud_Load);
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);

            frm.cmbModule.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbAction.KeyDown += new KeyEventHandler(cmb_KeyDown);

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
        private void read_modulo()
        {
            frm.cmbModule.DataSource = pxy_operacion.LIST_MODULE();
            frm.cmbModule.DisplayMember = "nombre";
            frm.cmbModule.ValueMember = "id";

        }
        private void read_accion()
        {
            frm.cmbAction.DataSource = pxy_operacion.LIST_ACTION();
            frm.cmbAction.DisplayMember = "nombre";
            frm.cmbAction.ValueMember = "id";

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
                vo_operacion.Modulo = Convert.ToInt16(frm.cmbModule.SelectedValue.ToString());
                vo_operacion.Accion = Convert.ToInt16(frm.cmbAction.SelectedValue.ToString());

                    if (vo_operacion.Operacion.Equals("update"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_operacion.UPDATE(vo_operacion))
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
                    else if (vo_operacion.Operacion.Equals("insert"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_operacion.CREATE(vo_operacion))
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
        private void frm_operation_crud_Load(object sender, EventArgs e)
        {
            frm.cmbModule.Text = mensaje_modulo;
            frm.cmbAction.Text = mensaje_accion;
        }

    }
}
