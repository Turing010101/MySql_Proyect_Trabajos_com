using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class frm_factura_report : Form
    {

        public frm_factura_report()
        {
            InitializeComponent();
        }

        private void frm_factura_report_Load(object sender, System.EventArgs e)
        {

            this.rpvFactura.RefreshReport();
        }
    }
}

