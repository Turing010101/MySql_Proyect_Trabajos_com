using Capa_Modelo._Visitor;
using System;
using System.Collections.Generic;

namespace Capa_Modelo._VO
{
    public class Vo_persona:Vst_validatable<Vo_persona>
    {
        int clave;
        string rfc;
        string nombre;
        string apellido_paterno;
        string apellido_materno;
        char sexo;
        string status;
        string telefono_personal;
        string telefono_periente;
        string correo_electronico;
        string localidad;
        string nombre_calle;
        string numero_calle;
        string municipio;
        string estado;
        string codigo_postal;
        DateTime fecha_registro;
        string fecha_contrasena;
        string usuario;
        string contrasena;
        object rol;
        string operacion;
        string expresion;
        bool visible;
        byte[] fotografia;


        public int Clave { get => clave; set => clave = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Telefono_personal { get => telefono_personal; set => telefono_personal = value; }
        public string Telefono_periente { get => telefono_periente; set => telefono_periente = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Nombre_calle { get => nombre_calle; set => nombre_calle = value; }
        public string Numero_calle { get => numero_calle; set => numero_calle = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Codigo_postal { get => codigo_postal; set => codigo_postal = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public object Rol { get => rol; set => rol = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public string Expresion { get => expresion; set => expresion = value; }
        public bool Visible { get => visible; set => visible = value; }
        public string Fecha_contrasena { get => fecha_contrasena; set => fecha_contrasena = value; }
        public string Status { get => status; set => status = value; }
        public byte[] Fotografia { get => fotografia; set => fotografia = value; }

        public bool validate(Vst_validator<Vo_persona> validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            return validator.IsValid(this);
        }
    }
}
