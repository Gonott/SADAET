using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SERVICIOS;
using SERVICIOS.PerfilesComposite;

namespace BLL
{
    public class PermisoBLL
    {

        PermisoDAL mapper = new PermisoDAL();
        RolBLL rolbl = new RolBLL();

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



   
        
#region Asignaciones
        public void AgregarPermisoUsuario(Permiso perm, Usuario usu)
        {
            try
            {
                usu.Autorizaciones.Add(perm);
                mapper.AsignarPermisoAUsuario(perm, usu);
                GestorBitacoraBLL.ObtenerInstancia.Grabar("Agregación de Permiso" , "Se le agregó el permiso" + perm.Nombre + " al usuario " + usu.NombreUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }


        public void AgregarPermisoRol(Permiso perm, Rol unrol)
        {

            try
            {
                
                mapper.AsignarPermisoARol(perm, unrol);
                unrol.AgregarAutorizacion(perm);
                GestorBitacoraBLL.ObtenerInstancia.Grabar("Asignación de permiso a Rol", "Se le asignó el permiso " + perm.Nombre + " a " + unrol.Nombre);

            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }


        #endregion



#region Desasignaciones

        public void DesasignarPermisoUsuario(Permiso perm, Usuario usu)
        {
            try
            {
                usu.Autorizaciones.Remove(perm);
                mapper.DesasignarPermisoUsuario(perm, usu);
                GestorBitacoraBLL.ObtenerInstancia.Grabar("Desasignación de Permiso", "Se le quito el permiso" + perm.Nombre + " al usuario " + usu.NombreUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void DesasignarPermisoRol(Permiso perm, Rol unrol)
        {

            try
            {

                mapper.DesasignarPermisoRol(perm, unrol);
                unrol.RemoverAutorizacion(perm);

                GestorBitacoraBLL.ObtenerInstancia.Grabar("Desasignación de permiso a Rol", "Se le quitó el permiso " + perm.Nombre + " a " + unrol.Nombre);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        #endregion


#region Listados
        public List<Permiso> ListarTodos()
        {
            try
            {
                return mapper.ListarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public List<Permiso> ListarPermisosPorRol(Rol unrol)
        {
            try
            {
                return mapper.ListarPermisosRol(unrol);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


        public List<Permiso> ListarPermisosUsuario(Usuario usu)
        {
            try
            {
                return mapper.ListarPermisosUsuario(usu);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        #endregion

#region ABM


        public void Alta(Permiso p)
        {
            try
            {
                GestorBitacoraBLL.ObtenerInstancia.Grabar("Alta de permiso", "Se dio de alta el permiso : " + p.Nombre);
                mapper.AltaPermiso(p);
            }
            catch (Exception)
            {

                throw;
            }
           ;
        }

        public void Baja(Permiso p)
        {
            try
            {
                mapper.BajaPermiso(p);
                GestorBitacoraBLL.ObtenerInstancia.Grabar("Baja de permiso", "Se dio de baja el permiso : " + p.Nombre);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Modificar(Permiso p)
        {
            try
            {
                mapper.Modificar(p);
                GestorBitacoraBLL.ObtenerInstancia.Grabar("Modificación de permiso", "Se modificó el permiso : " + p.Nombre);
            }
            catch (Exception)
            {

                throw;
            }
        }


        #endregion





    }
}
