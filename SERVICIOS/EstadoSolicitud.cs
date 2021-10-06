using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace SERVICIOS
{
    public class EstadoSolicitud
    {
        public int id { get; set; }

        //public int idSolicitud { get; set; }

        public int idEmpleado { get; set; }

        public int idEquipo { get; set; }

        public string estado { get; set; }

        public DateTime fecha { get; set; }

        public long nroRemito { get; set; }

        public long nroComodato { get; set; }

        public DateTime fechaEditado{ get; set; }

        public string nombreUsuario { get; set; }

    }
}
