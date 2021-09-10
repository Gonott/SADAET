using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class SolicitudBLL
    {
		SolicitudDAL mapper = new SolicitudDAL();

	


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
				return Filtradas;
			}
			catch (Exception)
			{

				throw;
			}

        }

		public void AsignarEquipo(Equipo equipo, Solicitud solicitud)
		{
			try
			{
				mapper.AsignarEquipo(equipo, solicitud);
			}
			catch (Exception)
			{

				throw;
			}

		}


		public void CambiarEstado(Solicitud unaSolicitud,Estado nuevoEstado)
		{
			try
			{
				mapper.ModificarEstado(unaSolicitud, nuevoEstado);
			}
			catch (Exception)
			{

				throw;
			}


		}

		public void IngresarSolicitud(Solicitud nuevaSolicitud)
		{
			try
			{
				nuevaSolicitud.estado = Estado.Asignación;
				nuevaSolicitud.Fecha = DateTime.Now;
				mapper.Alta(nuevaSolicitud);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void AsignarDocumento(Solicitud unasolicitud, int nroDoc)
		{
			try
			{
				if (unasolicitud.estado == Estado.ComodatoLegal)
				{
					mapper.AsignarComodato(unasolicitud, nroDoc);
					CambiarEstado(unasolicitud, Estado.CorreoInterno);
				}
				if (unasolicitud.estado == Estado.Preparación)
				{
					mapper.AsignarRemito(unasolicitud, nroDoc);
					CambiarEstado(unasolicitud, Estado.ComodatoLegal);
					
				}
				
			}
			catch (Exception)
			{

				throw;
			}


		}



    }
}
