using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERVICIOS;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());

           
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Hacer Algo con la exepción
            DialogResult result = MessageBox.Show("Hay una exepción no manejada, ¿Desea enviarla por correo al desarrollador? Es necesario que tenga Microsoft Outlook Instalado.", e.Exception.Message, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Serializador serializador = new Serializador();
                    serializador.Serializar(e.Exception);
                }
                catch (Exception)
                {

                    MessageBox.Show("No se pudo enviar el correo, la excepción se guardó en: " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                }
                
            }



        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            
            // Hacer Algo con la exepción
            MessageBox.Show("No se pudo enviar el correo, la excepción se guardó en: " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

        }
    }
}
