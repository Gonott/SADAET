using BE;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;



namespace BLL
{
    public class EmpleadoBLL
    {

		EmpleadoDAL mapper = new EmpleadoDAL();

        public List<Software> ConocerSoftware(Empleado empleado, Departamento depa)
        {//se conoce software pasando el empleado y su departamento
			try
			{

				List<Software> softDepa = new List<Software>();
				List<Software> softUsuario = new List<Software>();
				softUsuario = mapper.ListarSoftwareEmpleado(empleado);
				softDepa = mapper.ListarSoftwareDepartamento(depa);
				foreach (Software item in softDepa)
				{
					softUsuario.Add(item); //vamos a agregar cada software de departamento a la lista de 
					//software que ya tiene el software de usuario.
				}
				return softUsuario;
			}
			catch (Exception)
			{

				throw;
			}

        }

        public int[] CalcularRequisitosHardware(Empleado empleado)
        {

            int RAMnecesaria = 0, DiscoNecesario = 0, ProcesadorNecesario = 0;
            foreach (Software software in empleado.Aplicaciones)
            {
                //vamos a ir sumando la ram necesaria
                RAMnecesaria += software.RequisitoRAM;
                //vamos a ir sumando el espacio de disco a utilizar
                DiscoNecesario = DiscoNecesario + software.Espacio_Disco;
                //se toman como referencia el software que necesite mayor velocidad de procesador
                if (software.RequisitoCPU >= ProcesadorNecesario)
                {
                    ProcesadorNecesario = software.RequisitoCPU;
                }

            }
            //se vueltan los parametros en un array que va a representar al equipo ideal y  se retorna
            int[] EquipoIdeal = { RAMnecesaria, DiscoNecesario, ProcesadorNecesario };
            return EquipoIdeal;
        }



        public List<Empleado> ListarEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                empleados = mapper.ListarEmpleados();
                return empleados;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
