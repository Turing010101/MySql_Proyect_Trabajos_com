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
    class C_rol_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_rol vo_rol = new Vo_rol();
        C_validacion valida = new C_validacion();

        Dao_rol pxy_rol = (Pxy_rol)Fty_fabrica.Fabricar(new Pxy_rol());

        C_message c_message;

        Capa_Vista.frm_role_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;
        

        public C_rol_crud(Vo_rol rol = null)
        {
            frm = new Capa_Vista.frm_role_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            vo_rol.Operacion = "insert";
            InitializeEvents();

            if (rol != null)
            {
                vo_rol.Clave = rol.Clave;
                vo_rol.Operacion = rol.Operacion;
                frm.txtName.Text = rol.Nombre;
            }
          

        }
        public frm_role_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);
            
            frm.txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraEspacio(e, frm.txtName,20);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtName.Focus();
            }
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
                vo_rol.Nombre = frm.txtName.Text;

                    if (vo_rol.Operacion.Equals("update"))
                    {

                        desenfoque_abrir_formulario();

                        if (pxy_rol.UPDATE(vo_rol))
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
                    else if (vo_rol.Operacion.Equals("insert"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_rol.CREATE(vo_rol))
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

    }
}
