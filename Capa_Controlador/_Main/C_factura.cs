using System;
using System.Drawing;
using System.Data;
using Capa_Vista;
using System.Windows.Forms;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._VO;
using Capa_Modelo._DAO;

namespace Capa_Controlador
{
    class C_factura
    {
        Vo_contrato e_contrato = new Vo_contrato();
        Vo_contrato_detalle e_detalle = new Vo_contrato_detalle();

        Dao_contrato pxy_contrato = (Pxy_contrato)Fty_fabrica.Fabricar(new Pxy_contrato());
        Dao_contrato_detalle pxy_detalle = (Pxy_contrato_detalle)Fty_fabrica.Fabricar(new Pxy_contrato_detalle());

        C_message c_message;

        Capa_Vista.frm_facture frm;

        C_cliente_select frm_select_client;
        C_contrato_select frm_select_contract;
        C_servicio_select frm_select_service;


        C_factura_report frm_report;

        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;


        C_validacion valida = new C_validacion();
        DialogResult resultado = new DialogResult();


        public static int clave_contrato;
        public static string estado_contrato;

        public static int clave_cliente;
        public static string nombre_cliente;

        public static int clave_servicio;
        public static string nombre_servicio;
        public static string precio_servicio;
        public static string descripcion_serivico;
      


        string mensaje_comision = "--Elegir--";
        string mensaje_modo_pago = "--Elegir--";

        public C_factura()
        {
            frm = new Capa_Vista.frm_facture();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();
            read_commission();
            read_pay();
            InitializeEvents();
        }
        public Form getFormulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
           
            frm.Load += new EventHandler(frm_bill_Load);
            frm.btnContrato.Click += new EventHandler(btnContrato_Click);
            frm.btnReporte.Click += new EventHandler(btnReporte_Click);
            frm.btnEliminar.Click += new EventHandler(btnDelete_Click);
            frm.btnAgregarServicio.Click += new EventHandler(btnAddService_Click);
            frm.dtgTableBill.CellClick += new DataGridViewCellEventHandler(dtgTableBill_CellClick);
            frm.btnBuscarCliente.Click += new EventHandler(btnSelectClient_Click);
            frm.btnBuscarContrato.Click += new EventHandler(btnSelectContract_Click);
            frm.btnBuscarFactura.Click += new EventHandler(btnSelectFactura_Click);
            frm.btnFactura.Click += new EventHandler(btnFactura_Click);
            frm.btnBuscarServicio.Click += new EventHandler(btnSelectService_Click);
            frm.dtgTableBill.Layout += new LayoutEventHandler(dtgTableBill_Layout);
            frm.cmbComision.SelectedIndexChanged += new EventHandler(cmbComision_SelectedIndexChanged);
            frm.dtgTableBill.CellMouseEnter += new DataGridViewCellEventHandler(dtgTableBill_CellMouseEnter);
            frm.dtgTableBill.CellMouseLeave += new DataGridViewCellEventHandler(dtgTableBill_CellMouseLeave);
            frm.cmbComision.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbModoPago.KeyDown += new KeyEventHandler(cmb_KeyDown);

            frm.txtCantidad.KeyPress += new KeyPressEventHandler(txtCantidad_KeyPress);
            frm.txtPrecio.KeyPress += new KeyPressEventHandler(txtPrecio_KeyPress);
          
        }

        private void read_client(object sender = null, EventArgs e = null)
        {
            frm.txtCliente.Text = nombre_cliente;
        }

