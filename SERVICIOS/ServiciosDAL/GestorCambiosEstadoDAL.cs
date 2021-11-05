using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SERVICIOS;
using SERVICIOS.DigitosVerificador;
using BE;


namespace SERVICIOS.ServiciosDAL
{
    public class GestorCambiosEstadoDAL
    {

        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();



        public void GrabarEstado(Solicitud solicitud)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = cn;
                cmd.CommandText = "GuardarEstado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSolicitud", solicitud.CodPedido);
                cmd.Parameters.AddWithValue("@idusr", Sesion.ObtenerInstancia.EsteUsuario.IdUsuario);
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


        public List<EstadoSolicitud> ListarEstadosSolicitud(Solicitud solicitud)
        {

            
            try
            {
                cmd.Parameters.Clear();
                List<EstadoSolicitud> estados = new List<EstadoSolicitud>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarEstadosSolicitud";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idSolicitud", solicitud.CodPedido);
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    EstadoSolicitud estadoSolicitud = new EstadoSolicitud();
                    estadoSolicitud.id = int.Parse(Lector["IdEstado"].ToString());
                    estadoSolicitud.estado =  Lector["Estado"].ToString();
                    estadoSolicitud.idEmpleado = int.Parse(Lector["IdEmpleado"].ToString());
                    estadoSolicitud.fecha = DateTime.Parse(Lector["Fecha"].ToString());
                    if (Lector["IdEquipo"].ToString() != "")
                    {
                        estadoSolicitud.idEquipo = int.Parse(Lector["IdEquipo"].ToString());
                    }
                    else
                    {
                        estadoSolicitud.idEquipo = 0;
                    }
                    if (Lector["NroRemito"].ToString() != "")
                    {
                        estadoSolicitud.nroRemito = long.Parse(Lector["NroRemito"].ToString());
                    }
                    else 
                    {
                        estadoSolicitud.nroRemito = 0;
                    }
                    if (Lector["NroComodato"].ToString() != "")
                    {
                        estadoSolicitud.nroComodato = long.Parse(Lector["NroComodato"].ToString());
                    }
                    else
                    {
                        estadoSolicitud.nroComodato = 0;
                    }
                    
                    estadoSolicitud.fechaEditado = DateTime.Parse(Lector["FechaEditado"].ToString());
                    estadoSolicitud.nombreUsuario = Lector["NombreUsuario"].ToString();
                    estados.Add(estadoSolicitud);
                    
                }
                cmd.Connection.Close();
                return estados;
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


        public void VoverEstadoSolicitud(EstadoSolicitud estadoSolicitud)
        {

            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = cn;
                cmd.CommandText = "VolverEstadoSolicitud";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstado", estadoSolicitud.id);
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
                DigitosVerificadores.GrabarPorTabla("Select * from Solicitud");
            }

        }
    


    }
}
