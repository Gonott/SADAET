using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace GUI
{
    public partial class Form_Devoluciones : Form
    {
        public FormPrincipal FormParent;
        DevolucionBLL devolucionBll = new DevolucionBLL();
        Devolución devolucionTemp;
        List<Devolución> listado = new List<Devolución>();
        AvisoBLL avisoBll = new AvisoBLL();

        public Form_Devoluciones()
        {
            InitializeComponent();
        }

        private void Form_Devoluciones_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CompararFechas();
            if (avisoBll.VerMisAvisos(106).Count >= 1)
            {
                DialogResult resultado = MessageBox.Show("¿Deseas ver los anuncios ahora?","Avisos Pendientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    this.FormParent.LanzarAvisos(106);
                }
                    
            }
        }



        void ActualizarGrilla()
        {
            listado = devolucionBll.VerDevoluciones();
            dataGridViewDevoluciones.ReadOnly = true;
            dataGridViewDevoluciones.DataSource = null;
            dataGridViewDevoluciones.DataSource = listado;
        }

        private void dataGridViewDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewDevoluciones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null )
                {
                    dataGridViewDevoluciones.Rows[e.RowIndex].Selected = true;
                    if(devolucionTemp == null)
                    {
                        devolucionTemp = new Devolución();
                    }

                    foreach (Devolución devo in listado)
                    {
                        if (int.Parse(dataGridViewDevoluciones.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()) == devo.Codigo)
                        {
                            devolucionTemp = devo;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe hacer click dentro de las casillas.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }

        private void AplicarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                devolucionBll.AsignarFecha(devolucionTemp, dateTimePicker1.Value);
                ActualizarGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void CompararFechas()
        {

            foreach (Devolución devo in listado)
            {
                int comparacion = DateTime.Compare(devo.Fecha, DateTime.Now); 
                if (comparacion < 0)
                {
                    avisoBll.CrearAviso(106, "Devolución vencida", "Se debió ir a buscar la devolución de la orden: "
                        + devo.NroOrden + " el día " + devo.Fecha.ToString("dd/MM/yyyy"));
                }


            }



        }

    }
}
