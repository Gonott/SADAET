using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;
using SERVICIOS;



namespace DAL   
{
    public class UsuarioDAL
    {

        SqlConnection cnx = AccesoDAL.ObtInstancia.ObtenerConexionSql();


        public int ValidarUsuario()
        {
            try
            {
                int count;
                SqlCommand cmd = new SqlCommand("ValidarUsuario", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usu", Sesion.ObtenerInstancia.EsteUsuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@pwd", Sesion.ObtenerInstancia.EsteUsuario.Contraseña);
                cnx.Open();
                object objetoDB = cmd.ExecuteScalar();
                if (objetoDB != null)
                {
                    count = int.Parse(objetoDB.ToString());

                }
                else
                {
                    count = 0;
                }

                Sesion.ObtenerInstancia.EsteUsuario.IdUsuario = count;
                cnx.Close();
                return count;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cnx != null && cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }




        public List<Usuario> VerUsuarios()
        {
            try
            {
                List<Usuario> Usuarios = new List<Usuario>();
                SqlCommand cmd = new SqlCommand("ListarUsuarios", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Usuario usu = new Usuario();
                    usu.IdUsuario = int.Parse(Lector["IdUsuario"].ToString());
                    usu.NombreUsuario = Lector["NombreUsuario"].ToString();
                    Usuarios.Add(usu);
                }

                cmd.Connection.Close();
                return Usuarios;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cnx != null && cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }


        #region ABM Usuarios


        public void Alta(Usuario usr)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AltaUsuario";
                cmd.Parameters.AddWithValue("@nombre", usr.NombreUsuario);
                cmd.Parameters.AddWithValue("@pwd",  usr.Contraseña);  //llamar al critografo desde UI.
                cmd.Connection = cnx;
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
                if (cnx != null && cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }


        }


        public void Baja(Usuario usr)
        {

            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BajaUsuario";
                cmd.Parameters.AddWithValue("@id", usr.IdUsuario);
                cmd.Connection = cnx;
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
                if (cnx != null && cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }



        public void Modificar(Usuario usr)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModificarUsuario";
                cmd.Parameters.AddWithValue("@id", usr.IdUsuario);
                cmd.Parameters.AddWithValue("@nombre", usr.NombreUsuario);
                cmd.Parameters.AddWithValue("@pwd", usr.Contraseña);  //llamar al critografo desde UI.
                cmd.Connection = cnx;
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
                if (cnx != null && cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }

        #endregion


    }
}
