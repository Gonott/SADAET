using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAL;
using SERVICIOS.ObserverIdioma;
using SERVICIOS;

namespace BLL
{
    public class GestorIdiomasBLL
    {
        GestorIdiomasDAL mapper = new GestorIdiomasDAL();

        public string Traducir(Idioma idioma, int nroTag) //acude a la DAL para retornar el valor de leyenda
        {
            try
            {
                return mapper.CambiarTexto(idioma, nroTag);
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            } 
        }

        public List<Idioma> ListarIdiomas()
        {
            try
            {
                return mapper.ListarIdiomas();
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }
        
        }


        public List<ObjetoAuxiliarIdioma> ListarControles()
        {
            try
            {
                return mapper.ListarControles();
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }

        }

        public int AltaIdioma(string nombre)
        {
            try
            {
                GestorBitacora.ObtenerInstancia.Grabar("Alta de Idioma", "Se ingresó al sistema un nuevo idioma : " + nombre);
                return mapper.AltaIdioma(nombre);
                
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }
        }


        public void InsertarTraduccion(int idIdioma, List<ObjetoAuxiliarIdioma> traducciones)
        {
            try
            {
                foreach (ObjetoAuxiliarIdioma elemento in traducciones) //para cada objeto en la lista
                {
                    mapper.InsertarTraduccion(idIdioma, elemento); //insertar por medio de la dal.
                }
            }
            catch (Exception ex)
            {
                GestorBitacora.ObtenerInstancia.Grabar("Excepción", "El sistema lanzó la excepción: " + ex.Message);
                throw ex;
            }
        }


    }
}
