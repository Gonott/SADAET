using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BE
{
    public sealed class Sesion
    { 
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

       /// <summary>
       /// Meter un Log Out / Gestionarlo aca 
       /// </summary>

        public Usuario EsteUsuario;





    }
}
