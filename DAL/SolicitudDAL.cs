using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using SERVICIOS;
using SERVICIOS.DigitosVerificador;
using SERVICIOS.ServiciosDAL;


namespace DAL
{
    public class SolicitudDAL
    {
        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();
        Encriptador criptografo = new Encriptador();

        public List<Solicitud> ListarSolicitudes()
        {
            try
            {
                cmd.Parameters.Clear();
                List<Solicitud> solicitudes = new List<Solicitud>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarSolicitudesCombo";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Solicitud solicitud = new Solicitud();
                    Empleado emple = new Empleado();

                    solicitud.CodPedido = int.Parse(Lector["Id"].ToString());
                    solicitud.empleado.Legajo = int.Parse(Lector["IdEmpleado"].ToString());
                    solicitud.empleado.Nombre = Lector["Nombre"].ToString();
                    solicitud.empleado.DNI = int.Parse(Lector["DNI"].ToString());
                    solicitud.empleado.Correo = Lector["Correo"].ToString();
                    solicitud.empleado.Dirección = criptografo.DesEncriptarDatoSensible(Lector["Direccion"].ToString());
                    solicitud.empleado.Telefono = int.Parse(Lector["Telefono"].ToString());
                    if (Lector["IdEquipo"].ToString() != "")
                    {
                        solicitud.equipo.CodInventario = int.Parse(Lector["IdEquipo"].ToString());
                    }                    
                    solicitud.empleado.idDepartamento = int.Parse(Lector["IdDepartamento"].ToString());
                    solicitud.Fecha = DateTime.Parse(Lector["Fecha"].ToString());
                    
                    switch (Lector["Estado"].ToString())
                    {
                        case "Asignación":
                            solicitud.estado = Estado.Asignación;
                            break;
                        case "Preparación":
                            solicitud.estado = Estado.Preparación;
                            break;
                        case "ComodatoLegal":
                            solicitud.estado = Estado.ComodatoLegal;
                            break;
                        case "CorreoInterno":
                            solicitud.estado = Estado.CorreoInterno;
                            break;
                        case "Entregado":
                            solicitud.estado = Estado.Entregado;
                            break;
                        case "Devolucion":
                            solicitud.estado = Estado.Devolucion;
                            break;
                    }

                    solicitudes.Add(solicitud);
                }
                cmd.Connection.Close();
                return solicitudes;

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

        public void AsignarEquipo(Equipo equipo, Solicitud solicitud)
        { //asocia en la base de datos un id de equipo con un Id de solicitud y setea el estado en "Preparación".
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AsignarEquipo";
                cmd.Parameters.AddWithValue("@idequipo", equipo.CodInventario);
                cmd.Parameters.AddWithValue("@CodPedido", solicitud.CodPedido);
                cmd.Parameters.AddWithValue("@estado", solicitud.estado.ToString());
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
                DigitosVerificadores.GrabarPorTabla("Select * from Solicitud");
            }
            

        }

       public void AsignarRemito(Solicitud unaSolicitud, long nroDocumento)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AsignarRemito";
                cmd.Parameters.AddWithValue("@idSolicitud", unaSolicitud.CodPedido);
                cmd.Parameters.AddWithValue("@remito", nroDocumento);
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
                DigitosVerificadores.GrabarPorTabla("Select * from Solicitud");
            }


        }

        public void AsignarComodato(Solicitud unaSolicitud, long nroDocumento)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AsignarComodato";
                cmd.Parameters.AddWithValue("@idSolicitud", unaSolicitud.CodPedido);
                cmd.Parameters.AddWithValue("@nroComodato", nroDocumento);
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
                DigitosVerificadores.GrabarPorTabla("Select * from Solicitud");
            }
        }

        public void ModificarEstado(Solicitud nueva,Estado estado)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModificarEstadoSolicitud";
                cmd.Parameters.AddWithValue("@idSolicitud", nueva.CodPedido);
                cmd.Parameters.AddWithValue("@estado", estado.ToString());
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
                DigitosVerificadores.GrabarPorTabla("Select * from Solicitud");
            }
        }


        public void Alta(Solicitud nueva)
        {

            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AltaDeSolicitud";
                cmd.Parameters.AddWithValue("@idEmpleado", nueva.empleado.Legajo);
                cmd.Parameters.AddWithValue("@estado",nueva.estado.ToString() );
                cmd.Parameters.AddWithValue("@fecha",nueva.Fecha);
                cmd.Parameters.AddWithValue("@idusr", Sesion.ObtenerInstancia.EsteUsuario.IdUsuario);
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
                DigitosVerificadores.GrabarPorTabla("Select * from Solicitud");
            }

        }




    }
}
