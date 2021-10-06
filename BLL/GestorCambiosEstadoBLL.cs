using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SERVICIOS;
using BE;

namespace BLL
{
    public class GestorCambiosEstadoBLL
    {

        GestorCambiosEstadoDAL mapper = new GestorCambiosEstadoDAL();


        public void GrabarEstadoSolicitud(Solicitud solicitud)
        {
            try
            {
                mapper.GrabarEstado(solicitud);
            }
            catch (Exception)
            {
                throw;
            }
            
        }



        public List<EstadoSolicitud> VerEstadosSolicitud(Solicitud sol)
        {
            try
            {
                return mapper.ListarEstadosSolicitud(sol);
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        public void VolverEstado(EstadoSolicitud estadoSolicitud)
        {

            try
            {
                mapper.VoverEstadoSolicitud(estadoSolicitud);
            }
            catch (Exception)
            {

                throw;
            }


        }


    }

}
