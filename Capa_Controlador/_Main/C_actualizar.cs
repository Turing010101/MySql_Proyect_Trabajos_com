using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Capa_Controlador._Main;
using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._Visitor;
using Capa_Modelo._VO;
using Capa_Vista;
namespace Capa_Controlador
{
    public class C_actualizar
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Capa_Vista.frm_update frm;
        frm_blur overlayForm;

        Vst_actualizar validator = new Vst_actualizar();
        IEnumerable<string> brokenRules;

        C_message c_message;
        Vo_actualizar e_actualizar = new Vo_actualizar();

        Dao_actualizar pxy_actualizar = (Pxy_actualizar)Fty_fabrica.Fabricar(new Pxy_actualizar());

        Capa_Vista.frm_message_ok message_box;
        int contar;
        Random Rdn = new Random();

        public C_actualizar()
        {
            frm = new Capa_Vista.frm_update();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();
        }
        public void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_update_Load);
            frm.ckbNoSoyRobot.CheckedChanged += new EventHandler(ckbNoSoyRobot_CheckedChanged);
            frm.timer1.Tick += new EventHandler(timer1_Tick);
            frm.btnAceptar.Click += new EventHandler(btnAceptar_Click);
            frm.btnGenerate.Click += new EventHandler(btnGenerar_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);

            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);

            frm.txt_current.Enter += new EventHandler(txtCurrent_Enter);
            frm.txt_current.Leave += new EventHandler(txtCurrent_Leave);

            frm.txt_password.Enter += new EventHandler(txtPassword_Enter);
            frm.txt_password.Leave += new EventHandler(txtPassword_Leave);

            frm.txt_confirm.Enter += new EventHandler(txtConfirmar_Enter);
            frm.txt_confirm.Leave += new EventHandler(txtConfirmar_Leave);

            frm.ptb_current.MouseHover += new EventHandler(ptbCurrent_Hover);
            frm.ptb_current.MouseLeave += new EventHandler(ptbCurrent_Leave);
            frm.ptb_password.MouseHover += new EventHandler(ptbPassword_Hover);
            frm.ptb_password.MouseLeave += new EventHandler(ptbPassword_Leave);
            frm.ptb_confirm.MouseHover += new EventHandler(ptbConfirm_Hover);
            frm.ptb_confirm.MouseLeave += new EventHandler(ptbConfirm_Leave);

            desenfoque_abrir_formulario();
            frm.ShowDialog();
        }
        private void ptbClose_Click(object sender, EventArgs e)
        {
            overlayForm.Dispose();
            Application.Exit();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frm.lblReCaptcha.Text = "";
            frm.txt_valor.Clear();
            frm.timer1.Start();
            frm.txt_valor.Focus();
        }
        private void frm_update_Load(object sender, EventArgs e)
        {
            frm.lblReCaptcha.Visible = false;
            frm.lblReCaptcha.Text = "";
            frm.lblContador.Text = "";
            frm.btnGenerate.Visible = false;
            frm.txt_valor.Visible = false;
        }

        public void Catcha()
        {
            int a;
            string[] cap = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int cant;
            string cap1;

            cant = Rdn.Next(5, 8);

            for (int i = 0; i < cant; i++)
            {
                a = Rdn.Next(0, 63);
                cap1 = cap[a];
                frm.lblReCaptcha.Text += cap1;
            }

        }
        public void seleccionar_Catcha()
        {
            if (frm.ckbNoSoyRobot.Checked == true)
            {
                frm.timer1.Start();
                frm.txt_valor.Focus();
            }
            else
            {
                frm.timer1.Stop();
                contar = 0;
                frm.lblContador.Text = contar.ToString();
                frm.lblReCaptcha.Visible = false;
                frm.lblReCaptcha.Text = "";
                frm.btnGenerate.Visible = false;
                frm.txt_valor.Visible = false;
            }
        }
        public void iniciar_Catcha()
        {
            contar += 1;
            if (contar <= 5)
            {
                frm.lblContador.Visible = true;
                frm.lblContador.Text = contar.ToString();

            }
            else
            {
                frm.lblContador.Visible = false;
                frm.lblReCaptcha.Visible = true;
                frm.btnGenerate.Visible = true;
                frm.txt_valor.Visible = true;
                contar = 0;
                frm.timer1.Stop();
                frm.lblContador.Text = contar.ToString();
                if (frm.lblReCaptcha.Text == "")
                {
                    Catcha();
                }
            }
        }
        private void ckbNoSoyRobot_CheckedChanged(object sender, System.EventArgs e)
        {
            seleccionar_Catcha();
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            iniciar_Catcha();
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
        private void txtCurrent_Enter(object sender, EventArgs e)
        {
            if (frm.txt_current.Text == "CONTRASEÑA ACTUAL")
            {
                frm.txt_current.Text = string.Empty;
                frm.txt_current.UseSystemPasswordChar = true;
            }
        }
        private void txtCurrent_Leave(object sender, EventArgs e)
        {
            if (frm.txt_current.Text == "")
            {
                frm.txt_current.Text = "CONTRASEÑA ACTUAL";
                frm.txt_current.UseSystemPasswordChar = false;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (frm.txt_password.Text == "CONTRASEÑA NUEVA")
            {
                frm.txt_password.Text = string.Empty;
                frm.txt_password.UseSystemPasswordChar = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (frm.txt_password.Text == "")
            {
                frm.txt_password.Text = "CONTRASEÑA NUEVA";
                frm.txt_password.UseSystemPasswordChar = false;
            }
        }
        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (frm.txt_confirm.Text == "CONFIRMAR CONTRASEÑA")
            {
                frm.txt_confirm.Text = string.Empty;
                frm.txt_confirm.UseSystemPasswordChar = true;
            }
        }
        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (frm.txt_confirm.Text == "")
            {
                frm.txt_confirm.Text = "CONFIRMAR CONTRASEÑA";
                frm.txt_confirm.UseSystemPasswordChar = false;
            }
        }
        private void ptbPassword_Leave(object sender, EventArgs e)
        {
            frm.txt_password.Focus();
            frm.txt_password.UseSystemPasswordChar = true;
        }
        private void ptbPassword_Hover(object sender, EventArgs e)
        {
            frm.ptb_password.Focus();
            frm.txt_password.UseSystemPasswordChar = false;
        }
        private void ptbCurrent_Leave(object sender, EventArgs e)
        {
            frm.txt_current.Focus();
            frm.txt_current.UseSystemPasswordChar = true;
        }
        private void ptbCurrent_Hover(object sender, EventArgs e)
        {
            frm.ptb_current.Focus();
            frm.txt_current.UseSystemPasswordChar = false;
        }
        private void ptbConfirm_Leave(object sender, EventArgs e)
        {
            frm.txt_confirm.Focus();
            frm.txt_confirm.UseSystemPasswordChar = true;
        }
        private void ptbConfirm_Hover(object sender, EventArgs e)
        {
            frm.ptb_confirm.Focus();
            frm.txt_confirm.UseSystemPasswordChar = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            e_actualizar.Clave = C_logeo.clave[0];
            e_actualizar.Contrasena_nueva = frm.txt_password.Text;
            e_actualizar.Confirmar = frm.txt_confirm.Text;

            if (e_actualizar.Contrasena_nueva == e_actualizar.Confirmar)
            {
                if (frm.ckbNoSoyRobot.Checked == true)
                {
                    if (frm.txt_valor.Text == frm.lblReCaptcha.Text)
                    {
                        if (!(e_actualizar.validate(validator, out brokenRules)))
                        {
                            e_actualizar.Contrasena_actual = Vst_seguridad.GetSHA256(frm.txt_current.Text);
                            e_actualizar.Contrasena_nueva = Vst_seguridad.GetSHA256(frm.txt_password.Text);

                            if (pxy_actualizar.UPDATE(e_actualizar))
                            {
                                overlayForm.Dispose();
                                desenfoque_abrir_formulario();
                                c_message.message("La contraseña ha sido actualizada ", C_message.message_type.information);
                                overlayForm.Dispose();
                                frm.Hide();
                            }
                            else
                            {
                                desenfoque_abrir_formulario();
                                c_message.message("Verifca la contraseña actual ", C_message.message_type.error);
                                overlayForm.Dispose();
                            }
                        }
                        else
                        {
                            desenfoque_abrir_formulario();
                            foreach (var item in brokenRules)
                            {
                                c_message.message(item, C_message.message_type.error);
                            }
                            overlayForm.Dispose();
                        }
                    }
                    else
                    {
                        desenfoque_abrir_formulario();
                        c_message.message("Resolver el Captcha ", C_message.message_type.error);
                        overlayForm.Dispose();
                    }
                }
                else
                {
                    desenfoque_abrir_formulario();
                    c_message.message("Seleccionar el Captcha ", C_message.message_type.error);
                    overlayForm.Dispose();
                }
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("Las contraseñas no coinciden ", C_message.message_type.error);
                overlayForm.Dispose();
            }
        }

    }
}
