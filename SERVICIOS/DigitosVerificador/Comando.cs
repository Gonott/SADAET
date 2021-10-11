using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace SERVICIOS.DigitosVerificador
{
    public class Comando
    {

       
        private static SqlCommand Command;

        public static SqlCommand ObjComando(String selectCommand, SqlConnection conexion)
        {
            Command = new SqlCommand();
            Command.CommandText = selectCommand;
            Command.CommandType = CommandType.Text;
            Command.Connection = conexion;
            return Command;
        }

        public static DataTable ObjDataTable(String selectCommand)
        {
            SqlDataAdapter DA = new SqlDataAdapter(selectCommand, AccesoDAL.ObtInstancia.ObtenerConexionSql());
            DataTable DT = new DataTable();
            DA.Fill(DT);
            return DT;
        }

        public static void ActualizarBD(String selectCommand, DataTable DT)
        {
            SqlDataAdapter DA = new SqlDataAdapter(selectCommand, AccesoDAL.ObtInstancia.ObtenerConexionSql());
            SqlCommandBuilder CB = new SqlCommandBuilder(DA);
            DA.InsertCommand = CB.GetInsertCommand();
            DA.DeleteCommand = CB.GetDeleteCommand();
            DA.UpdateCommand = CB.GetUpdateCommand();
            DA.Update(DT);
        }

        public static void ConsultaSQL(String selectCommand, SqlConnection conexion)
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();

            Command = ObjComando(selectCommand, conexion);
            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }
    }
}
