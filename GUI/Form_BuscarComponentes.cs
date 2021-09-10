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
    public partial class Form_BuscarComponentes : Form, IIdiomaObserver
    {

        SolicitudBLL solicitudBLL = new SolicitudBLL();
        internal Solicitud solicitudTemporal = new Solicitud();
        List<Solicitud> solicitudesNuevas = new List<Solicitud>();
        internal ComponenteBLL compobll = new ComponenteBLL();
        internal Equipo equipotemporal = new Equipo();
        internal Departamento deptotemporal = new Departamento();
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();

        public Form_BuscarComponentes()
        {
            InitializeComponent();
        }

        private void Form_BuscarComponentes_Load(object sender, EventArgs e)
        {
            ActualizarSolicitudes();
            Subject.AgregarObserver(this);

        }


        public void ActualizarSolicitudes()
        {
            solicitudesNuevas = solicitudBLL.ListarPorEstado(BE.Estado.Asignación);
            dataGridViewSolicitudes.DataSource = solicitudesNuevas;
            dataGridViewSolicitudes.ReadOnly = true;
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
                    foreach (Solicitud solicitud in solicitudesNuevas)
                    {
                        if (solicitud.CodPedido == id)
                        {
                            solicitudTemporal = solicitud;
                            deptotemporal.Id = solicitud.empleado.idDepartamento;
                        }
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            equipotemporal.Componentes = compobll.BuscarComponentesAdecuados(solicitudTemporal.empleado, deptotemporal);
            LlenarReporte();
        }

        internal void LlenarReporte()
        {

            try
            {
                //usamos la solicitud temporal para llenar los parametros del documento
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = "ComponentesAdecuados.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                //uso de parametros para llenar el documento.
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("IdSolicitud", solicitudTemporal.CodPedido.ToString());
                parameters[1] = new ReportParameter("Legajo", solicitudTemporal.empleado.Legajo.ToString());
                parameters[2] = new ReportParameter("NombreEmp", solicitudTemporal.empleado.Nombre);
                parameters[3] = new ReportParameter("fecha", solicitudTemporal.Fecha.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Componentes", equipotemporal.Componentes));
                this.reportViewer1.RefreshReport();
    


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
