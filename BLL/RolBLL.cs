using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Resources;
using SERVICIOS.PerfilesComposite;
using SERVICIOS;

namespace BLL
{
    public class RolBLL
    {
        RolDAL mapper = new RolDAL();
        
        public List<Rol> ObtenerRolesporUsuario(Usuario usr)
        {
            try
            {
                return mapper.ListarRolesUsuario(usr);
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", ex.Message);
                throw;
            }
               
        }

        public void AgregarRolAUsuario(Rol r, Usuario u)
        {
            try
            {
                mapper.AsignarRolAUsuario(r, u);
                Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones.Add(r);
                GestorBitacora.ObtenerInstancia.Grabar("Asignación de Rol", "El usuario ha asignado un rol al usuario "+ u.NombreUsuario );
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", ex.Message);
                throw ex;
            }
        }

        public void DesasignarRolDeUsuario(Rol r, Usuario u)
        {
            try
            {
                mapper.DesasignarRolUsuario(r, u);
                Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones.Remove(r);
                GestorBitacora.ObtenerInstancia.Grabar("Desasignación de Rol", "El usuario le ha quitado un rol al usuario " + u.NombreUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public List<Rol> ListarTodos()
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

        #region ABM Roles


        public void Alta(Rol r)
        {
            try
            {
                GestorBitacora.ObtenerInstancia.Grabar("Alta de Rol", "El usuario ha dado de alta el rol " + r.Nombre);
                mapper.AltaRol(r);

            }
            catch (Exception)
            {

                throw;
            }

            
        }


        public void Baja(Rol r)
        {
            try
            {
                GestorBitacora.ObtenerInstancia.Grabar("Baja de Rol", "El usuario ha dado de baja el rol" + r.Nombre);
                mapper.Baja(r);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void modificar(Rol r)
        {
            try
            {
                GestorBitacora.ObtenerInstancia.Grabar("Modificación de Rol", "El usuario ha modificado el rol" + r.Nombre);
                mapper.Modificar(r);
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        #endregion

    }
}
