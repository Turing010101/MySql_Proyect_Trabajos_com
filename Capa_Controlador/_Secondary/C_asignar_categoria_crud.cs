using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._Visitor;
using Capa_Modelo._VO;
using Capa_Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_asignar_categoria_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_asignar_categoria vo_asignar = new Vo_asignar_categoria();
        C_validacion valida = new C_validacion();

        Dao_asignar_categoria pxy_asignar = (Pxy_asignar_categoria)Fty_fabrica.Fabricar(new Pxy_asignar_categoria());
    
        C_message c_message;

        Capa_Vista.frm_assign_category_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

        string mensaje_trabajador = "--Elegir--";
        string mensaje_categoria = "--Elegir--";

        public C_asignar_categoria_crud(Vo_asignar_categoria asignar = null)
        {
            frm = new Capa_Vista.frm_assign_category_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            vo_asignar.Operacion = "insert";
            InitializeEvents();
            read_trabajador();
            read_categoria();

            if (asignar != null)
            {
                vo_asignar.Clave = asignar.Clave;
                vo_asignar.Operacion = asignar.Operacion;

                frm.cmbEstado.Text = asignar.Estado.ToString();

                mensaje_trabajador = asignar.Trabajador.ToString();
                mensaje_categoria = asignar.Categoria.ToString();
            }
        }
        public frm_assign_category_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_assign_category_crud_Load);
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);

            frm.cmbWorker.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbCategory.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbEstado.KeyDown += new KeyEventHandler(cmb_KeyDown);

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
        private void read_trabajador()
        {
            frm.cmbWorker.DataSource = pxy_asignar.LIST_WORKER();
            frm.cmbWorker.DisplayMember = "nombre";
            frm.cmbWorker.ValueMember = "id";

        }
        private void read_categoria()
        {
            frm.cmbCategory.DataSource = pxy_asignar.LIST_CATEGORY();
            frm.cmbCategory.DisplayMember = "nombre";
            frm.cmbCategory.ValueMember = "id";

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
                vo_asignar.Trabajador = Convert.ToInt16(frm.cmbWorker.SelectedValue.ToString());
                vo_asignar.Categoria = Convert.ToInt16(frm.cmbCategory.SelectedValue.ToString());
                vo_asignar.Estado = frm.cmbEstado.SelectedItem.ToString();

                if (vo_asignar.Operacion.Equals("update"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_asignar.UPDATE(vo_asignar))
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
                    else if (vo_asignar.Operacion.Equals("insert"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_asignar.CREATE(vo_asignar))
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
        private void frm_assign_category_crud_Load(object sender, EventArgs e)
        {
            frm.cmbWorker.Text = mensaje_trabajador;
            frm.cmbCategory.Text = mensaje_categoria;
        }

    }
}
