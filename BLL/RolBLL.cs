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
               return mapper.ListarRolesUsuario(usr);
        }

        public void AgregarRolAUsuario(Rol r, Usuario u)
        {
            try
            {
                mapper.AsignarRolAUsuario(r, u);
                Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones.Add(r);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DesasignarRolDeUsuario(Rol r, Usuario u)
        {
            try
            {
                mapper.DesasignarRolUsuario(r, u);
                Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones.Remove(r);
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
