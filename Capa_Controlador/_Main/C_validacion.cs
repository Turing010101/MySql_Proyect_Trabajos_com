using System.Windows.Forms;

namespace Capa_Controlador
{
    class C_validacion
    {
        public ErrorProvider errores = new ErrorProvider();
        bool resp;

        ///VALIDACION DE SOLO NUMEROS
        public void SoloNumero(KeyPressEventArgs E, TextBox caja, int limite)
        {
            errores.SetIconPadding(caja, -20);

            if (char.IsNumber(E.KeyChar))
            {

                if (caja.Text.Length<limite)
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {
                    E.Handled = true;
                    errores.SetError(caja, "Limite");
                }
            }
            else
            {
                if (char.IsControl(E.KeyChar))
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {
                    if (char.IsWhiteSpace(E.KeyChar))
                    {
                        E.Handled = true;
                        errores.SetError(caja, "No se aceptan espacios en blanco");
                    }
                    else
                    {
                        E.Handled = true;
                        errores.SetError(caja, "Se aceptan solo números");
                    }
                }
            }
        }
        ///VALIDACION DE SOLO NUMEROS, LETRAS Y ESPACIOS.
        public void SoloNumeroLetraEspacio(KeyPressEventArgs E, TextBox caja, int limite)
        {
            errores.SetIconPadding(caja, -20);

                if (caja.Text.Length < limite)
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {

                     if (char.IsControl(E.KeyChar))
                    {
                     errores.Clear();
                    E.Handled = false;
                    }
                else
                {
                    E.Handled = true;
                    errores.SetError(caja, "Limite");
                }

                }
        }
        //VALIDACION DE SOLO LETRAS Y ESPACIOS
        internal void SoloLetraEspacio(KeyPressEventArgs E, TextBox caja,int limite)
        {
            errores.SetIconPadding(caja, -20);
            if (char.IsLetter(E.KeyChar))
            {

                if (caja.Text.Length < limite)
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {
                    E.Handled = true;
                    errores.SetError(caja, "Limite");
                }
            }
            else
            {
                if (char.IsControl(E.KeyChar))
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {
                    if (char.IsWhiteSpace(E.KeyChar))
                    {
                        E.Handled = false;
                    }
                    else
                    {
                        E.Handled = true;
                        errores.SetError(caja, "Se aceptan solo letras y espacios");
                    }
                }
            }
        }
        //VALIDACION DE SOLO LETRAS Y NUMEROS
        internal void SoloLetraNumero(KeyPressEventArgs E, TextBox caja, int limite)
        {
            errores.SetIconPadding(caja, -20);
            if (char.IsLetter(E.KeyChar) || char.IsNumber(E.KeyChar))
            {

                if (caja.Text.Length < limite)
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {
                    E.Handled = true;
                    errores.SetError(caja, "Limite");
                }
            }
            else
            {
                if (char.IsControl(E.KeyChar))
                {
                    errores.Clear();
                    E.Handled = false;
                }
                else
                {

                    E.Handled = true;
                    errores.SetError(caja, "Se aceptan solo letras y numeros");
                
                }
            }
        }
        //////////VALIDACION DE NO VACIOS
        public bool CampoObligatorio(Panel todo)
        {
            resp = true;
            foreach (Control controles in todo.Controls)
            {
                if (controles is TextBox)
                {
                    errores.SetIconPadding(controles, -20);
                    if (controles.Text==string.Empty && controles.Visible!=false)
                    {
                        errores.SetError(controles, "Campo obligatorio");
                        resp = false;
                    }
                    else
                    {
                        errores.SetError(controles, string.Empty);
                    }
                }
                else
                {
                    if (controles is ComboBox)
                    {
                        errores.SetIconPadding(controles, -20);
                        if (controles.Text== "--Elegir--")
                        {
                            errores.SetError(controles, "Campo obligatorio");
                            resp = false;
                        }
                        else
                        {
                            errores.SetError(controles, string.Empty);
                        }

                    }
                }
            }
            return resp;
        }
        
        public bool SqlInjection(Form todo)
        {
            resp = true;
            foreach (Control controles in todo.Controls)
            {
                if (controles is TextBox)
                {
                    if (controles.Text.Contains("=") && controles.Text.ToLower().Contains("or") && controles.Text.Contains("'"))
                    {
                        resp = false;
                    }
                    else if (controles.Text.Contains("=")  && controles.Text.ToLower().Contains("or") )
                    {
                        resp = false;
                    }
                }
            }
            return resp;
        }
    }
}