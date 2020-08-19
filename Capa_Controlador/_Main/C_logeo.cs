using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._Visitor;
using Capa_Modelo._VO;
using Capa_Vista;
namespace Capa_Controlador
{
    public class C_logeo
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Capa_Vista.frm_login frm;
        frm_blur overlayForm;

        C_main c_main;
        C_message c_message;

        C_recuperar c_recuperar;
        Vo_login e_login = new Vo_login();
        C_validacion validar = new C_validacion();

        Dao_login pxy_login = (Pxy_login)Fty_fabrica.Fabricar(new Pxy_login());
        Dao_permiso pxy_permiso = (Pxy_permiso)Fty_fabrica.Fabricar(new Pxy_permiso());

        Capa_Vista.frm_message_ok message_box;

         public static int[,] permisos;
         public static int[] clave;

        int intentos = 3;

        public C_logeo()
        {  
            frm = new Capa_Vista.frm_login();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();
            c_main = new C_main();
        }

        public void InitializeEvents()
        {
            frm.btnAceptar.Click += new EventHandler(btnAceptar_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.lkl_recuperar.LinkClicked += new LinkLabelLinkClickedEventHandler(lkl_recuperar_LinkClicked);

            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);

            frm.txt_user.Enter += new EventHandler(txtUser_Enter);
            frm.txt_user.Leave += new EventHandler(txtUser_Leave);
            frm.txt_password.Enter += new EventHandler(txtPassword_Enter);
            frm.txt_password.Leave += new EventHandler(txtPassword_Leave);

            frm.ptbInvisible.MouseHover += new EventHandler(ptbVisible_Hover);
            frm.ptbInvisible.MouseLeave += new EventHandler(ptbVisible_Leave);

            desenfoque_abrir_formulario();
            frm.ShowDialog();
        }
        private void ptbClose_Click(object sender, EventArgs e)
        {
            overlayForm.Dispose();
            Application.Exit();
        }
        private void lkl_recuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            overlayForm.Dispose();
            frm.Hide();
            c_recuperar = new C_recuperar();
            c_recuperar.InitializeEvents();
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapturea();
            SendMessage(frm.Handle, 0x112, 0xf012, 0);
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
        private void txtUser_Enter(object sender,EventArgs e)
        {
            if (frm.txt_user.Text=="USUARIO")
            {
                frm.txt_user.Text = string.Empty;
            }
           
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (frm.txt_user.Text == "")
            {
                frm.txt_user.Text = "USUARIO";
            }

        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (frm.txt_password.Text == "CONTRASEÑA")
            {
                frm.txt_password.Text = string.Empty;
                frm.txt_password.UseSystemPasswordChar = true;
            }

        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (frm.txt_password.Text == "")
            {
                frm.txt_password.Text = "CONTRASEÑA";
                frm.txt_password.UseSystemPasswordChar = false;
            }

        }
        private void ptbVisible_Leave(object sender, EventArgs e)
        {
            frm.txt_password.Focus();
            frm.txt_password.UseSystemPasswordChar = true;
        }
        private void ptbVisible_Hover(object sender, EventArgs e)
        {
            frm.ptbInvisible.Focus();
            frm.txt_password.UseSystemPasswordChar = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (frm.txt_password.Text!="CONTRASEÑA" || frm.txt_user.Text!="USUARIO")
            {
                if (validar.SqlInjection(frm))
                {
                    e_login.Usuario = frm.txt_user.Text;
                    e_login.Contrasena = Vst_seguridad.GetSHA256(frm.txt_password.Text);

                    clave = pxy_login.SEARCH(e_login);

                    if (clave[0] != 0)
                    {
                        permisos = pxy_permiso.FIND(clave[1]);
                        overlayForm.Dispose();
                        frm.Hide();
                        c_main.InitializeEvents();
                    }
                    else
                    {
                        desenfoque_abrir_formulario();
                        c_message.message("No hay ninguna cuenta con dichos datos ", C_message.message_type.error);
                        overlayForm.Dispose();
                        intentos--;
                    }
                }
                else
                {
                    desenfoque_abrir_formulario();
                    c_message.message("Por seguridad no ingresar: ' = or ", C_message.message_type.warning);
                    overlayForm.Dispose();
                    intentos--;
                }
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("No deje campos vacios ", C_message.message_type.error);
                overlayForm.Dispose();
                intentos--;
            }

            if (intentos==0)
            {
                desenfoque_abrir_formulario();
                c_message.message("Superaste la cantidad de intentos ", C_message.message_type.warning);
                overlayForm.Dispose();
                Application.Exit();
            }
         
        }

    }
}
