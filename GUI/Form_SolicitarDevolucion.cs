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

namespace GUI
{
    public partial class Form_SolicitarDevolucion : Form
    {

        SolicitudBLL solicitudBLL = new SolicitudBLL();
        List<Solicitud> solicitudesEntregadas = new List<Solicitud>();
        Solicitud solicitudTemporal;
        DevolucionBLL devolucionBLL = new DevolucionBLL();
        Devolución devolucionActual;

        public Form_SolicitarDevolucion()
        {
            InitializeComponent();
        }

        private void Form_SolicitarDevolucion_Load(object sender, EventArgs e)
        {
            ActualizarSolicitudes();
            
            textBoxMotivo.Enabled = false;
        }





        private void ActualizarSolicitudes()
        {
            solicitudesEntregadas = solicitudBLL.ListarPorEstado(BE.Estado.Entregado);
            dataGridViewSolicitudes.DataSource = solicitudesEntregadas;
            dataGridViewSolicitudes.ReadOnly = true;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            
          devolucionActual =  devolucionBLL.CrearDevolución (textBoxMotivo.Text,solicitudTemporal);
            GenerarOrden(solicitudTemporal, devolucionActual);
            solicitudBLL.CambiarEstado(solicitudTemporal, Estado.Devolucion);
            this.reportViewer1.RefreshReport();
            ActualizarSolicitudes();
        }

        private void dataGridViewSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                dataGridViewSolicitudes.Rows[e.RowIndex].Selected = true;
                if (dataGridViewSolicitudes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (solicitudTemporal == null)
                    {
                        solicitudTemporal = new Solicitud();
                    }
                    foreach (Solicitud solicitud in solicitudesEntregadas)
                    {
                        if (solicitud.CodPedido == int.Parse(dataGridViewSolicitudes.Rows[e.RowIndex].Cells["CodPedido"].Value.ToString()))
                        {
                            solicitudTemporal = solicitud;
                            textBoxMotivo.Enabled = true;
                        }
                    }
              
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }

            

        }



        void GenerarOrden(Solicitud sol, Devolución dev)
        {

            try
            {
                //usamos la solicitud temporal para llenar los parametros del documento
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = "OrdenDeRetiro.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                //uso de parametros para llenar el documento.
                ReportParameter[] parameters = new ReportParameter[6];
                parameters[0] = new ReportParameter("pLegajo", sol.empleado.Legajo.ToString());
                parameters[1] = new ReportParameter("pNomEmpleado", sol.empleado.Nombre);
                parameters[2] = new ReportParameter("pDireccion", sol.empleado.Dirección);
                parameters[3] = new ReportParameter("pDNI", sol.empleado.DNI.ToString());
                parameters[4] = new ReportParameter("pFecha", DateTime.Now.ToString("dd/MM/yyyy"));
                parameters[5] = new ReportParameter("pNumero", DateTime.Now.ToString("yyMMddHHmm"));
                reportViewer1.LocalReport.SetParameters(parameters);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSElementos", dev.elementos));
                this.reportViewer1.RefreshReport();



            }
            catch (Exception)
            {

                throw;
            }



        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
