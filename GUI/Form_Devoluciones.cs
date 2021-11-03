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
        DevolucionBLL devolucionBll = new DevolucionBLL();
        Devolución devolucionTemp;
        List<Devolución> listado = new List<Devolución>();

        public Form_Devoluciones()
        {
            InitializeComponent();
        }

        private void Form_Devoluciones_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
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
    }
}
