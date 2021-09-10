using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using BE;
using SERVICIOS.PerfilesComposite;

namespace DAL
{
    public class PermisoDAL
    {

        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();

        #region ABM Patentes

        public void AltaPermiso(Permiso unper)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarPermiso";
                cmd.Parameters.AddWithValue("@Id", unper.Id);
                cmd.Parameters.AddWithValue("@nombre", unper.Nombre);
                cmd.Parameters.AddWithValue("@desc", unper.Descripcion);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        }


        public void BajaPermiso(Permiso unper)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EliminarPermiso";
                cmd.Parameters.AddWithValue("@Id", unper.Id);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }


        }



        public void Modificar(Permiso unper)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModificarPermiso";
                cmd.Parameters.AddWithValue("@idp", unper.Id);
                cmd.Parameters.AddWithValue("@nombre", unper.Nombre);
                cmd.Parameters.AddWithValue("@desc", unper.Descripcion);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        }

        #endregion

        #region Selects

       

        public List<Permiso> ListarTodos()
        {
            try
            {
                List<Permiso> permisos = new List<Permiso>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarTodosPermisos";
                cmd.Parameters.Clear();
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Permiso unperm = new Permiso();
                    unperm.Id = int.Parse(Lector["IdAutorizacion"].ToString());
                    unperm.Nombre = Lector["Nombre"].ToString();
                    unperm.Descripcion = Lector["Descripcion"].ToString();
                    permisos.Add(unperm);
                }
                cmd.Connection.Close();
                return permisos;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            
            
        }

        public List<Permiso> ListarPermisosUsuario(Usuario u)
        {
            try
            {
                List<Permiso> permisos = new List<Permiso>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.CommandText = "ListarPermisosDeUsuario";
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@idusr", u.IdUsuario);
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Permiso unperm = new Permiso();
                    unperm.Id = int.Parse(Lector["IdAutorizacion"].ToString());
                    unperm.Nombre = Lector["Nombre"].ToString();
                    unperm.Descripcion = Lector["Descripcion"].ToString();
                    permisos.Add(unperm);
                }
                cmd.Connection.Close();
                return permisos;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }


        }


        public List<Permiso> ListarPermisosRol(Rol r)
        {
            try
            {
                List<Permiso> permisos = new List<Permiso>();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarPermisosDeRol";
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@idrol", r.Id);
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Permiso unperm = new Permiso();
                    unperm.Id = int.Parse(Lector["IdAutorizacion"].ToString());
                    unperm.Nombre = Lector["Nombre"].ToString();
                    unperm.Descripcion = Lector["Descripcion"].ToString();
                    permisos.Add(unperm);
                }
                cmd.Connection.Close();
                return permisos;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
         

        }

        #endregion


        #region Asignaciones


        public void AsignarPermisoARol(Permiso unper, Rol unrol)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AsignarPermisoARol";
                cmd.Parameters.AddWithValue("@idperm", unper.Id);
                cmd.Parameters.AddWithValue("@idrol", unrol.Id);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }


        }

        public void DesasignarPermisoRol(Permiso unp, Rol unr)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DesasignarPermisoDeRol";
                cmd.Parameters.AddWithValue("@idperm", unp.Id);
                cmd.Parameters.AddWithValue("@idrol", unr.Id);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }




        public void AsignarPermisoAUsuario(Permiso unper, Usuario usr)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AsignarPermisoAUsuario";
                cmd.Parameters.AddWithValue("@idperm", unper.Id);
                cmd.Parameters.AddWithValue("@idusr", usr.IdUsuario);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }



        }


        public void DesasignarPermisoUsuario(Permiso unp, Usuario us)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DesasignarPermisoDeUsuario";
                cmd.Parameters.AddWithValue("@idperm", unp.Id);
                cmd.Parameters.AddWithValue("@idus", us.IdUsuario);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            
        }

        #endregion


    }
}
