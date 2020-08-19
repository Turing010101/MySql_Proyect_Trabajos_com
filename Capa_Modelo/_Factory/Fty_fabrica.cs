using Capa_Modelo._Proxy;
namespace Capa_Modelo._Factory
{
    public class Fty_fabrica
    {
        public static object Fabricar(object X)
        {
            if (X is Pxy_persona)
            {
                return new Pxy_persona();
            }
            else if (X is Pxy_rol)
            {
                return new Pxy_rol();
            }
            else if(X is Pxy_categoria)
            {
                return new Pxy_categoria();
            }
            else if(X is Pxy_puesto)
            {
                return new Pxy_puesto();
            }
            else if(X is Pxy_sucursal)
            {
                return new Pxy_sucursal();
            }
            else if(X is Pxy_empleado)
            {
                return new Pxy_empleado();
            }
            else if (X is Pxy_login)
            {
                return new Pxy_login();
            }
            else if (X is Pxy_gmail)
            {
                return new Pxy_gmail();
            }
            else if (X is Pxy_recuperar)
            {
                return new Pxy_recuperar();
            }
            else if (X is Pxy_modificar)
            {
                return new Pxy_modificar();
            }
            else if (X is Pxy_permiso)
            {
                return new Pxy_permiso();
            }
            else if (X is Pxy_verificar)
            {
                return new Pxy_verificar();
            }
            else if (X is Pxy_actualizar)
            {
                return new Pxy_actualizar();
            }
            else if (X is Pxy_cliente)
            {
                return new Pxy_cliente();
            }
            else if (X is Pxy_documento)
            {
                return new Pxy_documento();
            }
            else if (X is Pxy_modulo)
            {
                return new Pxy_modulo();
            }
            else if (X is Pxy_accion)
            {
                return new Pxy_accion();
            }
            else if (X is Pxy_operacion)
            {
                return new Pxy_operacion();
            }
            else if (X is Pxy_operacion_perfil)
            {
                return new Pxy_operacion_perfil();
            }
            else if (X is Pxy_trabajador)
            {
                return new Pxy_trabajador();
            }
            else if (X is Pxy_asignar_categoria)
            {
                return new Pxy_asignar_categoria();
            }
            else if (X is Pxy_evaluar_trabajador)
            {
                return new Pxy_evaluar_trabajador();
            }
            else if (X is Pxy_contrato)
            {
                return new Pxy_contrato();
            }
            else if (X is Pxy_contrato_detalle)
            {
                return new Pxy_contrato_detalle();
            }
            else if (X is Pxy_servicio)
            {
                return new Pxy_servicio();
            }
            else
            {
                return null;
            }
        }
    }
}
