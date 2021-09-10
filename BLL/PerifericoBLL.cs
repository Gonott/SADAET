﻿
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

        public List<Periferico> ListarPerifericosNoAsignados()
        {
			try
			{
				return mapper.ListarPerifericos();
			}
			catch (Exception)
			{

				throw;
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
					}
				}

				
			}
			catch (Exception)
			{

				throw;
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
			return perifericosPC;
		}


	}
}