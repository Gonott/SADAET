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
            listViewEventos.View = View.Details;
            listViewEventos.LabelEdit = false;
            listViewEventos.AllowColumnReorder = true;
            listViewEventos.FullRowSelect = true;

            foreach (EventoBitacora evento in GestorBitacoraBLL.ObtenerInstancia.LeerBitacora())
            {
                ListViewItem esteEvento = new ListViewItem(evento.idEvento.ToString());
                esteEvento.SubItems.Add(evento.actividad);
                esteEvento.SubItems.Add(evento.información);
                esteEvento.SubItems.Add(evento.fecha.ToString());
                esteEvento.SubItems.Add(evento.nombreUsuario);
                listViewEventos.Items.Add(esteEvento);
            }

           
            listViewEventos.Columns.Add("Id",50);
            listViewEventos.Columns.Add("Evento",115);
            listViewEventos.Columns.Add("Descripcion",400);
            listViewEventos.Columns.Add("Fecha y Hora",120);
            listViewEventos.Columns.Add("Usuario",100);


        }
    }
}
