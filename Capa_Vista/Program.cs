using Capa_Controlador;
using System;
using System.Windows.Forms;
namespace Capa_Vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            C_logeo c_logeo = new C_logeo();
            c_logeo.InitializeEvents();
        }
    }
}