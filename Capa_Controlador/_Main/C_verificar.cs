using Capa_Modelo._VO;
using Capa_Vista;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Capa_Controlador
{
    public class C_verificar
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Capa_Vista.frm_code frm;
        frm_blur overlayForm;

        C_message c_message;
        C_modificar c_modificar;
        C_recuperar c_recuperar;

        Vo_recuperar e_recuperar = new Vo_recuperar();
        Vo_gmail e_gmail = new Vo_gmail();

        Capa_Vista.frm_message_ok message_box;

        int contar;
        Random Rdn = new Random();
        
        public C_verificar(Vo_gmail vo_gmail=null)
        {  
            frm = new Capa_Vista.frm_code();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();
            e_gmail = vo_gmail;
        }

        public void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_recover_Load);
            frm.btnGenerate.Click += new EventHandler(btnGenerar_Click);
            frm.ckbNoSoyRobot.CheckedChanged += new EventHandler(ckbNoSoyRobot_CheckedChanged);
            frm.timer1.Tick += new EventHandler(timer1_Tick);

            frm.lkl_codigo.LinkClicked += new LinkLabelLinkClickedEventHandler(lkl_recuperar_LinkClicked);
            frm.btnAceptar.Click += new EventHandler(btnAceptar_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);


            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);

            frm.txt_code.Enter += new EventHandler(txtCodigo_Enter);
            frm.txt_code.Leave += new EventHandler(txtCodigo_Leave);

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
        private void frm_recover_Load(object sender, EventArgs e)
        {
            frm.lblReCaptcha.Visible = false;
            frm.lblReCaptcha.Text = "";
            frm.lblContador.Text = "";
            frm.btnGenerate.Visible = false;
            frm.txt_valor.Visible = false;
            frm.lblGmail.Text = e_gmail.RecipientMail[0];
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
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frm.lblReCaptcha.Text = "";
            frm.txt_valor.Clear();
            frm.timer1.Start();
            frm.txt_valor.Focus();
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
        private void txtCodigo_Enter(object sender,EventArgs e)
        {
            if (frm.txt_code.Text== "CÓDIGO")
            {
                frm.txt_code.Text = string.Empty;
            }
           
        }
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            frm.ckbNoSoyRobot.Focus();
            if (frm.txt_code.Text == "")
            {
                frm.txt_code.Text = "CÓDIGO";
              
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (frm.txt_code.Text!= "CÓDIGO")
            {
                if (frm.ckbNoSoyRobot.Checked == true)
                {
                    if (frm.txt_valor.Text == frm.lblReCaptcha.Text)
                    {
                            if (frm.txt_code.Text==e_gmail.Code)
                            {
                                overlayForm.Dispose();
                                frm.Hide();

                                c_modificar = new C_modificar(e_gmail);
                                c_modificar.InitializeEvents();
                            }
                            else
                            {
                                desenfoque_abrir_formulario();
                                c_message.message("El código no es valido ", C_message.message_type.error);
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
                c_message.message("Ingrese el dato correspondiente ", C_message.message_type.error);
                overlayForm.Dispose();
            }
        }

    }
}
