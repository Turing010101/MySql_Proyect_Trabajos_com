﻿using Capa_Modelo._DAO;
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
    class C_categoria_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_categoria vo_categoria = new Vo_categoria();
        C_validacion valida = new C_validacion();

        Dao_categoria pxy_categoria = (Pxy_categoria)Fty_fabrica.Fabricar(new Pxy_categoria());

        C_message c_message;

        Capa_Vista.frm_category_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;
        

        public C_categoria_crud(Vo_categoria categoria = null)
        {
            frm = new Capa_Vista.frm_category_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            vo_categoria.Operacion = "insert";
            InitializeEvents();

            if (categoria != null)
            {
                vo_categoria.Clave = categoria.Clave;
                vo_categoria.Operacion = categoria.Operacion;
                frm.txtName.Text = categoria.Nombre;
            }
          

        }
        public frm_category_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);
            
            frm.txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraEspacio(e, frm.txtName,40);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtName.Focus();
            }
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
                vo_categoria.Nombre = frm.txtName.Text;

                    if (vo_categoria.Operacion.Equals("update"))
                    {

                        desenfoque_abrir_formulario();

                        if (pxy_categoria.UPDATE(vo_categoria))
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
                    else if (vo_categoria.Operacion.Equals("insert"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_categoria.CREATE(vo_categoria))
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
