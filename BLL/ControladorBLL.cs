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
   public class ControladorBLL
    {
        private Devolución devActual = new Devolución();
        private Solicitud solicitudEntregados = new Solicitud();
        private List<Elemento> entregados = new List<Elemento>();
        public List<Elemento> Faltantes = new List<Elemento>();
        public List<Elemento> Dañados = new List<Elemento>();

        ControladorBLL(Devolución devolucionRecibida, Solicitud solicitudCorrespondiente)
        {
            devActual = devolucionRecibida;
            solicitudEntregados = solicitudCorrespondiente;
            foreach (Elemento item in solicitudCorrespondiente.Perifericos)
            {
                entregados.Add(item);
            }
            entregados.Add(solicitudCorrespondiente.equipo);
        }


        public bool ControlarCompletitud()
        {
            
            bool resultado = false;

            if (devActual.elementos.Count() == entregados.Count())
            {
                foreach (Elemento elemRecibido in devActual.elementos)
                {
                    foreach (Elemento elemEnregado in entregados)
                    {
                        if (elemRecibido.CodInventario == elemEnregado.CodInventario)
                        {
                            resultado = true;
                        }
                        if (elemRecibido.CodInventario != elemEnregado.CodInventario)
                        {
                            resultado = false;
                            Faltantes.Add(elemEnregado);
                        }

                    }

                }
            }
            else if(devActual.elementos.Count() != entregados.Count())
            {
                foreach (Elemento recibido in devActual.elementos)
                {
                    foreach (Elemento entregado in entregados)
                    {
                        if (entregado.CodInventario != recibido.CodInventario)
                        {
                            Faltantes.Add(entregado);
                            resultado = false;
                        }
                    }
                }
            }

            return resultado;
        }

        public bool ControlarCondiciones()
        {
            bool resultado = false;

            foreach (Elemento  recibido in devActual.elementos)
            {
                foreach (Elemento entregado in entregados)
                {
                    if (recibido.CodInventario == entregado.CodInventario)
                    {
                        if (recibido.condicion != entregado.condicion)
                        {
                            Dañados.Add(recibido);
                            resultado = false;
                        }
                        if (recibido.condicion == entregado.condicion)
                        {
                            resultado = true;
                        }
                    }

                    
                }
                
            }
            return resultado;


        }




    }
}
