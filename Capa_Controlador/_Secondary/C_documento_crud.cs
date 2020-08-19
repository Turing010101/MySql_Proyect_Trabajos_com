using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._Visitor;
using Capa_Modelo._VO;
using Capa_Vista;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_documento_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_documento vo_documento = new Vo_documento();
        C_validacion valida = new C_validacion();

        Dao_documento pxy_documento = (Pxy_documento)Fty_fabrica.Fabricar(new Pxy_documento());

        C_message c_message;

        Capa_Vista.frm_document_crud frm;
        frm_blur overlayForm;

        string directorio = Directory.GetCurrentDirectory()+@"\doc\";
        Capa_Vista.frm_message_ok message_box;

        int i = 0;
        string[] encabezado = { "Credencial del elector", "Comprobante domicilio", "Certificado de trabajo" };
        string[] img = new string[3];

        public C_documento_crud(Vo_documento documento = null)
        {
            frm = new Capa_Vista.frm_document_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();


            vo_documento.Operacion = "insert";

            InitializeEvents();

            if (documento != null)
            {
                vo_documento.Clave = documento.Clave;
                vo_documento.Operacion = documento.Operacion;

                vo_documento.Credencial = documento.Credencial;
                vo_documento.Comprobante_domicilio = documento.Comprobante_domicilio;
                vo_documento.Certificado = documento.Certificado;

                img[0] = documento.Credencial;
                img[1] = documento.Comprobante_domicilio;
                img[2] = documento.Certificado;

                frm.txtRFC.Text = documento.Rfc_trabajdor;
                frm.txtName.Text = documento.Nombre_trabajador;
                frm.cmbEstado.Text = documento.Estado.ToString();
                frm.txtObservaciones.Text = documento.Observaciones;
                if (documento.Fecha_evaluacion != "Pendiente")
                {
                    frm.dtpRegistrationDate.Value = Convert.ToDateTime(documento.Fecha_evaluacion);
                }
            }

        }
        public frm_document_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_document_crud_Load);
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);
            frm.cmbEstado.KeyDown += new KeyEventHandler(cmb_KeyDown);

            frm.ptbDoc.Click += new EventHandler(ptbDoc_Click);
            frm.btnDerecha.Click += new EventHandler(btnDerecha_Click);
            frm.btnIzquierda.Click += new EventHandler(btnIzquierda_Click);

            frm.txtRFC.KeyPress += new KeyPressEventHandler(txtRFC_KeyPress);
            frm.txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
            frm.txtObservaciones.KeyPress += new KeyPressEventHandler(txtObservaciones_KeyPress);
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
        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraNumero(e, frm.txtRFC, 13);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtRFC.Focus();
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraEspacio(e, frm.txtName, 20);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtName.Focus();
            }
        }
        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeroLetraEspacio(e, frm.txtObservaciones, 200);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtObservaciones.Focus();
            }
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
                vo_documento.Rfc_trabajdor = frm.txtRFC.Text;
                vo_documento.Nombre_trabajador = frm.txtName.Text;
                vo_documento.Observaciones = frm.txtObservaciones.Text;
                vo_documento.Estado = frm.cmbEstado.SelectedItem.ToString();
                vo_documento.Fecha_evaluacion = frm.dtpRegistrationDate.Value.ToString("dd/MM/yyyy");

                if (vo_documento.Operacion.Equals("update"))
                {
                    desenfoque_abrir_formulario();

                    if (pxy_documento.UPDATE(vo_documento))
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
                else if (vo_documento.Operacion.Equals("insert"))
                {
                    desenfoque_abrir_formulario();

                    if (pxy_documento.CREATE(vo_documento))
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
        private void frm_document_crud_Load(object sender, EventArgs e)
        {
            paginacion();
        }
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (i < 2)
            {
                i++;
                paginacion();
            }

        }
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                paginacion();
            }

        }
        private void ptbDoc_Click(object sender, System.EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = directorio + img[i];
            proceso.Start();
        }
        private void paginacion()
        {
            frm.lblEncabezado.Text = encabezado[i].ToUpper();
            frm.ptbDoc.Image = Image.FromFile(directorio + img[i]);
            frm.ptbDoc.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
