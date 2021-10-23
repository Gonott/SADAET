using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using SERVICIOS;
using SERVICIOS.ServiciosDAL;


namespace DAL
{
    public class EquipoDAL
    {

        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();




        #region SELECTS

        public List<Equipo> ListarEquipos()
        {
            try
            {
                cmd.Parameters.Clear();
                List<Equipo> equipos = new List<Equipo>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarEquiposConfigurados";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Equipo equi = new Equipo();
                    equi.CodInventario = int.Parse(Lector["Codigo"].ToString());
                    equi.Descripcion = Lector["Descripcion"].ToString();
                    equipos.Add(equi);
                }
                cmd.Connection.Close();
                return equipos;
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


        public List<Componente> ListarComponentesPorEquipo(Equipo equi) //Lista los componentes para un equipo dado.
        {
            try
            {
                List<Componente> componentes = new List<Componente>();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idequipo", equi.CodInventario);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarComponentesDeEquipo";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Componente cmp = new Componente();
                    cmp.Id = int.Parse(Lector["Id"].ToString());
                    cmp.Descripcion = Lector["Descripcion"].ToString();
                    cmp.Capacidad = int.Parse(Lector["Capacidad"].ToString());
                    cmp.Velocidad = int.Parse(Lector["Velocidad"].ToString());
                    switch (Lector["Tipo"].ToString())
                    {
                        case "DiscoDuro": cmp.Tipo = TipoComponente.DiscoDuro; break;
                        case "MemoriaRAM": cmp.Tipo = TipoComponente.MemoriaRAM; break;
                        case "Procesador": cmp.Tipo = TipoComponente.Procesador; break;
                    }
                    componentes.Add(cmp);
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

         
        public Equipo SeleccionarEquipo (int codinventario)
        {
            try
            {
                Equipo equi = new Equipo();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SeleccionarEquipo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codinv", codinventario);
                cmd.Connection.Open();
                equi.Descripcion = cmd.ExecuteScalar().ToString();
                cmd.Connection.Close();
                equi.CodInventario = codinventario;
                equi.Componentes = ListarComponentesPorEquipo(equi);
                cmd.Dispose();
                return equi;
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

        #endregion


    }
}
