using SERVICIOS.PerfilesComposite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class Usuario
    {
        
        
        
        public List<Autorizacion> Autorizaciones = new List<Autorizacion>();

        
        public string NombreUsuario { get; set; }
        public string  Contraseña { get; set; }

        public int IdUsuario { get; set; } = 0;

        public bool Logueado { get; set; } = false;


    }


}
