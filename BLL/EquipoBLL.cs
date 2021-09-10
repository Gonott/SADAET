using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class EquipoBLL
    {
        EquipoDAL mapper = new EquipoDAL();


        public void AgregarEquipo (Equipo unEquipo)
        {
            mapper.AltaEquipo(unEquipo);
        }


        public void EliminarEquipo(Equipo unequipo)
        {
            mapper.BajaEquipo(unequipo);
        }

        public void ModificarEquipo(Equipo ue)
        {
            mapper.ModificarEquipo(ue);
        }


        public  List<Equipo> VerEquipos()
        {
            return mapper.ListarEquipos();

        }


    }
}
