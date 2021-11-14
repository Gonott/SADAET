using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.ObserverIdioma
{
    public class Idioma : Subject
    {

        public int IdIdioma { get; set; }

        public string Nombre { get; set; }


        private Idioma _idioma;



        public Idioma IdiomaSelected 
        {
            get { return _idioma; }
            set 
            { 
                _idioma = value;
                this.IdIdioma = _idioma.IdIdioma;
                this.Nombre = _idioma.Nombre;
                Notify(this);
            }
        }

    }
}
