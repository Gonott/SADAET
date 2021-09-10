using BE;
using BLL;
using SERVICIOS.ObserverIdioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using SERVICIOS;
using SERVICIOS.ObserverIdioma;

namespace GUI
{
    public partial class Asignación_de_Equipos : Form, IIdiomaObserver
    {
        SolicitudBLL solicitudBLL = new SolicitudBLL();
        Solicitud solicitudTemporal = new Solicitud();
        List<Solicitud> solicitudesNuevas = new List<Solicitud>();
        EquipoBLL equipoBll = new EquipoBLL();
        Equipo equipotemporal = new Equipo();
        Departamento deptotemporal = new Departamento();
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();


        public Asignación_de_Equipos()
        {
            InitializeComponent();
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

        private void Asignación_de_Equipos_Load(object sender, EventArgs e)
        {
            ActualizarSolicitudes();
            Subject.AgregarObserver(this);


        }


        private void buscarEquipoBtn_Click(object sender, EventArgs e)
        {
            equipotemporal = equipoBll.BuscarEquipoAdecuado(solicitudTemporal.empleado, deptotemporal);
            ActualizarTreeView();
           

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

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                solicitudTemporal.estado = Estado.Preparación;
                solicitudBLL.AsignarEquipo(equipotemporal, solicitudTemporal);
                ActualizarSolicitudes();
                treeView1.Nodes.Clear();
                MessageBox.Show("Equipo Asignado");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode raiz = new TreeNode();
              raiz.Text = equipotemporal.Descripcion;
            raiz.Tag = equipotemporal;
            treeView1.Nodes.Add(raiz);
            foreach (Componente cmp in equipotemporal.Componentes)
            {
                TreeNode nodo = new TreeNode();
                  nodo.Tag = cmp;
                nodo.Text = cmp.Tipo.ToString() + cmp.Descripcion +" Capacidad: " + cmp.Capacidad + " Velocidad: " + cmp.Velocidad;
                nodo.Name = cmp.Descripcion;
                raiz.Nodes.Add(nodo);
            }
            treeView1.ExpandAll();
        }


        public void  ActualizarSolicitudes()
        {
            solicitudesNuevas = solicitudBLL.ListarPorEstado(BE.Estado.Asignación);
            dataGridViewSolicitudes.DataSource = solicitudesNuevas;
            dataGridViewSolicitudes.ReadOnly = true;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Form_BuscarComponentes formbuscar = new Form_BuscarComponentes();
            formbuscar.MdiParent = this.MdiParent;
            formbuscar.solicitudTemporal = solicitudTemporal;
            formbuscar.equipotemporal.Componentes = formbuscar.compobll.BuscarComponentesAdecuados(solicitudTemporal.empleado, deptotemporal);
            formbuscar.LlenarReporte();
            formbuscar.Show();
        }
    }
}
