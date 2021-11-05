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
        private PerifericoBLL perifBLL = new PerifericoBLL();
        private EquipoBLL equipoBLL = new EquipoBLL();

        public ControladorBLL(Devolución devolucionRecibida, Solicitud solicitudCorrespondiente)
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
                foreach (Elemento elemEntregado in entregados)
                {
                    foreach (Elemento elemRecibido in devActual.elementos)
                    {
                        if (elemRecibido.CodInventario == elemEntregado.CodInventario)
                        {
                            resultado = true;
                            break;

                        }
                        if (elemRecibido.CodInventario != elemEntregado.CodInventario)
                        {
                            resultado = false; 
                        }

                    }
                    if (resultado == false)
                    {
                        Faltantes.Add(elemEntregado);
                    }

                }
            }
            else if (devActual.elementos.Count() < entregados.Count())
            {
                
                foreach (Elemento entregado in entregados)
                {
                    bool está = false;
                    foreach (Elemento recibido in devActual.elementos)
                    {
                        if (entregado.CodInventario != recibido.CodInventario)
                        {
                            
                            resultado = false;
                        }
                        if(entregado.CodInventario == recibido.CodInventario)
                        {
                            está = true;
                            break;
                        }
                    }
                    if(está == false)
                    {
                        Faltantes.Add(entregado);
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
