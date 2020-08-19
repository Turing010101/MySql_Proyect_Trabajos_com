using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._VO;
using Capa_Vista;

namespace Capa_Controlador
{
    class C_main
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Capa_Vista.frm_message_ok message_box;
        Capa_Vista.frm_main frm;
        Capa_Vista.frm_blur overlayForm;

        C_message c_message;
        C_actualizar c_actualizar;

        DialogResult resultado = new DialogResult();

        Vo_gmail e_gmail = new Vo_gmail();
        Vo_perfil e_perfil = new Vo_perfil();

        Vo_verificar e_verificar = new Vo_verificar();

        Dao_gmail pxy_gmail = (Pxy_gmail)Fty_fabrica.Fabricar(new Pxy_gmail());
        Dao_verificar pxy_verificar = (Pxy_verificar)Fty_fabrica.Fabricar(new Pxy_verificar());

        public C_main()
        {
            frm = new Capa_Vista.frm_main();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();
        }

        private void permisos()
        {
            int f = C_logeo.permisos.GetLength(0);

            for (int i = 0; i < f; i++)
            {
                switch (C_logeo.permisos[i,0])
                {
                    case 1:
                        frm.btnPersona.Enabled = true;
                        break;
                    case 2:
                        frm.btnEmpleado.Enabled = true;
                        break;
                    case 3:
                        frm.btnTrabajador.Enabled = true;
                        break;
                    case 4:
                        frm.btnDocumento.Enabled = true;
                        break;
                    case 5:
                        frm.btnCategoria.Enabled = true;
                        break;
                    case 6:
                        frm.btnCliente.Enabled = true;
                        break;
                    case 7:
                        frm.btnRol.Enabled = true;
                        break;
                    case 8:
                        frm.btnPuesto.Enabled = true;
                        break;
                    case 9:
                        frm.btnAssignCategory.Enabled = true;
                        break;
                    case 10:
                        frm.btnSucursal.Enabled = true;
                        break;
                    case 11:
                        frm.btnPriviliges.Enabled = true;
                        break;
                    case 12:
                        frm.btnModule.Enabled = true;
                        break;
                    case 13:
                        frm.btnAction.Enabled = true;
                        break;
                    case 14:
                        frm.btnOperation.Enabled = true;
                        break;
                    case 15:
                        frm.btnPermissions.Enabled = true;
                        break;
                    case 16:
                        frm.btnEvaluaction.Enabled = true;
                        break;
                    case 17:
                        frm.btnBill.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }
        private void revisar_actualizacion()
        {
            c_actualizar = new C_actualizar();
            e_verificar.Clave = C_logeo.clave[0];
            e_verificar.Fecha_modificar = DateTime.Now.ToString("yyyy-MM-dd");
            if (pxy_verificar.FIND(e_verificar))
            {
                desenfoque_abrir_formulario();
                c_message.message("Necesita actualizar contraseña ", C_message.message_type.warning);
                overlayForm.Dispose();
                c_actualizar.InitializeEvents();

            }
        }
        private void notificar()
        {
            e_verificar.Clave = C_logeo.clave[0];
            e_gmail= pxy_verificar.E_MAIL(e_verificar);
            if (e_gmail != null)
            {
                pxy_gmail.INITIALIZE_SMTP_CLIENT();
                pxy_gmail.SEND_MAIL(e_gmail);
            }
               
        }
        private void perfil_user()
        {
            e_verificar.Clave = C_logeo.clave[0];
            e_perfil = pxy_verificar.PERFIL(e_verificar);

            frm.lblUser.Text = e_perfil.Nombre;
            frm.lblRol.Text = e_perfil.Rol;

            if (e_perfil.Imagen != null)
            {
                MemoryStream ms = new MemoryStream(e_perfil.Imagen);
                frm.cpbUser.Image = Image.FromStream(ms);
            }
            else
            {
                frm.cpbUser.Image = null;
            }

        }
        public void InitializeEvents()
        {
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.ptbMaximize.Click += new EventHandler(ptbMaximize_Click);
            frm.ptbRestore.Click += new EventHandler(ptbRestore_Click);
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbOff.Click += new EventHandler(ptbOff_Click);

            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnPriviliges.Click += new EventHandler(btnPrivileges_Click);
            frm.btnModule.Click += new EventHandler(btnModulo_Click);
            frm.btnAction.Click += new EventHandler(btnAction_Click);
            frm.btnOperation.Click += new EventHandler(btnOperation_Click);
            frm.btnPermissions.Click += new EventHandler(btnPermissions_Click);
            frm.btnBill.Click += new EventHandler(btnFactura_Click);
            frm.btnPersona.Click += new EventHandler(btnPersona_Click);
            frm.btnEmpleado.Click += new EventHandler(btnEmpleado_Click);
            frm.btnTrabajador.Click += new EventHandler(btnTrabajador_Click);
            frm.btnDocumento.Click += new EventHandler(btnDocumentp_Click);
            frm.btnAssignCategory.Click += new EventHandler(btnAssignCategory_Click);
            frm.btnCliente.Click += new EventHandler(btnCliente_Click);
            frm.btnRol.Click += new EventHandler(btnRol_Click);
            frm.btnCategoria.Click += new EventHandler(btnCategoria_Click);
            frm.btnEvaluaction.Click += new EventHandler(btnEvaluateWorker_Click);
            frm.btnPuesto.Click += new EventHandler(btnPuesto_Click);
            frm.btnSucursal.Click += new EventHandler(btnSucursal_Click);
            //notificar();
            perfil_user();
            revisar_actualizacion();
            permisos();
            frmPoliticaPrivacidad();
            frm.ShowDialog();
           
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
        private void ptbClose_Click(object sender, EventArgs e)
        {
            frm.Close();

        }
        private void ptbOff_Click(object sender, EventArgs e)
        {
            C_logeo c_logeo = new C_logeo() ;
            desenfoque_abrir_formulario();
            c_message.message("¿Desea cerrar sessión?", C_message.message_type.warning, true);
            resultado = message_box.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                overlayForm.Dispose();
                frm.Hide();
                c_logeo.InitializeEvents();
            }
            else
            {
                overlayForm.Dispose();
            }
        }
        private void ptbMaximize_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Maximized;
            frm.ptbMaximize.Visible = false;
            frm.ptbRestore.Visible = true;
        }
        private void ptbRestore_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Normal;
            frm.ptbRestore.Visible = false;
            frm.ptbMaximize.Visible = true;
        }
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapturea();
            SendMessage(frm.Handle, 0x112, 0xf012, 0);
        }
        private void btnPrivileges_Click(object sender, EventArgs e)
        {
            if (frm.pnlSubMenu.Visible == false)
            {
                frm.pnlSubMenu.Location = new Point(30, 542);
                frm.pnlLeft.Controls.Add(frm.pnlSubMenu);
                frm.pnlSubMenu.Visible = true;

                frm.btnEvaluaction.Location = new Point(0, 677);
                frm.btnBill.Location = new Point(0, 714);
            }
            else
            {
                frm.pnlSubMenu.Visible = false;
                frm.btnEvaluaction.Location = new Point(0, 542);
                frm.btnBill.Location = new Point(0, 579);

            }
        }
        private void btnModulo_Click(object sender, EventArgs e)
        {
            C_modulo c_modulo = new C_modulo();
            openFormChild(c_modulo.getFormulario());
            
            frm.pnlSubMenu.Visible = false;
            frm.btnEvaluaction.Location = new Point(0, 542);
            frm.btnBill.Location = new Point(0, 579);
        }
        private void btnAction_Click(object sender, EventArgs e)
        {
            C_accion c_accion = new C_accion();
            openFormChild(c_accion.getFormulario());

            frm.pnlSubMenu.Visible = false;
            frm.btnEvaluaction.Location = new Point(0, 542);
            frm.btnBill.Location = new Point(0, 579);
        }
        private void btnOperation_Click(object sender, EventArgs e)
        {
            C_operacion c_operacion = new C_operacion();
            openFormChild(c_operacion.getFormulario());

            frm.pnlSubMenu.Visible = false;
            frm.btnEvaluaction.Location = new Point(0, 542);
            frm.btnBill.Location = new Point(0, 579);
        }
        private void btnPermissions_Click(object sender, EventArgs e)
        {
            C_operacion_perfil c_operacion_perfil = new C_operacion_perfil();
            openFormChild(c_operacion_perfil.getFormulario());

            frm.pnlSubMenu.Visible = false;
            frm.btnEvaluaction.Location = new Point(0, 542);
            frm.btnBill.Location = new Point(0, 579);
        }
        private void openFormChild(Form frm_child)
        {
            if (frm.pnlContent.Controls.Count > 0)
            {
                frm.pnlContent.Controls.RemoveAt(0);
            }
            Form fh = frm_child;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            frm.pnlContent.Controls.Add(fh);
            frm.pnlContent.Tag = fh;
            fh.Show();

        }
        private void btnFactura_Click(object sender, EventArgs e)
        {
            C_factura c_factura = new C_factura();
            openFormChild(c_factura.getFormulario());
        }
        private void frmPoliticaPrivacidad()
        {
            C_politca_privacidad c_politica = new C_politca_privacidad();
            openFormChild(c_politica.getFormulario());
        }
        private void btnPersona_Click(object sender, EventArgs e)
        {
            C_persona c_persona = new C_persona();
            openFormChild(c_persona.getFormulario());
        }
        private void btnAssignCategory_Click(object sender, EventArgs e)
        {
            C_asignar_categoria c_asignar = new C_asignar_categoria();
            openFormChild(c_asignar.getFormulario());
        }
        private void btnEvaluateWorker_Click(object sender, EventArgs e)
        {
            C_evaluar_trabajador evaluar = new C_evaluar_trabajador();
            openFormChild(evaluar.getFormulario());
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            C_empleado c_empleado = new C_empleado();
            openFormChild(c_empleado.getFormulario());
        }
        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            C_trabajador c_trabajador = new C_trabajador();
            openFormChild(c_trabajador.getFormulario());
        }
        private void btnDocumentp_Click(object sender, EventArgs e)
        {
            C_documento c_documento = new C_documento();
            openFormChild(c_documento.getFormulario());
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            C_cliente c_cliente = new C_cliente();
            openFormChild(c_cliente.getFormulario());
        }
        private void btnRol_Click(object sender, EventArgs e)
        {
            C_rol c_rol = new C_rol();
            openFormChild(c_rol.getFormulario());
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            C_categoria c_categoria = new C_categoria();
            openFormChild(c_categoria.getFormulario());
        }
        private void btnPuesto_Click(object sender, EventArgs e)
        {
            C_puesto c_puesto = new C_puesto();
            openFormChild(c_puesto.getFormulario());
        }
        private void btnSucursal_Click(object sender, EventArgs e)
        {
            C_sucursal c_sucursal = new C_sucursal();
            openFormChild(c_sucursal.getFormulario());
        }

    }
}
