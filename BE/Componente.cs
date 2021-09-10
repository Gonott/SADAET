using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class Componente
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int Capacidad { get; set; }

        public int Velocidad { get; set; }

        public TipoComponente Tipo;




    }
}
