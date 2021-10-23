using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SERVICIOS;

namespace BLL
{
    public class SolicitudBLL
    {
		SolicitudDAL mapper = new SolicitudDAL();
		GestorCambiosEstado cambiosEstadoBLL = new GestorCambiosEstado();
	
		public List<Solicitud> ListarSolicitudes()
        {
            try
            {
				GestorBitacora.ObtenerInstancia.Grabar("Listar solicitudes", "Se listaron todas las solicitudes");
				return mapper.ListarSolicitudes();
            }
            catch (Exception ex)
            {
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
            }
        }



		public List<Solicitud> ListarPorEstado(Estado estado)
        {
			List<Solicitud> Filtradas = new List<Solicitud>();
			try
			{
				List<Solicitud> solicitudes =  mapper.ListarSolicitudes();
				foreach (Solicitud item in solicitudes)
				{
					if (item.estado == estado)
					{
						Filtradas.Add(item);
					}
				}
				GestorBitacora.ObtenerInstancia.Grabar("Listar solicitudes", "Se listaron las solicitudes con estado " + estado);
				return Filtradas;
			}
			catch (Exception ex)
			{
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
			}

        }

		public void AsignarEquipo(Equipo equipo, Solicitud solicitud)
		{
			try
			{
				mapper.AsignarEquipo(equipo, solicitud);
				cambiosEstadoBLL.GrabarEstadoSolicitud(solicitud);
				GestorBitacora.ObtenerInstancia.Grabar("Asignación de Equipo", "Se asignó el equipo: " + equipo.CodInventario + " a la solicitud " + solicitud.CodPedido);
			}
			catch (Exception ex)
			{
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
			}

		}


		public void CambiarEstado(Solicitud unaSolicitud,Estado nuevoEstado)
		{
			try
			{
				mapper.ModificarEstado(unaSolicitud, nuevoEstado);
				cambiosEstadoBLL.GrabarEstadoSolicitud(unaSolicitud);
				GestorBitacora.ObtenerInstancia.Grabar("Cambio de Estado", "Cambió el estado de la solicitud " + unaSolicitud.CodPedido + " a " + nuevoEstado);
			}
			catch (Exception ex)
			{
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
			}


		}

		public void IngresarSolicitud(Solicitud nuevaSolicitud)
		{
			try
			{
				nuevaSolicitud.estado = Estado.Asignación;
				nuevaSolicitud.Fecha = DateTime.Now;
				mapper.Alta(nuevaSolicitud);
				GestorBitacora.ObtenerInstancia.Grabar("Ingreso de Solicitud", "Se ingresó al sistema la solicitud para " + nuevaSolicitud.empleado.Nombre);
			}
			catch (Exception ex)
			{
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
			}
		}

		public void AsignarDocumento(Solicitud unasolicitud, long nroDoc)
		{
			try
			{
				if (unasolicitud.estado == Estado.ComodatoLegal)
				{
					mapper.AsignarComodato(unasolicitud, nroDoc);
					CambiarEstado(unasolicitud, Estado.CorreoInterno);
					cambiosEstadoBLL.GrabarEstadoSolicitud(unasolicitud);
				}
				if (unasolicitud.estado == Estado.Preparación)
				{
					mapper.AsignarRemito(unasolicitud, nroDoc);
					CambiarEstado(unasolicitud, Estado.ComodatoLegal);
					cambiosEstadoBLL.GrabarEstadoSolicitud(unasolicitud);

				}
				
			}
			catch (Exception ex)
			{
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
			}


		}



    }
}
