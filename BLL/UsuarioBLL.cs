﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using SERVICIOS;
using SERVICIOS.PerfilesComposite;
using System.Threading;

namespace BLL
{
    public class UsuarioBLL
    {


        UsuarioDAL mapper = new UsuarioDAL();
        
        PermisoBLL permisoBll = new PermisoBLL();
        RolBLL rolbll = new RolBLL();

        public bool ComprobarUsuario(Usuario UnUsuario)
        {
            //Aca lo asigno a la Sesion Singleton
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
            //Ahora se procede a cargar el perfil.
            CargarPerfil(Sesion.ObtenerInstancia.EsteUsuario);

        }


        public List<Autorizacion> CargarPerfil(Usuario usr)
        {
            
            //llamamos a la DAL por permisos.
            List<Permiso> permisos = new List<Permiso>();
            permisos = permisoBll.ListarPermisosUsuario(usr); // llamar a permiso BLL que llama a PermisoDAL
            //agregamos cada permiso a las autorizaciones
            foreach (Permiso per in permisos)
            {
                usr.Autorizaciones.Add(per);
            }

            //luego voy por los roles
            List<Rol> roles = new List<Rol>();
            roles = rolbll.ObtenerRolesporUsuario(usr); //llamamos a RolBLL que a su vez llama a la DAL.

            foreach (Rol rolusr in roles)
            {

                //por cada rol voy a tener una lista de permisos/
                List<Permiso> permisosRol = new List<Permiso>();
                //llamamos a la DAL para obtener los permisos de ese rol: 
                permisosRol = permisoBll.ListarPermisosPorRol(rolusr);
                foreach (Permiso unpermiso in permisosRol) //la recorremos para agregar cada permiso
                {
                    rolusr.AgregarAutorizacion(unpermiso);
                }
                
                usr.Autorizaciones.Add(rolusr); //agregamos cada rol a las autorizaciones
            }

            return usr.Autorizaciones;


        }

      
        public bool ComprobarPermiso(int tagcontrol)
        {
            bool resultado = false;
            for (int i = 0; i < Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones.Count(); i++)
            {
                if (Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones[i].CantidadHijos() >= 1)// se trata de un rol
                {
                    Rol Roltemp = new Rol();
                    Roltemp = (Rol)Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones[i];
                    foreach (Permiso p in Roltemp.Autorizaciones)
                    {
                        if (tagcontrol == p.Id)
                        {
                            resultado = true;

                        }
                    }
                }
                if (Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones[i].CantidadHijos() == 0)
                {
                    if (tagcontrol == Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones[i].Id)
                    {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }


        public List<Usuario> ListarUsuarios()
        {
            try
            {
                return mapper.VerUsuarios();
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public void CerrarSesion()
        {
            
           
            Sesion.ObtenerInstancia.CerrarSesion();
        }

    }
}
