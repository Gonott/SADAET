using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPrincipal : Form
    {
        Form_Login FormAut = new Form_Login();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void gestiónDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void búsquedaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sectorInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormAut.IsDisposed)
            {
                FormAut = new Form_Login();
            }
            
            FormAut.MdiParent = this;
            FormAut.FormParent = this;
            FormAut.Show();


        }

        private void salirDelSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in this.menuStrip1.Items  )
            {
                item.Enabled = false;
            }
            Sesion.ObtenerInstancia.EsteUsuario = null;
            
        }

        private void entregasYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
