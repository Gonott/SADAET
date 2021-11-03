using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERVICIOS;
using DAL;
using System.Reflection;

namespace BLL
{
    public class DevolucionBLL
    {
        DevolucionDAL mapper = new DevolucionDAL();

        EquipoBLL equipobll = new EquipoBLL();
        PerifericoBLL perifbll = new PerifericoBLL();

        public void AsignarFecha(Devolución dev, DateTime fecha)
        {
            dev.Fecha = fecha;
            try
            {
               mapper.ModificarDevolucion(dev);
            }
            catch (Exception ex)
            {

                
                GestorBitacora.ObtenerInstancia.Grabar("excepcion", ex.Message);
                throw;
            }
           

        }

        public  List<Devolución> VerDevoluciones()
        {
            try
            {
                return mapper.Listar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Devolución CrearDevolución(string mot, Solicitud sol)
        {
            sol.Perifericos = perifbll.ListarPerifericosSolicitud(sol);
            Devolución dev = new Devolución();
            foreach (Elemento elemento in sol.Perifericos)
            {
                dev.elementos.Add(elemento);
            }
            sol.equipo = equipobll.SeleccionarEquipo(sol.equipo.CodInventario);
            dev.elementos.Add(sol.equipo);
            dev.Motivo = mot;
            mapper.AltaDevolucion(dev,sol);

            return dev;

        }


    }
}
