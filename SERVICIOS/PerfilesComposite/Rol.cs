using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.PerfilesComposite

{ 
    public class Rol : Autorizacion
    {
        public List<Autorizacion> Autorizaciones = new List<Autorizacion>();


        public override void AgregarAutorizacion(Autorizacion ElementoComponente)
        {
            Autorizaciones.Add(ElementoComponente);
        }

        public override int CantidadHijos()
        {
            return this.Autorizaciones.Count();
        }

        public override List<Autorizacion> GetChilds()
        {
            return Autorizaciones;
        }

        public override void RemoverAutorizacion(Autorizacion ElementoComponente)
        {
            throw new NotImplementedException();
        }
    }
}  