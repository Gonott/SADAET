using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;
using System.Data.Sql;
using SERVICIOS.PerfilesComposite;
using System.Data;
using SERVICIOS;

namespace DAL
{
    public class RolDAL
    {
        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();

        #region ABM FAMILIAS

        public void AltaRol(Rol UnRol)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AgregarRol";
                cmd.Parameters.AddWithValue("@nombre", UnRol.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", UnRol.Descripcion);
                cmd.Parameters.AddWithValue("@idrol", UnRol.Id);
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


        public void Baja(Rol UnRol)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EliminarRol";
                cmd.Parameters.AddWithValue("@idrol", UnRol.Id);
                //cmd.Parameters.AddWithValue("@nombre", UnRol.Nombre);
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



        public void Modificar(Rol UnRol)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModificarRol";
                cmd.Parameters.AddWithValue("@idrol", UnRol.Id);
                cmd.Parameters.AddWithValue("@nombre", UnRol.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", UnRol.Descripcion);
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


        #region  Selects

        public List<Rol> ListarTodos()
        {
            try
            {
                List<Rol> Roles = new List<Rol>();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarTodosRoles";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Rol unrol = new Rol();
                    unrol.Id = int.Parse(Lector["IdAutorizacion"].ToString());
                    unrol.Nombre = Lector["Nombre"].ToString();
                    unrol.Descripcion = Lector["Descripcion"].ToString();
                    Roles.Add(unrol);
                }
                cmd.Connection.Close();
                return Roles;

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

        public List<Rol> ListarRolesUsuario(Usuario usr)
        {
            try
            {
                List<Rol> Roles = new List<Rol>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.CommandText = "ListarRolesUsuario";
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@IdUsuario", usr.IdUsuario);
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Rol unrol = new Rol();
                    unrol.Id = int.Parse(Lector["IdAutorizacion"].ToString());
                    unrol.Nombre = Lector["Nombre"].ToString();
                    unrol.Descripcion = Lector["Descripcion"].ToString();
                    Roles.Add(unrol);
                }
                cmd.Connection.Close();
                return Roles;

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


        #region Asignaciones - Desasignaciones


        public void AsignarRolAUsuario(Rol unrol, Usuario usr)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AsignarRolAUsuario";
                cmd.Parameters.AddWithValue("@idusr",usr.IdUsuario);
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

        public void DesasignarRolUsuario(Rol unrol, Usuario usr)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DesasignarRolUsuario";
                cmd.Parameters.AddWithValue("@idusr", usr.IdUsuario);
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




        #endregion




    }

}