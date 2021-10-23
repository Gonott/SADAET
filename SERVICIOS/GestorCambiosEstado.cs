using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERVICIOS.ServiciosDAL;

namespace SERVICIOS
{
    public class GestorCambiosEstado
    {

        GestorCambiosEstadoDAL mapper = new GestorCambiosEstadoDAL();


        public void GrabarEstadoSolicitud(Solicitud solicitud)
        {
            try
            {
                mapper.GrabarEstado(solicitud);
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw;
            }
            
        }



        public List<EstadoSolicitud> VerEstadosSolicitud(Solicitud sol)
        {
            try
            {
                return mapper.ListarEstadosSolicitud(sol);
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }
            
        }


        public void VolverEstado(EstadoSolicitud estadoSolicitud)
        {

            try
            {
                mapper.VoverEstadoSolicitud(estadoSolicitud);
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }


        }


    }

}
