using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAL;
using SERVICIOS.ObserverIdioma;

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

                throw ex;
            }
        
        }


        public List<ObjetoAuxiliarIdioma> ListarControles()
        {
            try
            {
                return mapper.ListarControles();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int AltaIdioma(string nombre)
        {
            try
            {
                GestorBitacoraBLL.ObtenerInstancia.Grabar("Alta de Idioma", "Se ingresó al sistema un nuevo idioma : " + nombre);
                return mapper.AltaIdioma(nombre);
                
            }
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }


    }
}
