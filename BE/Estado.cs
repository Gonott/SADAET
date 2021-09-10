using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum Estado
    { 

        /// <summary>
        /// Las solicitudes incian con estado Asignación, luego de agregarles los periféricos y 
        /// asignarles el equipo, estas cambian a estado Preparación, al agregarles el remito
        /// pasan a ComodatoLegal, luego de emitir el comodato legal
        /// pasan a Correo interno, donde luego se entregan y cambian el estado a Entregado.
        /// </summary>
        /// 

        Asignación, //0
   
        Preparación, //1

        ComodatoLegal, //2

        CorreoInterno, //3

        Entregado //4



    }
}
