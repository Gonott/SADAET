using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using SERVICIOS;
using SERVICIOS.ServiciosDAL;




namespace DAL
{
    public class ComponenteDAL
    {
        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();

        public List<Componente> ListarComponentes()
        {   
            
            List<Componente> componentes = new List<Componente>();
            try
            {
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarComponentes";
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Componente componente = new Componente();
                    componente.Id = int.Parse(Lector["Id"].ToString());
                    componente.Capacidad = int.Parse(Lector["Capacidad"].ToString());
                    componente.Velocidad = int.Parse(Lector["Velocidad"].ToString());
                    componente.Descripcion = Lector["Descripcion"].ToString();
                    switch (Lector["Tipo"].ToString())
                    {
                        case "MemoriaRAM":
                            componente.Tipo = TipoComponente.MemoriaRAM;
                            break;
                        case "DiscoDuro":
                            componente.Tipo = TipoComponente.DiscoDuro;
                            break;
                        case "Procesador":
                            componente.Tipo = TipoComponente.Procesador;
                            break;
                    }
                    componentes.Add(componente);
                }
                cmd.Connection.Close();
                return componentes;
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
