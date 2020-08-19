using Capa_Modelo._DAO;
using Capa_Modelo._Factory;
using Capa_Modelo._Proxy;
using Capa_Modelo._Visitor;
using Capa_Modelo._VO;
using Capa_Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_persona_crud
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapturea();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int IParam);

        Vo_persona vo_persona = new Vo_persona();
        C_validacion valida = new C_validacion();

        Vst_persona validator = new Vst_persona();
        IEnumerable<string> brokenRules;

        Dao_persona pxy_persona = (Pxy_persona)Fty_fabrica.Fabricar(new Pxy_persona());

        C_message c_message;

        Capa_Vista.frm_people_crud frm;
        frm_blur overlayForm;

        Capa_Vista.frm_message_ok message_box;
 

        string mensaje = "--Elegir--";

        public C_persona_crud(Vo_persona persona = null)
        {
            frm = new Capa_Vista.frm_people_crud();
            c_message = C_message.getInstancia();
            message_box = c_message.formulario();

            frm.txtPassword.UseSystemPasswordChar = true;

            vo_persona.Operacion = "insert";
            vo_persona.Visible = true;
            visibilidad(true);
            InitializeEvents();
            read_role();

            if (persona != null)
            {
                vo_persona.Clave = persona.Clave;
                vo_persona.Operacion = persona.Operacion;
                vo_persona.Visible = persona.Visible;
                vo_persona.Fotografia = persona.Fotografia;
                visibilidad(false);
                acomodar();

                frm.txtRFC.Text = persona.Rfc;
                frm.txtName.Text = persona.Nombre;
                frm.txtFirstName.Text = persona.Apellido_paterno;
                frm.txtSecondName.Text = persona.Apellido_materno;
                frm.cmbSexo.Text = persona.Sexo.ToString();
                frm.cmbEstado.Text = persona.Status.ToString();
                frm.txtTelephonePersonal.Text = persona.Telefono_personal;
                frm.txtTelephoneRelative.Text = persona.Telefono_periente;
                frm.txtEmail.Text = persona.Correo_electronico;
                frm.txtLocation.Text = persona.Localidad;
                frm.txtNameStreet.Text = persona.Nombre_calle;
                frm.txtNumerStreet.Text = persona.Numero_calle.Trim();
                frm.txtMunicipality.Text = persona.Municipio;
                frm.txtState.Text = persona.Estado;
                frm.txtPostalCode.Text = persona.Codigo_postal.Trim();
                frm.dtpRegistrationDate.Value = persona.Fecha_registro;

                if (persona.Fotografia!=null) {
                    MemoryStream ms = new MemoryStream(persona.Fotografia);
                    frm.cpbFoto.Image = Image.FromStream(ms);
                }
                else{
                    frm.cpbFoto.Image = null;
                }

                mensaje = persona.Rol.ToString();
            }

        }
        public frm_people_crud formulario()
        {
            return frm;
        }
        private void visibilidad(bool v)
        {
            frm.lbl_password.Visible = v;
            frm.txtPassword.Visible = v;
            frm.ptbInvisible.Visible = v;

            frm.lbl_user.Visible = v;
            frm.txtUser.Visible = v;
        }
        private void acomodar()
        {
            frm.btnAcept.Location = new Point(295, 503);
            frm.Size =  new Size(405, 567);
        }
        private void InitializeEvents()
        {
            frm.Load += new EventHandler(frm_people_crud_Load);
            frm.ptbMinimize.Click += new EventHandler(ptbMinimize_Click);
            frm.ptbClose.Click += new EventHandler(ptbClose_Click);
            frm.pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
            frm.btnAcept.Click += new EventHandler(btnInsert_Click);
            frm.cmbRole.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbSexo.KeyDown += new KeyEventHandler(cmb_KeyDown);
            frm.cmbEstado.KeyDown += new KeyEventHandler(cmb_KeyDown);

            frm.txtRFC.KeyPress += new KeyPressEventHandler(txtRFC_KeyPress);
            frm.txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
            frm.txtFirstName.KeyPress += new KeyPressEventHandler(txtFirstName_KeyPress);
            frm.txtSecondName.KeyPress += new KeyPressEventHandler(txtSecondName_KeyPress);
            frm.txtTelephonePersonal.KeyPress += new KeyPressEventHandler(txtTelephonePersonal_KeyPress);
            frm.txtTelephoneRelative.KeyPress += new KeyPressEventHandler(txtTelephoneRelative_KeyPress);
            frm.txtEmail.KeyPress += new KeyPressEventHandler(txtEmail_KeyPress);
            frm.txtLocation.KeyPress += new KeyPressEventHandler(txtLocation_KeyPress);
            frm.txtNameStreet.KeyPress += new KeyPressEventHandler(txtNameStreet_KeyPress);
            frm.txtNumerStreet.KeyPress += new KeyPressEventHandler(txtNumerStreet_KeyPress);
            frm.txtMunicipality.KeyPress += new KeyPressEventHandler(txtMunicipality_KeyPress);
            frm.txtState.KeyPress += new KeyPressEventHandler(txtState_KeyPress);
            frm.txtPostalCode.KeyPress += new KeyPressEventHandler(txtPostalCode_KeyPress);
            frm.txtUser.KeyPress += new KeyPressEventHandler(txtUser_KeyPress);
            frm.txtPassword.KeyPress += new KeyPressEventHandler(txtPassword_KeyPress);
            frm.btnExamine.Click += new EventHandler(btnExaminar_Click);

            frm.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            frm.ptbInvisible.MouseHover += new EventHandler(ptbVisible_Hover);
            frm.ptbInvisible.MouseLeave += new EventHandler(ptbVisible_Leave);

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
        private void read_role()
        {
            frm.cmbRole.DataSource = pxy_persona.LIST_ROLE();
            frm.cmbRole.DisplayMember = "nombre";
            frm.cmbRole.ValueMember = "id";

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
            valida.SoloLetraEspacio(e, frm.txtName,20);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtName.Focus();
            }
        }
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraEspacio(e, frm.txtFirstName, 40);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtFirstName.Focus();
            }
        }
        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraEspacio(e, frm.txtSecondName, 40);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtSecondName.Focus();
            }
        }
        private void txtTelephonePersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumero(e, frm.txtTelephonePersonal,10);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtTelephonePersonal.Focus();
            }
        }
        private void txtTelephoneRelative_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumero(e, frm.txtTelephoneRelative, 10);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtTelephoneRelative.Focus();
            }
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeroLetraEspacio(e, frm.txtEmail, 30);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtEmail.Focus();
            }
        }
        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeroLetraEspacio(e, frm.txtLocation, 50);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtLocation.Focus();
            }
        }
        private void txtNameStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraEspacio(e, frm.txtNameStreet, 40);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtNameStreet.Focus();
            }
        }
        private void txtNumerStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumero(e, frm.txtNumerStreet, 5);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtNumerStreet.Focus();
            }
        }
        private void txtMunicipality_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraEspacio(e, frm.txtMunicipality, 50);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtMunicipality.Focus();
            }
        }
        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloLetraEspacio(e, frm.txtState, 50);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtState.Focus();
            }
        }
        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumero(e, frm.txtPostalCode, 6);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtPostalCode.Focus();
            }
        }
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeroLetraEspacio(e, frm.txtUser, 30);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtUser.Focus();
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeroLetraEspacio(e, frm.txtPassword,20);
            if (e.KeyChar == (char)Keys.Enter)
            {
                frm.txtPassword.Focus();
            }
        }
        private void cmb_KeyDown(object sender, KeyEventArgs e)
        {
            // ComboBox is readonly 
            e.SuppressKeyPress = true;
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            frm.txtPassword.UseSystemPasswordChar = true;
        }
        private void ptbVisible_Leave(object sender, EventArgs e)
        {
            frm.txtPassword.Focus();
            frm.txtPassword.UseSystemPasswordChar = true;
        }
        private void ptbVisible_Hover(object sender, EventArgs e)
        {
            frm.ptbInvisible.Focus();
            frm.txtPassword.UseSystemPasswordChar = false;
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
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            selecionarImagen(frm.cpbFoto);
        }
        private string selecionarImagen(PictureBox ptbFoto)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            DialogResult rs = abrir.ShowDialog();
            string nombre = "";

            if (rs == DialogResult.OK)
            {
                string cadena = abrir.SafeFileName;

                if (cadena != "")
                {
                    string[] extension = cadena.Split('.');

                    if (extension[1] == "jpg" || extension[1] == "png")
                    {
                        ptbFoto.Image = Image.FromFile(abrir.FileName);
                        nombre = (extension[0] + "." + extension[1]);
                    }
                    else
                    {
                        desenfoque_abrir_formulario();
                        c_message.message("Extensión incorrecta ", C_message.message_type.error);
                        overlayForm.Dispose();
                        nombre = "";
                    }
                }
                else
                {

                    desenfoque_abrir_formulario();
                    c_message.message("No seleccionó imagen! ", C_message.message_type.warning);
                    overlayForm.Dispose();
                    nombre = "";
                }
            }
            return nombre;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (valida.CampoObligatorio(frm.pnlContent))
            {
                if (frm.cpbFoto.Image != null)
                {
                    vo_persona.Rfc = frm.txtRFC.Text;
                    vo_persona.Nombre = frm.txtName.Text;
                    vo_persona.Apellido_paterno = frm.txtFirstName.Text;
                    vo_persona.Apellido_materno = frm.txtSecondName.Text;
                    vo_persona.Sexo = Convert.ToChar(frm.cmbSexo.SelectedItem.ToString());
                    vo_persona.Status = frm.cmbEstado.SelectedItem.ToString();
                    vo_persona.Telefono_personal = frm.txtTelephonePersonal.Text;
                    vo_persona.Telefono_periente = frm.txtTelephoneRelative.Text;
                    vo_persona.Correo_electronico = frm.txtEmail.Text;
                    vo_persona.Localidad = frm.txtLocation.Text;
                    vo_persona.Nombre_calle = frm.txtNameStreet.Text;
                    vo_persona.Numero_calle = frm.txtNumerStreet.Text;
                    vo_persona.Municipio = frm.txtMunicipality.Text;
                    vo_persona.Estado = frm.txtState.Text;
                    vo_persona.Codigo_postal = frm.txtPostalCode.Text;
                    vo_persona.Fecha_registro = frm.dtpRegistrationDate.Value;
                    vo_persona.Usuario = frm.txtUser.Text;
                    vo_persona.Contrasena = frm.txtPassword.Text;
                    vo_persona.Rol = Convert.ToInt16(frm.cmbRole.SelectedValue.ToString());

                    MemoryStream ms = new MemoryStream();
                    frm.cpbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    vo_persona.Fotografia = ms.GetBuffer();

                    if (!(vo_persona.validate(validator, out brokenRules)))
                    {
                        vo_persona.Contrasena = Vst_seguridad.GetSHA256(frm.txtPassword.Text);

                        if (vo_persona.Operacion.Equals("update"))
                        {

                            desenfoque_abrir_formulario();

                            if (pxy_persona.UPDATE(vo_persona))
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
                        else if (vo_persona.Operacion.Equals("insert"))
                        {
                            desenfoque_abrir_formulario();

                            if (pxy_persona.CREATE(vo_persona))
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
                        foreach (var item in brokenRules)
                        {
                            c_message.message(item, C_message.message_type.error);
                        }
                        overlayForm.Dispose();
                    }
                }
            else
            {
                desenfoque_abrir_formulario();
                c_message.message("Seleccione una imagen ", C_message.message_type.error);
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
            frm.cmbRole.Text = mensaje;
        }

    }
}
