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
    public partial class Form_MarcarConfigurado : Form, IIdiomaObserver

    {
        Solicitud solicitudtemporal = new Solicitud();
        SolicitudBLL bllsolicitud = new SolicitudBLL();
        EquipoBLL bllequipo = new EquipoBLL();
        List<Solicitud> listado = new List<Solicitud>();
        PerifericoBLL bllperiferico = new PerifericoBLL();
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();


        public Form_MarcarConfigurado()
        {
            InitializeComponent();
        }

        private void Form_MarcarConfigurado_Load(object sender, EventArgs e)
        {
            ActualizarSolicitudes();
            Subject.AgregarObserver(this);
            this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    textBoxDNI.Text = solicitudtemporal.empleado.DNI.ToString();
                    textBoxDireccion.Text = solicitudtemporal.empleado.Dirección;
                    textBoxCodSolic.Text = solicitudtemporal.CodPedido.ToString();
                    textBoxNombre.Text = solicitudtemporal.empleado.Nombre;
                    textBoxLegajo.Text = solicitudtemporal.empleado.Legajo.ToString();
                    textBoxTelefono.Text = solicitudtemporal.empleado.Telefono.ToString();
                    solicitudtemporal.equipo = bllequipo.SeleccionarEquipo(solicitudtemporal.equipo.CodInventario);


                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }

        private void buttonPerifericos_Click(object sender, EventArgs e)
        {
            try
            {
                solicitudtemporal.Perifericos = bllperiferico.BuscarPerifericosEquipo();
                dataGridViewPerifericos.DataSource = solicitudtemporal.Perifericos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonRemito_Click(object sender, EventArgs e)
        {
            try
            {
                //Armamos el objeto REMITO
                Remito remito = new Remito();
                remito.Fecha = DateTime.Now;
                //Random r = new Random();
                //remito.Numero = r.Next(1, 10000);
                remito.Numero = int.Parse(DateTime.Now.ToString("ddMMyyHHmm"));


                //usamos la solicitud para llenar el remito fisico.
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = "ReporteRemito.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                //uso los parametros para llenar el encabezado del Remito.
                ReportParameter[] parameters = new ReportParameter[6];

                parameters[0] = new ReportParameter("pFecha", remito.Fecha.ToString("dd/MM/yyyy"));
                parameters[1] = new ReportParameter("pNumero", remito.Numero.ToString());
                parameters[2] = new ReportParameter("pNomEmpleado", solicitudtemporal.empleado.Nombre);
                parameters[3] = new ReportParameter("pLegajo", solicitudtemporal.empleado.Legajo.ToString());
                parameters[4] = new ReportParameter("pDireccion", solicitudtemporal.empleado.Dirección);
                parameters[5] = new ReportParameter("pDNI", solicitudtemporal.empleado.DNI.ToString());

                reportViewer1.LocalReport.SetParameters(parameters);
                List<Equipo> ListaUnSoloEquipo = new List<Equipo>();//Esta es una lista que contiene un solo equipo, por que la tabla
                                                                    //recibe un IEnumerable.
                ListaUnSoloEquipo.Add(solicitudtemporal.equipo);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Equipo", ListaUnSoloEquipo));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ComponentesEquipo", solicitudtemporal.equipo.Componentes));
                
                if (solicitudtemporal.Perifericos == null)
                {
                    List<Periferico> perifericosnull = new List<Periferico>();
                    Periferico uno = new Periferico();
                    uno.CodInventario = 0;
                    uno.Descripcion = "Sin Periféricos";
                    perifericosnull.Add(uno);
                    solicitudtemporal.Perifericos = perifericosnull;
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Perifericos", solicitudtemporal.Perifericos));
                
                this.reportViewer1.RefreshReport();

                //finalmente se impacta en la base de datos y se hace el cambio de estado de la solicitud a Comodato Legal.

                bllperiferico.AsignarPerifericos(solicitudtemporal);
                bllsolicitud.AsignarDocumento(solicitudtemporal, remito.Numero);
                ActualizarSolicitudes();
                dataGridViewPerifericos.DataSource = null;
                
                

            }
            catch (Exception)
            {

                throw;
            }

            
           
        }


        public void ActualizarSolicitudes()
        {
            listado = bllsolicitud.ListarPorEstado(Estado.Preparación);
            dataGridViewSolicitudes.DataSource = listado;
            dataGridViewSolicitudes.ReadOnly = true;
            dataGridViewPerifericos.ReadOnly = true;
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

