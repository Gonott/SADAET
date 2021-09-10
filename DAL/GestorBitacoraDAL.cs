using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using BE;
using SERVICIOS;


namespace DAL
{
    public class GestorBitacoraDAL
    {
        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();

        public List<string> LeerBitacora()
        {
            try
            {
                 List<string> registro = new List<string>();
                 cmd.Connection = cn;
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "Select * from Bitacora";
                 cmd.Connection.Open();
                 SqlDataReader lector = cmd.ExecuteReader();
                 while(lector.Read() == true)
                {
                    string id = lector["IdEvento"].ToString();
                    string descripcion = lector["Descripcion"].ToString();
                    string fecha = lector["Fecha"].ToString();
                    string NombreUsuario = lector["IdUsuario"].ToString();
                    string evento = id + " " + fecha + " " + descripcion + " " + NombreUsuario;
                    registro.Add(evento);
                }
                cmd.Connection.Close();
                return registro;
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


        public void Grabar(string accion, int idusuario)
        {
            try
            {
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GrabarBitacora"; 
                cmd.Parameters.AddWithValue("Descripcion", accion);
                cmd.Parameters.AddWithValue("Fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("IdUsuario", idusuario);
                cmd.ExecuteNonQuery();


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


    }
}
