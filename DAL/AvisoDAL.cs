using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BE;
using SERVICIOS.ServiciosDAL;
using System.Data;

namespace DAL
{
    public class AvisoDAL
    {
        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();



        public List<Aviso> VerAvisosRol(int rol)
        {
            
            try
            {
                cmd.Parameters.Clear();
                List<Aviso> avisos = new List<Aviso>();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Aviso";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Aviso aviso = new Aviso();
                    aviso.Codigo = int.Parse(Lector["Id"].ToString());
                    aviso.Fecha = DateTime.Parse(Lector["Fecha"].ToString());
                    aviso.RolDestinatario = int.Parse(Lector["RolDestinatario"].ToString());
                    aviso.Titulo = Lector["Titulo"].ToString();
                    aviso.Mensaje = Lector["Mensaje"].ToString();
                    avisos.Add(aviso);
                }
                cmd.Connection.Close();
                return avisos;
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

        public void AltaAviso(Aviso unAviso)
        {
            try
            {
                
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AltaAviso";
                cmd.Parameters.AddWithValue("@fecha", unAviso.Fecha);
                cmd.Parameters.AddWithValue("@rol", unAviso.RolDestinatario);
                cmd.Parameters.AddWithValue("@titulo", unAviso.Titulo);
                cmd.Parameters.AddWithValue("@msj", unAviso.Mensaje);
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



        public void EliminarPorRol(int esterol)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EliminarPorRol";
                cmd.Parameters.AddWithValue("@rol", esterol);
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






    }



        


    
}
