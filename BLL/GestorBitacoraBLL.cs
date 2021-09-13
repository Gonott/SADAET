using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SERVICIOS;

namespace BLL
{
    public class GestorBitacoraBLL
    {

        GestorBitacoraDAL mapper = new GestorBitacoraDAL();

        public List<string> LeerBitacora()
        {
            
            return mapper.LeerBitacora();
            
        }
            
        
        public void Grabar(string evento)
        {
            mapper.Grabar(evento, Sesion.ObtenerInstancia.EsteUsuario.IdUsuario);
        }

    }
}
