using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Devolución
    {

        public List<Elemento> elementos = new List<Elemento>();


        public int Codigo { get; set; }

        public string Motivo { get; set; }

        public DateTime Fecha { get; set; }


        public int NroOrden;

        public int solicitudAsociada;

    }
}
