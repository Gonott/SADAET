using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;



namespace DAL   
{
   public class UsuarioDAL
    {

        SqlConnection cnx = AccesoDAL.ObtInstancia.ObtenerConexionSql();


        public int ValidarUsuario()
        {
           
            Usuario usu = Sesion.ObtenerInstancia.EsteUsuario;
            SqlCommand cmd = new SqlCommand("ValidarUsuario", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", usu.NombreUsuario);
            cmd.Parameters.AddWithValue("@pwd", usu.Contraseña);
            cnx.Open();
            int count = Sesion.ObtenerInstancia.EsteUsuario.IdUsuario = (int)cmd.ExecuteScalar();
            cnx.Close();
            return count;

        }

        public void IniciarSesion()
        {
            Usuario usu = Sesion.ObtenerInstancia.EsteUsuario;
            SqlCommand cmd = new SqlCommand("IniciarSesion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usu", usu.NombreUsuario);
            cmd.Parameters.AddWithValue("@pwd", usu.Contraseña);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }


        public void CerrarSesion()
        {
            Usuario usu = Sesion.ObtenerInstancia.EsteUsuario;
            SqlCommand cmd = new SqlCommand("CerrarSesion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usu", usu.NombreUsuario);
            cmd.Parameters.AddWithValue("@pwd", usu.Contraseña);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }


        public List<Usuario> VerUsuarios()
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
                usu.IdUsuario = int.Parse(Lector["Id"].ToString());
                usu.NombreUsuario = Lector["Usuario"].ToString();
                usu.Contraseña = Lector["Contraseña"].ToString();
                Usuarios.Add(usu);
            }

            cmd.Connection.Close();
            return Usuarios;
        }


    }
}
