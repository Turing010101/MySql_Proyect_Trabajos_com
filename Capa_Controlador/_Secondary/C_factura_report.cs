using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._VO;
using Capa_Vista;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_factura_report
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_contrato vo_contrato = new Vo_contrato();
        Vo_contrato_detalle vo_factura = new Vo_contrato_detalle();

        Dao_contrato_detalle pxy_factura = (Pxy_contrato_detalle)Fty_fabrica.Fabricar(new Pxy_contrato_detalle());
        Dao_contrato pxy_contrato = (Pxy_contrato)Fty_fabrica.Fabricar(new Pxy_contrato());

        C_message c_message;

        Capa_Vista.frm_factura_report frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;


        public C_factura_report(Vo_contrato_detalle e_detalle)
        {
            frm = new Capa_Vista.frm_factura_report();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            InitializeEvents();

            vo_factura.Clave_contrato = e_detalle.Clave_contrato;
            vo_contrato.Clave = e_detalle.Clave_contrato;
            generar_reprot();

        }
        public frm_factura_report formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);

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

        private void generar_reprot()
        {

            DataSet dts_contrato = pxy_contrato.REPORT(vo_contrato);
            DataSet dts_factura = pxy_factura.REPORT(vo_factura);
            
            ReportDataSource contrato = new ReportDataSource("dts_contracion", dts_contrato.Tables[0]);
            ReportDataSource factura = new ReportDataSource("dts_facturacion", dts_factura.Tables[0]);

            frm.rpvFactura.LocalReport.DataSources.Clear();
            frm.rpvFactura.LocalReport.DataSources.Add(contrato);
            frm.rpvFactura.LocalReport.DataSources.Add(factura);
            frm.rpvFactura.LocalReport.Refresh();
            frm.rpvFactura.Refresh();
            frm.rpvFactura.RefreshReport();
            
        }
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            generar_reprot();
            frm.Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapturea();
            SendMessage(frm.Handle, 0x112, 0xf012, 0);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

    }
}
