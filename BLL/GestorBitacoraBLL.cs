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

        public List<EventoBitacora> LeerBitacora()
        {
            
            return mapper.LeerBitacora();
            
        }
            
        
        public void Grabar(string evento, string info)
        {
            mapper.Grabar(evento, info, Sesion.ObtenerInstancia.EsteUsuario.IdUsuario);
        }

    }
}
