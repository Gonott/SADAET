using BE;
using BLL;
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
using SERVICIOS.ObserverIdioma;

namespace GUI
{
    public partial class Form_SolicitudDeEquipo : Form, IIdiomaObserver
    {
        EmpleadoBLL empleadoBll = new EmpleadoBLL();
        SolicitudBLL solicitudBll = new SolicitudBLL();
        Empleado empleadoTemporal = new Empleado();
        Solicitud solicitudTemporal = new Solicitud();
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();

        public Form_SolicitudDeEquipo()
        {
            InitializeComponent();
        }

        private void Form_SolicitudDeEquipo_Load(object sender, EventArgs e)
        {
            List<Empleado> empleados = empleadoBll.ListarEmpleados();
            dataGridView1.DataSource = empleados;
            dataGridView1.Columns["idDepartamento"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = true;
            Subject.AgregarObserver(this);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    if (empleadoTemporal == null)
                    {
                        empleadoTemporal = new Empleado();
                    }
                    empleadoTemporal.Legajo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Legajo"].Value.ToString());
                    empleadoTemporal.Nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    empleadoTemporal.DNI = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value.ToString());
                    empleadoTemporal.Telefono = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString());
                    empleadoTemporal.Correo = dataGridView1.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                    empleadoTemporal.Dirección = dataGridView1.Rows[e.RowIndex].Cells["Dirección"].Value.ToString();
                    empleadoTemporal.idDepartamento = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idDepartamento"].Value.ToString());
                    solicitudTemporal.empleado = empleadoTemporal;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                solicitudBll.IngresarSolicitud(solicitudTemporal);
                MessageBox.Show("Listo, se ha solicitado un equipo para  " + empleadoTemporal.Nombre);
            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar previamente un empleado");
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
