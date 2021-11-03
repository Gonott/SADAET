
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
    public class PerifericoBLL
    {
		PerifericoDAL mapper = new PerifericoDAL();


		public List<Periferico> ListarPerifericosSolicitud(Solicitud sol)
        {
            try
            {
				return mapper.ListarPorSolicitud(sol);
            }
            catch (Exception ex)
            {
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
			}
        }


		public List<Periferico> ListarPerifericosNoAsignados()
        {
			try
			{
				return mapper.ListarPerifericos();
			}
			catch (Exception ex)
			{
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
			}
        }

		public void AsignarPerifericos(Solicitud unasolicitud)
		{
			try
			{
				if (unasolicitud.Perifericos != null)
				{
					foreach (Periferico item in unasolicitud.Perifericos)
					{
						if (item.CodInventario != 0)
						{
							mapper.AsociarPerifericos(unasolicitud, item);
						}
						GestorBitacora.ObtenerInstancia.Grabar("Asignación de perifericos", "Se asignaron periféricos a la solicitud " + unasolicitud.CodPedido );
					}
				}

				
			}
			catch (Exception ex)
			{
				GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
				throw ex;
			}
		}

		public List<Periferico> BuscarPerifericosEquipo()
		{
			List<Periferico> perifericosPC = new List<Periferico>(); //lista de salida.
			List<Periferico> listado = ListarPerifericosNoAsignados(); //lista de entrada
			foreach (Periferico item in listado)
			{
				if (item.Tipo == TipoPeriferico.Monitor)
				{
					perifericosPC.Add(item);
					break;
				}
			}
			foreach(Periferico item in listado)
			{
				if (item.Tipo == TipoPeriferico.Teclado)
				{
					perifericosPC.Add(item);
					break;
				}

			}
			foreach (Periferico item in listado)
			{
				if(item.Tipo == TipoPeriferico.Mouse)
				{
					perifericosPC.Add(item);
					break;
				}

			}
			GestorBitacora.ObtenerInstancia.Grabar("Busqueda de periféricos", "Se buscaron perifericos");
			return perifericosPC;
		}


	}
}
