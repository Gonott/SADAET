using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Empleado
    {

        public int Legajo { get; set; }

        public int DNI { get; set; }

        public string Nombre { get; set; }

        public int Telefono { get; set; }

        public string Correo { get; set; }

        public string Dirección { get; set; }

        public List<Software> Aplicaciones = new List<Software>();


        public int idDepartamento { get; set; }

       



    }
}
