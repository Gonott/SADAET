using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    /// <summary>
    /// Sirve para encapsular la excepción a serializar, 
    /// cada vez que se genera una exepción no controlada, cae aca y esto se serializa.
    /// </summary>
    
    [Serializable]
    public class ExepcionSerializada
    {

        public string Tipo { get; set; }

        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public ExepcionSerializada() 
        { 
            this.TimeStamp = DateTime.Now;
        }

        public ExepcionSerializada(string Message) : this() 
        {
            this.Message = Message;
        }

        public ExepcionSerializada(System.Exception ex) : this(ex.Message) 
        {
            this.StackTrace = ex.StackTrace; 
            this.Tipo = ex.GetType().ToString(); 
        }
        public override string ToString() { return this.Message + this.StackTrace; }



    }



}
