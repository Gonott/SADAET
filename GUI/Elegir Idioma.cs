using BLL;
using SERVICIOS;
using SERVICIOS.ObserverIdioma;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Elegir_Idioma : Form
    {
        GestorIdiomasBLL gestorIdiomasBll = new GestorIdiomasBLL();
        UsuarioBLL usubll = new UsuarioBLL();


        public Elegir_Idioma()
        {
            InitializeComponent();
        }

        private void Elegir_Idioma_Load(object sender, EventArgs e)
        {
            //ComprobarPermisos();
            comboBoxIdiomas.DataSource = gestorIdiomasBll.ListarIdiomas();
            comboBoxIdiomas.DisplayMember = "Nombre";
        }

        private void AplicarBtn_Click(object sender, EventArgs e)
        {
            Sesion.ObtenerInstancia.EsteIdioma.IdiomaSelected = (Idioma)comboBoxIdiomas.SelectedItem;
        }


        public void ComprobarPermisos()
        {
            foreach (Control boton in this.Controls)
            {
                if (boton is Button)
                {
                    boton.Enabled = false;
                    boton.Enabled = usubll.ComprobarPermiso(int.Parse(boton.Tag.ToString()));
                }

            }
        }


    }
}
