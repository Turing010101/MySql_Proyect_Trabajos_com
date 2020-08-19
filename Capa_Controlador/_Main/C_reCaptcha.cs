using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador._Main
{
    class C_reCaptcha
    {
        int contar;
        Random Rdn = new Random();
        Capa_Vista.frm_update frm;

        public C_reCaptcha(Capa_Vista.frm_update frmUpdate)
        {
            frm = frmUpdate;
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
    }
}
