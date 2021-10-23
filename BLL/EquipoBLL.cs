using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SERVICIOS;

namespace BLL
{
    public class EquipoBLL
    {
        EquipoDAL mapper = new EquipoDAL();
        EmpleadoBLL empleadoBll = new EmpleadoBLL();
        
 


        public Equipo BuscarEquipoAdecuado(Empleado empleado, Departamento departamento)
        {
            List<Equipo> EquiposAComparar = ListarEquipos();
            EquiposAComparar = ListarEquipos(); //se acude a la dal por medio del mapper para ver los equipos.
            empleado.Aplicaciones = empleadoBll.ConocerSoftware(empleado, departamento); //se acude a la bll de empleado para concoer el software que se necesita.
            //primero vamos a calcular los requisitos de hardware para el empleado

             int[] requisitos = empleadoBll.CalcularRequisitosHardware(empleado); // [Ram necesaria, Disco necesario, procesador necesario]
            
            //ahora vamos a ir a comparar equipo por equipo si es que tiene lo necesario.
            Equipo MejorEquipo = new Equipo();
            int RamSuperior = 32;// limite superior de comparacion de la RAM
            int ProcesadorSuperior = 5000; //limite superior de comparacion de velocidad de procesador
            foreach (Equipo equipo in EquiposAComparar)
            { //para cada equipo se van a recorrer sus componentes considerandolos

                bool matchRAM = false; //ayuda a saber si para este equipo la RAM es adecuada.
                bool matchProcesador = false; //ayuda a saber si para este equipo el procesador esta ok
                bool matchDisco = false; //lo mismo para el tamano de disco.

                foreach(Componente comp in equipo.Componentes)
                {

                    if (comp.Tipo == TipoComponente.Procesador) //comparamos por velocidad de procesador.
                    {
                        if(comp.Velocidad >= requisitos[2] && comp.Velocidad <= ProcesadorSuperior)
                        {
                            ProcesadorSuperior = comp.Velocidad; //sera la velocidad a 'superar'por el siguiente procesador.
                            matchProcesador = true;
                        }
                    }

                    //comparamos ram
                    if (comp.Tipo == TipoComponente.MemoriaRAM)
                    {
                        if(comp.Capacidad >= requisitos[0] && comp.Capacidad <= RamSuperior)
                        {
                            RamSuperior = comp.Capacidad; //esta sera la capacidad de ram a superar por la siguiente ram de otro equipo.
                            matchRAM = true;
                        }
                    }

                    //comparamos espacio de disco
                    if (comp.Tipo == TipoComponente.DiscoDuro)
                    {
                        if (comp.Capacidad > requisitos[1])
                        {
                            matchDisco = true; //media vez el espacio del disco es superior a lo requerido, es un match.
                        }
                    }

                }
                if ((matchProcesador == true) & (matchRAM == true) & (matchDisco == true)) //ahora comparamos los tres matchs, si estan true, el equipo completo es un match hasta que venga otro equipo.
                {
                    MejorEquipo = equipo;
                }

            }
            GestorBitacora.ObtenerInstancia.Grabar("Busqueda de Equipo Adecuado", "Se realizó la busqueda de un equipo adecuado empleado: " + empleado.Nombre );
            return MejorEquipo;
        

        }

   

        public List<Equipo> ListarEquipos()
        {
            try
            {
                List<Equipo> Equipos = new List<Equipo>();
                 Equipos = mapper.ListarEquipos();
                foreach (Equipo equipo in Equipos)
                {
                    equipo.Componentes = mapper.ListarComponentesPorEquipo(equipo);
                }
                return Equipos;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


       public Equipo SeleccionarEquipo(int codinv)
        {
            try
            {
                return mapper.SeleccionarEquipo(codinv);
            }
            catch (Exception)
            {

                throw;
            }
        }
        


    }
}
