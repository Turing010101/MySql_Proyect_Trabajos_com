using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._VO;
using Capa_Vista;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_establecer_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_persona vo_persona = new Vo_persona();
        C_validacion valida = new C_validacion();

        Dao_persona pxy_persona = (Pxy_persona)Fty_fabrica.Fabricar(new Pxy_persona());

        C_message c_message;

        Capa_Vista.frm_establish_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;
        

        public C_establecer_crud(Vo_rol rol = null)
        {
            frm = new Capa_Vista.frm_establish_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();
            InitializeEvents();
        }
        public frm_establish_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);
            
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
            vo_persona.Fecha_contrasena = frm.mthEstablecer.SelectionStart.ToString("yyyy-MM-dd");

            desenfoque_abrir_formulario();

            if (pxy_persona.ESTABLISH(vo_persona))
            {
               c_message.message("Se estableció la fecha para actualización", C_message.message_type.information);
               frm.Close();
            }
            else
            {
             c_message.message("No se estableció la fecha", C_message.message_type.error);
            }
            overlayForm.Dispose();
        }

    }
}
