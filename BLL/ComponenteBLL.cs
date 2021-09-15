using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using DAL;

namespace BLL
{
    public class ComponenteBLL
    {
        ComponenteDAL mapper = new ComponenteDAL();
        EmpleadoBLL empleadoBll = new EmpleadoBLL();


        public List<Componente> BuscarComponentesAdecuados(Empleado emp, Departamento depto)
        {
            List<Componente> ComponentesAComparar = ListarComponentes() ;
            List<Componente> Adecuados = new List<Componente>();
            emp.Aplicaciones = empleadoBll.ConocerSoftware(emp, depto);
            int[] requisitos = empleadoBll.CalcularRequisitosHardware(emp);// [Ram necesaria, Disco necesario, procesador necesario]
            int RamSuperior = 32;
            int DiscoSuperior = 1000;
            int ProcesadorSuperior = 5000;
            Componente RamAdecuada = new Componente();
            Componente ProcesadorAdecuado = new Componente();
            Componente DiscoAdecuado = new Componente();
            //a buscar en la lista la primer coincidencia para cada tipo de componente.

            foreach (Componente item in ComponentesAComparar)
            {
                if (item.Tipo == TipoComponente.MemoriaRAM)
                {
                    if (item.Capacidad >= requisitos[0] && item.Capacidad <= RamSuperior)
                    {
                        RamSuperior = item.Capacidad; //esta sera la capacidad de ram a superar por la siguiente ram .
                        RamAdecuada = item;
                    }
                }

                if (item.Tipo == TipoComponente.Procesador) //comparamos por velocidad de procesador.
                {
                    if (item.Velocidad >= requisitos[2] && item.Velocidad <= ProcesadorSuperior)
                    {
                        ProcesadorSuperior = item.Velocidad; //sera la velocidad a 'superar'por el siguiente procesador.
                        ProcesadorAdecuado = item;
                    }
                }
                if (item.Tipo == TipoComponente.DiscoDuro) 
                {
                    if (item.Capacidad >= requisitos[1] && item.Capacidad <= DiscoSuperior)
                    {
                        DiscoSuperior = item.Capacidad;
                        DiscoAdecuado = item; //media vez el espacio del disco es superior a lo requerido, es un match.
                    }
                }
            }
            Adecuados.Add(DiscoAdecuado);
            Adecuados.Add(RamAdecuada);
            Adecuados.Add(ProcesadorAdecuado);

            GestorBitacoraBLL.ObtenerInstancia.Grabar("Busqueda de componentes", "Se buscaron componentes adecuados para "+ emp.Nombre);
            return Adecuados;

        }

        public List<Componente> ListarComponentes()
        {
            try
            {
                return mapper.ListarComponentes();
            }
            catch (Exception)
            {

                throw;
            }

        }





    }
}
