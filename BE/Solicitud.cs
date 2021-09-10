using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Solicitud
    {

        public int CodPedido { get; set; }

        public List<Periferico> Perifericos;

        public Equipo equipo = new Equipo();


        public Empleado empleado = new Empleado();

        public DateTime Fecha;

        public Estado estado;


        ///
        /// 
        ///Los siguientes strings sirven para mostrar las solicitudes adecuadamente en los DataGridView
        ///

        public string NombreEmpleado
        {
            get { return empleado.Nombre; }
            set { }
        }

        public string Estado
        {
            get { return estado.ToString(); }
            set { }
        }


        public string Fecha_Pedido
        {
            get { return Fecha.ToString(); }
            set { }
        }

        public string Dirección
        {
            get { return empleado.Dirección; }
            set { }
        }


    }
}
