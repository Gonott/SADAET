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


    }
}
