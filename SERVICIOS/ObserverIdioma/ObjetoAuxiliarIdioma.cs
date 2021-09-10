using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.ObserverIdioma
{      
    
    //El propósito de este objeto es para auxiliar al manejo de estructuras integer-string 
    // que serán usadas para empaquetar Leyendas (Id,Texto) desde la base de datos y controles
    //también desde la base de datos cuya estructura es (Id,Descripcion).
   public class ObjetoAuxiliarIdioma
    {


        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Texto { get; set; }

    }
}
