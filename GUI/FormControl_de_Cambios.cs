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
using SERVICIOS.ServiciosDAL;
using SERVICIOS.ObserverIdioma;

namespace GUI
{
    public partial class FormControl_de_Cambios : Form, IIdiomaObserver
    {
        SolicitudBLL solicitudBLL = new SolicitudBLL();
        Solicitud solicitudTemporal = new Solicitud();
        List<Solicitud> solicitudes = new List<Solicitud>();
        List<EstadoSolicitud> estados = new List<EstadoSolicitud>();


        GestorCambiosEstado gestorbll = new GestorCambiosEstado();
        EstadoSolicitud estadoTemporal = new EstadoSolicitud();


        public FormControl_de_Cambios()
        {
            InitializeComponent();
        }

        private void FormControl_de_Cambios_Load(object sender, EventArgs e)
        {
                ActualizarSolicitudes();
            Subject.AgregarObserver(this);
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
            estados = gestorbll.VerEstadosSolicitud(sol);
            dataGridViewEstados.DataSource = estados;
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

        private void dataGridViewEstados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewEstados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewEstados.Rows[e.RowIndex].Selected = true;
                    if (estadoTemporal == null)
                    {
                        estadoTemporal = new EstadoSolicitud();
                    }
                    int id = int.Parse(dataGridViewEstados.CurrentRow.Cells["Id"].Value.ToString());
                    foreach (EstadoSolicitud estado in estados)
                    {
                        if (estado.id == id)
                        {
                            estadoTemporal = estado;
                        }
                    }

                }

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                gestorbll.VolverEstado(estadoTemporal);
                MessageBox.Show("Listo, se ha vuelto al estado" + estadoTemporal.id + " de fecha " + estadoTemporal.fechaEditado);
                ActualizarSolicitudes();
                dataGridViewEstados.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
    }
}
