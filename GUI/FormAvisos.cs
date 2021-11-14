using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using SERVICIOS;
using SERVICIOS.ObserverIdioma;
using SERVICIOS.ServiciosDAL;

namespace GUI
{
    public partial class FormAvisos : Form
    {
        private int rolActual;
        AvisoBLL gestor = new AvisoBLL();
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();


        public void Update(Idioma idioma)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null)
                {
                    if (int.Parse(control.Tag.ToString()) != 0)
                    {
                        control.Text = gestorDeIdiomas.Traducir(Sesion.ObtenerInstancia.EsteIdioma, int.Parse(control.Tag.ToString()));
                    }
                }
            }
        }



        public FormAvisos(int rol)
        {
            rolActual = rol;
            InitializeComponent();
        }



        private void FormAvisos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestor.EliminarMisAvisos(rolActual);
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.VerMisAvisos(rolActual);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

    }
}
