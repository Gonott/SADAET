using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;


namespace DAL
{
    public class EquipoDAL
    {

        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();



        #region ABM
        public void AltaEquipo(Equipo equi)
        {
            try
            {
                
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AgregarEquipo";
            cmd.Parameters.AddWithValue("@inv", equi.CodInventario);
            cmd.Parameters.AddWithValue("@ram", equi.RAM);
            cmd.Parameters.AddWithValue("@disco", equi.Disco);
            cmd.Parameters.AddWithValue("@desc", equi.Descripcion);
            cmd.Parameters.AddWithValue("@proc", equi.Procesador);
        
            cmd.Connection = cn;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            }
            catch (Exception e)
            {
                throw e;
               
            }


        }


        public void BajaEquipo(Equipo equi)
        {
            try
            {

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BajaEquipo";
                cmd.Parameters.AddWithValue("@inv", equi.CodInventario);
               

                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            catch (Exception e)
            {
                throw e;

            }



        }

        public void ModificarEquipo(Equipo equi)
        {

            try
            {

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModificarEquipo";
                cmd.Parameters.AddWithValue("@inv", equi.CodInventario);
                cmd.Parameters.AddWithValue("@ram", equi.RAM);
                cmd.Parameters.AddWithValue("@disco", equi.Disco);
                cmd.Parameters.AddWithValue("@desc", equi.Descripcion);
                cmd.Parameters.AddWithValue("@proc", equi.Procesador);

                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            catch (Exception e)
            {
                throw e;

            }


        }

        #endregion



        #region SELECTS

        public List<Equipo> ListarEquipos()
        {
            cmd.Parameters.Clear();
            List<Equipo> equipos = new List<Equipo>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarEquiposStock";
            cmd.Connection = cn;
            cmd.Connection.Open();
            SqlDataReader Lector = cmd.ExecuteReader();
            while (Lector.Read())
            {
                Equipo equi = new Equipo();
                //equi.CodInventario = int.Parse(Lector[0].ToString());
                //equi.ram = Lector[1].ToString();
                //equi.Disco = Lector[2].ToString();
                // se completará esta parte una vez bien definido el modelo de datos.
                equipos.Add(equi);
            }
            cmd.Connection.Close();
            return equipos;
        }

        #endregion


    }
}
