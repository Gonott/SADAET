using BE;
using SERVICIOS;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AvisoBLL
    {
        AvisoDAL mapper = new AvisoDAL();

        public List<Aviso> VerMisAvisos(int miRol)
        {
            List<Aviso> misAvisos = new List<Aviso>();
            try
            {
                foreach (Aviso item in mapper.VerAvisosRol(miRol))
                {
                    if (item.RolDestinatario == miRol)
                    {
                        misAvisos.Add(item);
                    }
                }
                return misAvisos;
            }
            catch (Exception)
            {

                throw;
            }
        
        
        }

        public void CrearAviso(int rol, string titulo, string mensaje)
        {
            try
            {
                Aviso unAviso = new Aviso();
                unAviso.RolDestinatario = rol;
                unAviso.Titulo = titulo;
                unAviso.Fecha = DateTime.Now;
                unAviso.Mensaje = mensaje;
                mapper.AltaAviso(unAviso);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void EliminarMisAvisos(int rol)
        {
            try
            {
                mapper.EliminarPorRol(rol);
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
