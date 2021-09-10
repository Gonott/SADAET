using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using SERVICIOS;
using System.Threading;

namespace BLL
{
    public class UsuarioBLL
    {

        
        UsuarioDAL mapper = new UsuarioDAL();
        public bool ComprobarUsuario(Usuario UnUsuario)
        {
            //Aca lo asigno a la Sesion Singleton
            Sesion.ObtenerInstancia.EsteUsuario = UnUsuario;
            //Si existe el usuario, será mayor o igual
            int count = mapper.ValidarUsuario();
            bool rta = false;
            if (count >= 1)
            {
                rta = true;
                IniciarSesion();
            }
            return rta;
        }


        public void IniciarSesion()
        {
           
            Sesion.ObtenerInstancia.EsteUsuario.Logueado = true;

            mapper.IniciarSesion();
            


        }



    }
}
