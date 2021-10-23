using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERVICIOS.ServiciosDAL;

namespace SERVICIOS
{
    public sealed class GestorBitacora
    {

        #region singleton 

        private GestorBitacora() { }

        private static GestorBitacora instancia = null;
        public static GestorBitacora ObtenerInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GestorBitacora();
                }
                return instancia;

            }
        }

        #endregion

        GestorBitacoraDAL mapper = new GestorBitacoraDAL();

        public List<EventoBitacora> LeerBitacora()
        {
            try
            {
                return mapper.LeerBitacora();
            }
            catch (Exception)
            {

                throw;
            }

            

        }



        public List<EventoBitacora> Filtrar(List<EventoBitacora> aFiltrar, DateTime desde, DateTime hasta)
        {
            List<EventoBitacora> filtrados = new List<EventoBitacora>();
            foreach (EventoBitacora evento in aFiltrar)
            {
                if (desde <= evento.fecha && evento.fecha <= hasta)
                {
                    filtrados.Add(evento);

                }
                
            }
            return filtrados;
        }


        public  List<EventoBitacora> Filtrar(List<EventoBitacora> aFiltrar, Usuario usr)
        {
            
            List<EventoBitacora> filtrados = new List<EventoBitacora>();
            foreach (EventoBitacora evento in aFiltrar)
            {
                if (evento.nombreUsuario == usr.NombreUsuario)
                {
                    filtrados.Add(evento);
                }

            }
            return filtrados;
        }


        public List<EventoBitacora> Filtrar(List<EventoBitacora> aFiltrar, string palabra)
        {

            List<EventoBitacora> filtrados = new List<EventoBitacora>();
            foreach (EventoBitacora evento in aFiltrar)
            {
                if (evento.actividad.Contains(palabra) || evento.información.Contains(palabra))
                {
                    filtrados.Add(evento);
                }

            }
            return filtrados;

        }



        public void Grabar(string evento, string info)
        {
            try
            {
                mapper.Grabar(evento, info, Sesion.ObtenerInstancia.EsteUsuario.IdUsuario);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
       
    }

}