        private void read_contract(object sender = null, EventArgs e = null)
        {
            if (clave_contrato!=0)
            {
                frm.txtIdContrato.Text = clave_contrato.ToString();
            }
            else
            {
                frm.txtIdContrato.Text = string.Empty;
            }
        }
        private void read_factura(object sender = null, EventArgs e = null)
        {
            frm.txtBuscarContrato.Text = clave_contrato.ToString();
            e_detalle.Clave_contrato = clave_contrato;
            read_bill(e_detalle);

        }
        private void read_service(object sender = null, EventArgs e = null)
        {
            frm.txtServicio.Text = nombre_servicio;
            frm.txtDescripcion.Text = descripcion_serivico;
            frm.txtPrecio.Text = precio_servicio;
        }
        private void read_commission()
        {
            frm.cmbComision.DataSource = pxy_contrato.LIST_COMMISSION();
            frm.cmbComision.DisplayMember = "porcentaje";
            frm.cmbComision.ValueMember = "id";

        }
        private void read_pay()
        {
            frm.cmbModoPago.DataSource = pxy_contrato.LIST_PAY();
            frm.cmbModoPago.DisplayMember = "nombre";
            frm.cmbModoPago.ValueMember = "id";

        }
        private void read_bill(Vo_contrato_detalle detalle)
        {
            DataTable dt = pxy_detalle.READ_FACTURA(e_detalle);
  
           frm.dtgTableBill.DataSource = dt;
           frm.dtgTableBill.ClearSelection();
           e_detalle.Clave_detalle = 0;
        }
        private void cmb_KeyDown(object sender, KeyEventArgs e)
        {
            // ComboBox is readonly 
            e.SuppressKeyPress = true;
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumero(e, frm.txtCantidad, 3);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtCantidad.Focus();
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumero(e, frm.txtPrecio, 5);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtPrecio.Focus();
            }
        }
        private void cmbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frm.txtSubTotal.Text!="")
            {
                double subtotal = Convert.ToDouble(frm.txtSubTotal.Text);
                double porcentaje = Convert.ToDouble(frm.cmbComision.Text);
                frm.txtTotal.Text = (subtotal + (porcentaje * subtotal)).ToString();
            }
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
        private void frm_bill_Load(object sender, EventArgs e)
        {
            frm.cmbComision.Text = mensaje_comision;
            frm.cmbModoPago.Text = mensaje_modo_pago;
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            generar_factura();
        }
        private void generar_factura()
        {
            if (e_detalle.Clave_contrato != 0)
            {
                if (estado_contrato == "Pagado" && frm.dtgTableBill.Rows.Count != 0)
                {
                    frm_report = new C_factura_report(e_detalle);

                    using (frm_factura_report frm_reporte = frm_report.formulario())
                    {
                        desenfoque_abrir_formulario();

                        frm_reporte.ShowDialog();

                        overlayForm.Dispose();
                    }
                }
                else
                {
                    desenfoque_abrir_formulario();
                    c_message.message("No exite la factura. ", C_message.message_type.error);
                    overlayForm.Dispose();
                }
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("No exite la contrato. ", C_message.message_type.error);
                overlayForm.Dispose();
            }
        }
        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            frm_select_client = new C_cliente_select();
          
            using (frm_client_select select_cliente = frm_select_client.getFormulario())
            {
                desenfoque_abrir_formulario();

                select_cliente.btnSelect.Click += new EventHandler(read_client);
                select_cliente.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void btnSelectContract_Click(object sender, EventArgs e)
        {
            frm_select_contract = new C_contrato_select();

            using (frm_contrato_select select_contract = frm_select_contract.getFormulario())
            {
                desenfoque_abrir_formulario();

                select_contract.btnSelect.Click += new EventHandler(read_contract);
                select_contract.btnEliminar.Click += new EventHandler(read_contract);
                select_contract.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void btnSelectFactura_Click(object sender, EventArgs e)
        {
            frm_select_contract = new C_contrato_select();

            using (frm_contrato_select select_contract = frm_select_contract.getFormulario())
            {
                desenfoque_abrir_formulario();

                select_contract.btnSelect.Click += new EventHandler(read_factura);
                select_contract.btnEliminar.Click += new EventHandler(read_contract);
                select_contract.ShowDialog();
                overlayForm.Dispose();
            }
        }
        private void btnSelectService_Click(object sender, EventArgs e)
        {
            frm_select_service = new C_servicio_select();

            using (frm_servicio_select select_service = frm_select_service.getFormulario())
            {
                desenfoque_abrir_formulario();

                select_service.btnSelect.Click += new EventHandler(read_service);
                select_service.ShowDialog();

                overlayForm.Dispose();
            }
        }
        private void dtgTableBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (!(e.RowIndex > -1)) { return; }
            e_detalle.Clave_detalle = Convert.ToInt16(frm.dtgTableBill.Rows[e.RowIndex].Cells["clave_detalle"].Value.ToString());
            e_detalle.Clave_contrato = Convert.ToInt16(frm.dtgTableBill.Rows[e.RowIndex].Cells["clave_contrato"].Value.ToString());          
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {

            if (frm.txtIdContrato.Text != "" && frm.txtServicio.Text != "" && frm.txtPrecio.Text != "" && frm.txtCantidad.Text != "")
            {

                e_detalle.Clave_contrato = Convert.ToInt16(frm.txtIdContrato.Text);
                e_detalle.Servicio = clave_servicio;
                e_detalle.Cantidad = Convert.ToInt16(frm.txtCantidad.Text);
                e_detalle.Precio = Convert.ToDouble(frm.txtPrecio.Text);

                if (pxy_detalle.CREATE(e_detalle))
                {
                    read_bill(e_detalle);
                    frm.txtSubTotal.Text = pxy_detalle.SELECT_SUBTOTAL(e_detalle).ToString();
                }
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("No deje campos vacios. ", C_message.message_type.error);
                overlayForm.Dispose();
            }
        }
        private void btnFactura_Click(object sender, EventArgs e)
        {

            if (frm.txtSubTotal.Text != "" && frm.txtTotal.Text != "" && frm.cmbComision.Text != "--Elegir--")
            {
                e_detalle.Clave_contrato= Convert.ToInt16(frm.txtIdContrato.Text);
                e_contrato.Clave = Convert.ToInt16(frm.txtIdContrato.Text);
                e_contrato.Total = Convert.ToDouble(frm.txtTotal.Text);
                e_contrato.Comision = Convert.ToDouble(frm.cmbComision.Text);

                if (pxy_contrato.PAY_CONTRACT(e_contrato))
                {
                    desenfoque_abrir_formulario();
                    c_message.message("Factura relizada. ", C_message.message_type.information);
                    overlayForm.Dispose();
                    estado_contrato = "Pagado";
                    generar_factura();
                }
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("No deje campos vacios. ", C_message.message_type.error);
                overlayForm.Dispose();
            }
        }
        private void btnContrato_Click(object sender, EventArgs e)
        {
            if (frm.txtCliente.Text!="" && frm.cmbModoPago.Text !="--Elegir--")
            {
                e_contrato.Cliente = clave_cliente;
                e_contrato.Fecha_contrato= frm.dtpFechaContrato.Value;
                e_contrato.Modo_pago = Convert.ToInt16(frm.cmbModoPago.SelectedValue.ToString());
                desenfoque_abrir_formulario();

                    if (pxy_contrato.CREATE(e_contrato))
                    {
                        c_message.message("El contrato ha sido realizado. ", C_message.message_type.information);
                         frm.txtIdContrato.Text = pxy_contrato.SELECT_HIGHER().ToString();
                    }
                    else
                    {
                        c_message.message("El contrato no ha sido realizado. ", C_message.message_type.error);

                    }
                    overlayForm.Dispose();
            }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("No deje campos vacios. ", C_message.message_type.error);
                overlayForm.Dispose();
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            desenfoque_abrir_formulario();

            if (e_detalle.Clave_detalle != 0)
            {
                if (estado_contrato=="Pendiente") {
                    c_message.message("¿Desea eliminar?", C_message.message_type.warning, true);
                    resultado = message_box.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        if (!pxy_detalle.DELETE(e_detalle))
                        {
                            c_message.message("Error al eliminar", C_message.message_type.error);
                        }
                        read_bill(e_detalle);
                    }
                }
                else
                {
                    c_message.message("La factura ha sido pagado.", C_message.message_type.warning);
                }
            }
            else
            {
                c_message.message("Selecciona un registro.", C_message.message_type.warning);
            }
            overlayForm.Dispose();
        }
        private void dtgTableBill_Layout(object sender, LayoutEventArgs e)
        {
            frm.dtgTableBill.ClearSelection();
        }
        private void dtgTableBill_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableBill.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(73, 199, 241);
            }
        }
        private void dtgTableBill_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm.dtgTableBill.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(115, 218, 251);
            }
        }
    }
}
