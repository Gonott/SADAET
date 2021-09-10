using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using SERVICIOS.ObserverIdioma;
using SERVICIOS;

namespace GUI
{
    public partial class Form_AgregarIdioma : Form, IIdiomaObserver
    {
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();
        int ididioma;


        public Form_AgregarIdioma()
        {
            InitializeComponent();
        }

        private void Form_AgregarIdioma_Load(object sender, EventArgs e)
        {
            Subject.AgregarObserver(this);

        }


        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {

            ididioma = gestorDeIdiomas.AltaIdioma(textBoxIdioma.Text);
            dataGridView1.DataSource = gestorDeIdiomas.ListarControles();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;

            }
            catch (Exception)
            {

                throw;
            }
            

        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ObjetoAuxiliarIdioma> nuevasLeyendas = new List<ObjetoAuxiliarIdioma>();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {

                    ObjetoAuxiliarIdioma leyenda = new ObjetoAuxiliarIdioma();
                    leyenda.Id = int.Parse(fila.Cells["Id"].Value.ToString());
                    if (fila.Cells[1].Value == null)
                    {
                        leyenda.Descripcion = "";
                    }
                    if (fila.Cells[1].Value != null)
                    {
                        leyenda.Descripcion = fila.Cells[1].Value.ToString();
                    }
                    if (fila.Cells[2].Value == null)
                    {
                        leyenda.Texto = "";
                    }
                    if (fila.Cells[2].Value != null)
                    {
                        leyenda.Texto = fila.Cells[2].Value.ToString();
                    }
                    nuevasLeyendas.Add(leyenda);
                }
                gestorDeIdiomas.InsertarTraduccion(ididioma, nuevasLeyendas);
                MessageBox.Show("Idioma " + textBoxIdioma.Text + " agregado");
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }


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


    }
}

