﻿using Capa_Modelo._DAO;
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
    class C_empleado_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_empleado vo_empleado = new Vo_empleado();
        C_validacion valida = new C_validacion();
        
        Dao_empleado pxy_empleado = (Pxy_empleado)Fty_fabrica.Fabricar(new Pxy_empleado());
    
        C_message c_message;

        Capa_Vista.frm_employee_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;

        string mensaje_puesto = "--Elegir--";
        string mensaje_sucursal = "--Elegir--";
        string mensaje_turno = "--Elegir--";
        string mensaje_persona = "--Elegir--";
        string mensaje_jefe = "--Elegir--";

        public C_empleado_crud(Vo_empleado empleado = null)
        {
            frm = new Capa_Vista.frm_employee_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            vo_empleado.Operacion = "insert";
            InitializeEvents();
            read_office();
            read_post();
            read_turn();
            read_people();
            read_boss();

            if (empleado != null)
            {
                vo_empleado.Clave = empleado.Clave;
                vo_empleado.Operacion = empleado.Operacion;

                mensaje_persona = empleado.Rfc_persona;
                mensaje_jefe = empleado.Rfc_jefe;

                mensaje_puesto = empleado.Puesto.ToString();
                mensaje_sucursal = empleado.Sucursal.ToString();
                mensaje_turno= empleado.Turno.ToString();
            }
        }
        public frm_employee_crud formulario()
        {
            return frm;
        }
        private void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_people_crud_Load);
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);

            frm.cmbOffice.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbPost.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbTurn.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbPeople.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbBoss.KeyDown += new KeyEventHandler(cmb_KeyDown);

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
        private void read_office()
        {
            frm.cmbOffice.DataSource = pxy_empleado.LIST_OFFICE();
            frm.cmbOffice.DisplayMember = "nombre";
            frm.cmbOffice.ValueMember = "id";

        }
        private void read_post()
        {
            frm.cmbPost.DataSource = pxy_empleado.LIST_POST();
            frm.cmbPost.DisplayMember = "nombre";
            frm.cmbPost.ValueMember = "id";

        }
        private void read_turn()
        {
            frm.cmbTurn.DataSource = pxy_empleado.LIST_TURN();
            frm.cmbTurn.DisplayMember = "nombre";
            frm.cmbTurn.ValueMember = "id";

        }
        private void read_people()
        {
            frm.cmbPeople.DataSource = pxy_empleado.LIST_PEOPLE();
            frm.cmbPeople.DisplayMember = "nombre";
            frm.cmbPeople.ValueMember = "rfc";

        }
        private void read_boss()
        {
            frm.cmbBoss.DataSource = pxy_empleado.LIST_PEOPLE();
            frm.cmbBoss.DisplayMember = "nombre";
            frm.cmbBoss.ValueMember = "rfc";

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
                vo_empleado.Rfc_persona = frm.cmbPeople.SelectedValue.ToString();
                vo_empleado.Rfc_jefe = frm.cmbBoss.SelectedValue.ToString();

                vo_empleado.Puesto = Convert.ToInt16(frm.cmbPost.SelectedValue.ToString());
                vo_empleado.Sucursal = Convert.ToInt16(frm.cmbOffice.SelectedValue.ToString());
                vo_empleado.Turno = Convert.ToInt16(frm.cmbTurn.SelectedValue.ToString());
                
                    if (vo_empleado.Operacion.Equals("update"))
                    {

                        desenfoque_abrir_formulario();

                        if (pxy_empleado.UPDATE(vo_empleado))
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
                    else if (vo_empleado.Operacion.Equals("insert"))
                    {
                        desenfoque_abrir_formulario();

                        if (pxy_empleado.CREATE(vo_empleado))
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
        private void frm_people_crud_Load(object sender, EventArgs e)
        {
            frm.cmbPost.Text = mensaje_puesto;
            frm.cmbOffice.Text = mensaje_sucursal;
            frm.cmbTurn.Text = mensaje_turno;
            frm.cmbPeople.Text = mensaje_persona;
            frm.cmbBoss.Text = mensaje_jefe;
        }

    }
}
