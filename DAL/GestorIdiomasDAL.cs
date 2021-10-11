using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using SERVICIOS.ObserverIdioma;
using System.Data;
using SERVICIOS;

namespace DAL
{
    public class GestorIdiomasDAL
    {

        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();


        public List<Idioma> ListarIdiomas() //simplemente lista idiomas.
        {
            try
            {
                List<Idioma> idiomas = new List<Idioma>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarIdiomas";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Idioma unidioma = new Idioma();
                    unidioma.IdIdioma = int.Parse(Lector["Id"].ToString());
                    unidioma.Nombre = Lector["Nombre"].ToString();
                    idiomas.Add(unidioma);
                }
                cmd.Connection.Close();
                return idiomas;
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

        public string CambiarTexto(Idioma idioma, int nroTag) //obtiene el texto desde la BD
        {
            try
            {
                string texto;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ObtenerLeyenda";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("IdLeyenda", nroTag);
                cmd.Parameters.AddWithValue("IdIdioma", idioma.IdIdioma);
                cmd.Connection = cn;
                cmd.Connection.Open();
                texto = cmd.ExecuteScalar().ToString();
                cmd.Connection.Close();
                return texto;
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

        public int AltaIdioma(string nombreidioma) //ejecuta el alta y recibe el nuevo Id de ese idioma
        { 
            try
            {
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IngresarIdioma";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreidioma", nombreidioma);
                cmd.Connection.Open();
                int _id = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.Connection.Close();
                return _id;
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


        public List<ObjetoAuxiliarIdioma> ListarControles() 
        {//Busca una lista de controles para luego ser desplegados en la UI por medio de la BLL.
            
            try
            {
                List<ObjetoAuxiliarIdioma> controles = new List<ObjetoAuxiliarIdioma>();
                cmd.Parameters.Clear();
                cmd.CommandText = "ListarLeyendas"; 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    ObjetoAuxiliarIdioma control = new ObjetoAuxiliarIdioma();
                    control.Id = int.Parse(Lector["Id"].ToString());
                    control.Descripcion = Lector["Nombre"].ToString();
                    controles.Add(control);
                }
                return controles;
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

        public void InsertarTraduccion(int idIdioma, ObjetoAuxiliarIdioma control)
            //recibe el id del idioma recien creado y ejecuta el insert leyendo el texto de la columna.
            
        {
            try
            {
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarTraduccion"; 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idIdioma", idIdioma);
                cmd.Parameters.AddWithValue("@idLeyenda", control.Id);
                cmd.Parameters.AddWithValue("@texto", control.Texto);
                cmd.Connection.Open();
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
