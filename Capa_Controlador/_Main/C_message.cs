using Capa_Vista;

namespace Capa_Controlador
{
    class C_message
    {
        Capa_Vista.frm_message_ok frm;

        public static C_message instancia;

        private C_message()
        {
            frm = new Capa_Vista.frm_message_ok();
        } 
        public static C_message getInstancia()
        {
            if (instancia==null)
            {
                instancia = new C_message();
            }
            return instancia;
        }

        public frm_message_ok formulario()
        {
           return frm;
        }
        public enum message_type
        {
            done,
            warning,
            error,
            information
        }
        public void message(string _sms, message_type _type, bool activar = false)
        {
            frm.lblMessage.Text = _sms;

            switch (_type)
            {
                case message_type.warning:
                    frm.ptbIcon.Image = frm.imgL.Images[1];
                    break;
                case message_type.information:
                    frm.ptbIcon.Image = frm.imgL.Images[0];
                    break;
                case message_type.error:
                    frm.ptbIcon.Image = frm.imgL.Images[2];
                    break;
                default:
                    break;
            }
            if (activar)
            {
                frm.btnNo.Visible = true;
            }
            else
            {
                frm.btnNo.Visible = false;
                frm.ShowDialog();
            }

        }
    }
}
