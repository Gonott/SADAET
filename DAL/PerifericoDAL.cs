using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;
using SERVICIOS;
using System.ComponentModel;
using SERVICIOS.ServiciosDAL;

namespace DAL
{
    public class PerifericoDAL
    {
        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand(); 


        public List<Periferico> ListarPerifericos()
        {
            try
            {
                List<Periferico> perifericos = new List<Periferico>();
                cmd.Connection = cn;
                cmd.CommandText = "ListarPerifericos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Periferico periferico = new Periferico();
                    periferico.CodInventario = int.Parse(Lector["CodInventario"].ToString());
                    periferico.Descripcion = Lector["Descripcion"].ToString();
                    switch (Lector["Tipo"].ToString())
                    {
                        case "Teclado":
                            periferico.Tipo = TipoPeriferico.Teclado;
                            break;
                        case "Mouse":
                            periferico.Tipo = TipoPeriferico.Mouse;
                            break;
                        case "Monitor":
                            periferico.Tipo = TipoPeriferico.Monitor;
                            break;
                    }
                    perifericos.Add(periferico);
                }
                cmd.Connection.Close();
                return perifericos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AsociarPerifericos(Solicitud _solicitud, Periferico _perif )
        {
            try
            {
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.CommandText = "AsociarPeriferico";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idsolicitud", _solicitud.CodPedido);
                cmd.Parameters.AddWithValue("codperiferico",_perif.CodInventario);
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }



        }


    }
}
