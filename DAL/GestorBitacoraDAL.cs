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

        public List<EventoBitacora> LeerBitacora()
        {
            try
            {
                 List<EventoBitacora> registro = new List<EventoBitacora>();
                 cmd.Connection = cn;
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.CommandText = "LeerBitacora";
                 cmd.Connection.Open();
                 SqlDataReader lector = cmd.ExecuteReader();
                 while(lector.Read() == true)
                {
                    EventoBitacora evento = new EventoBitacora();
                    evento.idEvento = int.Parse(lector["Id"].ToString());
                    evento.actividad = lector["Actividad"].ToString();
                    evento.información = lector["Descripcion"].ToString();
                    evento.fecha = DateTime.Parse(lector["Fecha"].ToString());
                    evento.nombreUsuario = lector["Usuario"].ToString();
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


        public void Grabar(string accion, string información, int idusuario)
        {
            try
            {
                cmd.Connection = cn;
                cmd.Parameters.Clear();
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GrabarBitacora";
                cmd.Parameters.AddWithValue("actividad", accion);
                cmd.Parameters.AddWithValue("desc", información);
                cmd.Parameters.AddWithValue("fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("idUsr", idusuario);
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
