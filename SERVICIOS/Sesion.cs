using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BE;
using SERVICIOS.ObserverIdioma;
using SERVICIOS.PerfilesComposite;

namespace SERVICIOS
{
    public sealed class Sesion
    {

        public Usuario EsteUsuario;

        public Idioma EsteIdioma;

        private Sesion() { }

        private static Sesion instancia = null;

       

        public static Sesion ObtenerInstancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Sesion();
                }
                return instancia;

            }
        }


        public void CerrarSesion()
        {
            if (EsteUsuario != null)
            {
                EsteUsuario.Autorizaciones = null;
                this.EsteUsuario = null;

            }
            //dejamos el espacio en null
            else
            {
                return;
            }

        }



    }
}
