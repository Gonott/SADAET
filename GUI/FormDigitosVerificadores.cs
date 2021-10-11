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


namespace GUI
{
    public partial class FormDigitosVerificadores : Form
    {

        DigitosVerificadores gestor = new DigitosVerificadores();

        public FormDigitosVerificadores()
        {
            InitializeComponent();
        }

        private void FormDigitosVerificadores_Load(object sender, EventArgs e)
        {

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
