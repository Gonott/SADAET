using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.PerfilesComposite
{
    public abstract class Autorizacion
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

       
        public abstract void AgregarAutorizacion(Autorizacion ElementoComponente);
        public abstract void RemoverAutorizacion(Autorizacion ElementoComponente);
        public abstract int CantidadHijos();

        public abstract List<Autorizacion> GetChilds();

    }
}
