using SERVICIOS.ObserverIdioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.ObserverIdioma
{
   public  interface IIdiomaObserver //el observador, los forms heredarán de aca para cambiar sus leyendas.
    {

         
         void Update(Idioma idioma);
    }
}
