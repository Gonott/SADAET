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
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using SERVICIOS;
using SERVICIOS.ObserverIdioma;

namespace GUI
{
    public partial class Form_ComodatoLegal : Form, IIdiomaObserver
    {
        Solicitud solicitudtemporal = new Solicitud();
        SolicitudBLL bllsolicitud = new SolicitudBLL();
        List<Solicitud> listado = new List<Solicitud>();
        EquipoBLL bllequipo = new EquipoBLL();
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();

        public Form_ComodatoLegal() 
        {
            InitializeComponent();
        }

        private void Form_ComodatoLegal_Load(object sender, EventArgs e)
        {
            ActualizarSolicitudes();
            this.reportViewer1.RefreshReport();
            Subject.AgregarObserver(this);
        }

        public void ActualizarSolicitudes()
        {
            listado = bllsolicitud.ListarPorEstado(Estado.ComodatoLegal);
            dataGridViewSolicitudes.DataSource = listado;
            dataGridViewSolicitudes.ReadOnly = true;
        }

        private void dataGridViewSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewSolicitudes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewSolicitudes.Rows[e.RowIndex].Selected = true;
                    if (solicitudtemporal == null)
                    {
                        solicitudtemporal = new Solicitud();
                    }
                    foreach (Solicitud una in listado)
                    {
                        if (int.Parse(dataGridViewSolicitudes.Rows[e.RowIndex].Cells["CodPedido"].Value.ToString()) == una.CodPedido)
                        {
                            solicitudtemporal = una;
                        }
                    }
                    solicitudtemporal.equipo = bllequipo.SeleccionarEquipo(solicitudtemporal.equipo.CodInventario);

                }
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }

        private void dataGridViewSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAutorizar_Click(object sender, EventArgs e)
        {
            try
            {
                //usamos la solicitud para llenar los parametros del documento
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = "ReporteComodato.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                //uso los parametros para llenar el encabezado del Remito.
                ReportParameter[] parameters = new ReportParameter[6];
                long nrocomodato = long.Parse(DateTime.Now.ToString("ddMMyyHHmm"));
                parameters[0] = new ReportParameter("pDNI", solicitudtemporal.empleado.DNI.ToString());
                parameters[1] = new ReportParameter("pNombre", solicitudtemporal.empleado.Nombre);
                parameters[2] = new ReportParameter("pDireccion", solicitudtemporal.empleado.Dirección);
                parameters[3] = new ReportParameter("pDescripcionEquipo", solicitudtemporal.equipo.Descripcion);
                parameters[4] = new ReportParameter("pCodInvEquipo", solicitudtemporal.equipo.CodInventario.ToString());
                parameters[5] = new ReportParameter("pNroComodato", nrocomodato.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();



                //finalmente se impacta en la base de datos y se hace el cambio de estado de la solicitud a CorreoInterno.


                bllsolicitud.AsignarDocumento(solicitudtemporal, nrocomodato);
                ActualizarSolicitudes();
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
