using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERVICIOS.ObserverIdioma;
using SERVICIOS;
using BE;
using BLL;

namespace GUI
{
    public partial class Form_Bitácora : Form, IIdiomaObserver
    {

        List<EventoBitacora> eventos = GestorBitacoraBLL.ObtenerInstancia.LeerBitacora();
        List<EventoBitacora> eventosFiltrados;

        public Form_Bitácora()
        {
            InitializeComponent();
        }

        public void Update(Idioma idioma)
        {
            throw new NotImplementedException();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Bitácora_Load(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            comboBox1.DataSource = usuarioBLL.ListarUsuarios();
            comboBox1.DisplayMember = "NombreUsuario";
            CargarEventos(eventos);

        }




        private void CargarEventos(List<EventoBitacora> eventosACargar)
        {
            listViewEventos.Clear();
            listViewEventos.View = View.Details;
            listViewEventos.LabelEdit = false;
            listViewEventos.AllowColumnReorder = true;
            listViewEventos.FullRowSelect = true;

            foreach (EventoBitacora evento in eventosACargar)
            {
                ListViewItem esteEvento = new ListViewItem(evento.idEvento.ToString());
                esteEvento.SubItems.Add(evento.actividad);
                esteEvento.SubItems.Add(evento.información);
                esteEvento.SubItems.Add(evento.fecha.ToString());
                esteEvento.SubItems.Add(evento.nombreUsuario);
                listViewEventos.Items.Add(esteEvento);
            }


            listViewEventos.Columns.Add("Id", 50);
            listViewEventos.Columns.Add("Evento", 115);
            listViewEventos.Columns.Add("Descripcion", 400);
            listViewEventos.Columns.Add("Fecha y Hora", 120);
            listViewEventos.Columns.Add("Usuario", 100);
        }

        private void AplicarBtn_Click(object sender, EventArgs e)
        {

            if (checkBoxfecha.Checked == true & checkBoxUsuario.Checked == true)// & checkBoxActividad.Checked == true)
            {

                eventosFiltrados = GestorBitacoraBLL.ObtenerInstancia.FiltrarPorFecha(eventos, dateTimePicker1.Value, dateTimePicker2.Value);
                eventosFiltrados = GestorBitacoraBLL.ObtenerInstancia.FiltrarPorUsuario(eventosFiltrados, (Usuario)comboBox1.SelectedItem);
                //aca eventos filtrados por keyword.
                CargarEventos(eventosFiltrados);
            }
            else if (checkBoxfecha.Checked == true & checkBoxUsuario.Checked == false)
            {
                eventosFiltrados = GestorBitacoraBLL.ObtenerInstancia.FiltrarPorFecha(eventos, dateTimePicker1.Value, dateTimePicker2.Value);
                

            }
            else if (checkBoxfecha.Checked == false & checkBoxUsuario.Checked == true)
            {
                eventosFiltrados = GestorBitacoraBLL.ObtenerInstancia.FiltrarPorUsuario(eventos, (Usuario)comboBox1.SelectedItem);
                CargarEventos(eventosFiltrados);
            }
            else
            {
                CargarEventos(eventos);
            }


        }

        private void checkBoxfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxfecha.Checked == true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            if(checkBoxfecha.Checked == false)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void checkBoxUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUsuario.Checked == true)
            {
                comboBox1.Enabled = true;
            }
            if (checkBoxUsuario.Checked == false)
            {
                comboBox1.Enabled = false;
            }
        }
    }
}
