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

namespace GUI
{
    public partial class FormControl_de_Cambios : Form
    {
        SolicitudBLL solicitudBLL = new SolicitudBLL();
        Solicitud solicitudTemporal = new Solicitud();
        List<Solicitud> solicitudes = new List<Solicitud>();

        GestorCambiosEstadoBLL gestorbll = new GestorCambiosEstadoBLL();


        public FormControl_de_Cambios()
        {
            InitializeComponent();
        }

        private void FormControl_de_Cambios_Load(object sender, EventArgs e)
        {
            ActualizarSolicitudes();
        }


        public void ActualizarSolicitudes()
        {
            solicitudes = solicitudBLL.ListarSolicitudes();
            dataGridViewSolicitudes.DataSource = solicitudes;
            dataGridViewSolicitudes.ReadOnly = true;
            dataGridViewSolicitudes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        public void ActualizarEstados(Solicitud sol)
        {
            dataGridViewEstados.DataSource = gestorbll.VerEstadosSolicitud(sol);
            dataGridViewEstados.ReadOnly = true;
            dataGridViewEstados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void dataGridViewSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewSolicitudes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewSolicitudes.Rows[e.RowIndex].Selected = true;
                    if (solicitudTemporal == null)
                    {
                        solicitudTemporal = new Solicitud();
                    }
                    int id = int.Parse(dataGridViewSolicitudes.CurrentRow.Cells["CodPedido"].Value.ToString());
                    foreach (Solicitud solicitud in solicitudes)
                    {
                        if (solicitud.CodPedido == id)
                        {
                            solicitudTemporal = solicitud;
                        }
                    }

                }

                ActualizarEstados(solicitudTemporal);

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }
    }
}
