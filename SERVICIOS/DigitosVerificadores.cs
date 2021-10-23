using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using SERVICIOS.ServiciosDAL;




namespace SERVICIOS.DigitosVerificador
{
    public class DigitosVerificadores
    {
        private static bool Digito = true; 
        private static String RegMod = ""; 
        public static String CreateHash(String CadenaParametro)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            Byte[] MiHash;
            String Resumen;

            Byte[] Cadena = UE.GetBytes(CadenaParametro);
            SHA1CryptoServiceProvider Sha1Service = new SHA1CryptoServiceProvider();

            MiHash = Sha1Service.ComputeHash(Cadena);
            Resumen = Convert.ToBase64String(MiHash);

            return Resumen;
        }

        public static void GrabarPorTabla(String Consulta)
        {
            try
            {
                DataTable Tabla = Comando.ObjDataTable(Consulta);
                for (int row = 0; row < Tabla.Rows.Count; row++)
                {
                    String Cadena = ""; 
                    for (int column = 0; column < Tabla.Columns.Count - 2; column++)
                    {
                        Cadena = Cadena + Tabla.Rows[row].ItemArray[column]; 
                    }
                    Tabla.Rows[row]["DVH"] = CreateHash(Cadena); 
                    Comando.ActualizarBD(Consulta, Tabla);  
                }

                DataTable TodasLasTablas = Comando.ObjDataTable("select name from sys.tables where name = 'Solicitud'");  //where agregado para probar con tabla Solicitud primero.

                String CadenaDVH = "";
                for (int r = 0; r < TodasLasTablas.Rows.Count; r++)  
                {
                    if (!TodasLasTablas.Rows[r].ItemArray[0].ToString().Equals("DVV"))  
                    {
                        DataTable TablaDVH = Comando.ObjDataTable("select DVH from " + TodasLasTablas.Rows[r].ItemArray[0]);
                        for (int Rows = 0; Rows < TablaDVH.Rows.Count; Rows++)  
                        {
                            CadenaDVH = CadenaDVH + TablaDVH.Rows[Rows].ItemArray[0]; 
                        }
                    }
                }
                String DVV = CreateHash(CadenaDVH);  
                DataTable TablaDVV = Comando.ObjDataTable("select * from DVV");  
                TablaDVV.Rows[0][0] = DVV; 
                Comando.ActualizarBD("select * from DVV", TablaDVV);
                Digito = true;
                RegMod = "";
            }
            catch(Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }
        }

        public static bool ValidarBBDD()  
        {
            bool Retorno = false;
            Digito = true; 

            try
            {
                if (RegMod.Equals("")) 
                {
                    String CadenaDeDVH = null;
                    Retorno = true;

                    DataTable DTAllTables = Comando.ObjDataTable("select name from sys.tables where name = 'Solicitud' "); //puse solo solicitud para probar esa tabla.
                    for (int a = 0; a < DTAllTables.Rows.Count; a++) 
                    {
                        if (!DTAllTables.Rows[a].ItemArray[0].Equals("DVV"))  
                        {
                            DataTable Tabla = Comando.ObjDataTable("select * from " + DTAllTables.Rows[a].ItemArray[0]);  
                            for (int row = 0; row < Tabla.Rows.Count; row++) 
                            {
                                Tabla.Rows[row].ToString();
                                String CadenaConcatenada = null;
                                for (int columna = 0; columna < Tabla.Columns.Count - 2; columna++) 
                                {
                                    CadenaConcatenada += Tabla.Rows[row].ItemArray[columna]; 
                                }
                                CadenaDeDVH += CreateHash(CadenaConcatenada); 
                                if (!Tabla.Rows[row]["DVH"].ToString().Equals(CreateHash(CadenaConcatenada).ToString())) 
                                {  
                                    RegMod += "Error de integridad en la tabla " + DTAllTables.Rows[a].ItemArray[0].ToString() + " en el registro " + Tabla.Rows[row].ItemArray[0];
                                    Retorno = false;
                                    Digito = false;
                                }
                            }
                        }
                    }
                    if (Retorno == true) 
                    {
                        String DVV = CreateHash(CadenaDeDVH);  
                        String DVVActual = DVVBBDD();   
                        if (DVV.Equals(DVVActual)) 
                            Retorno = true;
                        else
                            Retorno = false;
                    }
                }
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }
            return Retorno;
        }

        public static String DVVBBDD()  //trae de la BD el DVV. 
        {
            DataTable TablaDVV = Comando.ObjDataTable("select * from DVV"); 
            return TablaDVV.Rows[0].ItemArray[0].ToString();
        }

        public static String RegistrosCorruptos()
        {
            return RegMod;
        }

        public static bool GrabarDVHFull()  //genera los digitos para toda la BD.
        {
            bool retorno = true;
            try
            {
                DataTable DTAllTables = Comando.ObjDataTable("select name from sys.tables where name = 'Solicitud' ");  //le agregué where solo para traer una tabla.
                for (int a = 0; a < DTAllTables.Rows.Count; a++) 
                {
                    if (!"DVV".Equals(DTAllTables.Rows[a].ItemArray[0])) 
                    {
                        DataTable Tabla = Comando.ObjDataTable("select * from " + DTAllTables.Rows[a].ItemArray[0]); 
                        for (int row = 0; row < Tabla.Rows.Count; row++) 
                        {
                            String CadenaConcatenada = null;
                            for (int column = 0; column < Tabla.Columns.Count - 2; column++) 
                            {
                                CadenaConcatenada += Tabla.Rows[row].ItemArray[column];  
                            }
                            Tabla.Rows[row]["DVH"] = CreateHash(CadenaConcatenada); 
                        }
                        Comando.ActualizarBD("select * from " + DTAllTables.Rows[a].ItemArray[0], Tabla); 
                    }
                }

                String CadenaDVH = null;
                for (int r = 0; r < DTAllTables.Rows.Count; r++)  
                {
                    if (!"DVV".Equals(DTAllTables.Rows[r].ItemArray[0]))  
                    {
                        DataTable TablaDVH = Comando.ObjDataTable("select DVH from " + DTAllTables.Rows[r].ItemArray[0]); 
                        for (int rows = 0; rows < TablaDVH.Rows.Count; rows++) 
                        {
                            CadenaDVH += TablaDVH.Rows[rows].ItemArray[0]; 
                        }
                    }
                }

                String DVV = CreateHash(CadenaDVH); 
                DataTable TablaDVV = Comando.ObjDataTable("select * from DVV"); 
                TablaDVV.Rows[0][0] = DVV;  
                Comando.ActualizarBD("select * from DVV", TablaDVV); 
                Digito = true;
                RegMod = "";
            }
            catch(Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }
            return retorno;
        }



    }
}
