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

	
		public List<Solicitud> ListarSolicitudes()
        {
            try
            {
				GestorBitacoraBLL.ObtenerInstancia.Grabar("Listar solicitudes", "Se listaron todas las solicitudes");
				return mapper.ListarSolicitudes();
            }
            catch (Exception)
            {

                throw;
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
				GestorBitacoraBLL.ObtenerInstancia.Grabar("Listar solicitudes", "Se listaron las solicitudes con estado " + estado);
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

				GestorBitacoraBLL.ObtenerInstancia.Grabar("Asignación de Equipo", "Se asignó el equipo: " + equipo.CodInventario + " a la solicitud " + solicitud.CodPedido);
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
				GestorBitacoraBLL.ObtenerInstancia.Grabar("Cambio de Estado", "Cambió el estado de la solicitud " + unaSolicitud.CodPedido + " a " + nuevoEstado);
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
				GestorBitacoraBLL.ObtenerInstancia.Grabar("Ingreso de Solicitud", "Se ingresó al sistema la solicitud para " + nuevaSolicitud.empleado.Nombre);
			}
			catch (Exception)
			{

				throw;
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
