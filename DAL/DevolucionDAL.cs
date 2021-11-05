using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERVICIOS;
using SERVICIOS.ServiciosDAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{

    public class DevolucionDAL
    {
        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();

        public void AltaDevolucion(Devolución dev, Solicitud sol)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AltaDevolucion";
                cmd.Parameters.AddWithValue("@motivo", dev.Motivo);
                cmd.Parameters.AddWithValue("@codSol", sol.CodPedido);
                cmd.Parameters.AddWithValue("@orden", dev.NroOrden);
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
        
        
        
        public void BajaDevolucion(Devolución dev)
        {

        }


        public void ModificarDevolucion(Devolución dev)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModificarDevolucion";
                cmd.Parameters.AddWithValue("@cod", dev.Codigo);
                cmd.Parameters.AddWithValue("@mot", dev.Motivo);
                cmd.Parameters.AddWithValue("@fecha", dev.Fecha);
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


        public List<Devolución> Listar()
        {
            try
            {
                cmd.Parameters.Clear();
                List<Devolución> devs = new List<Devolución>();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Devolucion";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Devolución dev = new Devolución();
                    dev.Codigo = int.Parse(Lector["Codigo"].ToString());
                    dev.Motivo = Lector["Motivo"].ToString();
                    dev.solicitudAsociada = int.Parse(Lector["CodSolicitud"].ToString());
                    if (Lector["FechaDevolucion"].ToString() != "" )
                    {
                        dev.Fecha = DateTime.Parse(Lector["FechaDevolucion"].ToString());
                    }
                    
                    
                    devs.Add(dev);
                }
                cmd.Connection.Close();
                return devs;
            }
            catch(Exception)
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
