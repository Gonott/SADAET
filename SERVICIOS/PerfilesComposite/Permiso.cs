using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.PerfilesComposite
{
    public class Permiso : Autorizacion
    {

        

        public override void AgregarAutorizacion(Autorizacion ElementoComponente)
        {
            throw new NotImplementedException();
            
        }
        
        public override int CantidadHijos()
        {
            return 0;
            
        }

        public override List<Autorizacion> GetChilds()
        {
            return null;
        }

        public override void RemoverAutorizacion(Autorizacion ElementoComponente)
        {
            throw new NotImplementedException();
        }
    }
}
