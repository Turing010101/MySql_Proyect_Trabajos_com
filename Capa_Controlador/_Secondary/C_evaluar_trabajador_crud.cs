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
    class C_evaluar_trabajador_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_evaluar_trabajador vo_evaluar = new Vo_evaluar_trabajador();
        C_validacion valida = new C_validacion();

        Dao_evaluar_trabajador pxy_evaluar = (Pxy_evaluar_trabajador)Fty_fabrica.Fabricar(new Pxy_evaluar_trabajador());
    
        C_message c_message;

        Capa_Vista.frm_evaluate_worker_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

        string mensaje = "--Elegir--";

        C_document_select frm_select_document;

        public static int id_documento;
        public static string nombre_trabajador;

        public C_evaluar_trabajador_crud(Vo_evaluar_trabajador asignar = null)
        {
            frm = new Capa_Vista.frm_evaluate_worker_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            vo_evaluar.Operacion = "insert";
            InitializeEvents();

            if (asignar != null)
            {
                vo_evaluar.Clave = asignar.Clave;
                vo_evaluar.Operacion = asignar.Operacion;
                id_documento = asignar.Documento;

                frm.txtTrabajador.Text = asignar.Trabajador;
                frm.txtObservaciones.Text = asignar.Observaciones;

                frm.cmbEstado.Text=asignar.Estado.Equals(string.Empty)?mensaje:asignar.Estado;
            }
        }
        public frm_evaluate_worker_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);
            frm.btnBuscarTrabjador.Click += new EventHandler(btnSelectdocument_Click);

            frm.cmbEstado.KeyDown += new KeyEventHandler(cmb_KeyDown);

        }
        private void read_documeto(object sender = null, EventArgs e = null)
        {
            frm.txtTrabajador.Text = nombre_trabajador;
        }
        private void btnSelectdocument_Click(object sender, EventArgs e)
        {
            frm_select_document = new C_document_select();

            using (frm_document_select select_cliente = frm_select_document.getFormulario())
            {
                desenfoque_abrir_formulario();

                select_cliente.btnSelect.Click += new EventHandler(read_documeto);
                select_cliente.ShowDialog();

                overlayForm.Dispose();
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
        private void cmb_KeyDown(object sender, KeyEventArgs e)
        {
            // ComboBox is readonly 
            e.SuppressKeyPress = true;
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
                vo_evaluar.Documento = id_documento;
                vo_evaluar.Estado = frm.cmbEstado.SelectedItem.ToString();
                vo_evaluar.Observaciones = frm.txtObservaciones.Text;

                if (vo_evaluar.Operacion.Equals("update"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_evaluar.UPDATE(vo_evaluar))
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
                    else if (vo_evaluar.Operacion.Equals("insert"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_evaluar.CREATE(vo_evaluar))
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
