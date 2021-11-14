using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERVICIOS;
using SERVICIOS.DigitosVerificador;
using SERVICIOS.ObserverIdioma;
using SERVICIOS.ServiciosDAL;
using BLL;


namespace GUI
{
    public partial class FormDigitosVerificadores : Form, IIdiomaObserver
    {

        DigitosVerificadores gestor = new DigitosVerificadores();

        public FormDigitosVerificadores()
        {
            InitializeComponent();
        }


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

        private void FormDigitosVerificadores_Load(object sender, EventArgs e)
        {
            Subject.AgregarObserver(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DigitosVerificadores.GrabarDVHFull() == true)
            {
                MessageBox.Show("se generaron los DV");
            }
            else
            {
                MessageBox.Show("no se genero na");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DigitosVerificadores.ValidarBBDD() == false)
            {
                textBox1.Text = DigitosVerificadores.RegistrosCorruptos();
                
            }
            else
            {
                MessageBox.Show("No hay registros corruptos");
            }
        }
    }
}
