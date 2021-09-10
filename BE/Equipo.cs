using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Equipo
    {

        public int CodInventario { get; set; }

        public string Descripcion { get; set; }

        public List<Componente> Componentes = new List<Componente>();



    }
}
