using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using System.Security.Cryptography.X509Certificates;
using SERVICIOS;

namespace DAL
{
    public class EmpleadoDAL
    {

        SqlConnection cn = AccesoDAL.ObtInstancia.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();


        public List<Software> ListarSoftwareEmpleado(Empleado emp)
        {
            try
            {
                List<Software> softwares = new List<Software>();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("IdEmp", emp.Legajo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarSoftwareEmpleado";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Software software = new Software();
                    software.Id = int.Parse(Lector["Id"].ToString());
                    software.Nombre = Lector["Nombre"].ToString();
                    software.RequisitoCPU = int.Parse(Lector["RequisitoCPU"].ToString());
                    software.RequisitoRAM = int.Parse(Lector["RequisitoRAM"].ToString());
                    software.Espacio_Disco = int.Parse(Lector["RequisitoDisco"].ToString());
                    softwares.Add(software);
                }
                cmd.Connection.Close();
                return softwares;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            


        }


        public List<Software> ListarSoftwareDepartamento(Departamento depto)
        {
            try
            {
                List<Software> softwares = new List<Software>();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idDepto", depto.Id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarSoftwareDepartamento";
                cmd.Connection = cn;
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Software software = new Software();
                    software.Id = int.Parse(Lector["Id"].ToString());
                    software.Nombre = Lector["Nombre"].ToString();
                    software.RequisitoCPU = int.Parse(Lector["RequisitoCPU"].ToString());
                    software.RequisitoRAM = int.Parse(Lector["RequisitoRAM"].ToString());
                    software.Espacio_Disco = int.Parse(Lector["RequisitoDisco"].ToString());
                    softwares.Add(software);
                }
                cmd.Connection.Close();
                return softwares;
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
    
    public List<Empleado> ListarEmpleados()
        {
            try
            {
                Encriptador criptografo = new Encriptador();
                List<Empleado> empleados = new List<Empleado>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListarEmpleados";
                cmd.Parameters.Clear();
                cmd.Connection.Open();
                SqlDataReader Lector = cmd.ExecuteReader();
                while (Lector.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.Legajo = int.Parse(Lector["Legajo"].ToString());
                    empleado.Nombre = Lector["Nombre"].ToString();
                    empleado.Telefono = int.Parse(Lector["Telefono"].ToString());
                    empleado.DNI = int.Parse(Lector["DNI"].ToString());
                    empleado.Correo = Lector["Correo"].ToString();
                    empleado.idDepartamento = int.Parse(Lector["IdDepartamento"].ToString());
                    empleado.Dirección = criptografo.DesEncriptarDatoSensible(Lector["Direccion"].ToString());
                    empleados.Add(empleado);
                }
                cmd.Connection.Close();
                return empleados;
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
