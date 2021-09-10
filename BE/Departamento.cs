using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Software> Aplicaciones = new List<Software>();


        





    }
}
