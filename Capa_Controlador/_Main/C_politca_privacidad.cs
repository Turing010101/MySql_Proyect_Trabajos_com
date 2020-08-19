using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_politca_privacidad
    {

        Capa_Vista.frm_privacy_policy frm;

        public C_politca_privacidad()
        {
            frm = new Capa_Vista.frm_privacy_policy();
          
        }
        public Form getFormulario()
        {
            return frm;
        }
    }
}
